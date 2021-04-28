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
        private readonly string BaisctalRegex = @"^[0-9]+$";
        private readonly string BaiscTestRegex = @"^[a-z A-ZøæåØÆÅ]+$";

        public Ejendomme(Models.Action action, Baseform baseform)
        {
            InitializeComponent();
        }

        private void OpretBoligKnap_Click(object sender, EventArgs e)
        {
           


            String sSQL = "INSERT INTO Ejendome(Adresse, Pris, Boligareal, Grundareal, have, værelser, Etager, Type, Byggeår, Renoveret, Køkken, Badeværelse, " +
                "Andet, Ombygningsår, Detaljier, RenoveringsId) VALUES (@Adresse, @Pris, @Boligareal, @Grundareal, @have, @værelser, @Etager, @Type, @Byggeår, @Renoveret, @Køkken, @Badeværelse, " +
                "@Andet, @Ombygningsår, @Detaljier, @RenoveringsId)";
            SqlCommand cmd = new SqlCommand(sSQL);
            
            
            
            cmd.Parameters.AddWithValue("@Adresse", (AdresseBolig.Text));
            cmd.Parameters.AddWithValue("@Pris", int.Parse(PrisTextBox.Text));
            cmd.Parameters.AddWithValue("@Boligareal", int.Parse(BoligArealTextBox.Text));
            cmd.Parameters.AddWithValue("@Grundareal", int.Parse(GrundArealBoligTextBox.Text));
            cmd.Parameters.AddWithValue("@Have", (HaveBoligTextBox.Text));
            cmd.Parameters.AddWithValue("@Værelser", int.Parse(VæreslerBoligTextBox.Text));
            cmd.Parameters.AddWithValue("@Typebolig", (TypeBoligTextBox.Text));
            cmd.Parameters.AddWithValue("@Byggeår", int.Parse(ByggeårBoligTextBox.Text));
            cmd.Parameters.AddWithValue("@Renoveret", (RenoveretBoligCheckBox.Checked));
            cmd.Parameters.AddWithValue("@Køkken", (KøkkenCheckbox.Checked));
            cmd.Parameters.AddWithValue("@Badeværelse", (Badeværelsecheckbox.Checked));
            cmd.Parameters.AddWithValue("@Andet", (Andetboligtjekbox.Checked));
            cmd.Parameters.AddWithValue("@Ombygningsår", int.Parse(OmbygningsårLabel.Text));
            cmd.Parameters.AddWithValue("@Detaljier", (DetalijerLabel.Text));
            cmd.Parameters.AddWithValue("@Renoveringsid", int.Parse(RenoveringsIdLabel.Text));




            if ((TextCheck(AdresseBolig.Text) && TalCheck(PrisTextBox.Text) && TalCheck(BoligArealTextBox.Text) && TalCheck(GrundArealBoligTextBox.Text) && TextCheck(HaveBoligTextBox.Text)
             && TalCheck(VæreslerBoligTextBox.Text) && TextCheck(TypeBoligTextBox.Text) && TalCheck(ByggeårBoligTextBox.Text)))
            {      
                if (TalCheck(OmbygningsårLabel.Text) && TextCheck(DetalijerLabel.Text) && TalCheck(RenoveringsIdLabel.Text))
                {

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Boligen er nu gemt1111");
                }


                cmd.ExecuteNonQuery();
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
            cmd.Parameters.AddWithValue("@Andet", (Andetboligtjekbox.Checked));
            cmd.Parameters.AddWithValue("@Ombygningsår", int.Parse(OmbygningsårLabel.Text));
            cmd.Parameters.AddWithValue("@Detaljier", (DetalijerLabel.Text));
            cmd.Parameters.AddWithValue("@Renoveringsid", (RenoveringsIdLabel.Text));


            if (TalCheck(BolignrLabel.Text) && TextCheck(AdresseBolig.Text) && TalCheck(PrisTextBox.Text) && TalCheck(BoligArealTextBox.Text) && TalCheck(GrundArealBoligTextBox.Text) && TextCheck(HaveBoligTextBox.Text)
             && TalCheck(VæreslerBoligTextBox.Text) && TextCheck(TypeBoligTextBox.Text) && TalCheck(ByggeårBoligTextBox.Text) && RenoveretBoligCheckBox.Checked && KøkkenCheckbox.Checked &&
                Badeværelsecheckbox.Checked &&  TalCheck(OmbygningsårLabel.Text) &&TextCheck(DetalijerLabel.Text) && TalCheck(RenoveringsIdLabel.Text))
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
            KøkkenCheckbox_CheckEnabling();
            Badeværelsecheckbox_CheckEnabling();
            Andetboligtjekbox_CheckEnabling();
            OmbygningsårLabel_CheckEnabling();
            DetalijerLabel_checkEnabling();
            RenoveringsIdLabel_checkEnabling();
        }

        private void KøkkenCheckbox_CheckEnabling()
        {
            KøkkenCheckbox.Enabled = RenoveretBoligCheckBox.Checked;
        }

        private void Badeværelsecheckbox_CheckEnabling()
        {
            Badeværelsecheckbox.Enabled = RenoveretBoligCheckBox.Checked;
        }

        private void Andetboligtjekbox_CheckEnabling()
        {
            Andetboligtjekbox.Enabled = RenoveretBoligCheckBox.Checked;
        }


        private void OmbygningsårLabel_CheckEnabling()
        {
            OmbygningsårLabel.Enabled = RenoveretBoligCheckBox.Checked;
        }
        private void DetalijerLabel_checkEnabling()
        {
            DetalijerLabel.Enabled = RenoveretBoligCheckBox.Checked;
        }
        private void RenoveringsIdLabel_checkEnabling()
        {
            RenoveringsIdLabel.Enabled = RenoveretBoligCheckBox.Checked;
        }

        private bool TextCheck(string textToCheck)
        {
            return Regex.IsMatch(textToCheck, BaiscTestRegex);
        }

        private bool TalCheck(string textToCheck)
        {
            return Regex.IsMatch(textToCheck, BaisctalRegex);
        }



        private void BoligAndet_Click(object sender, EventArgs e)
        {

        }
    }

}
