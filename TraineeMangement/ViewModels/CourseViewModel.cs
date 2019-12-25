using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TraineeMangement.ViewModels
{
    public class CourseViewModel
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string ShortName { get; set; }
        public int TotalBatches { get; set; }
         public int RunningBatches { get; set; }

    }
}