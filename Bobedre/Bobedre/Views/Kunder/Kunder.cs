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

        private int kundeNr { get; set; }
        public Models.Action action { get; set; }
        private Baseform baseform { get; set; }

        public Kunder(Models.Action _action, Baseform _baseform, int _kundeNr = -1)
        {
            InitializeComponent();

            baseform = _baseform;
            action = _action;
            kundeNr = _kundeNr;

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

        /// <summary>
        /// Loading data from database
        /// </summary>
        /// <param name="kundeNr"></param>
        private async void LoadData(int kundeNr)
        {
            if (kundeNr < 0)
            {
                throw new ArgumentOutOfRangeException("KundeNr", "KundeNr can not be under 0");
            }

            var kunde = await Fetch.GetKundeByKundeNr(kundeNr);

            KundeNrBox.Text = kunde.KundeNr.ToString();
            KundeNavnBox.Text = kunde.Navn.ToString();
            KundeEmailBox.Text = kunde.Email.ToString();
            KundeTypeComboBox.Text = kunde.Type.ToString();
        }


        private void KundeTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void KundeNrBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void GåtilbageKnap_Click(object sender, EventArgs e)
        {
            baseform.ShowForm(new KunderView(baseform));
        }

        private void Kunder_Load(object sender, EventArgs e)
        {
        switch (action)
        {
            case Models.Action.create:
                KundeNrBox.ReadOnly = true;
                KundeGemKnap.Visible = false;
                KundeSletKnap.Visible = false;
                break;

            case Models.Action.edit:
                LoadData(kundeNr);
                KundeNrBox.ReadOnly = true;
                KundeOpretKnap.Visible = false;
                break;

            case Models.Action.delete:
                LoadData(kundeNr);
                KundeNavnBox.ReadOnly = true;
                KundeEmailBox.ReadOnly = true;
                break;

            case Models.Action.view:
                LoadData(kundeNr);
                KundeNrBox.ReadOnly = true;
                KundeNavnBox.ReadOnly = true;
                KundeEmailBox.ReadOnly = true;
                KundeTypeComboBox.Enabled = false;
                KundeOpretKnap.Visible = false;
                KundeGemKnap.Visible = false;
                KundeSletKnap.Visible = false;
                break;
        }
        }
    }
}
