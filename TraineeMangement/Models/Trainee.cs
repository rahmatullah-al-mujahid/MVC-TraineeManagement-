//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TraineeMangement.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Trainee
    {
        public int TraineeId { get; set; }
        public string TraineeCode { get; set; }
        public string TraineeName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string PresentAddress { get; set; }
        public string PermanentAddress { get; set; }
        public int BatchId { get; set; }
    
        public virtual Batch Batch { get; set; }
    }
}