using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DietPlanning.Mobile.DTO;
using Newtonsoft.Json;

namespace DietPlanning.Mobile.Persistence
{
    public class FoodPersistence
    {
        public ProteinDTO GetTestDTO()
        {
            HttpClient client = new HttpClient();
            var httpContent = client.GetAsync("http://192.168.0.108/api/Food/GetTestProteinDTo").Result.Content;
            try
            {
                var readAs = httpContent.ReadAs<ProteinDTO>();
                return readAs;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
            

        }
    }

    public static class Extensions
    {
        public static T ReadAs<T>(this HttpContent content)
        {
            return JsonConvert.DeserializeObject<T>(content.ReadAsStringAsync().Result);
        }
    }
}

