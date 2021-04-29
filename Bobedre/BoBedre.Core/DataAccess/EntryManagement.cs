using BoBedre.Core.AssetLoaders;
using BoBedre.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBedre.Core.DataAccess
{
    public static class EntryManagement
    {
        
        #region Ejendomsmægler
        public static async Task<string> UpdateEjendomsmægler(int medarbejderNr, string afdeling, string mæglerfirma, string navn, string email)
        {
            try
            {
                SqlCommand cmd = new("UPDATE Ejendomsmægler set Afdeling=@Afdeling, Mæglerfirma=@Mæglerfirma, Navn=@Navn, Email=@Email WHERE MedarbejderNr = @MedarbejderNr");
                cmd.Parameters.AddWithValue("@MedarbejderNr", medarbejderNr);
                cmd.Parameters.AddWithValue("@Afdeling", afdeling);
                cmd.Parameters.AddWithValue("@Mæglerfirma", mæglerfirma);
                cmd.Parameters.AddWithValue("@Navn", navn);
                cmd.Parameters.AddWithValue("@Email", email);

                await DBConnection.ExecuteNonQuery(cmd);

                return "Ejendomsmægleren er netop blevet opdateret";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


        public static async Task <string> DeleteEjendomsmægler (int medarbejderNr)
        {
            try
            {
                SqlCommand cmd = new("DELETE from Ejendomsmægler WHERE MedarbejderNr = @MedarbejderNr ");
                cmd.Parameters.AddWithValue("@MedarbejderNr", medarbejderNr);
                                
                await DBConnection.ExecuteNonQuery(cmd);

                return "Ejendomsmægleren er netop blevet slettet";

            }

            catch (Exception ex)
            {
                return ex.Message;
            }

        }


        public static async Task<string> CreateEjendomsmægler(string afdeling, string mæglerfirma, string navn, string email)
        {
            try
            {
                SqlCommand cmd = new("INSERT into Ejendomsmægler(Afdeling, Mæglerfirma, Navn, Email) VALUES (@Afdeling, @Mæglerfirma, @Navn, @Email)");

                cmd.Parameters.AddWithValue("@Afdeling", afdeling);
                cmd.Parameters.AddWithValue("@Mæglerfirma", mæglerfirma);
                cmd.Parameters.AddWithValue("@Navn", navn);
                cmd.Parameters.AddWithValue("@Email", email);

                await DBConnection.ExecuteNonQuery(cmd);

                return "Ejendomsmægleren er netop blevet tilføjet";

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        #endregion

        #region Ejendomme
        public static async Task CreateEjendom(
            string adresse, 
            int pris, 
            int boligAreal, 
            int grundAreal, 
            bool have, 
            int værelser,
            int etager,
            string typeBolig, 
            int byggeår,
            int postNr,
            bool renorvert,
            bool køkken,
            bool badeværelse,
            bool andet,
            int ombygningsÅr,
            string detaljer
            )
        {
            SqlCommand cmd = await CreateEjendomEntry(adresse, pris, boligAreal, grundAreal, have, værelser, etager, typeBolig, byggeår, postNr);

            int boligNr = (int)await DBConnection.ExecuteScalar(cmd);

            if (renorvert)
            {
                await CreateRenorvering(køkken, badeværelse, andet, ombygningsÅr, detaljer, boligNr);
            }
        }

        public static async Task CreateEjendom(
            string adresse,
            int pris,
            int boligAreal,
            int grundAreal,
            bool have,
            int værelser,
            int etager,
            string typeBolig,
            int byggeår,
            int postNr
            )
        {
            SqlCommand cmd = await CreateEjendomEntry(adresse, pris, boligAreal, grundAreal, have, værelser, etager, typeBolig, byggeår, postNr);

            await DBConnection.ExecuteNonQuery(cmd);
        }

        private static async Task<SqlCommand> CreateEjendomEntry(string adresse, int pris, int boligAreal, int grundAreal, bool have, int værelser, int etager, string typeBolig, int byggeår, int postNr)
        {
            SqlCommand cmd = new SqlCommand(
                            "INSERT INTO Ejendom(Adresse, Pris, Boligareal, Grundareal, have, værelser, Etager, Type, Byggeår, PostNr) " +
                            "OUTPUT INSERTED.BoligNr " +
                            "VALUES (@Adresse, @Pris, @Boligareal, @Grundareal, @have, @værelser, @Etager, @Type, @Byggeår, @PostNr)");

            cmd.Parameters.AddWithValue("@Adresse", adresse);
            cmd.Parameters.AddWithValue("@Pris", pris);
            cmd.Parameters.AddWithValue("@Boligareal", boligAreal);
            cmd.Parameters.AddWithValue("@Grundareal", grundAreal);
            cmd.Parameters.AddWithValue("@Have", have);
            cmd.Parameters.AddWithValue("@Værelser", værelser);
            cmd.Parameters.AddWithValue("@Etager", etager);
            cmd.Parameters.AddWithValue("@Type", typeBolig);
            cmd.Parameters.AddWithValue("@Byggeår", byggeår);

            if (await Fetch.GetByByPostNr(postNr) == null)
            {
                string cityName = await CityLoader.FindCityName(postNr.ToString());
                await CreateBy(postNr, cityName);
            }

            cmd.Parameters.AddWithValue("@PostNr", postNr);
            return cmd;
        }

        #endregion

        #region Renorvering
        public static async Task CreateRenorvering(
            bool køkken,
            bool badeværelse,
            bool andet,
            int ombygningsÅr,
            string detaljer,
            int boligNr)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Renorvering (Køkken, Badeværelse, Andet, OmbygningsÅr, Detaljer, BoligNr) VALUES (@køkken, @badeværelse, @andet, @ombygningsÅr, @detaljer, @boligNr)");
            
            cmd.Parameters.AddWithValue("@køkken", køkken);
            cmd.Parameters.AddWithValue("@badeværelse", badeværelse);
            cmd.Parameters.AddWithValue("@andet", andet);
            cmd.Parameters.AddWithValue("@ombygningsÅr", ombygningsÅr);
            cmd.Parameters.AddWithValue("@detaljer", detaljer);
            cmd.Parameters.AddWithValue("@boligNr", boligNr);

            await DBConnection.ExecuteNonQuery(cmd);
        }
        #endregion

        #region By

        /// <summary>
        /// Creates a by
        /// </summary>
        /// <param name="zipcode"></param>
        /// <param name="cityName"></param>
        /// <returns>Success</returns>
        public static async Task<bool> CreateBy(int zipcode, string cityName)
        {
            try
            {
                SqlCommand cmd = new("INSERT into [By] VALUES (@zipcode, @cityName)");

                cmd.Parameters.AddWithValue("@zipcode", zipcode);
                cmd.Parameters.AddWithValue("@cityname", cityName);

                await DBConnection.ExecuteNonQuery(cmd);

                return true;
            }
            catch 
            {
                return false;
            }
        }
        #endregion


        #region Kunde
        public static async Task<string> CreateKunde(string navn, string email)
        {
            try
            {
                SqlCommand cmd = new("INSERT into Kunde(Navn, Email) VALUES (@Navn, @Email)");

                cmd.Parameters.AddWithValue("@Navn", navn);
                cmd.Parameters.AddWithValue("@Email", email);

                await DBConnection.ExecuteNonQuery(cmd);

                return "Kunden er netop blevet tilføjet";

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        public static async Task<string> DeleteKunde(int KundeNr)
        {
            try
            {
                SqlCommand cmd = new("DELETE from Kunde WHERE KundeNr = @KundeNr ");
                cmd.Parameters.AddWithValue("@KundeNr", KundeNr);

                await DBConnection.ExecuteNonQuery(cmd);

                return "Kunden er netop blevet slettet";

            }

            catch (Exception ex)
            {
                return ex.Message;
            }

        }
        public static async Task<string> UpdateKunde(int KundeNr, string navn, string email)
        {
            try
            {
                SqlCommand cmd = new("UPDATE Kunde set Navn=@Navn, Email=@Email WHERE KundeNr = @KundeNr");
                cmd.Parameters.AddWithValue("@kundeNr", KundeNr);
                cmd.Parameters.AddWithValue("@Navn", navn);
                cmd.Parameters.AddWithValue("@Email", email);

                await DBConnection.ExecuteNonQuery(cmd);

                return "Kunden er netop blevet opdateret";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        #endregion

    }
}
