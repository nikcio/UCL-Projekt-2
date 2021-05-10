using BoBedre.Core.DataAccess;
using BoBedre.Core.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
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

        #region Annonceringer
        public async Task CreateUpdateDeleteAnnonceringTest()
        {
            //Create
            string type = "type";
            DateTime start = DateTime.Now;
            DateTime slut = DateTime.Now;
            int sagsnr = 1;
            

            var annoncenr = await EntryManagement.CreateAnnoncering(type, start, slut, sagsnr);
            var annonce = await Fetch.GetAnnonceringByAnnonceringsNr(annoncenr);

            Assert.AreEqual(type, annonce.Type, "the value is not equal to the expected");
            Assert.AreEqual(start, annonce.StartDato, "the value is not equal to the expected");
            Assert.AreEqual(slut, annonce.SlutDato, "the value is not equal to the expected");
            Assert.AreEqual(sagsnr, annonce.SagNr, "the value is not equal to the expected");
            


            //update
            type = "Updateny";
            start = DateTime.Today;
            slut = DateTime.Today;
            sagsnr = 2;
            

            await EntryManagement.UpdateAnnoncering(type, start, slut, sagsnr, annoncenr);
            annonce = await Fetch.GetAnnonceringByAnnonceringsNr(annoncenr);

            Assert.AreEqual(annoncenr, annonce.AnnonceringsNr, "the value is not equal to the expected");
            Assert.AreEqual(type, annonce.Type, "the value is not equal to the expected");
            Assert.AreEqual(start, annonce.StartDato, "the value is not equal to the expected");
            Assert.AreEqual(slut, annonce.SlutDato, "the value is not equal to the expected");
            Assert.AreEqual(sagsnr, annonce.SagNr, "the value is not equal to the expected");
          
            await EntryManagement.DeleteAnnoncering(annoncenr);
            Assert.IsNull(await Fetch.GetAnnonceringByAnnonceringsNr(annoncenr));

        }
        #endregion
          
        #region Ejendomme
        [TestMethod]
        public async Task CreateUpdateDeleteEjendomme()
        {
            
            //Create
            string Adresse = "Adresse";
            int pris = 0;
            int BoligAreal = 0;
            int GrundAreal = 0;
            bool have = true;
            int Værelser = 0;
            int Etager = 0;
            int Byggeår = 0;
            string Type = "Type";
            int postNr = 7000;



            var Bolignr = await EntryManagement.CreateEjendom(Adresse, pris, BoligAreal, GrundAreal, have, Værelser,Etager, Type, Byggeår,postNr);
            var ejendom = await Fetch.GetEjendomByBoligNr(Bolignr);

            Assert.AreEqual(Adresse, ejendom.Adresse , "the value is not equal to the expected");
            Assert.AreEqual(pris, ejendom.Pris, "the value is not equal to the expected");
            Assert.AreEqual(BoligAreal, ejendom.BoligAreal, "the value is not equal to the expected");
            Assert.AreEqual(GrundAreal, ejendom.GrundAreal, "the value is not equal to the expected");
            Assert.AreEqual(have, ejendom.Have, "the value is not equal to the expected");
            Assert.AreEqual(Værelser, ejendom.Værelser, "the value is not equal to the expected");
            Assert.AreEqual(Etager, ejendom.Etager, "the value is not equal to the expected");
            Assert.AreEqual(Type, ejendom.Type, "the value is not equal to the expected");
            Assert.AreEqual(Byggeår, ejendom.Byggeår, "the value is not equal to the expected");
            Assert.AreEqual(postNr,ejendom.PostNr, "the value is not equal to the expected");



            ////update
            Adresse = "Updateny";
            pris = 5;
            BoligAreal = 2;
            GrundAreal = 5;
            have = false;
            Værelser = 2;
            Etager = 15;
            Type = "hus";
            Byggeår = 2912;
            postNr = 7100;

           await EntryManagement.OpdaterEjendom(Adresse, pris, BoligAreal, GrundAreal, have, Værelser,Etager,Type,Byggeår,postNr,Bolignr);
           ejendom = await Fetch.GetEjendomByBoligNr(Bolignr);

            Assert.AreEqual(Adresse, ejendom.Adresse, "the value is not equal to the expected");
            Assert.AreEqual(pris, ejendom.Pris, "the value is not equal to the expected");
            Assert.AreEqual(BoligAreal, ejendom.BoligAreal, "the value is not equal to the expected");
            Assert.AreEqual(GrundAreal, ejendom.GrundAreal, "the value is not equal to the expected");
            Assert.AreEqual(have, ejendom.Have, "the value is not equal to the expected");
            Assert.AreEqual(Værelser, ejendom.Værelser, "the value is not equal to the expected");
            Assert.AreEqual(Etager, ejendom.Etager, "the value is not equal to the expected");
            Assert.AreEqual(Type, ejendom.Type, "the value is not equal to the expected");
            Assert.AreEqual(Byggeår, ejendom.Byggeår, "the value is not equal to the expected");
            Assert.AreEqual(postNr, ejendom.PostNr, "the value is not equal to the expected");

            //delete
            await EntryManagement.DeleteEjendom(Bolignr);
            Assert.IsNull(await Fetch.GetEjendomByBoligNr(Bolignr));

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
