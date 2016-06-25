using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Serialization;
using DietPlanning.Model.Annotations;

namespace DietPlanning.Model.Food.Nutrients
{
    [XmlInclude(typeof(Property))]
    [XmlRoot("Protein")]
    [XmlType("Protein")]
    public class Protein : Nutrient
    {

        #region Members

        #endregion
        
        #region Properties
        [XmlElement("Threonine")]
        public Property Threonine { get; set; }
        public Property Tryptophan { get; set; }
        public Property Isoleucine { get; set; }
        public Property Leucine { get; set; }
        public Property Lysine { get; set; }
        public Property Serine { get; set; }
        public Property Proline { get; set; }
        public Property GlutamicAcid { get; set; }
        public Property AsparticAcid { get; set; }
        public Property Alanine { get; set; }
        public Property Glycine { get; set; }
        public Property Histidine { get; set; }
        public Property Arginine { get; set; }
        public Property Valine { get; set; }
        public Property Phenylalanine { get; set; }
        public Property Tyrosine { get; set; }
        public Property Cystine { get; set; }
        public Property Methionine { get; set; }
        public Property HydroxyProline { get; set; }
        public Property BaseProteinContent { get; set; }

        #endregion

        public Protein()
        {
            /*this.OriginalName = "Protein";
            this.Value = BaseProteinContent.Value;
            this.Unit = BaseProteinContent.Unit;*/
           
            this.BaseProperty = BaseProteinContent;
            this.InitBaseProperty();
        }
    }
}
