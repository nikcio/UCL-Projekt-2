using BoBedre.Core.AssetLoaders;
using BoBedre.Infrastructure;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace BoBedre.Core.DataAccess
{
    public static class EntryManagement
    {

        #region Ejendomsmægler
        public static async Task<string> UpdateEjendomsmægler(int medarbejderNr, string afdeling, string mæglerfirma, string navn, string email, string stilling)
        {
            try
            {
                SqlCommand cmd = new("UPDATE Ejendomsmægler set Afdeling=@Afdeling, Mæglerfirma=@Mæglerfirma, Navn=@Navn, Email=@Email, Stilling=@Stilling WHERE MedarbejderNr = @MedarbejderNr");
                cmd.Parameters.AddWithValue("@MedarbejderNr", medarbejderNr);
                cmd.Parameters.AddWithValue("@Afdeling", afdeling);
                cmd.Parameters.AddWithValue("@Mæglerfirma", mæglerfirma);
                cmd.Parameters.AddWithValue("@Navn", navn);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Stilling", stilling);

                await DBConnection.ExecuteNonQuery(cmd);

                return "Ejendomsmægleren er netop blevet opdateret";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


        public static async Task<string> DeleteEjendomsmægler(int medarbejderNr)
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


        public static async Task<int> CreateEjendomsmægler(string afdeling, string mæglerfirma, string navn, string email, string stilling)
        {
            try
            {
                SqlCommand cmd = new("INSERT into Ejendomsmægler(Afdeling, Mæglerfirma, Navn, Email, Stilling) OUTPUT INSERTED.MedarbejderNr VALUES (@Afdeling, @Mæglerfirma, @Navn, @Email, @Stilling)");

                cmd.Parameters.AddWithValue("@Afdeling", afdeling);
                cmd.Parameters.AddWithValue("@Mæglerfirma", mæglerfirma);
                cmd.Parameters.AddWithValue("@Navn", navn);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Stilling", stilling);

                int medarbejderNr = (int)await DBConnection.ExecuteScalar(cmd);

                return medarbejderNr;

            }
            catch
            {

                return -1;
            }
        }
        #endregion

        #region Ejendomme
        public static async Task<int> CreateEjendom(
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

            return (int)await DBConnection.ExecuteScalar(cmd);
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
        public static async Task<string> DeleteEjendom(int Bolignr)
        {
            try
            {
                SqlCommand cmd = new("DELETE from Ejendom WHERE Bolignr = @Bolignr ");
                cmd.Parameters.AddWithValue("@Bolignr", Bolignr);

                await DBConnection.ExecuteNonQuery(cmd);

                return "Boligen er nu slettet";

            }

            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public static async Task OpdaterEjendom(
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
            int bolignr
            
            )
        {
            try
            {
                SqlCommand cmd = new("UPDATE Ejendom set Adresse=@Adresse, Pris=@Pris, Boligareal=@Boligareal, Grundareal=@Grundareal," +
                    "Have=@Have, Værelser=@Værelser, Etager=@Etager, Type=@Type, Byggeår=@Byggeår, Postnr=@Postnr WHERE Bolignr = @Bolignr");

                cmd.Parameters.AddWithValue("@Adresse", adresse);
                cmd.Parameters.AddWithValue("@Pris", pris);
                cmd.Parameters.AddWithValue("@Boligareal", boligAreal);
                cmd.Parameters.AddWithValue("@Grundareal", grundAreal);
                cmd.Parameters.AddWithValue("@Have", have);
                cmd.Parameters.AddWithValue("@Værelser", værelser);
                cmd.Parameters.AddWithValue("@Etager", etager);
                cmd.Parameters.AddWithValue("@Type", typeBolig);
                cmd.Parameters.AddWithValue("@Byggeår", byggeår);
                cmd.Parameters.AddWithValue("@Postnr", postNr);
                cmd.Parameters.AddWithValue("Bolignr", bolignr);

                if (await Fetch.GetByByPostNr(postNr) == null)
                {
                    string cityName = await CityLoader.FindCityName(postNr.ToString());
                    await CreateBy(postNr, cityName);
                }

                await DBConnection.ExecuteNonQuery(cmd);



               
            }
            catch (Exception ex)
            {

            }

        }

        #endregion

        #region Renorvering
        public static async Task<int> CreateRenorvering(
            bool køkken,
            bool badeværelse,
            bool andet,
            int ombygningsÅr,
            string detaljer,
            int boligNr)
        {
            SqlCommand cmd = new("INSERT INTO Renorvering (Køkken, Badeværelse, Andet, OmbygningsÅr, Detaljer, BoligNr) " +
                "OUTPUT INSERTED.RenorveringsId " +
                "VALUES (@køkken, @badeværelse, @andet, @ombygningsÅr, @detaljer, @boligNr)");

            cmd.Parameters.AddWithValue("@køkken", køkken);
            cmd.Parameters.AddWithValue("@badeværelse", badeværelse);
            cmd.Parameters.AddWithValue("@andet", andet);
            cmd.Parameters.AddWithValue("@ombygningsÅr", ombygningsÅr);
            cmd.Parameters.AddWithValue("@detaljer", detaljer);
            cmd.Parameters.AddWithValue("@boligNr", boligNr);

            return (int)await DBConnection.ExecuteScalar(cmd);
        }

        public static async Task UpdateRenorvering(
            bool køkken,
            bool badeværelse,
            bool andet,
            int ombygningsÅr,
            string detaljer,
            int renorveringId)
        {
            SqlCommand cmd = new("UPDATE Renorvering " +
                "SET Køkken=@køkken, Badeværelse=@badeværelse, Andet=@andet, OmbygningsÅr=@ombygningsÅr, Detaljer=@detaljer " +
                "WHERE RenorveringsId=@renorveringsId");

            cmd.Parameters.AddWithValue("@køkken", køkken);
            cmd.Parameters.AddWithValue("@badeværelse", badeværelse);
            cmd.Parameters.AddWithValue("@andet", andet);
            cmd.Parameters.AddWithValue("@ombygningsÅr", ombygningsÅr);
            cmd.Parameters.AddWithValue("@detaljer", detaljer);
            cmd.Parameters.AddWithValue("@renorveringsId", renorveringId);

            await DBConnection.ExecuteNonQuery(cmd);
        }

        public static async Task DeleteRenorvering(int renorveringsId)
        {
            SqlCommand cmd = new("DELETE FROM Renorvering WHERE RenorveringsId=@renorveringsId");

            cmd.Parameters.AddWithValue("@renorveringsId", renorveringsId);

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
        public static async Task CreateBy(int zipcode, string cityName)
        {
            SqlCommand cmd = new("INSERT into [By] VALUES (@zipcode, @cityName)");

            cmd.Parameters.AddWithValue("@zipcode", zipcode);
            cmd.Parameters.AddWithValue("@cityname", cityName);

            await DBConnection.ExecuteNonQuery(cmd);
        }

        /// <summary>
        /// Updates a By
        /// </summary>
        /// <param name="zipcode"></param>
        /// <param name="cityName"></param>
        /// <returns></returns>
        public static async Task UpdateBy(int zipcode, string cityName, int zipcodeNewValue)
        {
            SqlCommand cmd = new("UPDATE [By] SET PostNr=@zipcodeNewValue, ByNavn=@cityName WHERE PostNr=@zipcode");

            cmd.Parameters.AddWithValue("@zipcode", zipcode);
            cmd.Parameters.AddWithValue("@zipcodeNewValue", zipcodeNewValue);
            cmd.Parameters.AddWithValue("@cityname", cityName);

            await DBConnection.ExecuteNonQuery(cmd);
        }

        /// <summary>
        /// Deletes a By
        /// </summary>
        /// <param name="zipcode"></param>
        /// <returns></returns>
        public static async Task DeleteBy(int zipcode)
        {
            SqlCommand cmd = new("DELETE FROM [By] WHERE PostNr=@zipcode");

            cmd.Parameters.AddWithValue("@zipcode", zipcode);

            await DBConnection.ExecuteNonQuery(cmd);
        }
        #endregion


        #region Kunde
        public static async Task<int> CreateKunde(string navn, string email, string KundeType)
        {
            try
            {
                SqlCommand cmd = new("INSERT into Kunde(Navn, Email, Type) VALUES (@Navn, @Email, @Type)");

                cmd.Parameters.AddWithValue("@Navn", navn);
                cmd.Parameters.AddWithValue("@Email", email);
               cmd.Parameters.AddWithValue("@Type", KundeType );

                return (int)await DBConnection.ExecuteScalar(cmd);

            }
            catch (Exception ex)
            {
                return -1;
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
        public static async Task<string> UpdateKunde(int KundeNr, string navn, string email, string KundeType)
        {
            try
            {
                SqlCommand cmd = new("UPDATE Kunde set Navn=@Navn, Email=@Email, Type=@Type WHERE KundeNr = @KundeNr");
                cmd.Parameters.AddWithValue("@kundeNr", KundeNr);
                cmd.Parameters.AddWithValue("@Navn", navn);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Type", KundeType);


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
