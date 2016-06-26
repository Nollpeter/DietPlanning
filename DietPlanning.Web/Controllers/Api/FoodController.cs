using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using DietPlanning.Mobile.DTO;
using DietPlanning.Web.Controllers.Api;

namespace DietPlanning.Web.Controllers
{

    public class FoodController : ApiBaseController
    {
        public FoodController() { }
        public FoodController(IEntities entities) : base(entities) { }

        //[Route("Food/TestProteinDTo")]
        public IHttpActionResult GetTestProteinDTo()
        {
            ProteinDTO dto = new ProteinDTO() {ProteinContent = 123};
            return Ok(dto);
        }

        public IHttpActionResult GetAllFoodsName()
        {
            IEnumerable<String> names = Entities.Food.Select(p => p.Name);
            return Ok(names);
        }

        public IHttpActionResult GetFoodsNameByNameFilterExactMatch(String name)
        {

            IEnumerable<String> names = Entities.Food.Where(p => p.Name == name).Select(p=>p.Name);
            return Ok(names);

        }
        public IHttpActionResult GetFoodsNameByNameFilterLooseMatch(String name)
        {

            IEnumerable<String> names = Entities.Food.Where(p => p.Name.Contains(name)).Select(p => p.Name);
            return Ok(names);

        }

        public async Task<IHttpActionResult> GetFoodByName(String name)
        {
            FoodDTO food = (await Entities.Food.FirstOrDefaultAsync(p => p.Name == name))?.ToDTO();
            return Ok(food);
        }

        public async Task<IHttpActionResult> GetAllFoodDTO()
        {
            IEnumerable<FoodDTO> dtos = (await Entities.Food.ToListAsync()).Select(p => p.ToDTO());
           return Ok(dtos);
        }
    }
}
