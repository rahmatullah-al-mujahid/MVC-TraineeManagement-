﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TspDbContext : DbContext
    {
        public TspDbContext()
            : base("name=TspDbContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Batch> Batches { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Module> Modules { get; set; }
        public virtual DbSet<Trainee> Trainees { get; set; }

        public System.Data.Entity.DbSet<TraineeMangement.ViewModels.RptVm> RptVms { get; set; }
    }
}
