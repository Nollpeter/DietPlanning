using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DietPlanning.Model.Food.Nutrients
{
    public class Vitamins : Nutrient
    {
        public Property VitaminA { get; set; }
        public Property VitaminC { get; set; }
        public Property VitaminD { get; set; }
        public Property VitaminE { get; set; }
        public Property VitaminK { get; set; }
        public Property VitaminB6 { get; set; }
        public Property VitaminB12 { get; set; }
        public Property Thiamin { get; set; }
        public Property Riboflavin { get; set; }
        public Property Niacin { get; set; }
        public Property Folate { get; set; }
        public Property FolicAcid { get; set; }
        public Property PantothenicAcid { get; set; }
        public Property Choline { get; set; }
        public Property Betaine { get; set; }

        public Vitamins()
        {
            this.OriginalName = "Vitamins";
            //this.Value = null;
            this.Unit  =String.Empty;


        }
    }
}
