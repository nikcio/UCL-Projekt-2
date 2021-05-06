using BoBedre.Core.DataAccess;
using BoBedre.Core.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBedre.Core.Test.DataAccess
{
    [TestClass]
    public class EntryManagementTest
    {
        #region Ejendomsmægler
        [TestMethod]
        public async Task CreateUpdateDeleteEjendomsmæglerTest()
        {
            //Create
            string afdeling = "Afdeling";
            string mæglerFirma = "Mæglerfirma";
            string navn = "Navn";
            string email = "Email";
            string stilling = "Stilling";

            var medarbejderNr = await EntryManagement.CreateEjendomsmægler(afdeling, mæglerFirma, navn, email, stilling);
            var Ejendomsmægler = await Fetch.GetEjendomsmæglerByMedarbjederNr(medarbejderNr);

            Assert.AreEqual(afdeling, Ejendomsmægler.Afdeling, "the value is not equal to the expected");
            Assert.AreEqual(mæglerFirma, Ejendomsmægler.Mæglerfirma, "the value is not equal to the expected");
            Assert.AreEqual(navn, Ejendomsmægler.Navn, "the value is not equal to the expected");
            Assert.AreEqual(email, Ejendomsmægler.Email, "the value is not equal to the expected");
            Assert.AreEqual(stilling, Ejendomsmægler.Stilling, "the value is not equal to the expected");


            //update
            afdeling = "Updateny";
            mæglerFirma = "Update";
            navn = "Update";
            email = "Update";
            stilling = "Update";

            await EntryManagement.UpdateEjendomsmægler(medarbejderNr, afdeling, mæglerFirma, navn, email, stilling);
            Ejendomsmægler = await Fetch.GetEjendomsmæglerByMedarbjederNr(medarbejderNr);

            Assert.AreEqual(medarbejderNr, Ejendomsmægler.MedarbejderNr, "the value is not equal to the expected");
            Assert.AreEqual(afdeling, Ejendomsmægler.Afdeling, "the value is not equal to the expected");
            Assert.AreEqual(mæglerFirma, Ejendomsmægler.Mæglerfirma, "the value is not equal to the expected");
            Assert.AreEqual(navn, Ejendomsmægler.Navn, "the value is not equal to the expected");
            Assert.AreEqual(email, Ejendomsmægler.Email, "the value is not equal to the expected");
            Assert.AreEqual(stilling, Ejendomsmægler.Stilling, "the value is not equal to the expected");



            //delete
            await EntryManagement.DeleteEjendomsmægler(medarbejderNr);
            Assert.IsNull(await Fetch.GetEjendomsmæglerByMedarbjederNr(medarbejderNr));
           
        }    
 
        #endregion


    }
}
