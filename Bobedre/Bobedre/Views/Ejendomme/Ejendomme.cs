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
            if ((RegexCheck.TextCheck(AdresseBolig.Text) && RegexCheck.TalCheck(PrisTextBox.Text) && RegexCheck.TalCheck(BoligArealTextBox.Text) && RegexCheck.TalCheck(GrundArealBoligTextBox.Text) && RegexCheck.TextCheck(HaveBoligTextBox.Text)
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
                        true, 
                        int.Parse(VæreslerBoligTextBox.Text), 
                        int.Parse(EtagerBoligTextbox.Text), 
                        TypeBoligTextBox.Text, 
                        int.Parse(ByggeårBoligTextBox.Text), 
                        7100,
                        RenoveretBoligCheckBox.Checked, 
                        KøkkenCheckbox.Checked, 
                        Badeværelsecheckbox.Checked, 
                        Andetcheckbox.Checked, 
                        int.Parse(OmbygningsårTextbox.Text), 
                        DetalijerTextbox.Text);
                    MessageBox.Show("Boligen er nu gemt1111");
                }
                else
                {
                    await EntryManagement.CreateEjendom(
                        AdresseBolig.Text,
                        int.Parse(PrisTextBox.Text),
                        int.Parse(BoligArealTextBox.Text),
                        int.Parse(GrundArealBoligTextBox.Text),
                        true,
                        int.Parse(VæreslerBoligTextBox.Text),
                        int.Parse(EtagerBoligTextbox.Text),
                        TypeBoligTextBox.Text,
                        int.Parse(ByggeårBoligTextBox.Text),
                        7100);
                }
                MessageBox.Show("Boligen er nu gemt2");
            }
            else
            {
                MessageBox.Show("Boligen er ikke blevet gemt, forkert indtastning");
            }
        }

        private void SletButtonBolig_Click(object sender, EventArgs e)
        {
            string sSQL = "DELETE FROM Ejendome where Bolignr =@Bolignr";

            SqlCommand cmd = new SqlCommand(sSQL);
            cmd.Parameters.AddWithValue("@Bolingnr", int.Parse(BolignrLabel.Text));

            MessageBox.Show("Boligen er nu slettet");
            BolignrLabel.ResetText();

            cmd.ExecuteNonQuery();


        }

        private void OpdaterBoligKnap_Click(object sender, EventArgs e)
        {
            
            string sSQL = "UPDATE Ejendome set (Bolingnr=@Bolignr, Adresse=@Adresse, Pris=@Pris, Boligareal=@Boligareal, Grundareal=@Grundareal, Have=@Have, Værelser=@værelser, Etager=@Etager, " +
                "Type=@Type, Byggeår=@Byggeår, Renoveret=@Renoveret, Køkken=@Køkken, Badeværelse=@Badeværelse, Andet=@Andet, Ombygningsår=@Ombygningsår, Detalijer=@Detaljier, RenoveringsId=@RenoveringsId)";
            SqlCommand cmd = new SqlCommand(sSQL);

            cmd.Parameters.AddWithValue("@Bolignr", int.Parse(BolignrLabel.Text));
            cmd.Parameters.AddWithValue("@Adresse", (AdresseBolig.Text));
            cmd.Parameters.AddWithValue("@Pris", int.Parse(PrisTextBox.Text));
            cmd.Parameters.AddWithValue("@Boligareal", int.Parse(BoligArealTextBox.Text));
            cmd.Parameters.AddWithValue("@Grundareal", int.Parse(GrundArealBoligTextBox.Text));
            cmd.Parameters.AddWithValue("@Have", (HaveBoligTextBox.Text));
            cmd.Parameters.AddWithValue("@Værelser", (VæreslerBoligTextBox.Text));
            cmd.Parameters.AddWithValue("@Typebolig", (TypeBoligTextBox.Text));
            cmd.Parameters.AddWithValue("@Byggeår", int.Parse(ByggeårBoligTextBox.Text));
            cmd.Parameters.AddWithValue("@Renoveret", (RenoveretBoligCheckBox.Checked));
            cmd.Parameters.AddWithValue("@Køkken", (KøkkenCheckbox.Checked));
            cmd.Parameters.AddWithValue("@Badeværelse", (Badeværelsecheckbox.Checked));
            cmd.Parameters.AddWithValue("@Andet", (Andetcheckbox.Checked));
            cmd.Parameters.AddWithValue("@Ombygningsår", int.Parse(OmbygningsårTextbox.Text));
            cmd.Parameters.AddWithValue("@Detaljier", (DetalijerTextbox.Text));
            cmd.Parameters.AddWithValue("@Renoveringsid", (RenoveringsIdLabel.Text));


            if (RegexCheck.TalCheck(BolignrLabel.Text) && RegexCheck.TextCheck(AdresseBolig.Text) && RegexCheck.TalCheck(PrisTextBox.Text) && RegexCheck.TalCheck(BoligArealTextBox.Text) && RegexCheck.TalCheck(GrundArealBoligTextBox.Text) && RegexCheck.TextCheck(HaveBoligTextBox.Text)
             && RegexCheck.TalCheck(VæreslerBoligTextBox.Text) && RegexCheck.TextCheck(TypeBoligTextBox.Text) && RegexCheck.TalCheck(ByggeårBoligTextBox.Text) && RenoveretBoligCheckBox.Checked && KøkkenCheckbox.Checked &&
                Badeværelsecheckbox.Checked && RegexCheck.TalCheck(OmbygningsårTextbox.Text) && RegexCheck.TextCheck(DetalijerTextbox.Text) && RegexCheck.TalCheck(RenoveringsIdLabel.Text))
            {


                cmd.ExecuteNonQuery();
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
