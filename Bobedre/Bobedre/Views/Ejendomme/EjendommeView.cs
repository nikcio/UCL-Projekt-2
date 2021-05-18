using BoBedre.Core.DataAccess;
using BoBedre.Core.Models;
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
    public partial class EjendommeView : Form
    {
        private Baseform baseform { get; set; }
        public EjendommeView(Baseform _baseform)
        {
            InitializeComponent();

            baseform = _baseform;

            LoadData();
        }

        private async void LoadData()
        {
            var ejendomme = await Fetch.GetEjendomAll();

            foreach(var ejendom in ejendomme)
            {
                OpretTemplate(ejendom);
            }
        }

        private void OpretTemplate(Ejendom ejendom)
        {
            Panel panel1 = new System.Windows.Forms.Panel();
            Button Visboligoplysninger = new System.Windows.Forms.Button();
            Button OpdaterBoligoplsyninger = new System.Windows.Forms.Button();
            Label Boliggrundareal = new System.Windows.Forms.Label();
            Label VisGrundAreal = new System.Windows.Forms.Label();
            Button SletBoligKnap = new System.Windows.Forms.Button();
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
            panel1.Controls.Add(Visboligoplysninger);
            panel1.Controls.Add(OpdaterBoligoplsyninger);
            panel1.Controls.Add(Boliggrundareal);
            panel1.Controls.Add(VisGrundAreal);
            panel1.Controls.Add(SletBoligKnap);
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
            panel1.Location = new System.Drawing.Point(16, 67);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(474, 349);
            panel1.TabIndex = 1;
            // 
            // Visboligoplysninger
            // 
            Visboligoplysninger.AutoSize = true;
            Visboligoplysninger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Visboligoplysninger.Location = new System.Drawing.Point(308, 176);
            Visboligoplysninger.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Visboligoplysninger.Name = "Visboligoplysninger";
            Visboligoplysninger.Size = new System.Drawing.Size(111, 38);
            Visboligoplysninger.TabIndex = 12;
            Visboligoplysninger.Text = "Vis";
            Visboligoplysninger.UseVisualStyleBackColor = true;
            Visboligoplysninger.Click += new System.EventHandler((object sender, EventArgs e) => OpretButton_Click(ejendom.BoligNr));
            // 
            // OpdaterBoligoplsyninger
            // 
            OpdaterBoligoplsyninger.AutoSize = true;
            OpdaterBoligoplsyninger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            OpdaterBoligoplsyninger.Location = new System.Drawing.Point(308, 224);
            OpdaterBoligoplsyninger.Name = "OpdaterBoligoplsyninger";
            OpdaterBoligoplsyninger.Size = new System.Drawing.Size(111, 37);
            OpdaterBoligoplsyninger.TabIndex = 11;
            OpdaterBoligoplsyninger.Text = "Opdater";
            OpdaterBoligoplsyninger.UseVisualStyleBackColor = true;
            OpdaterBoligoplsyninger.Click += new System.EventHandler((object sender, EventArgs e) => OpdaterBoligoplsyninger_Click(ejendom.BoligNr));
            // 
            // Boliggrundareal
            // 
            Boliggrundareal.AutoSize = true;
            Boliggrundareal.Location = new System.Drawing.Point(12, 113);
            Boliggrundareal.Name = "Boliggrundareal";
            Boliggrundareal.Size = new System.Drawing.Size(101, 25);
            Boliggrundareal.TabIndex = 6;
            Boliggrundareal.Text = "GrundAreal";
            // 
            // VisGrundAreal
            // 
            VisGrundAreal.AutoSize = true;
            VisGrundAreal.Location = new System.Drawing.Point(130, 113);
            VisGrundAreal.Name = "VisGrundAreal";
            VisGrundAreal.Size = new System.Drawing.Size(22, 25);
            VisGrundAreal.TabIndex = 7;
            VisGrundAreal.Text = ejendom.GrundAreal.ToString();
            // 
            // SletBoligKnap
            // 
            SletBoligKnap.AutoSize = true;
            SletBoligKnap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            SletBoligKnap.Location = new System.Drawing.Point(308, 272);
            SletBoligKnap.Name = "SletBoligKnap";
            SletBoligKnap.Size = new System.Drawing.Size(111, 37);
            SletBoligKnap.TabIndex = 10;
            SletBoligKnap.Text = "Slet bolig";
            SletBoligKnap.UseVisualStyleBackColor = true;
            SletBoligKnap.Click += new System.EventHandler((object sender, EventArgs e) => SletBoligKnap_Click(ejendom.BoligNr));
            // 
            // VisByggeår
            // 
            VisByggeår.AutoSize = true;
            VisByggeår.Location = new System.Drawing.Point(382, 114);
            VisByggeår.Name = "VisByggeår";
            VisByggeår.Size = new System.Drawing.Size(22, 25);
            VisByggeår.TabIndex = 9;
            VisByggeår.Text = ejendom.Byggeår.ToString();
            // 
            // VisType
            // 
            VisType.AutoSize = true;
            VisType.Location = new System.Drawing.Point(382, 62);
            VisType.Name = "VisType";
            VisType.Size = new System.Drawing.Size(22, 25);
            VisType.TabIndex = 9;
            VisType.Text = ejendom.Type.ToString();
            // 
            // ByggeårLabel
            // 
            ByggeårLabel.AutoSize = true;
            ByggeårLabel.Location = new System.Drawing.Point(308, 114);
            ByggeårLabel.Name = "ByggeårLabel";
            ByggeårLabel.Size = new System.Drawing.Size(77, 25);
            ByggeårLabel.TabIndex = 8;
            ByggeårLabel.Text = "Byggeår";
            // 
            // TypeLabel
            // 
            TypeLabel.AutoSize = true;
            TypeLabel.Location = new System.Drawing.Point(308, 62);
            TypeLabel.Name = "TypeLabel";
            TypeLabel.Size = new System.Drawing.Size(49, 25);
            TypeLabel.TabIndex = 8;
            TypeLabel.Text = "Type";
            // 
            // VisEtager
            // 
            VisEtager.AutoSize = true;
            VisEtager.Location = new System.Drawing.Point(382, 1);
            VisEtager.Name = "VisEtager";
            VisEtager.Size = new System.Drawing.Size(22, 25);
            VisEtager.TabIndex = 7;
            VisEtager.Text =  ejendom.Etager.ToString();
            // 
            // VisVærelser
            // 
            VisVærelser.AutoSize = true;
            VisVærelser.Location = new System.Drawing.Point(129, 284);
            VisVærelser.Name = "VisVærelser";
            VisVærelser.Size = new System.Drawing.Size(22, 25);
            VisVærelser.TabIndex = 7;
            VisVærelser.Text = ejendom.Værelser.ToString();
            // 
            // EtagerBolig
            // 
            EtagerBolig.AutoSize = true;
            EtagerBolig.Location = new System.Drawing.Point(308, 1);
            EtagerBolig.Name = "EtagerBolig";
            EtagerBolig.Size = new System.Drawing.Size(62, 25);
            EtagerBolig.TabIndex = 6;
            EtagerBolig.Text = "Etager";
            // 
            // VisHave
            // 
            VisHave.AutoSize = true;
            VisHave.Location = new System.Drawing.Point(129, 223);
            VisHave.Name = "VisHave";
            VisHave.Size = new System.Drawing.Size(22, 25);
            VisHave.TabIndex = 7;
            VisHave.Text = ejendom.Have.ToString();
            // 
            // Boligværleser
            // 
            Boligværleser.AutoSize = true;
            Boligværleser.Location = new System.Drawing.Point(15, 279);
            Boligværleser.Name = "Boligværleser";
            Boligværleser.Size = new System.Drawing.Size(79, 25);
            Boligværleser.TabIndex = 6;
            Boligværleser.Text = "Værelser";
            // 
            // HaveBolig
            // 
            HaveBolig.AutoSize = true;
            HaveBolig.Location = new System.Drawing.Point(15, 223);
            HaveBolig.Name = "HaveBolig";
            HaveBolig.Size = new System.Drawing.Size(52, 25);
            HaveBolig.TabIndex = 6;
            HaveBolig.Text = "Have";
            // 
            // VisBoligPris
            // 
            VisBoligPris.AutoSize = true;
            VisBoligPris.Location = new System.Drawing.Point(126, 61);
            VisBoligPris.Name = "VisBoligPris";
            VisBoligPris.Size = new System.Drawing.Size(22, 25);
            VisBoligPris.TabIndex = 5;
            VisBoligPris.Text = ejendom.Pris.ToString();
            // 
            // PrisLabel
            // 
            PrisLabel.AutoSize = true;
            PrisLabel.Location = new System.Drawing.Point(12, 61);
            PrisLabel.Name = "PrisLabel";
            PrisLabel.Size = new System.Drawing.Size(40, 25);
            PrisLabel.TabIndex = 4;
            PrisLabel.Text = "Pris";

            // 
            // VisAdresse
            // 
            VisAdresse.AutoSize = true;
            VisAdresse.Location = new System.Drawing.Point(130, 166);
            VisAdresse.Name = "VisAdresse";
            VisAdresse.Size = new System.Drawing.Size(22, 25);
            VisAdresse.TabIndex = 3;
            VisAdresse.Text = ejendom.Adresse.ToString();
            // 
            // AdresseLabel
            // 
            AdresseLabel.AutoSize = true;
            AdresseLabel.Location = new System.Drawing.Point(12, 166);
            AdresseLabel.Name = "AdresseLabel";
            AdresseLabel.Size = new System.Drawing.Size(75, 25);
            AdresseLabel.TabIndex = 2;
            AdresseLabel.Text = "Adresse";
            // 
            // VisBoligNr
            // 
            VisBoligNr.AutoSize = true;
            VisBoligNr.Location = new System.Drawing.Point(129, 0);
            VisBoligNr.Name = "VisBoligNr";
            VisBoligNr.Size = new System.Drawing.Size(22, 25);
            VisBoligNr.TabIndex = 1;
            VisBoligNr.Text = ejendom.BoligNr.ToString();
            VisBoligNr.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BoligNrLabel
            // 
            BoligNrLabel.AutoSize = true;
            BoligNrLabel.Location = new System.Drawing.Point(15, 0);
            BoligNrLabel.Name = "BoligNrLabel";
            BoligNrLabel.Size = new System.Drawing.Size(71, 25);
            BoligNrLabel.TabIndex = 0;
            BoligNrLabel.Text = "BoligNr";
           




            flowLayoutPanel1.Controls.Add(panel1);
        }
        private void OpretButton_Click(int boligNr)
        {
            baseform.ShowForm(new Ejendomme(Models.Action.view, baseform, boligNr));

            
            

        }
        private void OpdaterBoligoplsyninger_Click(int boligNr)
        {
            baseform.ShowForm(new Ejendomme(Models.Action.edit, baseform, boligNr));
        }

        private void SletBoligKnap_Click(int boligNr)
        {
            baseform.ShowForm(new Ejendomme(Models.Action.delete, baseform, boligNr));

        }

        private void TilføjBoligKnap_Click(object sender, EventArgs e)
        {
            baseform.ShowForm(new Ejendomme(Models.Action.create, baseform));
        }
    }
}
