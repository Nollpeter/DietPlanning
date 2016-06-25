using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DietPlanning.Mobile.DTO;

namespace DietPlanning.Web.Controllers
{

    public class FoodController : ApiController
    {
        //[Route("Food/TestProteinDTo")]
        public IHttpActionResult GetTestProteinDTo()
        {
            ProteinDTO dto = new ProteinDTO() {ProteinContent = 123};
            return Ok(dto);
        }

        public IHttpActionResult GetAllFoodDTO()
        {
           // List<ProteinDTO> dtos
           return Ok();
        }
    }
}
