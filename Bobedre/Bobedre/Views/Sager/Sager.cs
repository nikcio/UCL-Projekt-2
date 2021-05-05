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

namespace Bobedre.Views.Sager
{
    public partial class Sager : Form
    {
        private Baseform baseform { get; set; }
        private Models.Action action { get; set; }
        private int sagNr { get; set; }

        public Sager(Models.Action _action, Baseform _baseform, int _sagNr)
        {
            InitializeComponent();

            baseform = _baseform;
            action = _action;
            sagNr = _sagNr;
        }

        private void GemButton_Click(object sender, EventArgs e)
        {
            
        }

        private void SletButton_Click(object sender, EventArgs e)
        {

        }

        private void LukButton_Click(object sender, EventArgs e)
        {
            baseform.ShowForm(new SagerView(baseform));
        }

        private async void VisTilKnytning(Type type, int id)
        {
            var data = await GetData(type, id);

            Panel panel1 = new System.Windows.Forms.Panel();
            Label TypeLabel = new System.Windows.Forms.Label();
            Label NrLabel = new System.Windows.Forms.Label();
            Label AttriLabel1 = new System.Windows.Forms.Label();
            Label label1 = new System.Windows.Forms.Label();
            Label label2 = new System.Windows.Forms.Label();
            Button RedigerButton = new System.Windows.Forms.Button();
            Label label3 = new System.Windows.Forms.Label();
            Button VisButton = new System.Windows.Forms.Button();
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(VisButton);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(RedigerButton);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(AttriLabel1);
            panel1.Controls.Add(NrLabel);
            panel1.Controls.Add(TypeLabel);
            panel1.Location = new System.Drawing.Point(174, 114);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(417, 105);
            panel1.TabIndex = 0;
            // 
            // TypeLabel
            // 
            TypeLabel.AutoSize = true;
            TypeLabel.Location = new System.Drawing.Point(15, 16);
            TypeLabel.Name = "TypeLabel";
            TypeLabel.Size = new System.Drawing.Size(73, 15);
            TypeLabel.TabIndex = 0;
            TypeLabel.Text = "Type: Sælger";
            // 
            // NrLabel
            // 
            NrLabel.AutoSize = true;
            NrLabel.Location = new System.Drawing.Point(15, 45);
            NrLabel.Name = "NrLabel";
            NrLabel.Size = new System.Drawing.Size(29, 15);
            NrLabel.TabIndex = 1;
            NrLabel.Text = data[0];
            // 
            // AttriLabel1
            // 
            AttriLabel1.AutoSize = true;
            AttriLabel1.Location = new System.Drawing.Point(145, 16);
            AttriLabel1.Name = "AttriLabel1";
            AttriLabel1.Size = new System.Drawing.Size(28, 15);
            AttriLabel1.TabIndex = 2;
            AttriLabel1.Text = data.Length > 1 ? data[1] : "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(145, 45);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(28, 15);
            label1.TabIndex = 3;
            label1.Text = data.Length > 2 ? data[2] : "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(277, 16);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(28, 15);
            label2.TabIndex = 4;
            label2.Text = data.Length > 3 ? data[3] : "";
            // 
            // RedigerButton
            // 
            RedigerButton.AutoSize = true;
            RedigerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            RedigerButton.Location = new System.Drawing.Point(15, 68);
            RedigerButton.Name = "RedigerButton";
            RedigerButton.Size = new System.Drawing.Size(75, 27);
            RedigerButton.TabIndex = 5;
            RedigerButton.Text = "Rediger";
            RedigerButton.UseVisualStyleBackColor = true;
            RedigerButton.Click += new EventHandler((object sender, EventArgs e) => RedigerButton_Click());
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(277, 45);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(28, 15);
            label3.TabIndex = 6;
            label3.Text = data.Length > 4 ? data[4] : "";
            // 
            // VisButton
            // 
            VisButton.AutoSize = true;
            VisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            VisButton.Location = new System.Drawing.Point(98, 68);
            VisButton.Name = "VisButton";
            VisButton.Size = new System.Drawing.Size(75, 27);
            VisButton.TabIndex = 7;
            VisButton.Text = "Vis";
            VisButton.UseVisualStyleBackColor = true;
            VisButton.Click += new EventHandler((object sender, EventArgs e) => VisButton_Click());

            TilknytningerFlowLayoutPanel.Controls.Add(panel1);
        }

        private async Task<string[]> GetData(Type type, int id)
        {
            string[] output = new string[0];
            if (type == typeof(Kunde))
            {
                var kunde = await Fetch.GetKundeByKundeNr(id);
                output = new string[]{ 
                    "KundeNr: " + kunde.KundeNr.ToString(), 
                    "Navn: " + kunde.Navn, 
                    "Email: " + kunde.Email };
                
            }else if(type == typeof(Ejendomsmægler))
            {
                var ejendomsmægler = await Fetch.GetEjendomsmæglerByMedarbjederNr(id);
                output = new string[] { 
                    "MedarbejderNr: " + ejendomsmægler.MedarbejderNr.ToString(), 
                    "Email: " + ejendomsmægler.Navn, ejendomsmægler.Email, 
                    "MæglerFirma: " + ejendomsmægler.Mæglerfirma, 
                    "Afdeling: " + ejendomsmægler.Afdeling };
            }else if(type == typeof(Ejendom))
            {
                var ejendom = await Fetch.GetEjendomByBoligNr(id);
                output = new string[] { 
                    "BoligNr: " + ejendom.BoligNr.ToString(), 
                    "Adresse: " + ejendom.Adresse, 
                    "BoligAreal: " + ejendom.BoligAreal.ToString(), 
                    "ByggeÅr" + ejendom.Byggeår.ToString(), 
                    "Pris: " + ejendom.Pris.ToString() };
            }

            return output;
        }

        private void RedigerButton_Click()
        {

        }

        private void VisButton_Click()
        {

        }

        private void VisTilkyntningsMulighed(Type type, string altName = null)
        {
            FlowLayoutPanel flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            Button AddButton = new System.Windows.Forms.Button();
            Button OpretButton = new System.Windows.Forms.Button();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(AddButton);
            flowLayoutPanel1.Controls.Add(OpretButton);
            flowLayoutPanel1.Location = new System.Drawing.Point(139, 83);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            flowLayoutPanel1.Size = new System.Drawing.Size(417, 105);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // AddButton
            // 
            AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            AddButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            AddButton.Location = new System.Drawing.Point(40, 15);
            AddButton.Margin = new System.Windows.Forms.Padding(15);
            AddButton.Name = "AddButton";
            AddButton.Size = new System.Drawing.Size(148, 70);
            AddButton.TabIndex = 0;
            AddButton.Text = "Tilføj eksiterende " + (altName == null ? type.Name : altName);
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += new System.EventHandler((object sender, EventArgs e) => AddButton_Click());
            // 
            // OpretButton
            // 
            OpretButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            OpretButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            OpretButton.Location = new System.Drawing.Point(218, 15);
            OpretButton.Margin = new System.Windows.Forms.Padding(15);
            OpretButton.Name = "OpretButton";
            OpretButton.Size = new System.Drawing.Size(148, 70);
            OpretButton.TabIndex = 1;
            OpretButton.Text = "Opret ny " + (altName == null ? type.Name : altName);
            OpretButton.UseVisualStyleBackColor = true;
            OpretButton.Click += new System.EventHandler((object sender, EventArgs e) => OpretButton_Click());

            TilknytningerFlowLayoutPanel.Controls.Add(flowLayoutPanel1);
        }

        private void OpretButton_Click()
        {

        }

        private void AddButton_Click()
        {

        }

        private async void LoadData(Models.Action action)
        {
            var sag = await Fetch.GetSagBySagNr(sagNr);

            SagNrTextBox.Text = sag.SagNr.ToString();
            GebyrTextBox.Text = sag.Gebyr.ToString();
            SalærTextBox.Text = sag.Salær.ToString();

            VisTilKnytning(typeof(Ejendomsmægler), sag.MedarbejderNr);

            if (sag.SælgerNr != null)
            {
                VisTilKnytning(typeof(Kunde), sag.SælgerNr.GetValueOrDefault());
            }
            else if(action == Models.Action.edit)
            {
                VisTilkyntningsMulighed(typeof(Kunde), "Sælger");
            }

            if (sag.KøberNr != null)
            {
                VisTilKnytning(typeof(Kunde), sag.KøberNr.GetValueOrDefault());
            }
            else if (action == Models.Action.edit)
            {
                VisTilkyntningsMulighed(typeof(Kunde), "Køber");
            }

            if (sag.BoligNr != null)
            {
                VisTilKnytning(typeof(Ejendom), sag.BoligNr.GetValueOrDefault());
            }
            else if (action == Models.Action.edit)
            {
                VisTilkyntningsMulighed(typeof(Ejendom));
            }
        }

        private void Sager_Load(object sender, EventArgs e)
        {
            switch (action)
            {
                case Models.Action.edit:
                    SletButton.Visible = false;
                    break;

                case Models.Action.view:
                    GebyrTextBox.Enabled = false;
                    SalærTextBox.Enabled = false;
                    GemButton.Visible = false;
                    break;
            }

            LoadData(action);
        }
    }
}
