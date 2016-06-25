using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DietPlanning.Model.Food.MealTypes
{
    public class FoodEventArgs : EventArgs
    {
        public Food Food;
    }
    public class Meal : IEnumerable<Food>
    {
        public delegate void FoodEventHandler(object sender, FoodEventArgs e);
        public event FoodEventHandler CollectionChanged;
        protected List<Food> Foods;

        public Meal()
        {
            Foods = new List<Food>();
            Statistics = new FoodStatistics();
        }

        public Meal(Food food) : this()
        {
            Add(food);
            CollectionChanged += Meal_CollectionChanged;
        }

        private void Meal_CollectionChanged(object sender, EventArgs e)
        {
            Statistics = new FoodStatistics();
            foreach (Food food in this)
            {
                Statistics += food as FoodStatistics;
            }
            #region régi
            /*for (int i = 0; i < this.Count(); i++)
            {
                for (int j = 0; j < this[i].Count(); j++)
                {
                    for (int k = 0; k < this[i][j].Count(); k++)
                    {
                        Statistics[j][k].Value += this[i][j][k].Value;
                    }
                }
            }*/
            #endregion
        }

        public static Meal FromSingleFood(Food food)
        {
            Meal meal = new Meal {food};
            return meal;
        }

        public FoodStatistics Statistics { get; set; }

        public void Add(object obj)
        {
            var food1 = obj as Food;
            if (food1 != null)
            {
                Foods.Add(food1);
                CollectionChanged?.Invoke(this,new FoodEventArgs() {Food = food1});
            }
        }

        public void Remove(Food food)
        {
            Foods.Remove(Foods.First(input => input == food));
            CollectionChanged?.Invoke(this, new FoodEventArgs() {Food = food});
        }

        public Food this[int id]
        {
            get { return Foods[id]; }
            set { Foods[id] = value; }
        }

        public IEnumerator<Food> GetEnumerator()
        {
            return ((IEnumerable<Food>) Foods).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<Food>) Foods).GetEnumerator();
        }
    }
}
