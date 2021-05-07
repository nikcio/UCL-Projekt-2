using BoBedre.Core.Models;
using BoBedre.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBedre.Core.DataAccess
{
    public static class Fetch
    {
        #region Ejendom
        /// <summary>
        /// Gets a ejendom based on the BoligNr
        /// </summary>
        /// <param name="boligNr"></param>
        /// <returns></returns>
        public static async Task<Ejendom> GetEjendomByBoligNr(int boligNr)
        {
            var sqlCommand = new SqlCommand("SELECT * FROM Ejendom WHERE BoligNr=@boligNr");
            sqlCommand.Parameters.AddWithValue("@boligNr", boligNr);
            return Ejendom.CreateEjendomFromData(await DBConnection.ReadElement(sqlCommand));
        }

        /// <summary>
        /// Gets all ejendomme
        /// </summary>
        /// <returns></returns>
        public static async Task<Ejendom[]> GetEjendomAll()
        {
            var sqlCpmmand = new SqlCommand("SELECT * FROM Ejendom");
            var ejendomme = await DBConnection.ReadElements(sqlCpmmand);
            var output = new List<Ejendom>();
            foreach (var ejendom in ejendomme)
            {
                output.Add(Ejendom.CreateEjendomFromData(ejendom));
            }
            return output.ToArray();
        }
        #endregion

        #region Ejendomsmægler
        /// <summary>
        /// Gets a ejendomsmægler based on the medarbjederNr
        /// </summary>
        /// <param name="medarbejderNr"></param>
        /// <returns></returns>
        public static async Task<Ejendomsmægler> GetEjendomsmæglerByMedarbjederNr(int medarbejderNr)
        {
            var sqlCommand = new SqlCommand("SELECT * FROM Ejendomsmægler WHERE MedarbejderNr=@medarbejderNr");
            sqlCommand.Parameters.AddWithValue("@medarbejderNr", medarbejderNr);
            return Ejendomsmægler.CreateEjendomsmæglerFromData(await DBConnection.ReadElement(sqlCommand));
        }

        /// <summary>
        /// Gets all ejendomsmæglere
        /// </summary>
        /// <returns></returns>
        public static async Task<Ejendomsmægler[]> GetEjendomsmæglerAll()
        {
            var sqlCpmmand = new SqlCommand("SELECT * FROM Ejendomsmægler");
            var ejendomsmæglere = await DBConnection.ReadElements(sqlCpmmand);
            var output = new List<Ejendomsmægler>();
            foreach (var ejendomsmægler in ejendomsmæglere)
            {
                output.Add(Ejendomsmægler.CreateEjendomsmæglerFromData(ejendomsmægler));
            }
            return output.ToArray();
        }
        #endregion

        #region By
        /// <summary>
        /// Gets a by based on the postNr
        /// </summary>
        /// <param name="postNr"></param>
        /// <returns></returns>
        public static async Task<By> GetByByPostNr(int postNr)
        {
            var sqlCommand = new SqlCommand("SELECT * FROM [By] WHERE PostNr=@postNr");
            sqlCommand.Parameters.AddWithValue("@postNr", postNr);
            return By.CreateByFromData(await DBConnection.ReadElement(sqlCommand));
        }

        /// <summary>
        /// Gets all byer
        /// </summary>
        /// <returns></returns>
        public static async Task<By[]> GetByAll()
        {
            var sqlCpmmand = new SqlCommand("SELECT * FROM [By]");
            var byer = await DBConnection.ReadElements(sqlCpmmand);
            var output = new List<By>();
            foreach (var by in byer)
            {
                output.Add(By.CreateByFromData(by));
            }
            return output.ToArray();
        }
        #endregion

        #region Kunde
        /// <summary>
        /// Gets a kunde based on the kundeNr
        /// </summary>
        /// <param name="kundeNr"></param>
        /// <returns></returns>
        public static async Task<Kunde> GetKundeByKundeNr(int kundeNr)
        {
            var sqlCommand = new SqlCommand("SELECT * FROM Kunde WHERE KundeNr=@kundeNr");
            sqlCommand.Parameters.AddWithValue("@kundeNr", kundeNr);
            return Kunde.CreateKundeFromData(await DBConnection.ReadElement(sqlCommand));
        }

        /// <summary>
        /// Gets all kunder
        /// </summary>
        /// <returns></returns>
        public static async Task<Kunde[]> GetKundeAll()
        {
            var sqlCpmmand = new SqlCommand("SELECT * FROM Kunde");
            var kunder = await DBConnection.ReadElements(sqlCpmmand);
            var output = new List<Kunde>();
            foreach (var kunde in kunder)
            {
                output.Add(Kunde.CreateKundeFromData(kunde));
            }
            return output.ToArray();
        }
        #endregion

        #region Renorvering
        /// <summary>
        /// Gets a renorvering based on the RenorveringsId
        /// </summary>
        /// <param name="renorveringsId"></param>
        /// <returns></returns>
        public static async Task<Renorvering> GetRenorveringByRenorveringsId(int renorveringsId)
        {
            var sqlCommand = new SqlCommand("SELECT * FROM Renorvering WHERE RenorveringsId=@renorveringsId");
            sqlCommand.Parameters.AddWithValue("@renorveringsId", renorveringsId);
            return Renorvering.CreateRenorveringFromData(await DBConnection.ReadElement(sqlCommand));
        }

        /// <summary>
        /// Gets all renorvering
        /// </summary>
        /// <returns></returns>
        public static async Task<Renorvering[]> GetRenorveringAll()
        {
            var sqlCpmmand = new SqlCommand("SELECT * FROM Renorvering");
            var renorveringer = await DBConnection.ReadElements(sqlCpmmand);
            var output = new List<Renorvering>();
            foreach (var renorvering in renorveringer)
            {
                output.Add(Renorvering.CreateRenorveringFromData(renorvering));
            }
            return output.ToArray();
        }

        /// <summary>
        /// Gets all renorveringer
        /// </summary>
        /// <returns></returns>
        public static async Task<Renorvering[]> GetRenorveringerByBoligNr(int boligNr)
        {
            var sqlCommand = new SqlCommand("SELECT * FROM Renorvering WHERE BoligNr=@boligNr");

            sqlCommand.Parameters.AddWithValue("@boligNr", boligNr);

            var renorveringer = await DBConnection.ReadElements(sqlCommand);
            var output = new List<Renorvering>();
            foreach (var renorvering in renorveringer)
            {
                output.Add(Renorvering.CreateRenorveringFromData(renorvering));
            }
            return output.ToArray();
        }
        #endregion

        #region Sag
        /// <summary>
        /// Gets a sag based on the sagNr
        /// </summary>
        /// <param name="sagNr"></param>
        /// <returns></returns>
        public static async Task<Sag> GetSagBySagNr(int sagNr)
        {
            var sqlCommand = new SqlCommand("SELECT * FROM Sag WHERE SagNr=@sagNr");
            sqlCommand.Parameters.AddWithValue("@sagNr", sagNr);
            return Sag.CreateSagFromData(await DBConnection.ReadElement(sqlCommand));
        }

        /// <summary>
        /// Gets all sager
        /// </summary>
        /// <returns></returns>
        public static async Task<Sag[]> GetSagAll()
        {
            var sqlCpmmand = new SqlCommand("SELECT * FROM Sag");
            var sager = await DBConnection.ReadElements(sqlCpmmand);
            var output = new List<Sag>();
            foreach (var sag in sager)
            {
                output.Add(Sag.CreateSagFromData(sag));
            }
            return output.ToArray();
        }
        #endregion

        #region Annoncering
        /// <summary>
        /// Gets a Annoncering based on the AnnonceringNr
        /// </summary>
        /// <param name="sagNr"></param>
        /// <returns></returns>
        public static async Task<Annoncering> GetAnnonceringByAnnonceringsNr(int annonceringNr)
        {
            var sqlCommand = new SqlCommand("SELECT * FROM Annoncering WHERE AnnonceringsNr=@annonceringsNr");
            sqlCommand.Parameters.AddWithValue("@annonceringsNr", annonceringNr);
            return Annoncering.CreateAnnonceringFromData(await DBConnection.ReadElement(sqlCommand));
        }

        /// <summary>
        /// Gets all annonceringNr
        /// </summary>
        /// <returns></returns>
        public static async Task<Annoncering[]> GetAnnonceringAll()
        {
            var sqlCpmmand = new SqlCommand("SELECT * FROM Annoncering");
            var annonceringer = await DBConnection.ReadElements(sqlCpmmand);
            var output = new List<Annoncering>();
            foreach (var annoncering in annonceringer)
            {
                output.Add(Annoncering.CreateAnnonceringFromData(annoncering));
            }
            return output.ToArray();
        }
        #endregion
    }
}
