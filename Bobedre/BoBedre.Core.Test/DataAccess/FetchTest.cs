using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoBedre.Core.DataAccess;

namespace BoBedre.Core.Test.DataAccess
{
    [TestClass]
    public class FetchTest
    {
        #region Ejendom
        [TestMethod]
        public async Task GetEjendomByBoligNr_NULL()
        {
            int boligNr = int.MaxValue;

            Assert.IsNull(await Fetch.GetEjendomByBoligNr(boligNr), "Ejendom does not exist and should return null");
        }
        #endregion

        #region Ejendomsmægler
        [TestMethod]
        public async Task GetEjendomsmæglerByMedarbjederNr_NULL()
        {
            int medarbejderNr = int.MaxValue;

            Assert.IsNull(await Fetch.GetEjendomsmæglerByMedarbjederNr(medarbejderNr), "Ejendomsmægler does not exist and should return null");
        }
        #endregion

        #region By
        [TestMethod]
        public async Task GetByByPostNr_NULL()
        {
            int postNr = int.MaxValue;

            Assert.IsNull(await Fetch.GetByByPostNr(postNr), "By does not exist and should return null");
        }
        #endregion

        #region Kunde
        [TestMethod]
        public async Task GetKundeByKundeNr_NULL()
        {
            int kundeNr = int.MaxValue;

            Assert.IsNull(await Fetch.GetKundeByKundeNr(kundeNr), "Kunde does not exist and should return null");
        }
        #endregion

        #region Renorvering
        [TestMethod]
        public async Task GetRenorveringByRenorveringsNr_NULL()
        {
            int renorveringsId = int.MaxValue;

            Assert.IsNull(await Fetch.GetRenorveringByRenorveringsId(renorveringsId), "Renorvering does not exist and should return null");
        }
        #endregion

        #region Sag
        [TestMethod]
        public async Task GetSagBySagNr_NULL()
        {
            int sagNr = int.MaxValue;

            Assert.IsNull(await Fetch.GetSagBySagNr(sagNr), "Sag does not exist and should return null");
        }
        #endregion
    }
}
