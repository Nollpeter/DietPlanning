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
    
    public partial class Food
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public Nullable<int> Category { get; set; }
    
        public virtual Carbohydrate Carbohydrate { get; set; }
        public virtual Energy Energy { get; set; }
        public virtual Fat Fat { get; set; }
        public virtual Minerals Minerals { get; set; }
        public virtual Other Other { get; set; }
        public virtual Protein Protein { get; set; }
        public virtual Vitamine Vitamine { get; set; }
    }
}
