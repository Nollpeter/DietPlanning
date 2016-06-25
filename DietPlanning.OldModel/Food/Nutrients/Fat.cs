using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DietPlanning.Model.Food.Nutrients
{
    public class Fat : Nutrient
    {
        public Property BaseFat { get; set; }
        public Property BaseSaturatedFat { get; set; }
        public Property BaseMonounsaturatedFat { get; set; }
        public Property BasePolyunsaturatedFat { get; set; }
        public Property BaseTransFattyAcids { get; set; }
        public Property BaseTransMonoenoicFatyAcids { get; set; }
        public Property BaseTransPolyenoicFatyAcids { get; set; }
        public Property BaseOmega3FattyAcids { get; set; }
        public Property BaseOmega6FattyAcids { get; set; }

        public Fat()
        {
            /*this.OriginalName = "Fat";
            this.Value = BaseFat.Value;
            this.Unit = BaseFat.Unit;*/
            BaseProperty = BaseFat;
            InitBaseProperty();
        }
    }
}
