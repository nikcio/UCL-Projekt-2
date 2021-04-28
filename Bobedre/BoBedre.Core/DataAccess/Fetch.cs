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
            return CreateEjendomFromData(await DBConnection.ReadElement(sqlCommand));
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
                output.Add(CreateEjendomFromData(ejendom));
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
            var sqlCommand = new SqlCommand("SELECT * FROM Ejendommægler WHERE MedarbjederNr=@medarbejderNr");
            sqlCommand.Parameters.AddWithValue("@medarbejderNr", medarbejderNr);
            return CreateEjendomsmæglerFromData(await DBConnection.ReadElement(sqlCommand));
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
                output.Add(CreateEjendomsmæglerFromData(ejendomsmægler));
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
            var sqlCommand = new SqlCommand("SELECT * FROM By WHERE PostNr=@postNr");
            sqlCommand.Parameters.AddWithValue("@postNr", postNr);
            return CreateByFromData(await DBConnection.ReadElement(sqlCommand));
        }

        /// <summary>
        /// Gets all byer
        /// </summary>
        /// <returns></returns>
        public static async Task<By[]> GetByAll()
        {
            var sqlCpmmand = new SqlCommand("SELECT * FROM By");
            var byer = await DBConnection.ReadElements(sqlCpmmand);
            var output = new List<By>();
            foreach (var by in byer)
            {
                output.Add(CreateByFromData(by));
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
            return CreateKundeFromData(await DBConnection.ReadElement(sqlCommand));
        }

        /// <summary>
        /// Gets all kunder
        /// </summary>
        /// <returns></returns>
        public static async Task<By[]> GetKundeAll()
        {
            var sqlCpmmand = new SqlCommand("SELECT * FROM Kunde");
            var kunder = await DBConnection.ReadElements(sqlCpmmand);
            var output = new List<By>();
            foreach (var kunde in kunder)
            {
                output.Add(CreateByFromData(kunde));
            }
            return output.ToArray();
        }
        #endregion

        #region Renorvering
        /// <summary>
        /// Gets a renorvering based on the RenorveringsNr
        /// </summary>
        /// <param name="renorveringsNr"></param>
        /// <returns></returns>
        public static async Task<Renorvering> GetRenorveringByRenorveringsNr(int renorveringsNr)
        {
            var sqlCommand = new SqlCommand("SELECT * FROM Renorvering WHERE RenorveringsNr=@renorveringsNr");
            sqlCommand.Parameters.AddWithValue("@renorveringsNr", renorveringsNr);
            return CreateRenorveringFromData(await DBConnection.ReadElement(sqlCommand));
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
                output.Add(CreateRenorveringFromData(renorvering));
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
            return CreateSagFromData(await DBConnection.ReadElement(sqlCommand));
        }

        /// <summary>
        /// Gets all renorvering
        /// </summary>
        /// <returns></returns>
        public static async Task<Sag[]> GetSagAll()
        {
            var sqlCpmmand = new SqlCommand("SELECT * FROM Sag");
            var sager = await DBConnection.ReadElements(sqlCpmmand);
            var output = new List<Sag>();
            foreach (var sag in sager)
            {
                output.Add(CreateSagFromData(sag));
            }
            return output.ToArray();
        }
        #endregion

        #region Create from database
        /// <summary>
        /// Creates a ejendoms object from object data
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        private static Ejendom CreateEjendomFromData(object[] values)
        {
            return new Ejendom(
                (int)values[0],
                (string)values[1],
                (int)values[2],
                (int)values[3],
                (int?)values[4],
                (int)values[5],
                (int?)values[6],
                (int)values[7],
                (bool)values[8],
                (string)values[9],
                (int)values[10]
                );
        }

        /// <summary>
        /// Creates a by object from object data
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        private static By CreateByFromData(object[] values)
        {
            return new By(
                (int)values[0],
                (string)values[1]
                );
        }

        /// <summary>
        /// Creates a ejendomsmægler object from object data
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        private static Ejendomsmægler CreateEjendomsmæglerFromData(object[] values)
        {
            return new Ejendomsmægler(
                (int)values[0],
                (string)values[1],
                (string)values[2],
                (string)values[3],
                (string)values[4]
                );
        }

        /// <summary>
        /// Create a kunde object from object data
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        private static Kunde CreateKundeFromData(object[] values)
        {
            return new Kunde(
                (int)values[0],
                (string)values[1],
                (string)values[2],
                (string)values[3]
                );
        }

        /// <summary>
        /// Create renorverings object from object data
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        private static Renorvering CreateRenorveringFromData(object[] values)
        {
            return new Renorvering(
                (int)values[0],
                (bool)values[1],
                (bool)values[2],
                (bool)values[3],
                (int)values[4],
                (string)values[5],
                (int)values[6]
                );
        }

        /// <summary>
        /// Create sag object from object data
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        private static Sag CreateSagFromData(object[] values)
        {
            return new Sag(
                (int)values[0],
                (int)values[1],
                (int)values[2],
                (int)values[3],
                (int)values[4]
                );
        }
        #endregion
    }
}
