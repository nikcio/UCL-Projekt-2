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
            var sqlCommand = new SqlCommand("SELECT * FROM Ejendomsmægler WHERE MedarbejderNr=@medarbejderNr");
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
            var sqlCommand = new SqlCommand("SELECT * FROM [By] WHERE PostNr=@postNr");
            sqlCommand.Parameters.AddWithValue("@postNr", postNr);
            return CreateByFromData(await DBConnection.ReadElement(sqlCommand));
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
        public static async Task<Kunde[]> GetKundeAll()
        {
            var sqlCpmmand = new SqlCommand("SELECT * FROM Kunde");
            var kunder = await DBConnection.ReadElements(sqlCpmmand);
            var output = new List<Kunde>();
            foreach (var kunde in kunder)
            {
                output.Add(CreateKundeFromData(kunde));
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

        /// <summary>
        /// Gets all renorvering
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
            if(values == null)
            {
                return null;
            }
            else if(values.Length == typeof(Ejendom).GetProperties().Length)
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
            else
            {
                throw new ArgumentOutOfRangeException("values", "values datapoints don't match model");
            }
        }

        /// <summary>
        /// Creates a by object from object data
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        private static By CreateByFromData(object[] values)
        {
            if(values == null)
            {
                return null;
            }
            else if(values.Length == typeof(By).GetProperties().Length)
            {
                return new By(
                (int)values[0],
                (string)values[1]
                );
            }
            else
            {
                throw new ArgumentOutOfRangeException("values", "values datapoints don't match model");
            }

        }

        /// <summary>
        /// Creates a ejendomsmægler object from object data
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        private static Ejendomsmægler CreateEjendomsmæglerFromData(object[] values)
        {
            if(values == null)
            {
                return null;
            }
            else if(values.Length == typeof(Ejendomsmægler).GetProperties().Length)
            {
                return new Ejendomsmægler(
                                (int)values[0],
                                (string)values[1],
                                (string)values[2],
                                (string)values[3],
                                (string)values[4]
                                );
            }
            else
            {
                throw new ArgumentOutOfRangeException("values", "values datapoints don't match model");
            }
            
        }

        /// <summary>
        /// Create a kunde object from object data
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        private static Kunde CreateKundeFromData(object[] values)
        {
            if(values == null)
            {
                return null;
            }
            else if(values.Length == typeof(Kunde).GetProperties().Length)
            {
                return new Kunde(
                (int)values[0],
                (string)values[1],
                (string)values[2],
                (string)values[3]
                );
            }
            else
            {
                throw new ArgumentOutOfRangeException("values", "values datapoints don't match model");
            }
        }

        /// <summary>
        /// Create renorverings object from object data
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        private static Renorvering CreateRenorveringFromData(object[] values)
        {
            if(values == null)
            {
                return null;
            }
            else if(values.Length == typeof(Renorvering).GetProperties().Length)
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
            else
            {
                throw new ArgumentOutOfRangeException("values", "values datapoints don't match model");
            }
        }

        /// <summary>
        /// Create sag object from object data
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        private static Sag CreateSagFromData(object[] values)
        {
            if(values == null)
            {
                return null;
            }
            else if(values.Length == typeof(Sag).GetProperties().Length)
            {
                return new Sag(
                                (int)values[0],
                                (int)values[1],
                                (int)values[2],
                                (int)values[3],
                                (int)values[4]
                                );
            }
            else
            {
                throw new ArgumentOutOfRangeException("values", "values datapoints don't match model");
            }
        }
        #endregion
    }
}
