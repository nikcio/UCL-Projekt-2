using Bobedre.Utility;
using BoBedre.Core.DataAccess;
using BoBedre.Core.TextChecking;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Bobedre.Views.Kunder
{
    public partial class Kunder : Form
    {
       
        public Kunder(Models.Action action, Baseform baseform)
        {
            InitializeComponent();
        }

        /// <summary>
        /// Create an Kunde to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void KundeOpretKnap_Click(object sender, EventArgs e)
        {
            
            if ((RegexCheck.TextCheck(KundeNavnBox.Text)) && RegexCheck.EmailCheck(KundeEmailBox.Text) && KundeTypeComboBox.SelectedItem != null)
            {
                var KundeType = KundeTypeComboBox.SelectedItem.ToString();
                await EntryManagement.CreateKunde(KundeNavnBox.Text, KundeEmailBox.Text, KundeType);
                ClearForm.CleanForm(Controls);

                MessageBox.Show("Kunden er netop blevet tilføjet");
            }
            else
            {
                MessageBox.Show("Kunden er ikke blevet oprettet pga. brug af forkerte tegn eller tomme felter.");
            }
        }

        /// <summary>
        /// Deletes a specefic Kunde from the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void KundeSletKnap_Click(object sender, EventArgs e)
        {
            if (int.TryParse(KundeNrBox.Text, out int KundeNr))
            {
                var message = await EntryManagement.DeleteKunde(KundeNr);
                ClearForm.CleanForm(Controls);

                MessageBox.Show(message);
            }
            else
            {
                KundeNrBox.ResetText();
                MessageBox.Show("KundeNr skal være et tal");
            }

        }

        /// <summary>
        /// Updates a specefic Kunde from the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void KundeGemKnap_Click(object sender, EventArgs e)
        {
            var KundeType = KundeTypeComboBox.SelectedItem.ToString();
            if ((RegexCheck.TextCheck(KundeNavnBox.Text)) && RegexCheck.EmailCheck(KundeEmailBox.Text))
            {
                if (int.TryParse(KundeNrBox.Text, out int KundeNr))
                {
                    var message = await EntryManagement.UpdateKunde(KundeNr, KundeNavnBox.Text, KundeEmailBox.Text, KundeType);
                    ClearForm.CleanForm(Controls);

                    MessageBox.Show(message);
                }
                else
                {
                    KundeNrBox.ResetText();
                    MessageBox.Show("KundeNr skal være et tal");

                }
            }
            else
            {
                MessageBox.Show("Kunden er ikke blevet opdateret pga. brug af forkerte tegn og alle felter skal udfyldes");
            }
        }

        private void KundeTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void KundeNrBox_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
