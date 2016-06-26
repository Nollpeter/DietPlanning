using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Web;
using DietPlanning.Mobile.DTO;
using DietPlanning.Web.Models.InterFaces;

namespace DietPlanning.Web.Models
{
    
    public class Nutrient : IDTOConvertible
    {
        public Dictionary<String,Double?> Properties { get; set; }

        public Double? this[String key]
        {
            get { return Properties[key]; }
            set
            {
                Properties[key] = value;
                SettPropertyValue(key,value);
            }
        }

        public virtual T ToDTO<T>() where T: IDTO, new()
        {
            //NutrientDTO dto = new NutrientDTO();
            T dto = new T();
            foreach (PropertyInfo propertyInfo in this.GetType().GetProperties())
            {

                var dtoPropertyInfo = dto.GetType().GetProperty(propertyInfo.Name);
                if (dtoPropertyInfo != null)
                {
                    dto.GetType().GetProperty(propertyInfo.Name).SetValue(dto,propertyInfo.GetValue(this));
                    //dto.GetType().GetProperties().SetValue(dto,//propertyInfo.GetValue(this));
                }
                
            }
            return dto;
        }
        protected void SettPropertyValue(String key, Double? value)
        {
            this.GetType().GetProperties().FirstOrDefault(p => p.Name==key)?.SetValue(this,value);
        }
        public Nutrient()
        {
            
            Properties = new Dictionary<string, Double?>();
            
        }

        public void InitDerived()
        {
            /*foreach (PropertyInfo propertyInfo in this.GetType().GetProperties())
            {
                Double? variablie = (Double?)propertyInfo.GetValue(this, new object[] { });
                Properties.Add(propertyInfo.Name, (Double?)propertyInfo.GetValue(variablie));
            }*/
        }
    }
}