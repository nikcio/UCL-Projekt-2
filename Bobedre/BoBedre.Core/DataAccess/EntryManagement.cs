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
          
        #region Annoncering
        public static async Task<int> CreateAnnoncering(
            string type,
            DateTime startDato,
            DateTime slutDato,
            int sagNr)
        {
            SqlCommand cmd = new("INSERT INTO Annoncering (Type, StartDato, SlutDato, SagNr) " +
                "OUTPUT INSERTED.AnnonceringsNr " +
                "VALUES (@Type, @StartDato, @SlutDato, @SagNr)");

            cmd.Parameters.AddWithValue("@Type", type);
            cmd.Parameters.AddWithValue("@StartDato", startDato);
            cmd.Parameters.AddWithValue("@SlutDato", slutDato);
            cmd.Parameters.AddWithValue("@Sagnr", sagNr);

            return (int)await DBConnection.ExecuteScalar(cmd);
        }
      
        public static async Task UpdateAnnoncering(
            string type,
            DateTime startDato,
            DateTime slutDato,
            int sagNr,
            int annonceringsNr)
        {
            SqlCommand cmd = new("UPDATE Annoncering " +
                "SET Type=@Type, StartDato=@StartDato, SlutDato=@SlutDato, SagNr=@SagNrer" +
                "WHERE AnnonceringsNr=@AnnonceringsNr");

            cmd.Parameters.AddWithValue("@Type",type);
            cmd.Parameters.AddWithValue("@StartDato", startDato);
            cmd.Parameters.AddWithValue("@SlutDato", slutDato);
            cmd.Parameters.AddWithValue("@SagNr", sagNr);
            cmd.Parameters.AddWithValue("@AnnonceringsNr",annonceringsNr);

            await DBConnection.ExecuteNonQuery(cmd);
        }

        public static async Task DeleteAnnoncering(int annonceringsNr)
        {
            SqlCommand cmd = new("DELETE FROM Annoncering WHERE AnnonceringsNr=@AnnonceringsNr");

            cmd.Parameters.AddWithValue("@AnnonceringsNr", annonceringsNr);

            await DBConnection.ExecuteNonQuery(cmd);
        }
        #endregion
          
        #region Kunde
        public static async Task<int> CreateKunde(string navn, string email, string KundeType)
        {
            try
            {
                SqlCommand cmd = new("INSERT into Kunde(Navn, Email, Type) OUTPUT INSERTED.KundeNr VALUES (@Navn, @Email, @Type)");

               cmd.Parameters.AddWithValue("@Navn", navn);
               cmd.Parameters.AddWithValue("@Email", email);
               cmd.Parameters.AddWithValue("@Type", KundeType);

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

        #region Sag
        public static async Task<int> CreateSag(
            DateTime oprettelsesDato,
            int medarbejderNr)
        {
            SqlCommand cmd = new("INSERT INTO Sag (OprettelsesDato, Solgt, MedarbejderNr) " +
                "OUTPUT INSERTED.SagNr " +
                "VALUES (@oprettelsesDato, @solgt, @medarbejderNr)");

            cmd.Parameters.AddWithValue("@oprettelsesDato", oprettelsesDato);
            cmd.Parameters.AddWithValue("@solgt", false);
            cmd.Parameters.AddWithValue("@medarbejderNr", medarbejderNr);

            return (int)await DBConnection.ExecuteScalar(cmd);
        }

        public static async Task UpdateSag(
            int sagNr,
            DateTime oprettelsesDato,
            DateTime? tilSalgDato,
            bool solgt,
            int? gebyr,
            int? salær,
            DateTime? overdragelsesDato,
            DateTime? afslutningsDato,
            int? boligNr,
            int? sælgerNr,
            int? køberNr,
            int medarbejderNr)
        {
            SqlCommand cmd = new("UPDATE Sag " +
                "SET OprettelsesDato=@oprettelsesDato, TilSalgDato=@tilSalgDato, Solgt=@solgt, Gebyr=@gebyr, Salær=@salær, OverdragelsesDato=@overdragelsesDato, AfslutningsDato=@afslutningsDato, BoligNr=@boligNr, SælgerNr=@sælgerNr, KøberNr=@køberNr, MedarbejderNr=@medarbejderNr " +
                "WHERE SagNr=@sagNr");
            
            cmd.Parameters.AddWithValue("@oprettelsesDato", oprettelsesDato);
            cmd.Parameters.AddWithValue("@tilSalgDato", tilSalgDato != null ? tilSalgDato : DBNull.Value);
            cmd.Parameters.AddWithValue("@solgt", solgt);
            cmd.Parameters.AddWithValue("@gebyr", gebyr != null ? gebyr : DBNull.Value);
            cmd.Parameters.AddWithValue("@salær", salær != null ? salær : DBNull.Value);
            cmd.Parameters.AddWithValue("@overdragelsesDato", overdragelsesDato != null ? overdragelsesDato : DBNull.Value);
            cmd.Parameters.AddWithValue("@afslutningsDato", afslutningsDato != null ? afslutningsDato : DBNull.Value);
            cmd.Parameters.AddWithValue("@boligNr", boligNr != null ? boligNr : DBNull.Value);
            cmd.Parameters.AddWithValue("@sælgerNr", sælgerNr != null ? sælgerNr : DBNull.Value);
            cmd.Parameters.AddWithValue("@køberNr", køberNr != null ? køberNr : DBNull.Value);
            cmd.Parameters.AddWithValue("@medarbejderNr", medarbejderNr);
            cmd.Parameters.AddWithValue("@sagNr", sagNr);

            await DBConnection.ExecuteNonQuery(cmd);
        }

        public static async Task DeleteSag(int sagNr)
        {
            SqlCommand cmd = new("DELETE FROM Sag WHERE SagNr=@sagNr");

            cmd.Parameters.AddWithValue("@sagNr", sagNr);

            await DBConnection.ExecuteNonQuery(cmd);
        }
        #endregion
    }
}
