using System;
using DietPlanning.Web.Controllers;
using DietPlanning.Web.Controllers.Api;
using DietPlanning.Web.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework.Internal;

namespace DietPlanning.Web.Tests.Controllers
{
    [TestClass]
    public class FoodControllerTests
    {
        protected FoodController Controller { get; set; }
        protected IEntities Entities { get; set; }
        [TestInitialize]
        public void Initialize()
        {
            Entities = new DietPlanningEntities();
            Entities.Food.Add(new Food()
            {
            });
             Controller  = new FoodController();
        }

        [TestMethod]
        public void TestGetAllFood()
        {
            Web.Controllers.FoodController foodController = new FoodController();
        }
    }
}
