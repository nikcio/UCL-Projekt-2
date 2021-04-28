using BoBedre.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBedre.Core.DataAccess
{
    public static class NonQuery
    {
        
        #region Ejendomsmægler
        public static async Task<string> UpdateEjendomsmægler(int medarbejderNr, string afdeling, string mæglerfirma, string navn, string email)
        {
            try
            {
                SqlCommand cmd = new("UPDATE Ejendomsmægler set Afdeling=@Afdeling, Mæglerfirma=@Mæglerfirma, Navn=@Navn, Email=@Email WHERE MedarbejderId = @MedarbejderId");
                cmd.Parameters.AddWithValue("@MedarbejderId", medarbejderNr);
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
