using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using DietPlanning.Web.Models;
using DietPlanning.Model.Food;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Food = DietPlanning.Web.Models.Food;

//using Food = DietPlanning.Model.Food.Food;

namespace DietPlanning.Web.Tests.Importing
{
    public class ArrayOfFood
    {
        [XmlElement("Food")]
        public Model.Food.Food[] FoodArrayFoods { get; set; }
    }

    [TestClass]
    public class ImportOlderFood
    {
        protected List<Model.Food.Food> Foods { get; set; }
        protected List<Food> ConvertedFoods { get; set; }

        public Food ConvertFood(Model.Food.Food f)
        {
            DietPlanning.Web.Models.Food food = new Food();
            food.Protein = new DietPlanning.Web.Models.Protein()
            {
                Alanine = f.Protein.Alanine.Value,
                Arginine = f.Protein.Arginine.Value,
                AsparticAcid = f.Protein.AsparticAcid.Value,
                BaseProteinContent = f.Protein.BaseProteinContent.Value,
                Cystine = f.Protein.Cystine.Value,
                GlutamicAcid = f.Protein.GlutamicAcid.Value,
                Glycine = f.Protein.Glycine.Value,
                Histidine = f.Protein.Histidine.Value,
                HydroxyProline = f.Protein.HydroxyProline.Value,
                Isoleucine = f.Protein.Isoleucine.Value,
                Leucine = f.Protein.Leucine.Value,
                Lysine = f.Protein.Lysine.Value,
                Methionine = f.Protein.Methionine.Value,
                Phenylalanine = f.Protein.Phenylalanine.Value,
                Proline = f.Protein.Proline.Value,
                Serine = f.Protein.Serine.Value,
                Threonine = f.Protein.Threonine.Value,
                Tryptophan = f.Protein.Tryptophan.Value,
                Tyrosine = f.Protein.Tyrosine.Value,
                Valine = f.Protein.Valine.Value
            };
            food.Carbohydrate = new Carbohydrate()
            {
                BaseCarboHydrate = f["BaseCarboHydrate"].Value,
                BaseDietaryFiber = f["BaseDietaryFiber"].Value,
                BaseStarch = f["BaseStarch"].Value,
                BaseSugars = f["BaseSugars"].Value,
                Sucrose = f["Sucrose"].Value,
                Glucose = f["Glucose"].Value,
                Fructose = f["Fructose"].Value,
                Lactose = f["Lactose"].Value,
                Maltose = f["Maltose"].Value,
                Galactose = f["Galactose"].Value,
            };
            food.Energy = new Energy()
            {
                Calories = f.Energy.Calories.Value,
                Kj = f.Energy.Kj.Value
            };
            food.Fat = new Fat()
            {
                BaseFat = f["BaseFat"].Value,
                BaseSaturatedFat = f["BaseSaturatedFat"].Value,
                BaseMonounsaturatedFat = f["BaseMonounsaturatedFat"].Value,
                BasePolyunsaturatedFat = f["BasePolyunsaturatedFat"].Value,
                BaseTransFattyAcids = f["BaseTransFattyAcids"].Value,
                BaseTransMonoenoicFatyAcids = f["BaseTransMonoenoicFatyAcids"].Value,
                BaseTransPolyenoicFatyAcids = f["BaseTransPolyenoicFatyAcids"].Value,
                BaseOmega3FattyAcids = f["BaseOmega3FattyAcids"].Value,
                BaseOmega6FattyAcids = f["BaseOmega6FattyAcids"].Value,
            };
            food.Minerals = new Minerals()
            {
                Calcium = f["Calcium"].Value,
                Iron = f["Iron"].Value,
                Magnesium = f["Magnesium"].Value,
                Phosphorus = f["Phosphorus"].Value,
                Potassium = f["Potassium"].Value,
                Sodium = f["Sodium"].Value,
                Zinc = f["Zinc"].Value,
                Copper = f["Copper"].Value,
                Manganese = f["Manganese"].Value,
                Selenium = f["Selenium"].Value,
                Fluoride = f["Fluoride"].Value,
            };
            food.Vitamine = new Vitamine();
            food.Vitamine.VitaminA = f["VitaminA"].Value;
            food.Vitamine.VitaminC = f["VitaminC"].Value;
            food.Vitamine.VitaminD = f["VitaminD"].Value;
            food.Vitamine.VitaminE1 = f["VitaminE"].Value;
            food.Vitamine.VitaminK = f["VitaminK"].Value;
            food.Vitamine.VitaminB6 = f["VitaminB6"].Value;
            food.Vitamine.VitaminB12 = f["VitaminB12"].Value;
            food.Vitamine.Thiamin = f["Thiamin"].Value;
            food.Vitamine.Riboflavin = f["Riboflavin"].Value;
            food.Vitamine.Niacin = f["Niacin"].Value;
            food.Vitamine.Folate = f["Folate"].Value;
            food.Vitamine.FolicAcid = f["FolicAcid"].Value;
            food.Vitamine.PantothenicAcid = f["PantothenicAcid"].Value;
            food.Vitamine.Choline = f["Choline"].Value;
            food.Vitamine.Betaine = f["Betaine"].Value;
            food.Name = f.Name;
            food.Other = new Other()
            {
                Cholesterol = f["Cholesterol"].Value,
                Phytosterols = f["Phytosterols"].Value,
                BaseAlcohol = f["BaseAlcohol"].Value,
                BaseWater = f["BaseWater"].Value,
                BaseAsh = f["BaseAsh"].Value,
                Caffeine = f["Caffeine"].Value,
                Theobromine = f["Theobromine"].Value,

            };
            return food;
        }

        
        public Model.Food.Food DeSerializeFood(String path)
        {
            DietPlanning.Model.Food.Food food = new Model.Food.Food();
            XElement x = new XElement("Food");
            var XSer = new XmlSerializer(typeof(XElement));
            using (StreamReader reader = new StreamReader(path))
            {
                x = (XElement)XSer.Deserialize(reader);

            }
            int i = 1;
            /*Parallel.ForEach(x.Elements(), p =>
            {
                int j = 0;
                foreach (var element in p.Elements())
                {
                    string s = element.Name.ToString();
                    //Property prop = food[s];
                    //prop.Value

                    food[s].Value = Convert.ToDouble(element.Element("Value").Value, CultureInfo.InvariantCulture);
                    j++;
                }
            });*/
            /* Parallel.ForEach(x.Elements(), p =>
             {
                 int j = 0;
                 foreach (var element in p.Elements())
                 {
                     string s = element.Name.ToString();
                     //Property prop = food[s];
                     //prop.Value

                     food[i][j].Value = Convert.ToDouble(element.Element("Value").Value,CultureInfo.InvariantCulture);
                     j++;
                 }
             });*/
            foreach (var p in x.Elements())
            {
                int j = 0;
                foreach (var element in p.Elements())
                {
                    string s = element.Name.ToString();
                    //Property prop = food[s];
                    //prop.Value

                    food[i][j].Value = Convert.ToDouble(element.Element("Value").Value);//, CultureInfo.InvariantCulture);
                    j++;
                }
                i++;

            }
            //food.ReCalculateStatistics();
            food.Name = path.Split('\\').Last().Split('.').FirstOrDefault();
            return food;
        }
        [TestInitialize]
        public void LoadOlderData()
        {
            
        }

        [TestMethod]
        public void InsertNewData()
        {
            Foods = new List<Model.Food.Food>();
            ConvertedFoods = new List<Food>();
            foreach (var i in Directory.GetFiles(@"E:\FoodsData\ConvertedData"))
            {
                /*StreamReader reader = new StreamReader(i);
                XmlSerializer serializer = new XmlSerializer(typeof(Model.Food.Food));*/
                Model.Food.Food deserializedList = DeSerializeFood(i); //serializer.Deserialize(reader) as Model.Food.Food;
                Foods.Add(deserializedList);
                try
                {
                    ConvertedFoods.Add(ConvertFood(deserializedList));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            DietPlanningEntities entities = new DietPlanningEntities();
            entities.Food.AddRange(ConvertedFoods);
            entities.SaveChanges();

        }
    }
}
