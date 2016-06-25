using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DietPlanning.Model.Food.Nutrients;
using System.Reflection;
using System.Collections;
using System.ComponentModel;
using System.Xml.Serialization;

namespace DietPlanning.Model.Food
{
    [XmlType("Food")]
    public class Food :Nutrient, IEnumerable<Nutrient>
    {
        /*public Property Name { get; set; }
        public Currency Price { get; set; }*/
        public int FoodId { get; set; }
        private string _name;
        [XmlElement("BusinessData")]
        public BusinessData BusinessData { get; set; }
        [XmlElement("Energy")]
        public Energy Energy { get; set; }
        [XmlElement("Protein")]
        public Protein Protein { get; set; }
        [XmlElement("CarboHydrate")]
        public CarboHydrate CarboHydrate { get; set; }
        [XmlElement("Fat")]
        public Fat Fat { get; set; }
        [XmlElement("Minerals")]
        public Minerals Minerals { get; set;}
        [XmlElement("Vitamins")]
        public Vitamins Vitamins { get; set; }
        [XmlElement("")]
        public Other Other { get; set; }

        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(nameof(Name));}
        }

        protected readonly List<Nutrient> NutrientsList;
        public List<Property> PropertiesList { get; }
        public Food()
        {
            NutrientsList = new List<Nutrient>();
            PropertiesList = this.Fields;
            InitMembers();
        }

        private new void InitMembers()
        {
            this.DisplayName = _name;
            //base.InitMembers();
            BusinessData = new BusinessData();
            Protein = new Protein();
            CarboHydrate = new CarboHydrate();
            Fat = new Fat();
            Minerals = new Minerals();
            Vitamins = new Vitamins();
            Other = new Other();
            Energy = new Energy();
            NutrientsList.AddRange( new Nutrient[] {BusinessData,Protein,CarboHydrate,Fat,Minerals,Vitamins,Other});
            foreach (var nutrient in NutrientsList)
            {
                PropertiesList.AddRange(nutrient.Fields);
            }
        }

        public new Nutrient this[int id]
        {
            get { return NutrientsList[id]; }
            set { NutrientsList[id] = value; }
        }

        public new Property this[string param]
        {
            get
            {
                return NutrientsList.FirstOrDefault(n => n.Any(p => p.OriginalName == param))?[param] ?? PropertiesList.FirstOrDefault(p => p.OriginalName == param);
            }
            set
            {
                Property temp = NutrientsList.FirstOrDefault(n => n.Any(p => p.OriginalName == param))?[param];
                temp = value;
            }
        } 

        //public new double this[string param]
        
        //public double? this[string value] => Fields.First(n => n.First(p => p.OriginalName == value).OriginalName == value).Value;

        public static Food operator +(Food food1, Food food2)
        {
            Food result = new Food();
            for (int j = 0; j < food1.Count(); j++)
            {
                for (int k = 0; k < food1[j].Count(); k++)
                {
                    //if (result[j][k].Value != null)
                    // Will never be null even if type is doulbe?, constructor intializes every value to 0
                        result[j][k].Value += (food1[j][k].Value + food2[j][k].Value);
                }
            }
            return result;
        }

        
        public override string ToString() => _name;

        public int Count()
        {
            return NutrientsList.Count;
        }

        public new void Add(object obj)
        {
            Nutrient item = obj as Nutrient;
            if (item != null)
                NutrientsList.Add(item);
        }
        public new IEnumerator<Nutrient> GetEnumerator()
        {
            return ((IEnumerable<Nutrient>)NutrientsList).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<Nutrient>)NutrientsList).GetEnumerator();
        }
    }
}
