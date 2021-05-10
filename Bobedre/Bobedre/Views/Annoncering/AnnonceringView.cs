using BoBedre.Core.DataAccess;
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
    public partial class AnnonceringView : Form
    {
        private Baseform baseform { get; set; }
        public AnnonceringView(Baseform _Baseform)
        {
            InitializeComponent();
            baseform = _Baseform;

            LoadData();
        }
        private async void LoadData()
        {
            BoBedre.Core.Models.Annoncering[] annonceringer = await Fetch.GetAnnonceringAll();

            foreach (var annonce in annonceringer)
            {
                VisAnnonceringer(annonce);
            }
        }
        private void VisAnnonceringer(BoBedre.Core.Models.Annoncering annonceringer)
        {
            Panel panel1 = new System.Windows.Forms.Panel();
            Label MedarbejderNrSvar = new System.Windows.Forms.Label();
            Label AnnonceringsNrLabel = new System.Windows.Forms.Label();
            Button VisKnap = new System.Windows.Forms.Button();
            Button RedigereKnap = new System.Windows.Forms.Button();
            Label SagsNrSvar = new System.Windows.Forms.Label();
            Label SagsNrLabel = new System.Windows.Forms.Label();
            Label SlutDatoSvar = new System.Windows.Forms.Label();
            Label SlutDatoLabel = new System.Windows.Forms.Label();
            Label StartDatoSvar = new System.Windows.Forms.Label();
            Label StartDatoLabel = new System.Windows.Forms.Label();
            Label TypeLabel = new System.Windows.Forms.Label();
            Label TypeSvar = new System.Windows.Forms.Label();
            
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(TypeSvar);
            panel1.Controls.Add(TypeLabel);
            panel1.Controls.Add(MedarbejderNrSvar);
            panel1.Controls.Add(AnnonceringsNrLabel);
            panel1.Controls.Add(VisKnap);
            panel1.Controls.Add(RedigereKnap);
            panel1.Controls.Add(SagsNrSvar);
            panel1.Controls.Add(SagsNrLabel);
            panel1.Controls.Add(SlutDatoSvar);
            panel1.Controls.Add(SlutDatoLabel);
            panel1.Controls.Add(StartDatoSvar);
            panel1.Controls.Add(StartDatoLabel);
            panel1.Location = new System.Drawing.Point(12, 22);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(369, 223);
            panel1.TabIndex = 1;
            // 
            // MedarbejderNrSvar
            // 
            MedarbejderNrSvar.AutoSize = true;
            MedarbejderNrSvar.Location = new System.Drawing.Point(132, 25);
            MedarbejderNrSvar.Name = "MedarbejderNrSvar";
            MedarbejderNrSvar.Size = new System.Drawing.Size(13, 15);
            MedarbejderNrSvar.TabIndex = 11;
            MedarbejderNrSvar.Text = annonceringer.AnnonceringsNr.ToString();
            // 
            // AnnonceringsNrLabel
            // 
            AnnonceringsNrLabel.AutoSize = true;
            AnnonceringsNrLabel.Location = new System.Drawing.Point(21, 25);
            AnnonceringsNrLabel.Name = "AnnonceringsNrLabel";
            AnnonceringsNrLabel.Size = new System.Drawing.Size(94, 15);
            AnnonceringsNrLabel.TabIndex = 10;
            AnnonceringsNrLabel.Text = "AnnonceringsNr";
            // 
            // VisKnap
            // 
            VisKnap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            VisKnap.Location = new System.Drawing.Point(269, 57);
            VisKnap.Name = "VisKnap";
            VisKnap.Size = new System.Drawing.Size(75, 23);
            VisKnap.TabIndex = 9;
            VisKnap.Text = "Vis";
            VisKnap.UseVisualStyleBackColor = true;
            VisKnap.Click += new System.EventHandler((object sender, EventArgs e) => VisKnap_Click(annonceringer.AnnonceringsNr));
            // 
            // RedigereKnap
            // 
            RedigereKnap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            RedigereKnap.Location = new System.Drawing.Point(269, 25);
            RedigereKnap.Name = "RedigereKnap";
            RedigereKnap.Size = new System.Drawing.Size(75, 23);
            RedigereKnap.TabIndex = 8;
            RedigereKnap.Text = "Redigere";
            RedigereKnap.UseVisualStyleBackColor = true;
            RedigereKnap.Click += new System.EventHandler((object sender, EventArgs e) => RedigereKnap_Click(annonceringer.AnnonceringsNr));
            // 
            // SagsNrSvar
            // 
            SagsNrSvar.AutoSize = true;
            SagsNrSvar.Location = new System.Drawing.Point(132, 164);
            SagsNrSvar.Name = "SagsNrSvar";
            SagsNrSvar.Size = new System.Drawing.Size(13, 15);
            SagsNrSvar.TabIndex = 5;
            SagsNrSvar.Text = annonceringer.SagNr.ToString();
            // 
            // SagsNrLabel
            // 
            SagsNrLabel.AutoSize = true;
            SagsNrLabel.Location = new System.Drawing.Point(21, 164);
            SagsNrLabel.Name = "SagsNrLabel";
            SagsNrLabel.Size = new System.Drawing.Size(44, 15);
            SagsNrLabel.TabIndex = 4;
            SagsNrLabel.Text = "SagsNr";
            // 
            // SlutDatoSvar
            // 
            SlutDatoSvar.AutoSize = true;
            SlutDatoSvar.Location = new System.Drawing.Point(132, 133);
            SlutDatoSvar.Name = "SlutDatoSvar";
            SlutDatoSvar.Size = new System.Drawing.Size(13, 15);
            SlutDatoSvar.TabIndex = 3;
            SlutDatoSvar.Text = annonceringer.SlutDato.ToShortDateString();
            // 
            // SlutDatoLabel
            // 
            SlutDatoLabel.AutoSize = true;
            SlutDatoLabel.Location = new System.Drawing.Point(21, 133);
            SlutDatoLabel.Name = "SlutDatoLabel";
            SlutDatoLabel.Size = new System.Drawing.Size(52, 15);
            SlutDatoLabel.TabIndex = 2;
            SlutDatoLabel.Text = "SlutDato";
            // 
            // StartDatoSvar
            // 
            StartDatoSvar.AutoSize = true;
            StartDatoSvar.Location = new System.Drawing.Point(132, 101);
            StartDatoSvar.Name = "StartDatoSvar";
            StartDatoSvar.Size = new System.Drawing.Size(13, 15);
            StartDatoSvar.TabIndex = 1;
            StartDatoSvar.Text = annonceringer.StartDato.ToShortDateString();
            // 
            // StartDatoLabel
            // 
            StartDatoLabel.AutoSize = true;
            StartDatoLabel.Location = new System.Drawing.Point(21, 101);
            StartDatoLabel.Name = "StartDatoLabel";
            StartDatoLabel.Size = new System.Drawing.Size(56, 15);
            StartDatoLabel.TabIndex = 0;
            StartDatoLabel.Text = "StartDato";
            // 
            // TypeLabel
            // 
            TypeLabel.AutoSize = true;
            TypeLabel.Location = new System.Drawing.Point(21, 65);
            TypeLabel.Name = "TypeLabel";
            TypeLabel.Size = new System.Drawing.Size(31, 15);
            TypeLabel.TabIndex = 12;
            TypeLabel.Text = "Type";
            // 
            // TypeSvar
            // 
            TypeSvar.AutoSize = true;
            TypeSvar.Location = new System.Drawing.Point(132, 65);
            TypeSvar.Name = "TypeSvar";
            TypeSvar.Size = new System.Drawing.Size(13, 15);
            TypeSvar.TabIndex = 13;
            TypeSvar.Text = annonceringer.Type.ToString();

            flowLayoutPanel1.Controls.Add(panel1);
        }

        private void TilføjKnap_Click(object sender, EventArgs e)
        {
            baseform.ShowForm(new Annoncering(Models.Action.create, baseform));
           
        }

        private void RedigereKnap_Click(int annonceringsNr)
        {
            baseform.ShowForm(new Annoncering(Models.Action.edit, baseform, annonceringsNr));
        }

        private void VisKnap_Click(int annonceringsNr)
        {
            baseform.ShowForm(new Annoncering(Models.Action.view, baseform, annonceringsNr));
        }

      
    }
}

