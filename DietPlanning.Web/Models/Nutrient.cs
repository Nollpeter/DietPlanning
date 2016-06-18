using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Web;

namespace DietPlanning.Web.Models
{
    
    public class Nutrient
    {
        public Dictionary<String,Double> Properties { get; set; }

        public Double this[String key]
        {
            get { return Properties[key]; }
            set
            {
                Properties[key] = value;
                SettPropertyValue(key,value);
            }
        }

        protected void SettPropertyValue(String key, Double value)
        {
            this.GetType().GetProperties().FirstOrDefault(p => p.Name==key)?.SetValue(this,value);
        }
        public Nutrient()
        {
            foreach (PropertyInfo propertyInfo in this.GetType().GetProperties())
            {
                Properties.Add(propertyInfo.Name,(Double)propertyInfo.GetValue(this));
            }
        }
    }
}