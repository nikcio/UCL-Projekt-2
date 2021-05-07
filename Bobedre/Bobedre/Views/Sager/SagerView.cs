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

        private void OpretSagButton_Click(object sender, EventArgs e)
        {

        }

        private void ShowSag()
        {
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
            panel1.Size = new System.Drawing.Size(185, 158);
            panel1.TabIndex = 0;
            // 
            // Sælger
            // 
            Sælger.AutoSize = true;
            Sælger.Location = new System.Drawing.Point(11, 69);
            Sælger.Name = "Sælger";
            Sælger.Size = new System.Drawing.Size(77, 15);
            Sælger.TabIndex = 2;
            Sælger.Text = "Navn: Sælger";
            // 
            // Medarbejder
            // 
            Medarbejder.AutoSize = true;
            Medarbejder.Location = new System.Drawing.Point(11, 39);
            Medarbejder.Name = "Medarbejder";
            Medarbejder.Size = new System.Drawing.Size(74, 15);
            Medarbejder.TabIndex = 1;
            Medarbejder.Text = "Medarbejder";
            // 
            // SagNr
            // 
            SagNr.AutoSize = true;
            SagNr.Location = new System.Drawing.Point(11, 11);
            SagNr.Name = "SagNr";
            SagNr.Size = new System.Drawing.Size(39, 15);
            SagNr.TabIndex = 0;
            SagNr.Text = "SagNr";
            // 
            // BoligNr
            // 
            BoligNr.AutoSize = true;
            BoligNr.Location = new System.Drawing.Point(103, 11);
            BoligNr.Name = "BoligNr";
            BoligNr.Size = new System.Drawing.Size(47, 15);
            BoligNr.TabIndex = 3;
            BoligNr.Text = "BoligNr";
            // 
            // OprrettelsesDato
            // 
            OprrettelsesDato.AutoSize = true;
            OprrettelsesDato.Location = new System.Drawing.Point(11, 125);
            OprrettelsesDato.Name = "OprrettelsesDato";
            OprrettelsesDato.Size = new System.Drawing.Size(32, 15);
            OprrettelsesDato.TabIndex = 4;
            OprrettelsesDato.Text = "Dato";
            // 
            // RedigerButton
            // 
            RedigerButton.Location = new System.Drawing.Point(11, 99);
            RedigerButton.Name = "RedigerButton";
            RedigerButton.Size = new System.Drawing.Size(75, 23);
            RedigerButton.TabIndex = 5;
            RedigerButton.Text = "Rediger";
            RedigerButton.UseVisualStyleBackColor = true;
            RedigerButton.Click += new EventHandler((object sender, EventArgs e) => RedigerButton_Click());
            // 
            // VisButton
            // 
            VisButton.Location = new System.Drawing.Point(92, 99);
            VisButton.Name = "VisButton";
            VisButton.Size = new System.Drawing.Size(75, 23);
            VisButton.TabIndex = 6;
            VisButton.Text = "Vis";
            VisButton.UseVisualStyleBackColor = true;
            VisButton.Click += new EventHandler((object sender, EventArgs e) => Visbutton_Click());
        }

        private void RedigerButton_Click()
        {

        }

        private void Visbutton_Click()
        {

        }

        private async void SagerView_Load(object sender, EventArgs e)
        {
            var ejendomsmæglere = await Fetch.GetEjendomsmæglerAll();

            MedarbjederComboBox.Items.AddRange(ejendomsmæglere.Select(item => item.Navn + " MedarbejderNr: " + item.MedarbejderNr).ToArray());
        }
    }
}
