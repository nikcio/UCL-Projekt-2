using Bobedre.Utility;
using BoBedre.Core.DataAccess;
using BoBedre.Core.TextChecking;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bobedre.Views.Annoncering
{
    public partial class Annoncering : Form
    {
        private Baseform baseform { get; set; }
        private Form prevForm { get; set; }
       
        public Models.Action action { get; set; }
        private int annonceringsNr { get; set; }
        public Annoncering(Models.Action _action, Baseform _baseform, int _annonceringsNr = -1)
        {
            InitializeComponent();

            baseform = _baseform;                     
            action = _action;
            annonceringsNr = _annonceringsNr;
        }
        /// <summary>
        /// Loading data into textboxes from database
        /// </summary>
        /// <param name="nr"></param>
        private async void LoadData(int annonceringsNr)
        {
            if (annonceringsNr < 0)
            {
                throw new ArgumentOutOfRangeException("annonceringsNr", "AnnonceringsNr can not be under 0");
            }

            var annoncering = await Fetch.GetAnnonceringByAnnonceringsNr(annonceringsNr);

            AnnonceringsNrBox.Text = annoncering.AnnonceringsNr.ToString();
            TypeBox.Text = annoncering.Type.ToString();
            StartDatoPicker.Value = annoncering.StartDato;
            StartDatoPicker.Value = annoncering.SlutDato;
            SagsNrCombobox.Text = annoncering.SagNr.ToString();

        }
             
     
        private async void Annoncering_Load(object sender, EventArgs e)
        {
            var sager = await Fetch.GetSagAll();

            Dictionary<string, int> dictonary = sager.ToDictionary(item => "SagNr: " + item.SagNr, item => item.SagNr);

            SagsNrCombobox.DataSource = dictonary.ToList();
            SagsNrCombobox.ValueMember = "Key";
            SagsNrCombobox.SelectedText = "Value";
            SagsNrCombobox.SelectedIndex = 0;


            switch (action)
            {
                case Models.Action.create:
                    break;

                case Models.Action.edit:
                    LoadData(annonceringsNr);
                    break;

                case Models.Action.view:
                    LoadData(annonceringsNr);
                    TypeBox.ReadOnly = true;              
                    SagsNrCombobox.Visible = false;
                    StartDatoPicker.Enabled = false;
                    SlutDatoPicker.Enabled = false;
                    Opretknap.Visible = false;
                    Gemknap.Visible = false;
                    Sletknap.Visible = false;
                    break;
            }
        }
        private async void Opretknap_Click(object sender, EventArgs e)
        {
            if (RegexCheck.TextCheck(TypeBox.Text) && SagsNrCombobox != null)
            {
                var sagsNr = ((KeyValuePair<string, int>)SagsNrCombobox.SelectedItem).Value;

                var message = await EntryManagement.CreateAnnoncering(TypeBox.Text, StartDatoPicker.Value, SlutDatoPicker.Value, sagsNr);
                ClearForm.CleanForm(Controls);


                MessageBox.Show("Annonceringen er oprettet");

            }
            else
            {
                MessageBox.Show("Annonceringen er ikke blevet oprettet pga. brug af forkerte tegn og alle felter skal udfyldes");
            }

        }

        private async void Gemknap_Click(object sender, EventArgs e)
        {
            if (RegexCheck.TextCheck(TypeBox.Text))
            {
                if (int.TryParse(AnnonceringsNrBox.Text, out int annonceringsNr))
                {
                    var sagsNr = ((KeyValuePair<string, int>)SagsNrCombobox.SelectedItem).Value;
                    await EntryManagement.UpdateAnnoncering(annonceringsNr,TypeBox.Text, StartDatoPicker.Value, SlutDatoPicker.Value, sagsNr);
                    ClearForm.CleanForm(Controls);
                    MessageBox.Show("Annonceringen er gemt");
                }
                else
                {
                    AnnonceringsNrBox.ResetText();
                    MessageBox.Show("AnnonceringsNr skal være et nummer");
                }
            }
            else
            {
                MessageBox.Show("Annonceringen er ikke blevet opdateret pga. brug af forkerte tegn og alle felter skal udfyldes");
            }
        }

        private async void Sletknap_Click(object sender, EventArgs e)
        {
            if (int.TryParse(AnnonceringsNrBox.Text, out int annonceringsNr))
            {
                await EntryManagement.DeleteAnnoncering(annonceringsNr);

                ClearForm.CleanForm(Controls);
                MessageBox.Show("Annonceringen er blevet slettet");

            }
            else
            {
                AnnonceringsNrBox.ResetText();
                MessageBox.Show("AnnonceringsNr skal være et nummer");
            }
        }

        private void GåtilbageKnap_Click(object sender, EventArgs e)
        {
            baseform.ShowForm(new AnnonceringView(baseform));
        }
    }
}
