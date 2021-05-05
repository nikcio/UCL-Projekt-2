﻿using BoBedre.Core.DataAccess;
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
        #region Ejendomægler
        [TestMethod]
        public async Task CreateUpdateDeleteEjendomsmæglerTest()
        {
            //Create
            string afdeling = "Afdeling";
            string mæglerFirma = "Mæglerfirma";
            string navn = "Navn";
            string email = "Email";

            var medarbejderNr = await EntryManagement.CreateEjendomsmægler(afdeling, mæglerFirma, navn, email);
            var Ejendomsmægler = await Fetch.GetEjendomsmæglerByMedarbjederNr(medarbejderNr);

            Assert.AreEqual(afdeling, Ejendomsmægler.Afdeling, "the value is not equal to the expected");
            Assert.AreEqual(mæglerFirma, Ejendomsmægler.Mæglerfirma, "the value is not equal to the expected");
            Assert.AreEqual(navn, Ejendomsmægler.Navn, "the value is not equal to the expected");
            Assert.AreEqual(email, Ejendomsmægler.Email, "the value is not equal to the expected");


            //update
            afdeling = "Updateny";
            mæglerFirma = "Update";
            navn = "Update";
            email = "Update";

            await EntryManagement.UpdateEjendomsmægler(medarbejderNr, afdeling, mæglerFirma, navn, email);
            Ejendomsmægler = await Fetch.GetEjendomsmæglerByMedarbjederNr(medarbejderNr);

            Assert.AreEqual(medarbejderNr, Ejendomsmægler.MedarbejderNr);
            Assert.AreEqual(afdeling, Ejendomsmægler.Afdeling, "the value is not equal to the expected");
            Assert.AreEqual(mæglerFirma, Ejendomsmægler.Mæglerfirma, "the value is not equal to the expected");
            Assert.AreEqual(navn, Ejendomsmægler.Navn, "the value is not equal to the expected");
            Assert.AreEqual(email, Ejendomsmægler.Email, "the value is not equal to the expected");

            

            //delete
            await EntryManagement.DeleteEjendomsmægler(medarbejderNr);
            Assert.IsNull(await Fetch.GetEjendomsmæglerByMedarbjederNr(medarbejderNr));
           
        }

        #endregion

        #region Kunde
        [TestMethod]
        public async Task CreateUpdateDeleteKundeTest()
        {
            //Create
            string navn = "Navn";
            string email = "Email";
            string type = "Type";


            var kundeNr = await EntryManagement.CreateKunde(navn, email, type);
            var Kunde = await Fetch.GetKundeByKundeNr(kundeNr);

            Assert.AreEqual(navn, Kunde.Navn , "the value is not equal to the expected");
            Assert.AreEqual(email, Kunde.Email , "the value is not equal to the expected");
            Assert.AreEqual(type, Kunde.Type , "the value is not equal to the expected");

            //update
            navn = "Update";
            email = "Update";
            type = "Update";

            await EntryManagement.UpdateKunde (kundeNr, navn, email, type);
            Kunde = await Fetch.GetKundeByKundeNr(kundeNr);

            Assert.AreEqual(kundeNr, Kunde.KundeNr);
            Assert.AreEqual(navn, Kunde.Navn, "the value is not equal to the expected");
            Assert.AreEqual(email, Kunde.Email, "the value is not equal to the expected");
            Assert.AreEqual(type, Kunde.Type, "the value is not equal to the expected");


            //delete
            await EntryManagement.DeleteKunde(kundeNr);
            Assert.IsNull(await Fetch.GetKundeByKundeNr(kundeNr));

        }

        #endregion
    }
}
