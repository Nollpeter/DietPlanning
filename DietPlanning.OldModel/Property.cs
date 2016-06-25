using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Resources;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;
using DietPlanning.Model.Annotations;
using DietPlanning.Model.Localization;

namespace DietPlanning.Model
{
    [XmlRoot("Property")]
    [XmlType("Property")]
    public class Property : INotifyPropertyChanged
    {
        public int PropertyId { get; set; }
        private string _unit;
        private double? _value;
        private string _originalName = String.Empty;

        /*private readonly ResourceManager _res = new ResourceManager("DietPlanning.Model.Localization.Hungarian",
            typeof (LocalizationManager).Assembly);*/

        #region Properties

        public string DisplayName
        {
            get
            {
                return ""; /*_res.GetString(this.OriginalName);*/ }
            set { OnPropertyChanged(nameof(DisplayName)); }
        }

        [XmlIgnore]
        public double? Value
        {
            get { return _value; }
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }

        public string OriginalName
        {
            get { return _originalName; }
            set
            {
                _originalName = value;
                OnPropertyChanged(nameof(OriginalName));
            }
        }

        public string Unit
        {
            get { return _unit; }
            set
            {
                _unit = value;
                OnPropertyChanged(nameof(Unit));
            }
        }

        #endregion

        private string GetPriceUnit()
        {
            return "Ft";
        }

        public override string ToString() => DisplayName + ": " + Value + " " + Unit;

        public static double operator *(Property prop, double value)
        {
            return prop.Value*value ?? 0;
        }

        public static double operator +(Property prop, double value)
        {
            return prop.Value + value ?? value;
        }

        public static double operator -(Property property, double value)
        {
            return property.Value - value ?? -1*value;
        }

        public static double operator / (Property property, double value)
        {
            return property.Value/value ?? 0;
        }
        public static double operator *(double value, Property property)
        {
            return property.Value * value ?? 0;
        }

        public static double operator +(double value, Property property)
        {
            return property.Value + value ?? value;
        }

        public static double operator -(double value, Property property)
        {
            return value - property.Value ?? value;
        }

        public static double operator /(double value, Property property)
        {
            return value / property.Value ?? 0;
        }

        public XElement ToXElement()
        {
            XElement x = new XElement(OriginalName);
            //x.Add(new XElement("DisplayName",DisplayName));
            x.Add(new XElement("Value", Value));
            x.Add(new XElement("OriginalName", OriginalName));
            x.Add(new XElement("Unit", Unit));
            return x;
        }

        public void UpdateDisplayName() => DisplayName = "";

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
