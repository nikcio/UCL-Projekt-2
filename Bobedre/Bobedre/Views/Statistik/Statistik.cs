using BoBedre.Core.DataAccess;
using BoBedre.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Bobedre.Views.Statistik
{
    public partial class Statistik : Form
    {
        private IEnumerable<Ejendom> ejendommeStatisk = null;

        public Statistik()
        {
            InitializeComponent();
        }

        private async void VisButton_Click(object sender, EventArgs e)
        {
            ejendommeStatisk = await BoBedre.Core.Logic.Statistik.GetEjendommeStatisk(
                ((KeyValuePair<string, int>)MedarbjederComboBox.SelectedItem).Value,
                StartDateTimePicker.Value,
                SlutDateTimePicker.Value,
                ((KeyValuePair<string, int>)PostnummerComboBox.SelectedItem).Value,
                ((KeyValuePair<string, int[]>)PrisComboBox.SelectedItem).Value
                );

            AntalLabel.Text = $"Antal: {ejendommeStatisk.Count()}";

            GemButton.Enabled = true;

            foreach(var item in ejendommeStatisk)
            {
                OpretTemplate(item);
            }
        }

        private void GemButton_Click(object sender, EventArgs e)
        {

        }

        private async void Statistik_Load(object sender, EventArgs e)
        {
            var byer = await Fetch.GetByAll();

            Dictionary<string, int> postnummerValues = byer.ToDictionary(item => $"{item.PostNr} - {item.ByNavn}", item => item.PostNr);

            PostnummerComboBox.DataSource = postnummerValues.ToList();
            PostnummerComboBox.ValueMember = "Key";
            PostnummerComboBox.SelectedText = "Value";
            PostnummerComboBox.SelectedIndex = 0;

            var medarbejdere = await Fetch.GetEjendomsmæglerAll();

            Dictionary<string, int> medarbejderValues = medarbejdere.ToDictionary(item => $"Navn: {item.Navn} - MedarbejderNr: {item.MedarbejderNr}", item => item.MedarbejderNr);

            MedarbjederComboBox.DataSource = medarbejderValues.ToList();
            MedarbjederComboBox.ValueMember = "Key";
            MedarbjederComboBox.SelectedText = "Value";
            MedarbjederComboBox.SelectedIndex = 0;

            Dictionary<string, int[]> priser = new Dictionary<string, int[]> {
                { "0 - 100.000 kr.", new int[] { 0, 100000 } },
                { "100.000 - 1.000.000 kr.", new int[] { 100000, 1000000} },
                { "1.000.000 - 1.500.000 kr.", new int[] { 1000000, 1500000 } },
                { "1.500.000 - 2.000.000 kr.", new int[] { 1500000, 2000000 } },
                { "2.000.000 - 2.250.000 kr.", new int[] { 2000000, 2250000 } },
                { "2.250.000 - 2.500.000 kr.", new int[] { 2250000, 2500000 } },
                { "2.500.000 - 2.750.000 kr.", new int[] { 2500000, 2750000 } },
                { "2.750.000 - 3.000.000 kr.", new int[] { 2750000, 3000000 } },
                { "3.000.000+ kr.", new int[] { 3000000, int.MaxValue } }
            };

            PrisComboBox.DataSource = priser.ToList();
            PrisComboBox.ValueMember = "Key";
            PrisComboBox.SelectedText = "Value";
            PrisComboBox.SelectedIndex = 0;

            AntalLabel.Text = "";

            GemButton.Enabled = false;
        }

        private void OpretTemplate(Ejendom ejendom)
        {
            Panel panel1 = new System.Windows.Forms.Panel();
            Label Boliggrundareal = new System.Windows.Forms.Label();
            Label VisGrundAreal = new System.Windows.Forms.Label();
            Label VisByggeår = new System.Windows.Forms.Label();
            Label VisType = new System.Windows.Forms.Label();
            Label ByggeårLabel = new System.Windows.Forms.Label();
            Label TypeLabel = new System.Windows.Forms.Label();
            Label VisEtager = new System.Windows.Forms.Label();
            Label VisVærelser = new System.Windows.Forms.Label();
            Label EtagerBolig = new System.Windows.Forms.Label();
            Label VisHave = new System.Windows.Forms.Label();
            Label Boligværleser = new System.Windows.Forms.Label();
            Label HaveBolig = new System.Windows.Forms.Label();
            Label VisBoligPris = new System.Windows.Forms.Label();
            Label PrisLabel = new System.Windows.Forms.Label();
            Label VisAdresse = new System.Windows.Forms.Label();
            Label AdresseLabel = new System.Windows.Forms.Label();
            Label VisBoligNr = new System.Windows.Forms.Label();
            Label BoligNrLabel = new System.Windows.Forms.Label();

            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(Boliggrundareal);
            panel1.Controls.Add(VisGrundAreal);
            panel1.Controls.Add(VisByggeår);
            panel1.Controls.Add(VisType);
            panel1.Controls.Add(ByggeårLabel);
            panel1.Controls.Add(TypeLabel);
            panel1.Controls.Add(VisEtager);
            panel1.Controls.Add(VisVærelser);
            panel1.Controls.Add(EtagerBolig);
            panel1.Controls.Add(VisHave);
            panel1.Controls.Add(Boligværleser);
            panel1.Controls.Add(HaveBolig);
            panel1.Controls.Add(VisBoligPris);
            panel1.Controls.Add(PrisLabel);
            panel1.Controls.Add(VisAdresse);
            panel1.Controls.Add(AdresseLabel);
            panel1.Controls.Add(VisBoligNr);
            panel1.Controls.Add(BoligNrLabel);
            panel1.Location = new System.Drawing.Point(11, 43);
            panel1.Margin = new System.Windows.Forms.Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(272, 151);
            panel1.TabIndex = 1;
            // 
            // Boliggrundareal
            // 
            Boliggrundareal.AutoSize = true;
            Boliggrundareal.Location = new System.Drawing.Point(-1, 46);
            Boliggrundareal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            Boliggrundareal.Name = "Boliggrundareal";
            Boliggrundareal.Size = new System.Drawing.Size(72, 15);
            Boliggrundareal.TabIndex = 6;
            Boliggrundareal.Text = "Groundareal";
            // 
            // VisGrundAreal
            // 
            VisGrundAreal.AutoSize = true;
            VisGrundAreal.Location = new System.Drawing.Point(80, 46);
            VisGrundAreal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            VisGrundAreal.Name = "VisGrundAreal";
            VisGrundAreal.Size = new System.Drawing.Size(13, 15);
            VisGrundAreal.TabIndex = 7;
            VisGrundAreal.Text = "1";
            // 
            // VisByggeår
            // 
            VisByggeår.AutoSize = true;
            VisByggeår.Location = new System.Drawing.Point(201, 46);
            VisByggeår.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            VisByggeår.Name = "VisByggeår";
            VisByggeår.Size = new System.Drawing.Size(13, 15);
            VisByggeår.TabIndex = 9;
            VisByggeår.Text = "1";
            // 
            // VisType
            // 
            VisType.AutoSize = true;
            VisType.Location = new System.Drawing.Point(201, 22);
            VisType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            VisType.Name = "VisType";
            VisType.Size = new System.Drawing.Size(13, 15);
            VisType.TabIndex = 9;
            VisType.Text = "1";
            // 
            // ByggeårLabel
            // 
            ByggeårLabel.AutoSize = true;
            ByggeårLabel.Location = new System.Drawing.Point(149, 46);
            ByggeårLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            ByggeårLabel.Name = "ByggeårLabel";
            ByggeårLabel.Size = new System.Drawing.Size(50, 15);
            ByggeårLabel.TabIndex = 8;
            ByggeårLabel.Text = "Byggeår";
            // 
            // TypeLabel
            // 
            TypeLabel.AutoSize = true;
            TypeLabel.Location = new System.Drawing.Point(149, 22);
            TypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            TypeLabel.Name = "TypeLabel";
            TypeLabel.Size = new System.Drawing.Size(31, 15);
            TypeLabel.TabIndex = 8;
            TypeLabel.Text = "Type";
            // 
            // VisEtager
            // 
            VisEtager.AutoSize = true;
            VisEtager.Location = new System.Drawing.Point(201, 0);
            VisEtager.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            VisEtager.Name = "VisEtager";
            VisEtager.Size = new System.Drawing.Size(13, 15);
            VisEtager.TabIndex = 7;
            VisEtager.Text = "1";
            // 
            // VisVærelser
            // 
            VisVærelser.AutoSize = true;
            VisVærelser.Location = new System.Drawing.Point(80, 116);
            VisVærelser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            VisVærelser.Name = "VisVærelser";
            VisVærelser.Size = new System.Drawing.Size(13, 15);
            VisVærelser.TabIndex = 7;
            VisVærelser.Text = "1";
            // 
            // EtagerBolig
            // 
            EtagerBolig.AutoSize = true;
            EtagerBolig.Location = new System.Drawing.Point(149, 0);
            EtagerBolig.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            EtagerBolig.Name = "EtagerBolig";
            EtagerBolig.Size = new System.Drawing.Size(40, 15);
            EtagerBolig.TabIndex = 6;
            EtagerBolig.Text = "Etager";
            // 
            // VisHave
            // 
            VisHave.AutoSize = true;
            VisHave.Location = new System.Drawing.Point(80, 89);
            VisHave.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            VisHave.Name = "VisHave";
            VisHave.Size = new System.Drawing.Size(13, 15);
            VisHave.TabIndex = 7;
            VisHave.Text = "1";
            // 
            // Boligværleser
            // 
            Boligværleser.AutoSize = true;
            Boligværleser.Location = new System.Drawing.Point(0, 113);
            Boligværleser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            Boligværleser.Name = "Boligværleser";
            Boligværleser.Size = new System.Drawing.Size(51, 15);
            Boligværleser.TabIndex = 6;
            Boligværleser.Text = "Værelser";
            // 
            // HaveBolig
            // 
            HaveBolig.AutoSize = true;
            HaveBolig.Location = new System.Drawing.Point(0, 88);
            HaveBolig.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            HaveBolig.Name = "HaveBolig";
            HaveBolig.Size = new System.Drawing.Size(34, 15);
            HaveBolig.TabIndex = 6;
            HaveBolig.Text = "Have";
            // 
            // VisBoligPris
            // 
            VisBoligPris.AutoSize = true;
            VisBoligPris.Location = new System.Drawing.Point(80, 22);
            VisBoligPris.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            VisBoligPris.Name = "VisBoligPris";
            VisBoligPris.Size = new System.Drawing.Size(13, 15);
            VisBoligPris.TabIndex = 5;
            VisBoligPris.Text = "1";
            // 
            // PrisLabel
            // 
            PrisLabel.AutoSize = true;
            PrisLabel.Location = new System.Drawing.Point(0, 22);
            PrisLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            PrisLabel.Name = "PrisLabel";
            PrisLabel.Size = new System.Drawing.Size(26, 15);
            PrisLabel.TabIndex = 4;
            PrisLabel.Text = "Pris";
            // 
            // VisAdresse
            // 
            VisAdresse.AutoSize = true;
            VisAdresse.Location = new System.Drawing.Point(80, 68);
            VisAdresse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            VisAdresse.Name = "VisAdresse";
            VisAdresse.Size = new System.Drawing.Size(13, 15);
            VisAdresse.TabIndex = 3;
            VisAdresse.Text = "1";
            // 
            // AdresseLabel
            // 
            AdresseLabel.AutoSize = true;
            AdresseLabel.Location = new System.Drawing.Point(-3, 68);
            AdresseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            AdresseLabel.Name = "AdresseLabel";
            AdresseLabel.Size = new System.Drawing.Size(48, 15);
            AdresseLabel.TabIndex = 2;
            AdresseLabel.Text = "Adresse";
            // 
            // VisBoligNr
            // 
            VisBoligNr.AutoSize = true;
            VisBoligNr.Location = new System.Drawing.Point(80, 0);
            VisBoligNr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            VisBoligNr.Name = "VisBoligNr";
            VisBoligNr.Size = new System.Drawing.Size(13, 15);
            VisBoligNr.TabIndex = 1;
            VisBoligNr.Text = "1";
            VisBoligNr.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BoligNrLabel
            // 
            BoligNrLabel.AutoSize = true;
            BoligNrLabel.Location = new System.Drawing.Point(0, 0);
            BoligNrLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            BoligNrLabel.Name = "BoligNrLabel";
            BoligNrLabel.Size = new System.Drawing.Size(47, 15);
            BoligNrLabel.TabIndex = 0;
            BoligNrLabel.Text = "BoligNr";
            flowLayoutPanel1.Controls.Add(panel1);
        }

    }
    
}
