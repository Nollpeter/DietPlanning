using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace DietPlanning.Model.Food.Nutrients
{
    [XmlInclude(typeof(Protein))]
    [XmlInclude(typeof(CarboHydrate))]
    [XmlInclude(typeof(Property))]
    
    public abstract class Nutrient :Property, IEnumerable<Property>
    {
        protected Property BaseProperty { get; set; }
        [XmlIgnore]
        protected internal List<Property> Fields { get; set; }

        #region Indexers
        public Property this[int id]
        {
            get { return Fields[id]; }
            set { Fields[id] = value; }
        }

        public Property this[string str]
        {
            get { return Fields.FirstOrDefault(prop => prop.OriginalName == str); }

            set
            {
                Property temp = Fields.FirstOrDefault(prop => prop.DisplayName == str);
                temp = value;
            }
        }
        #endregion
        
        protected Nutrient()
        {
            Fields = new List<Property>();
            InitMembers();
           
        }
        protected void InitBaseProperty() => BaseProperty.PropertyChanged += OnPropertyChanged; 
        public void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            DisplayName = BaseProperty.DisplayName;
            OriginalName = BaseProperty.OriginalName;
            Value = BaseProperty.Value;
            Unit = BaseProperty.Unit;
        }
        protected void InitMembers()
        {
            BaseProperty = new Property();
            PropertyInfo[] fields = this.GetType().GetProperties();
            foreach (PropertyInfo item in fields)
            {
                if (item.PropertyType.Name == "Property" && item.Name != "Item")
                {
                    // Get the reference to the property
                    Property temp = ((Property) item.GetValue(this, new object[] {}));
                    
                    // Initialize Poperty here
                    // item.name refers to PropertyInfo.Name
                    temp = new Property {OriginalName = item.Name, Value = 0};
                    temp.Unit = GetUnit(temp);
                    item.SetValue(this, temp,new object[] {});
                    // Add Property to Fields
                    Fields.Add(temp);
                }
            }
        }

        public new XElement ToXElement()
        {
            XElement x = new XElement(this.OriginalName);
            foreach (Property VARIABLE in this)
            {
                x.Add(VARIABLE.ToXElement());
            }
            return x;
        }
        private string GetUnit(Property temp)
        {
           
            if (temp.OriginalName.Length >= 4 && temp.OriginalName.Substring(0, 4) == "Base")
            {
                return "g";
            }
            else
            {
                switch (temp.OriginalName)
                {
                    case "Kj": return "Kj";
                    case "Kcal": return "Kcal";
                    default: return "mg";
                }
            }
        }

        private string GetPriceUnit()
        {
            return "Ft";
        }

        public void Add(object obj)
        {
            Property item = obj as Property;
            if( item != null)
            Fields.Add(item);
        }

        #region IEnumberable<Property> implementation
        IEnumerator<Property> IEnumerable<Property>.GetEnumerator()
        {
            return (Fields).GetEnumerator();
        }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)Fields).GetEnumerator();
        } 
        #endregion
    }
}
