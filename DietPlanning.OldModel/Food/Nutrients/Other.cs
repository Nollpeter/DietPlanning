using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DietPlanning.Model.Food.Nutrients
{
    public class Other : Nutrient
    {
        public Property Cholesterol { get; set; }
        public Property Phytosterols { get; set; }
        public Property BaseAlcohol { get; set; }
        public Property BaseWater { get; set; }
        public Property BaseAsh { get; set; }
        public Property Caffeine { get; set; }
        public Property Theobromine { get; set; }

        public Other()
        {
            this.OriginalName = "Other";
            this.Unit = String.Empty;
            //this.Value = null;
        }
    }
}
