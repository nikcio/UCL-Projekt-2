using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void OpretBoligKnap_Click(object sender, EventArgs e)
        {
           
            String sSQL = "INSERT INTO Ejendome VALUES (@Bolignr, @Adresse, @Pris, @Boligareal, @Grundareal, @have, @værelser, @Etager, @Type, @Byggeår, @Renoveret, @Køkken, @Badeværelse, @Andet, @Ombygningsår, @Detaljier, @RenoveringsId)";
            SqlCommand cmd = new SqlCommand(sSQL);
            
            cmd.Parameters.AddWithValue("@Bolignr", int.Parse(BolignrLabel.Text));
            cmd.Parameters.AddWithValue("@Adresse", (AdresseBolig.Text));
            cmd.Parameters.AddWithValue("@Pris", int.Parse(PrisTextBox.Text));
            cmd.Parameters.AddWithValue("@Boligareal", int.Parse(BoligArealTextBox.Text));
            cmd.Parameters.AddWithValue("@Grundareal", int.Parse(GrundArealBoligTextBox.Text));
            cmd.Parameters.AddWithValue("@Have", (HaveBoligTextBox.Text));
            cmd.Parameters.AddWithValue("@Værelser", int.Parse(VæreslerBoligTextBox.Text));
            cmd.Parameters.AddWithValue("@Typebolig", (TypeBoligTextBox.Text));
            cmd.Parameters.AddWithValue("@Byggeår", int.Parse(ByggeårBoligTextBox.Text));
            cmd.Parameters.AddWithValue("@Bolignr", int.Parse(RenoveretBoligCheckBox.Text));



            if (Regex.IsMatch((BolignrLabel.Text) + (AdresseBolig.Text) + (PrisTextBox.Text) + (BoligArealTextBox.Text)
                + (GrundArealBoligTextBox.Text) + (HaveBoligTextBox.Text) + (VæreslerBoligTextBox.Text) + (TypeBoligTextBox.Text)
                + ByggeårBoligTextBox.Text) + (ByggeårBoligTextBox.Text) + (RenoveretBoligCheckBox), @"^[a-z A-Z]+$")
            {

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
            
            string sSQL = "UPDATE Ejendome set (Bolingnr=@Bolignr, Adresse=@Adresse, Pris=@Pris, Boligareal=@Boligareal, Grundareal=@Grundareal, Have=@Have, Værelser=@værelser, Etager=@Etager, Type=@Type, Byggeår=@Byggeår, Renoveret=@Renoveret, Køkken=@Køkken, Badeværelse=@Badeværelse, Andet=@Andet, Ombygningsår=@Ombygningsår, Detalijer=@Detaljier, RenoveringsId=@RenoveringsId)";
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
            cmd.Parameters.AddWithValue("@Bolignr", int.Parse(RenoveretBoligCheckBox.Text));
        }
    }
}
