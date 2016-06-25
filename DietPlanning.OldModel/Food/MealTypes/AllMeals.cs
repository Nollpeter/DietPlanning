using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DietPlanning.Model.Food.MealTypes
{
    class AllMeals : IEnumerable<Meal>
    {
        public FoodStatistics Statistics => Meals.Aggregate(new FoodStatistics(), (current, variable) => current + variable.Statistics);
        protected List<Meal> Meals;
        public IEnumerator<Meal> GetEnumerator()
        {
            return Meals.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable) Meals).GetEnumerator();
        }
    }
}
