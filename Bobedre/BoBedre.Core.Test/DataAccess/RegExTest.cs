using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BoBedre.Core.TextChecking;



namespace BoBedre.Core.Test.DataAccess
{
    [TestClass]
    public class RegExTest
    {
        #region RegExTest
        [TestMethod]
        public void TextCheckRegTest()
        {
            //Create
            string text = "afdeling";

            var test = RegexCheck.TextCheck(text);

            Assert.IsTrue(test, "The value is not true");

          
        }
        [TestMethod]
        public void TalCheckRegTest()
        {
            //Create
            string text = "21252139";

            var test = RegexCheck.TalCheck(text);

            Assert.IsTrue(test, "The value is not true");


        }

        [TestMethod]
        public void EmailCheckRegTest()
        {
            //Create
            string text = "test@gmail.com";

            var test = RegexCheck.EmailCheck(text);

            Assert.IsTrue(test, "The value is not true");


        }

        #endregion









    }
}
