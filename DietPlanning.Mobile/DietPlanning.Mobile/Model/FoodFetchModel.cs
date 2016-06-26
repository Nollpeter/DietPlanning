using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DietPlanning.Mobile.DTO;
using DietPlanning.Mobile.Persistence;

namespace DietPlanning.Mobile.Model
{
    public class FoodFetchModel
    {
        public FoodFetchModel()
        {
            Persistence = new FoodPersistence();
        }

        protected FoodPersistence Persistence { get; set; }
        public async Task<FoodDTO> FetchFoodByNameAsync(String name)
        {
            return await Persistence.GetFoodByNameAsync(name);
        }
    }
}
