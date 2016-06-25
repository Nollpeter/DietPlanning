using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DietPlanning.Model.Annotations;
using DietPlanning.Model.Food.Nutrients;

namespace DietPlanning.Model.Food.MealTypes
{
    
    
    public class FoodStatistics: Food
    {
        public FoodStatistics() : base()
        {
            
            ReCalculateStatistics();
        }

        public FoodStatistics(Food food)
        {
            for (int i = 0; i < this.NutrientsList.Count; i++)
            {
                foreach (Property VARIABLE in this[i])
                {
                    this[VARIABLE.OriginalName].Value = food[VARIABLE.OriginalName].Value;
                }
            }
            ReCalculateStatistics();
        }
        #region operators
        public static FoodStatistics operator +(FoodStatistics stat1, FoodStatistics stat2)
        {
            FoodStatistics result = new FoodStatistics(stat1 as Food + stat2);
            result.ReCalculateStatistics();
            return result;
        }
        public static FoodStatistics operator +(FoodStatistics food1, Food food2)
        {
            FoodStatistics result = new FoodStatistics(food1 as Food + food2);
            result.ReCalculateStatistics();
            return result;
        }
        public static FoodStatistics operator +(Food food1, FoodStatistics food2)
        {
            FoodStatistics result = food2 + food1;
            result?.ReCalculateStatistics();
            return result;
        }
        #endregion

        public Property CaloriesFromProtein { get; private set; }
        public Property CaloriesFromCarbohydrate { get; private set; }
        public Property CaloriesFromFat { get; private set; }
        public Property ProteinRatioBasedOnMass { get; private set; }
        public Property ProteinRatioBasedOnCalories { get; private set; }
        public Property CarboHydrateRatioBasedOnMass { get; private set; }
        public Property CarboHydrateRatioBasedOnCalories { get; private set; }
        public Property FatRatioBasedOnMass { get; private set; }
        public Property FatRatioBasedOnCalories { get; private set; }

        public void ReCalculateStatistics()
        {
            double masssum;
            double caloriesum = Protein.BaseProteinContent*4 + CarboHydrate.BaseCarboHydrate*4 + Fat.BaseFat*9;
            masssum = Protein.BaseProteinContent*1 + CarboHydrate.BaseCarboHydrate*1 + Fat.BaseFat*1;
            CaloriesFromProtein.Value = Protein.BaseProteinContent*4;
            CaloriesFromCarbohydrate.Value = CarboHydrate*4;
            CaloriesFromFat.Value = Fat*9;
            ProteinRatioBasedOnCalories.Value = CaloriesFromProtein/caloriesum*100;
            ProteinRatioBasedOnMass.Value = Protein/masssum*100;
            CarboHydrateRatioBasedOnCalories.Value = CaloriesFromCarbohydrate/caloriesum*100;
            CarboHydrateRatioBasedOnMass.Value = CarboHydrate/masssum*100;
            FatRatioBasedOnCalories.Value = CaloriesFromFat/caloriesum*100;
            FatRatioBasedOnMass.Value = Fat/masssum*100;
        }
    }
}
