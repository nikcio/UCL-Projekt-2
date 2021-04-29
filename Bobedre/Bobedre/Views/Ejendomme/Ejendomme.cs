using Bobedre.Utility;
using BoBedre.Core.DataAccess;
using BoBedre.Core.TextChecking;
using BoBedre.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bobedre.Views.Ejendomme
{
    public partial class Ejendomme : Form
    {
        public Ejendomme(Models.Action action, Baseform baseform)
        {
            InitializeComponent();
        }

        private async void OpretBoligKnap_Click(object sender, EventArgs e)
        {
            if ((RegexCheck.TextCheck(AdresseBolig.Text) && RegexCheck.TalCheck(PrisTextBox.Text) && RegexCheck.TalCheck(BoligArealTextBox.Text) && RegexCheck.TalCheck(GrundArealBoligTextBox.Text) && (HaveCheckBox.Checked)
             && RegexCheck.TalCheck(VæreslerBoligTextBox.Text) && RegexCheck.TextCheck(TypeBoligTextBox.Text) && RegexCheck.TalCheck(ByggeårBoligTextBox.Text)))
            {
                if (RenoveretBoligCheckBox.Checked &&
                    (RegexCheck.TalCheck(OmbygningsårTextbox.Text) && RegexCheck.TextCheck(DetalijerTextbox.Text) && RegexCheck.TalCheck(RenoveringsIdLabel.Text)))
                {
                    await EntryManagement.CreateEjendom(
                        AdresseBolig.Text, 
                        int.Parse(PrisTextBox.Text), 
                        int.Parse(BoligArealTextBox.Text), 
                        int.Parse(GrundArealBoligTextBox.Text), 
                        HaveCheckBox.Checked, 
                        int.Parse(VæreslerBoligTextBox.Text), 
                        int.Parse(EtagerBoligTextbox.Text), 
                        TypeBoligTextBox.Text, 
                        int.Parse(ByggeårBoligTextBox.Text), 
                        int.Parse(PostNrTextBox.Text),
                        RenoveretBoligCheckBox.Checked, 
                        KøkkenCheckbox.Checked, 
                        Badeværelsecheckbox.Checked, 
                        Andetcheckbox.Checked, 
                        int.Parse(OmbygningsårTextbox.Text), 
                        DetalijerTextbox.Text);
                    MessageBox.Show("Boligen er nu gemt");
                }
                else
                {
                    await EntryManagement.CreateEjendom(
                        AdresseBolig.Text,
                        int.Parse(PrisTextBox.Text),
                        int.Parse(BoligArealTextBox.Text),
                        int.Parse(GrundArealBoligTextBox.Text),
                        HaveCheckBox.Checked,
                        int.Parse(VæreslerBoligTextBox.Text),
                        int.Parse(EtagerBoligTextbox.Text),
                        TypeBoligTextBox.Text,
                        int.Parse(ByggeårBoligTextBox.Text),
                        int.Parse(PostNrTextBox.Text)); 
                }
                MessageBox.Show("Boligen er nu gemt2");
            }
            else
            {
                MessageBox.Show("Boligen er ikke blevet gemt, forkert indtastning");
            }
        }

        private async void SletButtonBolig_Click(object sender, EventArgs e)
        {
            if (int.TryParse(BolignrLabel.Text, out int Bolignr))
            {
                var message = await EntryManagement.SletBolig(Bolignr);

                ClearForm.CleanForm(Controls);
                MessageBox.Show(message);

            }
            else
            {
                
                MessageBox.Show("fejl skal være et Nr");
            }





        }

        private async void OpdaterBoligKnap_Click(object sender, EventArgs e)
        {

           


            if (RegexCheck.TalCheck(BolignrLabel.Text) && RegexCheck.TextCheck(AdresseBolig.Text) && RegexCheck.TalCheck(PrisTextBox.Text) && RegexCheck.TalCheck(BoligArealTextBox.Text) && RegexCheck.TalCheck(GrundArealBoligTextBox.Text) && (HaveCheckBox.Checked)
             && RegexCheck.TalCheck(VæreslerBoligTextBox.Text) && RegexCheck.TextCheck(TypeBoligTextBox.Text) && RegexCheck.TalCheck(ByggeårBoligTextBox.Text))
            {
                await EntryManagement.OpdaterEjendom(
                AdresseBolig.Text,
                int.Parse(PrisTextBox.Text),
                int.Parse(BoligArealTextBox.Text),
                int.Parse(GrundArealBoligTextBox.Text),
                HaveCheckBox.Checked,
                int.Parse(VæreslerBoligTextBox.Text),
                int.Parse(EtagerBoligTextbox.Text),
                TypeBoligTextBox.Text,
                int.Parse(ByggeårBoligTextBox.Text),
                int.Parse(PostNrTextBox.Text),
                int.Parse(BolignrLabel.Text));
                


                MessageBox.Show("Boligens oplysninger er nu opdateret");
            }
            else
            {
                MessageBox.Show("Boligens oplysninger blev ikke opdateret pgf. forkerte oplysninger");
            }



        }

        private void RenoveretBoligCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            KøkkenCheckbox.Enabled = RenoveretBoligCheckBox.Checked;
            Badeværelsecheckbox.Enabled = RenoveretBoligCheckBox.Checked;
            Andetcheckbox.Enabled = RenoveretBoligCheckBox.Checked;
            OmbygningsårTextbox.Enabled = RenoveretBoligCheckBox.Checked;
            DetalijerTextbox.Enabled = RenoveretBoligCheckBox.Checked;
            RenoveringsIdLabel.Enabled = RenoveretBoligCheckBox.Checked;
        }

        private void BoligAndet_Click(object sender, EventArgs e)
        {

        }






    }

}
