using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DietPlanning.Mobile.Persistence;
using DietPlanning.Portable.DTO;

namespace DietPlanning.Mobile.Model
{
    public class FoodFetchModel
    {
        public FoodFetchModel()
        {
            Persistence = new FoodPersistence();
        }

        protected FoodPersistence Persistence { get; set; }
        public async Task<DietPlanning.Portable.DTO.FoodDTO> FetchFoodByNameAsync(String name)
        {
            return await Persistence.GetFoodByNameAsync(name);
        }
    }
}
