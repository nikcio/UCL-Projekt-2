using BoBedre.Core.DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

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

        [TestMethod]
        public async Task GetEjendomAll_NotNull()
        {
            Assert.IsNotNull(await Fetch.GetEjendomAll(), "GetEjendomAll should not return null but a empty array if no elements are in the database");
        }


        #endregion

        #region Ejendomsmægler
        [TestMethod]
        public async Task GetEjendomsmæglerByMedarbjederNr_NULL()
        {
            int medarbejderNr = int.MaxValue;

            Assert.IsNull(await Fetch.GetEjendomsmæglerByMedarbjederNr(medarbejderNr), "Ejendomsmægler does not exist and should return null");
        }

        [TestMethod]
        public async Task GetEjendomsmæglerAll_NotNull()
        {
            Assert.IsNotNull(await Fetch.GetEjendomsmæglerAll(), "GetEjendomsmæglerAll should not return null but a empty array if no elements are in the database");
        }
        #endregion

        #region By
        [TestMethod]
        public async Task GetByByPostNr_NULL()
        {
            int postNr = int.MaxValue;

            Assert.IsNull(await Fetch.GetByByPostNr(postNr), "By does not exist and should return null");
        }

        [TestMethod]
        public async Task GetByAll_NotNull()
        {
            Assert.IsNotNull(await Fetch.GetByAll(), "GetByAll should not return null but a empty array if no elements are in the database");
        }
        #endregion

        #region Kunde
        [TestMethod]
        public async Task GetKundeByKundeNr_NULL()
        {
            int kundeNr = int.MaxValue;

            Assert.IsNull(await Fetch.GetKundeByKundeNr(kundeNr), "Kunde does not exist and should return null");
        }

        [TestMethod]
        public async Task GetKundeAll_NotNull()
        {
            Assert.IsNotNull(await Fetch.GetKundeAll(), "GetKundeAll should not return null but a empty array if no element are in the database");
        }
        #endregion

        #region Renorvering
        [TestMethod]
        public async Task GetRenorveringByRenorveringsNr_NULL()
        {
            int renorveringsId = int.MaxValue;

            Assert.IsNull(await Fetch.GetRenorveringByRenorveringsId(renorveringsId), "Renorvering does not exist and should return null");
        }

        [TestMethod]
        public async Task GetRenorveringAll_NotNull()
        {
            Assert.IsNotNull(await Fetch.GetRenorveringAll(), "GetRenorveringAll should not return null but a empty array if no elements are in the database");
        }
        #endregion

        #region Sag
        [TestMethod]
        public async Task GetSagBySagNr_NULL()
        {
            int sagNr = int.MaxValue;

            Assert.IsNull(await Fetch.GetSagBySagNr(sagNr), "Sag does not exist and should return null");
        }

        [TestMethod]
        public async Task GetSagAll_NotNull()
        {
            Assert.IsNotNull(await Fetch.GetSagAll(), "GetSagAll Should not return null but a empty array if no elements are in the database");
        }
        #endregion
    }
}
