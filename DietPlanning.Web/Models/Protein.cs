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
    
    public partial class Protein
    {
        public Nullable<double> Threonine { get; set; }
        public Nullable<double> Tryptophan { get; set; }
        public Nullable<double> Isoleucine { get; set; }
        public Nullable<double> Leucine { get; set; }
        public Nullable<double> Lysine { get; set; }
        public Nullable<double> Serine { get; set; }
        public Nullable<double> Proline { get; set; }
        public Nullable<double> GlutamicAcid { get; set; }
        public Nullable<double> AsparticAcid { get; set; }
        public Nullable<double> Alanine { get; set; }
        public Nullable<double> Glycine { get; set; }
        public Nullable<double> Histidine { get; set; }
        public Nullable<double> Arginine { get; set; }
        public Nullable<double> Valine { get; set; }
        public Nullable<double> Phenylalanine { get; set; }
        public Nullable<double> Tyrosine { get; set; }
        public Nullable<double> Cystine { get; set; }
        public Nullable<double> Methionine { get; set; }
        public Nullable<double> HydroxyProline { get; set; }
        public Nullable<double> BaseProteinContent { get; set; }
        public Nullable<int> FoodId_ { get; set; }
        public int Id { get; set; }
    
        public virtual Food Food { get; set; }
    }
}
