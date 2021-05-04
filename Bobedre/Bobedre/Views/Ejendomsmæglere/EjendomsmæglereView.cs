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
                M1(ejendomsmægler);
            }
        } 
        private void button1_Click(int medarbejderNr)
        {
            baseform.ShowForm(new Ejendomsmæglere(Models.Action.edit, baseform, medarbejderNr));
            
             

        }
    
        private void M1(Ejendomsmægler ejendomsmægler) 
        {
            Panel panel1 = new System.Windows.Forms.Panel();
            Label Mæglerfirmasvar = new System.Windows.Forms.Label();
            Label MæglerFirmaLabel = new System.Windows.Forms.Label();
            Label AfdelingSvar = new System.Windows.Forms.Label();
            Label AfdelingLabel = new System.Windows.Forms.Label();
            Label NavnSvar = new System.Windows.Forms.Label();
            Label NavnLabel = new System.Windows.Forms.Label();
            Label EmailSvar = new System.Windows.Forms.Label();
            Label EmailLabel = new System.Windows.Forms.Label();
            Button  RedigereKnap = new System.Windows.Forms.Button();
          
            // 
            // panel1
            // 
            panel1.Controls.Add(RedigereKnap);
            panel1.Controls.Add(EmailSvar);
            panel1.Controls.Add(EmailLabel);
            panel1.Controls.Add(NavnSvar);
            panel1.Controls.Add(NavnLabel);
            panel1.Controls.Add(Mæglerfirmasvar);
            panel1.Controls.Add(MæglerFirmaLabel);
            panel1.Controls.Add(AfdelingSvar);
            panel1.Controls.Add(AfdelingLabel);
            panel1.Location = new System.Drawing.Point(44, 38);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(360, 144);
            panel1.TabIndex = 0;
            // 
            // Mæglerfirmasvar
            // 
            Mæglerfirmasvar.AutoSize = true;
            Mæglerfirmasvar.Location = new System.Drawing.Point(123, 45);
            Mæglerfirmasvar.Name = "Mæglerfirmasvar";
            Mæglerfirmasvar.Size = new System.Drawing.Size(13, 15);
            Mæglerfirmasvar.TabIndex = 3;
            Mæglerfirmasvar.Text = ejendomsmægler.Mæglerfirma.ToString();
            
            // 
            // MæglerFirmaLabel
            // 
            MæglerFirmaLabel.AutoSize = true;
            MæglerFirmaLabel.Location = new System.Drawing.Point(12, 45);
            MæglerFirmaLabel.Name = "MæglerFirmaLabel";
            MæglerFirmaLabel.Size = new System.Drawing.Size(78, 15);
            MæglerFirmaLabel.TabIndex = 2;
            MæglerFirmaLabel.Text = "MæglerFirma";
            // 
            // AfdelingSvar
            // 
            AfdelingSvar.AutoSize = true;
            AfdelingSvar.Location = new System.Drawing.Point(123, 13);
            AfdelingSvar.Name = "AfdelingSvar";
            AfdelingSvar.Size = new System.Drawing.Size(13, 15);
            AfdelingSvar.TabIndex = 1;
            AfdelingSvar.Text = ejendomsmægler.Afdeling.ToString();
            // 
            // AfdelingLabel
            // 
            AfdelingLabel.AutoSize = true;
            AfdelingLabel.Location = new System.Drawing.Point(12, 13);
            AfdelingLabel.Name = "AfdelingLabel";
            AfdelingLabel.Size = new System.Drawing.Size(52, 15);
            AfdelingLabel.TabIndex = 0;
            AfdelingLabel.Text = "Afdeling";
            // 
            // NavnSvar
            // 
            NavnSvar.AutoSize = true;
            NavnSvar.Location = new System.Drawing.Point(123, 76);
            NavnSvar.Name = "NavnSvar";
            NavnSvar.Size = new System.Drawing.Size(13, 15);
            NavnSvar.TabIndex = 5;
            NavnSvar.Text = ejendomsmægler.Navn.ToString();
            // 
            // NavnLabel
            // 
            NavnLabel.AutoSize = true;
            NavnLabel.Location = new System.Drawing.Point(12, 76);
            NavnLabel.Name = "NavnLabel";
            NavnLabel.Size = new System.Drawing.Size(35, 15);
            NavnLabel.TabIndex = 4;
            NavnLabel.Text = "Navn";
            // 
            // EmailSvar
            // 
            EmailSvar.AutoSize = true;
            EmailSvar.Location = new System.Drawing.Point(123, 107);
            EmailSvar.Name = "EmailSvar";
            EmailSvar.Size = new System.Drawing.Size(13, 15);
            EmailSvar.TabIndex = 7;
            EmailSvar.Text = ejendomsmægler.Email.ToString();
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new System.Drawing.Point(12, 107);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new System.Drawing.Size(36, 15);
            EmailLabel.TabIndex = 6;
            EmailLabel.Text = "Email";
            // 
            // RedigereKnap
            // 
            RedigereKnap.Location = new System.Drawing.Point(245, 13);
            RedigereKnap.Name = "RedigereKnap";
            RedigereKnap.Size = new System.Drawing.Size(75, 23);
            RedigereKnap.TabIndex = 8;
            RedigereKnap.Text = "Redigere";
            RedigereKnap.UseVisualStyleBackColor = true;
            RedigereKnap.Click += new System.EventHandler((object sender, EventArgs e) => button1_Click(ejendomsmægler.MedarbejderNr));

            flowLayoutPanel1.Controls.Add(panel1);
        }

        
    }
}
