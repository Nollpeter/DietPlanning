using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace DietPlanning.Model.Food.Nutrients
{
    [XmlType("CarboHaydrate")]
    public class CarboHydrate : Nutrient
    {
        #region Properties

        public Property BaseCarboHydrate { get; set; }

        public Property BaseDietaryFiber { get; set; }
        public Property BaseStarch { get; set; }
        public Property BaseSugars { get; set; }
        public Property Sucrose { get; set; }
        public Property Glucose { get; set; }
        public Property Fructose { get; set; }
        public Property Lactose { get; set; }
        public Property Maltose { get; set; }
        public Property Galactose { get; set; }

        #endregion

        public CarboHydrate()
        {
            /*
            this.OriginalName = "Carbohydrate";
            this.Unit = BaseCarboHydrate.Unit;
            this.Value = BaseCarboHydrate.Value;
            this.BaseCarboHydrate.PropertyChanged += OnPropertyChanged;*/
            BaseProperty = BaseCarboHydrate;
            InitBaseProperty();
        }

       
    }
}
