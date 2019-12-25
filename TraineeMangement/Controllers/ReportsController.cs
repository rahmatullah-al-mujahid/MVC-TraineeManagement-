using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TraineeMangement.Models;
using TraineeMangement.ViewModels;

using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using iTextSharp.text.html.simpleparser;

namespace TraineeMangement.Controllers
{
    public class ReportsController : Controller
    {
        private TspDbContext db = new TspDbContext();
        // GET: Reports
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Rpt()
        {
            var data = db.Trainees.
                GroupBy(x => x.Batch.BatchCode)
                .Select(x => new RptVm
                {
                    Batch = x.Key,
                    Trainees = x.Select(t => t)
                }).ToList();
            return View(data);
        }
        [HttpPost]
        [ValidateInput(false)]
        public FileResult Export(string GridHtml, string reportName = "")
        {
            using (MemoryStream stream = new System.IO.MemoryStream())
            {
                StringReader sr = new StringReader(GridHtml);
                Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 100f, 0f);
                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                pdfDoc.Close();
                string fileName = (reportName == "" ? "Report" : reportName) + DateTime.Now.Ticks + ".pdf";
                return File(stream.ToArray(), "application/pdf", fileName);
            }
        }
    }
}