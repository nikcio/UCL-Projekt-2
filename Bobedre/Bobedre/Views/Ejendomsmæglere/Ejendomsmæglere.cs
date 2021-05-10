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

        private int medarbejderNr { get; set; }
        public Models.Action action { get; set; }
        private Baseform baseform { get; set; }


        public Ejendomsmæglere(Models.Action _action, Baseform _baseform, int _medarbejderNr = -1)
        {
            InitializeComponent();

            baseform = _baseform;
            action = _action;
            medarbejderNr = _medarbejderNr;

        }
        



        /// <summary>
        /// Create an ejendomsmægler to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private async void Opretknap_Click(object sender, EventArgs e)
        {
            if (RegexCheck.TextCheck(Afdelingbox.Text) && RegexCheck.TextCheck(StillingSvar.Text) && RegexCheck.TextCheck(Mæglerfirmabox.Text) && RegexCheck.TextCheck(NavnBox.Text) && RegexCheck.EmailCheck(Emailbox.Text))
            {
                var message = await EntryManagement.CreateEjendomsmægler(Afdelingbox.Text, Mæglerfirmabox.Text, NavnBox.Text, Emailbox.Text, StillingSvar.Text);
                ClearForm.CleanForm(Controls);
                

                MessageBox.Show("Ejendomsmægleren er oprettet");

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
            if (RegexCheck.TextCheck(Afdelingbox.Text) && RegexCheck.TextCheck(StillingSvar.Text) && RegexCheck.TextCheck(Mæglerfirmabox.Text) && RegexCheck.TextCheck(NavnBox.Text) && RegexCheck.EmailCheck(Emailbox.Text))
            {
                if (int.TryParse(MedarbejderNrBox.Text, out int medarbejderNr))
                {
                    var message = await EntryManagement.UpdateEjendomsmægler(medarbejderNr, Afdelingbox.Text, Mæglerfirmabox.Text, NavnBox.Text, Emailbox.Text, StillingSvar.Text);
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

        /// <summary>
        /// Loading data from database
        /// </summary>
        /// <param name="medarbejderNr"></param>
        private async void LoadData(int medarbejderNr)
        {
            if (medarbejderNr < 0)
            {
                throw new ArgumentOutOfRangeException("MedarbejderNr", "MedarbejderNr can not be under 0");
            }

            var ejendomsmægler = await Fetch.GetEjendomsmæglerByMedarbjederNr(medarbejderNr);

            MedarbejderNrBox.Text = ejendomsmægler.MedarbejderNr.ToString();
            Afdelingbox.Text = ejendomsmægler.Afdeling.ToString();
            Mæglerfirmabox.Text = ejendomsmægler.Mæglerfirma.ToString();
            NavnBox.Text = ejendomsmægler.Navn.ToString();
            Emailbox.Text = ejendomsmægler.Email.ToString();
            StillingSvar.Text = ejendomsmægler.Stilling.ToString();

        }

      
        private void Ejendomsmæglere_Load(object sender, EventArgs e)
        {
            switch (action)
            {
                case Models.Action.create:                    
                    break;


                case Models.Action.edit:
                    LoadData(medarbejderNr);
                    break;
                                    

                case Models.Action.view:
                    LoadData(medarbejderNr);
                    Afdelingbox.ReadOnly = true;
                    Mæglerfirmabox.ReadOnly = true;
                    NavnBox.ReadOnly = true;
                    Emailbox.ReadOnly = true;
                    StillingSvar.ReadOnly = true;
                    Opretknap.Visible = false;
                    Gemknap.Visible = false;
                    Sletknap.Visible = false;
                    break;
            }
        }

        private void GåtilbageKnap_Click(object sender, EventArgs e)
        {
            baseform.ShowForm(new EjendomsmæglereView(baseform));
        }


    }
}
