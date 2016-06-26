using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using DietPlanning.Web.Models;

namespace DietPlanning.Web.Controllers.Api
{
    public class ApiBaseController : ApiController
    {
        protected IEntities Entities { get; set; }

        public ApiBaseController()
        {
            Entities = new DietPlanningEntities();
        }

        public ApiBaseController(IEntities entities)
        {
            Entities = entities;
        }
    }

    public interface IEntities 
    {
        DbSet<Carbohydrate> Carbohydrate { get; set; }
        DbSet<Energy> Energy { get; set; }
        DbSet<Fat> Fat { get; set; }
        DbSet<Food> Food { get; set; }
        DbSet<Minerals> Minerals { get; set; }
        DbSet<Other> Other { get; set; }
        DbSet<Protein> Protein { get; set; }
        DbSet<Vitamine> Vitamine { get; set; }
        Int32 SaveChanges();
    }
}