using BoBedre.Core.DataAccess;
using BoBedre.Core.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

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

        #region Renorvering
        [TestMethod]
        public async Task CreateUpdateDeleteRenorvering()
        {
            bool køkken = true;
            bool badeværelse = false;
            bool andet = true;
            int ombygningsÅr = 2020;
            string detaljer = "Dette er detaljer";
            bool deleteEjendom = false; // Determins if we should delete the ejendom on exit
            
            Ejendom[] ejendomme = await Fetch.GetEjendomAll();
            int? boligNr = ejendomme.FirstOrDefault()?.BoligNr;

            // Create ejendom if none is avalible
            if(boligNr == null)
            {
                string adresse = "addresse 1";
                int pris = 100;
                int boligAreal = 120;
                int grundAreal = 200;
                bool have = true;
                int værelser = 2;
                int etager = 1;
                string typeBolig = "Lejlighed";
                int byggeår = 2020;
                int postNr = 7100;
                deleteEjendom = true;

                boligNr = await EntryManagement.CreateEjendom(adresse, pris, boligAreal, grundAreal, have, værelser, etager, typeBolig, byggeår, postNr);
            }

            // Create
            int renorveringsId = await EntryManagement.CreateRenorvering(køkken, badeværelse, andet, ombygningsÅr, detaljer, boligNr.GetValueOrDefault());
            Renorvering renorvering = await Fetch.GetRenorveringByRenorveringsId(renorveringsId);

            Assert.AreEqual(køkken, renorvering.Køkken, "Values does not match");
            Assert.AreEqual(badeværelse, renorvering.Badeværelse, "Values does not match");
            Assert.AreEqual(andet, renorvering.Andet, "Values does not match");
            Assert.AreEqual(ombygningsÅr, renorvering.Ombygningsår, "Values does not match");
            Assert.AreEqual(detaljer, renorvering.Detaljer, "Values does not match");

            // Update
            køkken = false;
            badeværelse = true;
            andet = false;
            ombygningsÅr = 1020;
            detaljer = "Update Update update";

            await EntryManagement.UpdateRenorvering(køkken, badeværelse, andet, ombygningsÅr, detaljer, renorveringsId);
            renorvering = await Fetch.GetRenorveringByRenorveringsId(renorveringsId);

            Assert.AreEqual(køkken, renorvering.Køkken, "Values does not match");
            Assert.AreEqual(badeværelse, renorvering.Badeværelse, "Values does not match");
            Assert.AreEqual(andet, renorvering.Andet, "Values does not match");
            Assert.AreEqual(ombygningsÅr, renorvering.Ombygningsår, "Values does not match");
            Assert.AreEqual(detaljer, renorvering.Detaljer, "Values does not match");

            // Delete
            await EntryManagement.DeleteRenorvering(renorveringsId);

            Assert.IsNull(await Fetch.GetRenorveringByRenorveringsId(renorveringsId), "Renorvering should be null");

            // Clean up
            if (deleteEjendom)
            {
                await EntryManagement.DeleteEjendom(boligNr.GetValueOrDefault());
            }
        }
        #endregion

        #region By
        [TestMethod]
        public async Task CreateUpdateDeleteBy()
        {
            // Create
            int zipcode = 100;
            string cityName = "Test by";

            // Make sure no by exists
            By by = await Fetch.GetByByPostNr(zipcode);
            if (by != null)
            {
                await EntryManagement.DeleteBy(zipcode);
            }

            await EntryManagement.CreateBy(zipcode, cityName);
            by = await Fetch.GetByByPostNr(zipcode);

            Assert.AreEqual(zipcode, by.PostNr);
            Assert.AreEqual(cityName, by.ByNavn);

            // Update
            var zipcodeNewValue = 200;
            cityName = "Test 2";

            // Make sure nu by exists
            by = await Fetch.GetByByPostNr(zipcodeNewValue);
            if (by != null)
            {
                await EntryManagement.DeleteBy(zipcodeNewValue);
            }

            await EntryManagement.UpdateBy(zipcode, cityName, zipcodeNewValue);
            by = await Fetch.GetByByPostNr(zipcodeNewValue);

            Assert.AreEqual(zipcodeNewValue, by.PostNr);
            Assert.AreEqual(cityName, by.ByNavn);

            // Delete
            await EntryManagement.DeleteBy(zipcodeNewValue);

            Assert.IsNull(await Fetch.GetByByPostNr(zipcodeNewValue));
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

            Assert.AreEqual(navn, Kunde.Navn, "the value is not equal to the expected");
            Assert.AreEqual(email, Kunde.Email, "the value is not equal to the expected");
            Assert.AreEqual(type, Kunde.Type, "the value is not equal to the expected");

            //update
            navn = "Update";
            email = "Update";
            type = "Update";

            await EntryManagement.UpdateKunde(kundeNr, navn, email, type);
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
