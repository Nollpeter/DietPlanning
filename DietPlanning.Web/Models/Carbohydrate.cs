//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Carbohydrate
    {
        public int Id { get; set; }
        public Nullable<int> FoodId { get; set; }
        public Nullable<double> BaseCarboHydrate { get; set; }
        public Nullable<double> BaseDietaryFiber { get; set; }
        public Nullable<double> BaseStarch { get; set; }
        public Nullable<double> BaseSugars { get; set; }
        public Nullable<double> Sucrose { get; set; }
        public Nullable<double> Glucose { get; set; }
        public Nullable<double> Fructose { get; set; }
        public Nullable<double> Lactose { get; set; }
        public Nullable<double> Maltose { get; set; }
        public Nullable<double> Galactose { get; set; }
    
        public virtual Food Food { get; set; }
    }
}