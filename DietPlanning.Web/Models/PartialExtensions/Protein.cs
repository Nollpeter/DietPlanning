using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DietPlanning.Web.Models
{
    public partial class Protein : Nutrient
    {
        public Protein()
        {
            InitDerived();
        }
    }
}