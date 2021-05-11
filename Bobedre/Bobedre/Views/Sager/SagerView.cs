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
    public partial class SagerView : Form
    {
        public Baseform baseform { get; set; }
        public SagerView(Baseform _baseform)
        {
            InitializeComponent();

            baseform = _baseform;
        }

        private async void OpretSagButton_Click(object sender, EventArgs e)
        {
            if(MedarbjederComboBox.SelectedItem == null)
            {
                MessageBox.Show("Vælg en medarbejder først");
            }
            else
            {
                var sagNr = await EntryManagement.CreateSag(DateTime.Now, ((KeyValuePair<string, int>)MedarbjederComboBox.SelectedItem).Value);
                baseform.ShowForm(new Sager(Models.Action.edit, baseform, sagNr));
            }
        }

        private async void ShowSag(Sag sag)
        {
            // Get info:
            var sælger = await Fetch.GetKundeByKundeNr(sag.SælgerNr.GetValueOrDefault());
            var medarbejder = await Fetch.GetEjendomsmæglerByMedarbjederNr(sag.MedarbejderNr);
            

            Panel panel1 = new System.Windows.Forms.Panel();
            Label Sælger = new System.Windows.Forms.Label();
            Label Medarbejder = new System.Windows.Forms.Label();
            Label SagNr = new System.Windows.Forms.Label();
            Label BoligNr = new System.Windows.Forms.Label();
            Label OprrettelsesDato = new System.Windows.Forms.Label();
            Button RedigerButton = new System.Windows.Forms.Button();
            Button VisButton = new System.Windows.Forms.Button();
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(VisButton);
            panel1.Controls.Add(RedigerButton);
            panel1.Controls.Add(OprrettelsesDato);
            panel1.Controls.Add(BoligNr);
            panel1.Controls.Add(Sælger);
            panel1.Controls.Add(Medarbejder);
            panel1.Controls.Add(SagNr);
            panel1.Location = new System.Drawing.Point(29, 31);
            panel1.Margin = new System.Windows.Forms.Padding(10);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(225, 188);
            panel1.TabIndex = 0;
            // 
            // Sælger
            // 
            Sælger.AutoSize = true;
            Sælger.Location = new System.Drawing.Point(11, 79);
            Sælger.Name = "Sælger";
            Sælger.Size = new System.Drawing.Size(77, 15);
            Sælger.TabIndex = 2;
            Sælger.Text = sælger != null ? $"{sælger.Navn} (Sælger)" : "";
            // 
            // Medarbejder
            // 
            Medarbejder.AutoSize = true;
            Medarbejder.Location = new System.Drawing.Point(11, 49);
            Medarbejder.Name = "Medarbejder";
            Medarbejder.Size = new System.Drawing.Size(74, 15);
            Medarbejder.TabIndex = 1;
            Medarbejder.Text = $"Medarbejder: {medarbejder.Navn}";
            // 
            // SagNr
            // 
            SagNr.AutoSize = true;
            SagNr.Location = new System.Drawing.Point(11, 11);
            SagNr.Name = "SagNr";
            SagNr.Size = new System.Drawing.Size(39, 15);
            SagNr.TabIndex = 0;
            SagNr.Text = $"SagNr: {sag.SagNr}";
            // 
            // BoligNr
            // 
            BoligNr.AutoSize = true;
            BoligNr.Location = new System.Drawing.Point(123, 11);
            BoligNr.Name = "BoligNr";
            BoligNr.Size = new System.Drawing.Size(47, 15);
            BoligNr.TabIndex = 3;
            BoligNr.Text = sag.BoligNr != null ? $"BoligNr: {sag.BoligNr}" : "";
            // 
            // OprrettelsesDato
            // 
            OprrettelsesDato.AutoSize = true;
            OprrettelsesDato.Location = new System.Drawing.Point(11, 155);
            OprrettelsesDato.Name = "OprrettelsesDato";
            OprrettelsesDato.Size = new System.Drawing.Size(32, 15);
            OprrettelsesDato.TabIndex = 4;
            OprrettelsesDato.Text = $"Dato: {sag.OprettelsesDato.ToShortDateString()}";
            // 
            // RedigerButton
            // 
            RedigerButton.FlatStyle = FlatStyle.Flat;
            RedigerButton.AutoSize = true;
            RedigerButton.Location = new System.Drawing.Point(11, 109);
            RedigerButton.Name = "RedigerButton";
            RedigerButton.Size = new System.Drawing.Size(75, 23);
            RedigerButton.TabIndex = 5;
            RedigerButton.Text = "Rediger";
            RedigerButton.UseVisualStyleBackColor = true;
            RedigerButton.Click += new EventHandler((object sender, EventArgs e) => RedigerButton_Click(sag.SagNr));
            // 
            // VisButton
            // 
            VisButton.FlatStyle = FlatStyle.Flat;
            VisButton.AutoSize = true;
            VisButton.Location = new System.Drawing.Point(92, 109);
            VisButton.Name = "VisButton";
            VisButton.Size = new System.Drawing.Size(75, 23);
            VisButton.TabIndex = 6;
            VisButton.Text = "Vis";
            VisButton.UseVisualStyleBackColor = true;
            VisButton.Click += new EventHandler((object sender, EventArgs e) => Visbutton_Click(sag.SagNr));

            flowLayoutPanel1.Controls.Add(panel1);
        }

        private void RedigerButton_Click(int sagNr)
        {
            baseform.ShowForm(new Sager(Models.Action.edit, baseform, sagNr));
        }

        private void Visbutton_Click(int sagNr)
        {
            baseform.ShowForm(new Sager(Models.Action.view, baseform, sagNr));
        }

        private async void SagerView_Load(object sender, EventArgs e)
        {
            var ejendomsmæglere = await Fetch.GetEjendomsmæglerAll();

            Dictionary<string, int> values = ejendomsmæglere.ToDictionary(item => "Navn: " + item.Navn + " Nr: " + item.MedarbejderNr, item => item.MedarbejderNr);

            MedarbjederComboBox.DataSource = values.ToList();
            MedarbjederComboBox.ValueMember = "Key";
            MedarbjederComboBox.SelectedText = "Value";
            MedarbjederComboBox.SelectedIndex = 0;

            var sager = await Fetch.GetSagAll();

            foreach(var sag in sager)
            {
                ShowSag(sag);
            }
        }
    }
}
