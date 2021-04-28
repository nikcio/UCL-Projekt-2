using BoBedre.Core.DataAccess;
using System;
using System.Text.RegularExpressions;
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
        /// Create an ejendomsmægler to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private async void Opretknap_Click(object sender, EventArgs e)
        {
            if (TextCheck(Afdelingbox.Text) && TextCheck(Mæglerfirmabox.Text) && TextCheck(NavnBox.Text) && EmailCheck(Emailbox.Text))
            {
                var message = await NonQuery.Createejendomsmægler(Afdelingbox.Text, Mæglerfirmabox.Text, NavnBox.Text, Emailbox.Text);
                ClearForm.CleanForm(Controls);
                

                MessageBox.Show(message);

            }
            else
            {
                MessageBox.Show("Ejendomsmægler er ikke blevet oprettet pga. brug af forkerte tegn og alle felter skal udfyldes");
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

            if (int.TryParse(MedarbejderNrBox.Text, out int medarbejderNr))
            {
                var message = await NonQuery.DeleteEjendomsmægler(medarbejderNr);

                ClearForm.CleanForm(Controls);
                MessageBox.Show(message);

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
                    ClearForm.CleanForm(Controls);
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
