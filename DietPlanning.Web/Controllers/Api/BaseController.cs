using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DietPlanning.Web.Models;

namespace DietPlanning.Web.Controllers.Api
{
    public class BaseController
    {
        protected DietPlanningEntities Entities { get; set; }

        public BaseController()
        {
            Entities = new DietPlanningEntities();
        }
    }
}