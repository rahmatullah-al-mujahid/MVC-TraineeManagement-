using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TraineeMangement.Models;

namespace TraineeMangement.ViewModels
{
    public class RptVm
    {
        [Key]
        public string Batch { get; set; }
        public IEnumerable<Trainee> Trainees { get; set; }
    }
}