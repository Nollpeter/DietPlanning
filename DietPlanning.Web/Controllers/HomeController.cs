using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DietPlanning.Web.Models;

namespace DietPlanning.Web.Controllers
{
    public class HomeController : Controller
    {
        DietPlanningEntities dt = new DietPlanningEntities();
        public ActionResult Index()
        {
            /*dt.Food.Add(new Food()
            {
                Carbohydrate =
                    new Carbohydrate()
                    {
                        BaseCarboHydrate = 10,
                        BaseDietaryFiber = 10,
                        BaseStarch = 10,
                        BaseSugars = 10,
                        Fructose = 12
                    }
            });*/
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}