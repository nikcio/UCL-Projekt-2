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

namespace Bobedre.Views.Ejendomsmæglere
{
    public partial class EjendomsmæglereView : Form
    {
        private Baseform baseform { get; set; }

        public EjendomsmæglereView(Baseform _Baseform)
        {
            InitializeComponent();
            baseform = _Baseform;

            LoadData();
        }

        private async void LoadData()
        {
          Ejendomsmægler[] ejendomsmæglere = await Fetch.GetEjendomsmæglerAll();

            foreach (var ejendomsmægler in ejendomsmæglere)
            {
                VisEjendomsmægler(ejendomsmægler);
            }
        } 
        private void Redigere_click(int medarbejderNr)
        {
            baseform.ShowForm(new Ejendomsmæglere(Models.Action.edit, baseform, medarbejderNr));          

        }
        private void VisKnap_Click(int medarbejderNr)
        {
            baseform.ShowForm(new Ejendomsmæglere(Models.Action.view, baseform, medarbejderNr));
        }

        private void VisEjendomsmægler(Ejendomsmægler ejendomsmægler) 
        {
            Panel panel1 = new System.Windows.Forms.Panel();
            Label MedarbejderNrSvar = new System.Windows.Forms.Label();
            Label MedarbejderNrLabel = new System.Windows.Forms.Label();
            Button VisKnap = new System.Windows.Forms.Button();
            Button RedigereKnap = new System.Windows.Forms.Button();
            Label EmailSvar = new System.Windows.Forms.Label();
            Label EmailLabel = new System.Windows.Forms.Label();
            Label NavnSvar = new System.Windows.Forms.Label();
            Label NavnLabel = new System.Windows.Forms.Label();
            Label Mæglerfirmasvar = new System.Windows.Forms.Label();
            Label MæglerFirmaLabel = new System.Windows.Forms.Label();
            Label AfdelingSvar = new System.Windows.Forms.Label();
            Label AfdelingLabel = new System.Windows.Forms.Label();

            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(MedarbejderNrSvar);
            panel1.Controls.Add(MedarbejderNrLabel);
            panel1.Controls.Add(VisKnap);
            panel1.Controls.Add(RedigereKnap);
            panel1.Controls.Add(EmailSvar);
            panel1.Controls.Add(EmailLabel);
            panel1.Controls.Add(NavnSvar);
            panel1.Controls.Add(NavnLabel);
            panel1.Controls.Add(Mæglerfirmasvar);
            panel1.Controls.Add(MæglerFirmaLabel);
            panel1.Controls.Add(AfdelingSvar);
            panel1.Controls.Add(AfdelingLabel);
            panel1.Location = new System.Drawing.Point(12, 23);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(377, 189);
            panel1.TabIndex = 0;
            // 
            // MedarbejderNrSvar
            // 
            MedarbejderNrSvar.AutoSize = true;
            MedarbejderNrSvar.Location = new System.Drawing.Point(132, 25);
            MedarbejderNrSvar.Name = "MedarbejderNrSvar";
            MedarbejderNrSvar.Size = new System.Drawing.Size(13, 15);
            MedarbejderNrSvar.TabIndex = 11;
            MedarbejderNrSvar.Text = ejendomsmægler.MedarbejderNr.ToString();
            // 
            // MedarbejderNrLabel
            // 
            MedarbejderNrLabel.AutoSize = true;
            MedarbejderNrLabel.Location = new System.Drawing.Point(21, 25);
            MedarbejderNrLabel.Name = "MedarbejderNrLabel";
            MedarbejderNrLabel.Size = new System.Drawing.Size(87, 15);
            MedarbejderNrLabel.TabIndex = 10;
            MedarbejderNrLabel.Text = "MedarbejderNr";
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
            VisKnap.Click += new System.EventHandler((object sender, EventArgs e) => VisKnap_Click(ejendomsmægler.MedarbejderNr));
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
            RedigereKnap.Click += new System.EventHandler((object sender, EventArgs e) => Redigere_click(ejendomsmægler.MedarbejderNr));
            // 
            // EmailSvar
            // 
            EmailSvar.AutoSize = true;
            EmailSvar.Location = new System.Drawing.Point(132, 155);
            EmailSvar.Name = "EmailSvar";
            EmailSvar.Size = new System.Drawing.Size(13, 15);
            EmailSvar.TabIndex = 7;
            EmailSvar.Text = ejendomsmægler.Email.ToString();
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new System.Drawing.Point(21, 155);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new System.Drawing.Size(36, 15);
            EmailLabel.TabIndex = 6;
            EmailLabel.Text = "Email";
            // 
            // NavnSvar
            // 
            NavnSvar.AutoSize = true;
            NavnSvar.Location = new System.Drawing.Point(132, 124);
            NavnSvar.Name = "NavnSvar";
            NavnSvar.Size = new System.Drawing.Size(13, 15);
            NavnSvar.TabIndex = 5;
            NavnSvar.Text = ejendomsmægler.Navn.ToString();
            // 
            // NavnLabel
            // 
            NavnLabel.AutoSize = true;
            NavnLabel.Location = new System.Drawing.Point(21, 124);
            NavnLabel.Name = "NavnLabel";
            NavnLabel.Size = new System.Drawing.Size(35, 15);
            NavnLabel.TabIndex = 4;
            NavnLabel.Text = "Navn";
            // 
            // Mæglerfirmasvar
            // 
            Mæglerfirmasvar.AutoSize = true;
            Mæglerfirmasvar.Location = new System.Drawing.Point(132, 93);
            Mæglerfirmasvar.Name = "Mæglerfirmasvar";
            Mæglerfirmasvar.Size = new System.Drawing.Size(13, 15);
            Mæglerfirmasvar.TabIndex = 3;
            Mæglerfirmasvar.Text = ejendomsmægler.Mæglerfirma.ToString();
            // 
            // MæglerFirmaLabel
            // 
            MæglerFirmaLabel.AutoSize = true;
            MæglerFirmaLabel.Location = new System.Drawing.Point(21, 93);
            MæglerFirmaLabel.Name = "MæglerFirmaLabel";
            MæglerFirmaLabel.Size = new System.Drawing.Size(78, 15);
            MæglerFirmaLabel.TabIndex = 2;
            MæglerFirmaLabel.Text = "MæglerFirma";
            // 
            // AfdelingSvar
            // 
            AfdelingSvar.AutoSize = true;
            AfdelingSvar.Location = new System.Drawing.Point(132, 61);
            AfdelingSvar.Name = "AfdelingSvar";
            AfdelingSvar.Size = new System.Drawing.Size(13, 15);
            AfdelingSvar.TabIndex = 1;
            AfdelingSvar.Text = ejendomsmægler.Afdeling.ToString() ;
            // 
            // AfdelingLabel
            // 
            AfdelingLabel.AutoSize = true;
            AfdelingLabel.Location = new System.Drawing.Point(21, 61);
            AfdelingLabel.Name = "AfdelingLabel";
            AfdelingLabel.Size = new System.Drawing.Size(52, 15);
            AfdelingLabel.TabIndex = 0;
            AfdelingLabel.Text = "Afdeling";
            

            flowLayoutPanel1.Controls.Add(panel1);
        }
      
       

    }
}
