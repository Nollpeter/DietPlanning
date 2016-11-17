using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DietPlanning.Portable.DTO;
using Newtonsoft.Json;

namespace DietPlanning.Mobile.Persistence
{
    public class FoodPersistence:PersistenceBase
    {
        /*public ProteinDTO GetTestDTO()
        {
            HttpClient client = new HttpClient();
            var httpContent = client.GetAsync("http://192.168.0.108/api/Food/GetTestProteinDTo").Result.Content;
            try
            {
                var readAs = httpContent.ReadAsAsync<ProteinDTO>();
                return readAs;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
            

        }*/

        public async Task<FoodDTO> GetFoodByNameAsync(String name)
        {
            HttpResponseMessage httpResponseMessage = await Client.GetAsync($"Food/GetFoodByName/?name={name}");
            return await httpResponseMessage.Content.ReadAsAsync<FoodDTO>();
        }
    }


    public abstract class PersistenceBase
    {
        protected HttpClient Client { get; set; }

        protected PersistenceBase()
        {
            Client = new HttpClient()
            {
             //   BaseAddress = new Uri("http://192.168.0.103/api/"),
                    BaseAddress = new Uri("http://project.diet/api")
            };
        }
    }

    public static class Extensions
    {
        public static async Task<T> ReadAsAsync<T>(this HttpContent content)
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(await content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.GetType().Name);
                throw;
            }
            
        }
    }
}

