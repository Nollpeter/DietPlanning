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
    
    public partial class Energy
    {
        public Nullable<double> Kj { get; set; }
        public Nullable<double> Calories { get; set; }
        public int FoodId { get; set; }
    
        public virtual Food Food { get; set; }
    }
}
