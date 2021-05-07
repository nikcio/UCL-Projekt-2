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

namespace Bobedre.Views.Kunder
{
    public partial class KunderView : Form
    {
        private Baseform baseform { get; set; }

        public KunderView(Baseform _Baseform)
        {
            InitializeComponent();
            baseform = _Baseform;

            LoadData();
        }

        private async void LoadData()
        {
            Kunde[] kunder = await Fetch.GetKundeAll();

            foreach (var kunde in kunder)
            {
                VisKunde(kunde);
            }
        }
        private void RedigereKnap_Click(int kundeNr)
        {
            baseform.ShowForm(new Kunder(Models.Action.edit, baseform, kundeNr));
        }

        private void VisKnap_Click(int kundeNr)
        {
            baseform.ShowForm(new Kunder(Models.Action.view, baseform, kundeNr));
        }

        private void VisKunde(Kunde kunde)
        {
            Panel panel1 = new System.Windows.Forms.Panel();
            Label KundeNrSvar = new System.Windows.Forms.Label();
            Label KundeNrLabel = new System.Windows.Forms.Label();
            Button VisKnap = new System.Windows.Forms.Button();
            Button RedigereKnap = new System.Windows.Forms.Button();
            Label KundeTypeSvar = new System.Windows.Forms.Label();
            Label KundeTypeLabel = new System.Windows.Forms.Label();
            Label KundeEmailSvar = new System.Windows.Forms.Label();
            Label KundeEmailLabel = new System.Windows.Forms.Label();
            Label KundeNavnSvar = new System.Windows.Forms.Label();
            Label KundeNavnLabel = new System.Windows.Forms.Label();

            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(KundeNrSvar);
            panel1.Controls.Add(KundeNrLabel);
            panel1.Controls.Add(VisKnap);
            panel1.Controls.Add(RedigereKnap);
            panel1.Controls.Add(KundeTypeSvar);
            panel1.Controls.Add(KundeTypeLabel);
            panel1.Controls.Add(KundeEmailSvar);
            panel1.Controls.Add(KundeEmailLabel);
            panel1.Controls.Add(KundeNavnSvar);
            panel1.Controls.Add(KundeNavnLabel);
            panel1.Location = new System.Drawing.Point(23, 24);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(354, 178);
            panel1.TabIndex = 1;
            // 
            // KundeNrSvar
            // 
            KundeNrSvar.AutoSize = true;
            KundeNrSvar.Location = new System.Drawing.Point(132, 25);
            KundeNrSvar.Name = "KundeNrSvar";
            KundeNrSvar.Size = new System.Drawing.Size(13, 15);
            KundeNrSvar.TabIndex = 11;
            KundeNrSvar.Text = "1";
            KundeNrSvar.Text = kunde.KundeNr.ToString();
            // 
            // KundeNrLabel
            // 
            KundeNrLabel.AutoSize = true;
            KundeNrLabel.Location = new System.Drawing.Point(21, 25);
            KundeNrLabel.Name = "KundeNrLabel";
            KundeNrLabel.Size = new System.Drawing.Size(54, 15);
            KundeNrLabel.TabIndex = 10;
            KundeNrLabel.Text = "KundeNr";
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
            VisKnap.Click += new System.EventHandler((object sender, EventArgs e) => VisKnap_Click(kunde.KundeNr));
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
            RedigereKnap.Click += new System.EventHandler((object sender, EventArgs e) => RedigereKnap_Click(kunde.KundeNr));
            // 
            // KundeTypeSvar
            // 
            KundeTypeSvar.AutoSize = true;
            KundeTypeSvar.Location = new System.Drawing.Point(132, 124);
            KundeTypeSvar.Name = "KundeTypeSvar";
            KundeTypeSvar.Size = new System.Drawing.Size(13, 15);
            KundeTypeSvar.TabIndex = 5;
            KundeTypeSvar.Text = "1";
            // 
            // KundeTypeLabel
            // 
            KundeTypeLabel.AutoSize = true;
            KundeTypeLabel.Location = new System.Drawing.Point(21, 124);
            KundeTypeLabel.Name = "KundeTypeLabel";
            KundeTypeLabel.Size = new System.Drawing.Size(31, 15);
            KundeTypeLabel.TabIndex = 4;
            KundeTypeLabel.Text = "Type";
            // 
            // KundeEmailSvar
            // 
            KundeEmailSvar.AutoSize = true;
            KundeEmailSvar.Location = new System.Drawing.Point(132, 93);
            KundeEmailSvar.Name = "KundeEmailSvar";
            KundeEmailSvar.Size = new System.Drawing.Size(13, 15);
            KundeEmailSvar.TabIndex = 3;
            KundeEmailSvar.Text = "1";
            // 
            // KundeEmailLabel
            // 
            KundeEmailLabel.AutoSize = true;
            KundeEmailLabel.Location = new System.Drawing.Point(21, 93);
            KundeEmailLabel.Name = "KundeEmailLabel";
            KundeEmailLabel.Size = new System.Drawing.Size(36, 15);
            KundeEmailLabel.TabIndex = 2;
            KundeEmailLabel.Text = "Email";
            // 
            // KundeNavnSvar
            // 
            KundeNavnSvar.AutoSize = true;
            KundeNavnSvar.Location = new System.Drawing.Point(132, 61);
            KundeNavnSvar.Name = "KundeNavnSvar";
            KundeNavnSvar.Size = new System.Drawing.Size(13, 15);
            KundeNavnSvar.TabIndex = 1;
            KundeNavnSvar.Text = "1";
            // 
            // KundeNavnLabel
            // 
            KundeNavnLabel.AutoSize = true;
            KundeNavnLabel.Location = new System.Drawing.Point(21, 61);
            KundeNavnLabel.Name = "KundeNavnLabel";
            KundeNavnLabel.Size = new System.Drawing.Size(35, 15);
            KundeNavnLabel.TabIndex = 0;
            KundeNavnLabel.Text = "Navn";

            flowLayoutPanel1.Controls.Add(panel1);
        }

        private void TilføjKnap_Click(object sender, EventArgs e)
        {
            baseform.ShowForm(new Kunder(Models.Action.create, baseform));
        }
    }
}
