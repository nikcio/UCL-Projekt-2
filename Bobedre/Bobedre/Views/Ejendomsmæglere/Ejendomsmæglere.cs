using Bobedre.Utility;
using BoBedre.Core.DataAccess;
using BoBedre.Core.TextChecking;
using System;
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
        /// Create an ejendomsmægler to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private async void Opretknap_Click(object sender, EventArgs e)
        {
            if (RegexCheck.TextCheck(Afdelingbox.Text) && RegexCheck.TextCheck(Mæglerfirmabox.Text) && RegexCheck.TextCheck(NavnBox.Text) && RegexCheck.EmailCheck(Emailbox.Text))
            {
                var message = await EntryManagement.CreateEjendomsmægler(Afdelingbox.Text, Mæglerfirmabox.Text, NavnBox.Text, Emailbox.Text);
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
                var message = await EntryManagement.DeleteEjendomsmægler(medarbejderNr);

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
            if (RegexCheck.TextCheck(Afdelingbox.Text) && RegexCheck.TextCheck(Mæglerfirmabox.Text) && RegexCheck.TextCheck(NavnBox.Text) && RegexCheck.EmailCheck(Emailbox.Text))
            {
                if (int.TryParse(MedarbejderNrBox.Text, out int medarbejderNr))
                {
                    var message = await EntryManagement.UpdateEjendomsmægler(medarbejderNr, Afdelingbox.Text, Mæglerfirmabox.Text, NavnBox.Text, Emailbox.Text);
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

    }
}
