using BoBedre.Core.DataAccess;
using BoBedre.Core.Models;
using BoBedre.Core.TextChecking;
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

        private async void GemButton_Click(object sender, EventArgs e)
        {
            if ((RegexCheck.TalCheck(GebyrTextBox.Text) || GebyrTextBox.Text == "") && (RegexCheck.TalCheck(SalærTextBox.Text) || SalærTextBox.Text == ""))
            {
                GetDates(out DateTime oprettelsesDato, out DateTime? tilSalgDato, out DateTime? overdragelsesDato, out DateTime? afslutningsDato);
                var sag = await Fetch.GetSagBySagNr(sagNr);
                await EntryManagement.UpdateSag(sagNr, oprettelsesDato, tilSalgDato, SolgtCheckBox.Checked, GebyrTextBox.Text == "" ? null : int.Parse(GebyrTextBox.Text), SalærTextBox.Text == "" ? null : int.Parse(SalærTextBox.Text), overdragelsesDato, afslutningsDato, sag.BoligNr, sag.SælgerNr, sag.KøberNr, sag.MedarbejderNr);
                baseform.ShowForm(new SagerView(baseform));
            }
            else
            {
                MessageBox.Show("Der er fejl i værdierne");
            }
        }

        private async void SletButton_Click(object sender, EventArgs e)
        {
            await EntryManagement.DeleteSag(sagNr);
            baseform.ShowForm(new SagerView(baseform));
        }

        private void LukButton_Click(object sender, EventArgs e)
        {
            baseform.ShowForm(new SagerView(baseform));
        }

        private async void VisTilKnytning(Type type, int id, string altName = null)
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
            TypeLabel.Text = altName == null ? $"Type: {type.Name}" : $"Type: {altName}";
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
            RedigerButton.Click += new EventHandler((object sender, EventArgs e) => RedigerButton_Click(id, type));
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
            VisButton.Click += new EventHandler((object sender, EventArgs e) => VisButton_Click(id, type));

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
                    "ByggeÅr: " + ejendom.Byggeår.ToString(), 
                    "Pris: " + ejendom.Pris.ToString() };
            }

            return output;
        }

        private void RedigerButton_Click(int id, Type type)
        {
            if(type == typeof(Kunde)){
                baseform.ShowForm(new Kunder.Kunder(Models.Action.edit, baseform, id));
            }else if (type == typeof(Ejendom))
            {
                baseform.ShowForm(new Ejendomme.Ejendomme(Models.Action.edit, baseform, id));
            }else if(type == typeof(Ejendomsmægler))
            {
                baseform.ShowForm(new Ejendomsmæglere.Ejendomsmæglere(Models.Action.edit, baseform, id));
            }
            
        }

        private void VisButton_Click(int id, Type type)
        {
            if (type == typeof(Kunde))
            {
                baseform.ShowForm(new Kunder.Kunder(Models.Action.view, baseform, id));
            }
            else if (type == typeof(Ejendom))
            {
                baseform.ShowForm(new Ejendomme.Ejendomme(Models.Action.view, baseform, id));
            }
            else if (type == typeof(Ejendomsmægler))
            {
                baseform.ShowForm(new Ejendomsmæglere.Ejendomsmæglere(Models.Action.view, baseform, id));
            }
        }

        private void VisTilkyntningsMulighed(Type type, string altName = null)
        {
            FlowLayoutPanel flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            Button AddButton = new System.Windows.Forms.Button();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(AddButton);
            flowLayoutPanel1.Location = new System.Drawing.Point(139, 83);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            flowLayoutPanel1.Size = new System.Drawing.Size(417, 105);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // AddButton
            // 
            AddButton.AutoSize = true;
            AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            AddButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            AddButton.Location = new System.Drawing.Point(40, 15);
            AddButton.Margin = new System.Windows.Forms.Padding(15);
            AddButton.Name = "AddButton";
            AddButton.Size = new System.Drawing.Size(148, 70);
            AddButton.TabIndex = 0;
            AddButton.Text = "Tilføj eksiterende " + (altName == null ? type.Name : altName);
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += new System.EventHandler((object sender, EventArgs e) => AddButton_Click(flowLayoutPanel1, type, altName));

            TilknytningerFlowLayoutPanel.Controls.Add(flowLayoutPanel1);
        }

        private async void AddButton_Click(FlowLayoutPanel panel, Type type, string altName = null)
        {
            var dialog = new SagerDialog(type, altName);
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                TilknytningerFlowLayoutPanel.Controls.Remove(panel);
                var sag = await Fetch.GetSagBySagNr(sagNr);
                var id = ((KeyValuePair<string, int>)dialog.comboBox1.SelectedItem).Value;
                if(type == typeof(Kunde) && altName == "Sælger")
                {
                    await EntryManagement.UpdateSag(sagNr, sag.OprettelsesDato, sag.TilSalgDato, sag.Solgt, sag.Gebyr, sag.Salær, sag.OverdragelsesDato, sag.AfslutningsDato, sag.BoligNr, id, sag.KøberNr, sag.MedarbejderNr);
                }
                else if(type == typeof(Kunde) && altName == "Køber")
                {
                    await EntryManagement.UpdateSag(sagNr, sag.OprettelsesDato, sag.TilSalgDato, sag.Solgt, sag.Gebyr, sag.Salær, sag.OverdragelsesDato, sag.AfslutningsDato, sag.BoligNr, sag.SælgerNr, id, sag.MedarbejderNr);
                }
                else if(type == typeof(Ejendomsmægler))
                {
                    await EntryManagement.UpdateSag(sagNr, sag.OprettelsesDato, sag.TilSalgDato, sag.Solgt, sag.Gebyr, sag.Salær, sag.OverdragelsesDato, sag.AfslutningsDato, sag.BoligNr, sag.SælgerNr, sag.KøberNr, id);
                }
                else if(type == typeof(Ejendom))
                {
                    await EntryManagement.UpdateSag(sagNr, sag.OprettelsesDato, sag.TilSalgDato, sag.Solgt, sag.Gebyr, sag.Salær, sag.OverdragelsesDato, sag.AfslutningsDato, id, sag.SælgerNr, sag.KøberNr, sag.MedarbejderNr);
                }

                VisTilKnytning(type, id);
            }

        }

        private void GetDates(out DateTime oprettelsesDato, out DateTime? tilSalgDato, out DateTime? overdragelsesDato, out DateTime? afslutningsDato)
        {
            var defaultValue = new DateTime(9998, 12, 31);
            oprettelsesDato = OprettelsesDato.Value;
            tilSalgDato = TilSalgDato.Value != defaultValue ? TilSalgDato.Value : null;
            overdragelsesDato = OverdragelsesDato.Value != defaultValue ? OverdragelsesDato.Value : null;
            afslutningsDato = AfsllutningsDato.Value != defaultValue ? AfsllutningsDato.Value : null;
        }

        private async void LoadData(Models.Action action)
        {
            var sag = await Fetch.GetSagBySagNr(sagNr);

            SagNrTextBox.Text = sag.SagNr.ToString();
            GebyrTextBox.Text = sag.Gebyr.ToString();
            SalærTextBox.Text = sag.Salær.ToString();

            OprettelsesDato.Value = sag.OprettelsesDato;
            if(sag.TilSalgDato != null)
            {
                TilSalgDato.Value = sag.TilSalgDato.GetValueOrDefault();
            }
            if(sag.OverdragelsesDato != null)
            {
                OverdragelsesDato.Value = sag.OverdragelsesDato.GetValueOrDefault();
            }
            if(sag.AfslutningsDato != null)
            {
                AfsllutningsDato.Value = sag.AfslutningsDato.GetValueOrDefault();
            }

            VisTilKnytning(typeof(Ejendomsmægler), sag.MedarbejderNr);

            if (sag.SælgerNr != null)
            {
                VisTilKnytning(typeof(Kunde), sag.SælgerNr.GetValueOrDefault(), "Sælger");
            }
            else if(action == Models.Action.edit)
            {
                VisTilkyntningsMulighed(typeof(Kunde), "Sælger");
            }

            if (sag.KøberNr != null)
            {
                VisTilKnytning(typeof(Kunde), sag.KøberNr.GetValueOrDefault(), "Køber");
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
                    OprettelsesDato.Enabled = false;
                    OverdragelsesDato.Enabled = false;
                    TilSalgDato.Enabled = false;
                    AfsllutningsDato.Enabled = false;
                    SolgtCheckBox.Enabled = false;
                    break;
            }

            LoadData(action);
        }
    }
}
