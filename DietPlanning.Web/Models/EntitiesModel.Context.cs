﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DietPlanning.Web.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DietPlanningEntities : DbContext
    {
        public DietPlanningEntities()
            : base("name=DietPlanningEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Carbohydrate> Carbohydrate { get; set; }
        public virtual DbSet<Energy> Energy { get; set; }
        public virtual DbSet<Fat> Fat { get; set; }
        public virtual DbSet<Food> Food { get; set; }
        public virtual DbSet<Minerals> Minerals { get; set; }
        public virtual DbSet<Other> Other { get; set; }
        public virtual DbSet<Protein> Protein { get; set; }
        public virtual DbSet<Vitamine> Vitamine { get; set; }
    }
}
