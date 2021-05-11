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
        [TestMethod]
        public async Task CreateUpdateDeleteAnnonceringTest()
        {
            //Create
            string type = "type";
            DateTime start = DateTime.Now.Date;
            DateTime slut = DateTime.Now.Date;
            bool deleteSag = false;
            bool deleteSag2 = false;
            bool deleteEjendomsmægler = false;
            int? medarbejderNr = null;
            var sager = await Fetch.GetSagAll();
            int? sagnr = sager.FirstOrDefault()?.SagNr;
            if(sagnr == null)
            {
                deleteSag = true;
                var oprettelsesDato = DateTime.Now.Date;
                var medarbejdere = await Fetch.GetEjendomsmæglerAll();
                medarbejderNr = medarbejdere.FirstOrDefault()?.MedarbejderNr;
                if(medarbejderNr == null)
                {
                    deleteEjendomsmægler = true;
                    string afdeling = "testAfdeling";
                    string mæglerfirma = "mæglerfirma 1";
                    string navn = "mit navn";
                    string email = "email@email.com";
                    string stilling = "Stilling 1";
                    medarbejderNr = await EntryManagement.CreateEjendomsmægler(afdeling, mæglerfirma, navn, email, stilling);
                }

                sagnr = await EntryManagement.CreateSag(oprettelsesDato, medarbejderNr.GetValueOrDefault());
            }

            var annoncenr = await EntryManagement.CreateAnnoncering(type, start, slut, sagnr.GetValueOrDefault());
            var annonce = await Fetch.GetAnnonceringByAnnonceringsNr(annoncenr);

            Assert.AreEqual(type, annonce.Type, "the value is not equal to the expected");
            Assert.AreEqual(start, annonce.StartDato, "the value is not equal to the expected");
            Assert.AreEqual(slut, annonce.SlutDato, "the value is not equal to the expected");
            Assert.AreEqual(sagnr.GetValueOrDefault(), annonce.SagNr, "the value is not equal to the expected");
            


            //update
            type = "Updateny";
            start = DateTime.Now.Date.AddDays(2);
            slut = DateTime.Now.Date.AddDays(2);

            sager = await Fetch.GetSagAll();
            int? sagnr2 = sager.FirstOrDefault(item => item.SagNr != sagnr)?.SagNr;
            if(sagnr2 == null)
            {
                deleteSag2 = true;
                DateTime oprettelsesDato = DateTime.Now.Date;
                sagnr2 = await EntryManagement.CreateSag(oprettelsesDato, medarbejderNr.GetValueOrDefault());
            }

            await EntryManagement.UpdateAnnoncering(annoncenr, type, start,slut, sagnr2.GetValueOrDefault());
            annonce = await Fetch.GetAnnonceringByAnnonceringsNr(annoncenr);

            Assert.AreEqual(annoncenr, annonce.AnnonceringsNr, "the value is not equal to the expected");
            Assert.AreEqual(type, annonce.Type, "the value is not equal to the expected");
            Assert.AreEqual(start, annonce.StartDato, "the value is not equal to the expected");
            Assert.AreEqual(slut, annonce.SlutDato, "the value is not equal to the expected");
            Assert.AreEqual(sagnr2.GetValueOrDefault(), annonce.SagNr, "the value is not equal to the expected");
          
            await EntryManagement.DeleteAnnoncering(annoncenr);
            Assert.IsNull(await Fetch.GetAnnonceringByAnnonceringsNr(annoncenr));

            //Clean up
            if(deleteSag == true)
            {
                await EntryManagement.DeleteSag(sagnr.GetValueOrDefault());
            }
            if(deleteSag2 == true)
            {
                await EntryManagement.DeleteSag(sagnr2.GetValueOrDefault());
            }
            if(deleteEjendomsmægler == true)
            {
                await EntryManagement.DeleteEjendomsmægler(medarbejderNr.GetValueOrDefault());
            }

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

        #region sag
        [TestMethod]
        public async Task CreateUpdateDeleteSagTest()
        {
            // Create
            DateTime oprettelsesDato = DateTime.Now.Date;

            var medarbejdere = await Fetch.GetEjendomsmæglerAll();
            int? medarbejderNr = medarbejdere.FirstOrDefault()?.MedarbejderNr;
            bool deleteMedarbejder = false;
            bool deleteMedarbejder2 = false;

            if(medarbejderNr == null)
            {
                string afdeling = "afdeling";
                string mæglerfirma = "mæglerfirma";
                string navn = "mægler navn";
                string email = "email@email.com";
                string stilling = "stilling";
                deleteMedarbejder = true;

                medarbejderNr = await EntryManagement.CreateEjendomsmægler(afdeling, mæglerfirma, navn, email, stilling);
            }

            var sagsnr = await EntryManagement.CreateSag(oprettelsesDato, medarbejderNr.GetValueOrDefault());
            var sag = await Fetch.GetSagBySagNr(sagsnr);

            Assert.AreEqual(oprettelsesDato, sag.OprettelsesDato, "the value is not equal to the expected");
            Assert.AreEqual(medarbejderNr, sag.MedarbejderNr, "the value is not equal to the expected");


            // Update

            oprettelsesDato = DateTime.Now.Date.AddDays(5);
            DateTime TilsalgsDato = DateTime.Now.Date;
            bool solgt = true;
            int gebyr = 20000;
            int salær = 1230;
            DateTime OverdragelsesDato = DateTime.Now.Date.AddDays(20);
            DateTime AfslutningsDato = DateTime.Now.Date.AddDays(45);
            
            medarbejdere = await Fetch.GetEjendomsmæglerAll();
            int? medarbejderNr2 = medarbejdere.FirstOrDefault(item => item.MedarbejderNr == medarbejderNr.GetValueOrDefault())?.MedarbejderNr;
            if (medarbejderNr2 == null)
            {
                string afdeling = "afdeling";
                string mæglerfirma = "mæglerfirma";
                string navn = "mægler2 navn";
                string email = "email@email.com";
                string stilling = "stilling";
                deleteMedarbejder = true;

                medarbejderNr2 = await EntryManagement.CreateEjendomsmægler(afdeling, mæglerfirma, navn, email, stilling);
            }

            var ejendomme = await Fetch.GetEjendomAll();
            int? bolignr = ejendomme.FirstOrDefault()?.BoligNr;
            bool deleteBolig = false;
            if(bolignr == null)
            {
                //Create
                string adresse = "Adresse";
                int pris = 0;
                int boligAreal = 0;
                int grundAreal = 0;
                bool have = true;
                int værelser = 0;
                int etager = 0;
                int byggeår = 0;
                string type = "Type";
                int postNr = 7000;
                deleteBolig = true;

                bolignr = await EntryManagement.CreateEjendom(adresse, pris, boligAreal, grundAreal, have, værelser, etager, type, byggeår, postNr);
            }

            var sælgere = await Fetch.GetSælgerAll();
            int? sælgernr = sælgere.FirstOrDefault()?.KundeNr;
            bool deleteSælger = false;
            if(sælgernr == null)
            {
                string navn = "Navn";
                string email = "Email";
                string type = "Sælger";
                deleteSælger = true;

                sælgernr = await EntryManagement.CreateKunde(navn, email, type);
            }

            var købere = await Fetch.GetKøberAll();
            int? købernr = købere.FirstOrDefault()?.KundeNr;
            bool deleteKøber = false;
            if(købernr == null)
            {
                string navn = "Navn";
                string email = "Email";
                string type = "Køber";
                deleteKøber = true;

                købernr = await EntryManagement.CreateKunde(navn, email, type);
            }

            await EntryManagement.UpdateSag(sagsnr, oprettelsesDato, TilsalgsDato, solgt, gebyr, salær, OverdragelsesDato, AfslutningsDato, bolignr, sælgernr, købernr, medarbejderNr2.GetValueOrDefault());     
            sag = await Fetch.GetSagBySagNr(sagsnr);

            Assert.AreEqual(oprettelsesDato, sag.OprettelsesDato, "the value is not equal to the expected");
            Assert.AreEqual(medarbejderNr, sag.MedarbejderNr, "the value is not equal to the expected");
            Assert.AreEqual(solgt, sag.Solgt, "the value is not equal to the expected");
            Assert.AreEqual(gebyr, sag.Gebyr, "the value is not equal to the expected");
            Assert.AreEqual(salær, sag.Salær, "the value is not equal to the expected");
            Assert.AreEqual(OverdragelsesDato, sag.OverdragelsesDato, "the value is not equal to the expected");
            Assert.AreEqual(AfslutningsDato, sag.AfslutningsDato, "the value is not equal to the expected");
            Assert.AreEqual(bolignr, sag.BoligNr, "the value is not equal to the expected");
            Assert.AreEqual(sælgernr, sag.SælgerNr, "the value is not equal to the expected");
            Assert.AreEqual(købernr, sag.KøberNr, "the value is not equal to the expected");

            // Delete
            await EntryManagement.DeleteSag(sagsnr);
            Assert.IsNull(await Fetch.GetSagBySagNr(sagsnr));

            // Clean up
            if (deleteMedarbejder)
            {
                await EntryManagement.DeleteEjendomsmægler(medarbejderNr.GetValueOrDefault());
            }
            if (deleteMedarbejder2)
            {
                await EntryManagement.DeleteEjendomsmægler(medarbejderNr2.GetValueOrDefault());
            }
            if (deleteBolig)
            {
                await EntryManagement.DeleteEjendom(bolignr.GetValueOrDefault());
            }
            if (deleteKøber)
            {
                await EntryManagement.DeleteKunde(købernr.GetValueOrDefault());
            }
            if (deleteSælger)
            {
                await EntryManagement.DeleteKunde(sælgernr.GetValueOrDefault());
            }

        }

        #endregion
    }
}
