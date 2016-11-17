using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DietPlanning.Portable.DTO;
using DietPlanning.Web.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DietPlanning.Web.Tests.Conversion
{
    [TestClass]
    public class DTOConversion
    {
        [TestMethod]
        public void TestNutrientDTOConversion()
        {
            Protein p = new Protein() {Threonine = 20, Alanine = 10 };
            ProteinDTO dto = p.ToDTO<ProteinDTO>();
            Assert.AreEqual(20,dto.Threonine);
            Assert.AreEqual(10,dto.Alanine); 
        }

        [TestMethod]
        public void CanAddNullToDict()
        {
            Dictionary<String,Double?> asd = new Dictionary<string, double?>();
            asd.Add("qwe",null);
        }
        [TestMethod]
        public void TestDtoConversion()
        {

        }
    }
}
