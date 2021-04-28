using BoBedre.Infrastructure;
using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Bobedre.Views.Ejendomsmæglere
{
    public partial class Ejendomsmæglere : Form
    {
        public Ejendomsmæglere(Models.Action action, Baseform baseform)
        {
            InitializeComponent();
        }


        /// <summary>
        /// Clears all textboxes in the specific form window
        /// </summary>
        private void CleanForm()
        {
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
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

            try
            {
                SqlCommand cmd = new SqlCommand("INSERT into Ejendomsmægler(Afdeling, Mæglerfirma, Navn, Email) VALUES (@Afdeling, @Mæglerfirma, @Navn, @Email)");

                cmd.Parameters.AddWithValue("@Afdeling", Afdelingbox.Text);
                cmd.Parameters.AddWithValue("@Mæglerfirma", Mæglerfirmabox.Text);
                cmd.Parameters.AddWithValue("@Navn", NavnBox.Text);
                cmd.Parameters.AddWithValue("@Email", Emailbox.Text);

                if (Regex.IsMatch((Afdelingbox.Text) + (Mæglerfirmabox.Text) + (NavnBox.Text), @"^[a-å A-Å]+$"))
                {
                    await DBConnection.ExecuteNonQuery(cmd);
                    int.TryParse(MedarbejderNrBox.Text, out int x);
                    MessageBox.Show("Ejendomsmægleren er netop tilføjet");

                }
                else
                {
                    MessageBox.Show("Ejendomsmægler er ikke oprettet pga. brug af forkerte tegn");

                }
                CleanForm();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
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
            try
            {
                SqlCommand cmd = new SqlCommand("Delete from Ejendomsmægler WHERE MedarbejderNr = @MedarbejderNr ");

                cmd.Parameters.AddWithValue("@MedarbejderNr", int.Parse(MedarbejderNrBox.Text));

                MessageBox.Show("Ejendomsmægleren er nu slettet");
                await DBConnection.ExecuteNonQuery(cmd);

                CleanForm();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
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
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE Ejendomsmægler set Afdeling=@Afdeling, Mæglerfirma= @Mæglerfirma, Navn=@Navn, Email=@Email WHERE MedarbejderId = @MedarbejderId");
                cmd.Parameters.AddWithValue("@MedarbejderId", int.Parse(MedarbejderNrBox.Text));
                cmd.Parameters.AddWithValue("@Afdeling", Afdelingbox.Text);
                cmd.Parameters.AddWithValue("@Mæglerfirma", Mæglerfirmabox.Text);
                cmd.Parameters.AddWithValue("@Navn", NavnBox.Text);
                cmd.Parameters.AddWithValue("@Email", Emailbox.Text);

                if (Regex.IsMatch((Afdelingbox.Text) + (Mæglerfirmabox.Text) + (NavnBox.Text), @"^[a-å A-Å]+$"))
                {
                    await DBConnection.ExecuteNonQuery(cmd);
                    MessageBox.Show("Ejendomsmægleren er netop blevet opdateret");

                }
                else
                {
                    MessageBox.Show("Ejendomsmægler er ikke blevet opdateret pga. brug af forkerte tegn");

                }
                CleanForm();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
    }
}
