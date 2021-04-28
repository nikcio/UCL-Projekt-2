using BoBedre.Core.DataAccess;
using BoBedre.Infrastructure;
using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bobedre.Views.Ejendomsmæglere
{
    public partial class Ejendomsmæglere : Form
    {
        private readonly string BasicTextRegex = @"^[a-z A-ZåæøÅÆØ]+$";
        private readonly string EmailRegex = "^(?(\")(\".+?(?<!\\)\"@)|(([0 - 9a - z]((\\.(?!\\.))|[-!#\\$%&'\\*\\+/=\\?\\^`\\{\\}\\|~\\w])*)(?<=[0-9a-z])@))(?(\\[)(\\[(\\d{1,3}\\.){3}\\d{1,3}\\])|(([0-9a-z][-\\w]*[0-9a-z]*\\.)+[a-z0-9][\\-a-z0-9]{0,22}[a-z0-9]))$"; // Taken from: https://emailregex.com/

        public Ejendomsmæglere(Models.Action action, Baseform baseform)
        {
            InitializeComponent();
        }


        /// <summary>
        /// Clears all textboxes in the specific form window
        /// </summary>
        private void CleanForm()
        {
            foreach (var control in Controls)
            {
                if (control is TextBox box)
                {
                    box.Text = String.Empty;
                }
            }

        }

        /// <summary>
        /// Create an ejendomsmægler to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private async void Opretknap_Click(object sender, EventArgs e)
        {
            if (TextCheck(Afdelingbox.Text) && TextCheck(Mæglerfirmabox.Text) && TextCheck(NavnBox.Text) && EmailCheck(Emailbox.Text))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("INSERT into Ejendomsmægler(Afdeling, Mæglerfirma, Navn, Email) VALUES (@Afdeling, @Mæglerfirma, @Navn, @Email)");

                    cmd.Parameters.AddWithValue("@Afdeling", Afdelingbox.Text);
                    cmd.Parameters.AddWithValue("@Mæglerfirma", Mæglerfirmabox.Text);
                    cmd.Parameters.AddWithValue("@Navn", NavnBox.Text);
                    cmd.Parameters.AddWithValue("@Email", Emailbox.Text);

                    await DBConnection.ExecuteNonQuery(cmd);
                    MessageBox.Show("Ejendomsmægleren er netop tilføjet");

                    CleanForm();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Ejendomsmægler er ikke oprettet pga. brug af forkerte tegn");

            }
        }


        /// <summary>
        /// Deletes a specific ejendomsmægler from the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private async void Sletknap_Click(object sender, EventArgs e)
        {
            if(int.TryParse(MedarbejderNrBox.Text, out int medarbejderNr))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("DELETE from Ejendomsmægler WHERE MedarbejderNr = @MedarbejderNr ");

                    cmd.Parameters.AddWithValue("@MedarbejderNr", medarbejderNr);

                    MessageBox.Show("Ejendomsmægleren er nu slettet");
                    await DBConnection.ExecuteNonQuery(cmd);

                    CleanForm();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MedarbejderNrBox.ResetText();
                MessageBox.Show("MedarbejderNr skal være et nummer");
            }
        }

        /// <summary>
        /// Updates a specific ejendomsmægler from the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private async void Gemknap_Click(object sender, EventArgs e)
        {
            if (TextCheck(Afdelingbox.Text) && TextCheck(Mæglerfirmabox.Text) && TextCheck(NavnBox.Text) && EmailCheck(Emailbox.Text))
            {
                if (int.TryParse(MedarbejderNrBox.Text, out int medarbejderNr))
                {
                    var message = await NonQuery.UpdateEjendomsmægler(medarbejderNr, Afdelingbox.Text, Mæglerfirmabox.Text, NavnBox.Text, Emailbox.Text);
                    CleanForm();
                    MessageBox.Show(message);
                }
                else
                {
                    MedarbejderNrBox.ResetText();
                    MessageBox.Show("MedarbejderNr skal være et nummer");
                }
            }
            else
            {
                MessageBox.Show("Ejendomsmægler er ikke blevet opdateret pga. brug af forkerte tegn og alle felter skal udfyldes");
            }

        }

        private bool TextCheck(string textToCheck)
        {
            return Regex.IsMatch(textToCheck, BasicTextRegex);
        }

        private bool EmailCheck(string textToCheck)
        {
            return Regex.IsMatch(textToCheck, EmailRegex);
        }
    }
}
