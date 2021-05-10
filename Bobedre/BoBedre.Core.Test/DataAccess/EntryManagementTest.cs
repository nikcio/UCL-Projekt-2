using BoBedre.Core.DataAccess;
using BoBedre.Core.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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
            

            await EntryManagement.UpdateAnnoncering(annoncenr, type, start,slut,sagsnr);
            annonce = await Fetch.GetAnnonceringByAnnonceringsNr(annoncenr);

            Assert.AreEqual(annoncenr, annonce.AnnonceringsNr, "the value is not equal to the expected");
            Assert.AreEqual(type, annonce.Type, "the value is not equal to the expected");
            Assert.AreEqual(start, annonce.StartDato, "the value is not equal to the expected");
            Assert.AreEqual(slut, annonce.SlutDato, "the value is not equal to the expected");
            Assert.AreEqual(sagsnr, annonce.SagNr, "the value is not equal to the expected");



            //delete
            await EntryManagement.DeleteAnnoncering(annoncenr);
            Assert.IsNull(await Fetch.GetAnnonceringByAnnonceringsNr(annoncenr));

        }
        #endregion


    }
}
