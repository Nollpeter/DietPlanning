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
    
    public partial class Vitamine
    {
        public int Id { get; set; }
        public Nullable<int> FoodId { get; set; }
        public Nullable<double> VitaminA { get; set; }
        public Nullable<double> VitaminC { get; set; }
        public Nullable<double> VitaminD { get; set; }
        public Nullable<double> VitaminE1 { get; set; }
        public Nullable<double> VitaminK { get; set; }
        public Nullable<double> VitaminB6 { get; set; }
        public Nullable<double> VitaminB12 { get; set; }
        public Nullable<double> Thiamin { get; set; }
        public Nullable<double> Riboflavin { get; set; }
        public Nullable<double> Niacin { get; set; }
        public Nullable<double> Folate { get; set; }
        public Nullable<double> FolicAcid { get; set; }
        public Nullable<double> PantothenicAcid { get; set; }
        public Nullable<double> Choline { get; set; }
        public Nullable<double> Betaine { get; set; }
    
        public virtual Food Food { get; set; }
    }
}
