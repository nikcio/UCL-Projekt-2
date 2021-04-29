using BoBedre.Core.AssetLoaders;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBedre.Core.Test.AssetLoaders
{
    [TestClass]
    public class CityLoaderTest
    {
        [TestMethod]
        public async Task FindCityName_NULL()
        {
            int zipcode = int.MaxValue;

            Assert.IsNull(await CityLoader.FindCityName(zipcode.ToString()), "CityName should be null for int.MaxValue");
        }

        [TestMethod]
        public async Task FindCityName_Vaild()
        {
            int zipcode = 7100;
            string expected = "Vejle";

            string value = await CityLoader.FindCityName(zipcode.ToString());

            Assert.AreEqual(expected, value, "City name doen't match zipcode");
        }

    }
}
