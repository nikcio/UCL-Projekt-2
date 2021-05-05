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

    }
}
