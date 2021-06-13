using Bobedre.Utility;
using BoBedre.Core.DataAccess;
using BoBedre.Core.TextChecking;
using BoBedre.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BoBedre.Core.Models;
using Bobedre.Models;
using BoBedre.Core.Logic;

namespace Bobedre.Views.Ejendomme
{
    public partial class Ejendomme : Form
    {
        private Baseform baseform { get; set; }

        private Models.Action action { get; set; }

        private int boligNr { get; set; }

        public Ejendomme(Models.Action _action, Baseform _baseform, int _boligNr = -1)
        {
            InitializeComponent();

            baseform = _baseform;

            boligNr = _boligNr;
            action = _action;

        }

        public async void LoadData(int boligNr)
        {
            if(boligNr < 0)
            {
                throw new ArgumentOutOfRangeException("boligNr", "boligNr can not be under 0");
            }

            var ejendom = await Fetch.GetEjendomByBoligNr(boligNr);

            BolignrTextbox.Text = ejendom.BoligNr.ToString();
            AdresseBolig.Text = ejendom.Adresse;
            PrisTextBox.Text = ejendom.Pris.ToString();
            BoligArealTextBox.Text = ejendom.BoligAreal.ToString();
            GrundArealBoligTextBox.Text = ejendom.GrundAreal.ToString();
            HaveCheckBox.Checked = ejendom.Have;
            VæreslerBoligTextBox.Text = ejendom.Værelser.ToString();
            EtagerBoligTextbox.Text = ejendom.Etager.ToString();
            TypeComboBox.SelectedItem = ejendom.Type;
            ByggeårBoligTextBox.Text = ejendom.Byggeår.ToString();
            PostNrTextBox.Text = ejendom.PostNr.ToString();

            // Load renorveringer:
            var renorveringer = await Fetch.GetRenorveringerByBoligNr(ejendom.BoligNr);

            foreach(var renorvering in renorveringer)
            {
                ShowRenorvering(renorvering);
            }
        }

        private async void OpretBoligKnap_Click(object sender, EventArgs e)
        {
            if ((RegexCheck.TalCheck(PrisTextBox.Text) && RegexCheck.TalCheck(BoligArealTextBox.Text) && RegexCheck.TalCheck(GrundArealBoligTextBox.Text)
             && RegexCheck.TalCheck(VæreslerBoligTextBox.Text) && RegexCheck.TextCheck(TypeComboBox.SelectedItem.ToString()) && RegexCheck.TalCheck(ByggeårBoligTextBox.Text)))
            {
                var boligNr = await EntryManagement.CreateEjendom(
                        AdresseBolig.Text,
                        int.Parse(PrisTextBox.Text),
                        int.Parse(BoligArealTextBox.Text),
                        int.Parse(GrundArealBoligTextBox.Text),
                        HaveCheckBox.Checked,
                        int.Parse(VæreslerBoligTextBox.Text),
                        int.Parse(EtagerBoligTextbox.Text),
                        TypeComboBox.SelectedItem.ToString(),
                        int.Parse(ByggeårBoligTextBox.Text),
                        int.Parse(PostNrTextBox.Text));
                MessageBox.Show("Boligen er nu gemt");
                baseform.ShowForm(new Ejendomme(Models.Action.edit, baseform, boligNr));
            }
            else
            {
                MessageBox.Show("Boligen er ikke blevet gemt, forkert indtastning");
            }
        }

        private async void SletButtonBolig_Click(object sender, EventArgs e)
        {
            if (int.TryParse(BolignrTextbox.Text, out int Bolignr))
            {
                await EntryManagement.DeleteEjendom(Bolignr);

                ClearForm.CleanForm(Controls);
                MessageBox.Show("Ejendom er blevet slettet");
                baseform.ShowForm(new EjendommeView(baseform));

            }
            else
            {
                MessageBox.Show("Fejl boligNr skal være et Nr");
            }
        }

        private async void OpdaterBoligKnap_Click(object sender, EventArgs e)
        {
            if (RegexCheck.TalCheck(BolignrTextbox.Text) && RegexCheck.TalCheck(PrisTextBox.Text) && RegexCheck.TalCheck(BoligArealTextBox.Text) && RegexCheck.TalCheck(GrundArealBoligTextBox.Text) && (HaveCheckBox.Checked)
             && RegexCheck.TalCheck(VæreslerBoligTextBox.Text) && RegexCheck.TextCheck(TypeComboBox.SelectedItem.ToString()) && RegexCheck.TalCheck(ByggeårBoligTextBox.Text))
            {
                await EntryManagement.OpdaterEjendom(
                AdresseBolig.Text,
                int.Parse(PrisTextBox.Text),
                int.Parse(BoligArealTextBox.Text),
                int.Parse(GrundArealBoligTextBox.Text),
                HaveCheckBox.Checked,
                int.Parse(VæreslerBoligTextBox.Text),
                int.Parse(EtagerBoligTextbox.Text),
                TypeComboBox.SelectedItem.ToString(),
                int.Parse(ByggeårBoligTextBox.Text),
                int.Parse(PostNrTextBox.Text),
                int.Parse(BolignrTextbox.Text));
                


                MessageBox.Show("Boligens oplysninger er nu opdateret");
            }
            else
            {
                MessageBox.Show("Boligens oplysninger blev ikke opdateret pga. forkerte oplysninger");
            }
        }

        private void AddRenorveringButton_Click(object sender, EventArgs e)
        {
            if (RegexCheck.TalCheck(BolignrTextbox.Text))
            {
                var boligNr = int.Parse(BolignrTextbox.Text);
                baseform.ShowForm(new Renorvering.Renorvering(Models.Action.create, baseform, new Ejendomme(Models.Action.edit, baseform, boligNr), -1, boligNr));
            }
        }

        private void ShowRenorvering(BoBedre.Core.Models.Renorvering renorvering)
        {
            Panel ItemPanel = new System.Windows.Forms.Panel();
            Button SletButton = new System.Windows.Forms.Button();
            Button RedigerButton = new System.Windows.Forms.Button();
            Label RenorveringsId = new System.Windows.Forms.Label();
            Label OmbygningsÅr = new System.Windows.Forms.Label();
            CheckBox KøkkenCheckBox = new System.Windows.Forms.CheckBox();
            FlowLayoutPanel Checkboxes = new System.Windows.Forms.FlowLayoutPanel();
            CheckBox BadeværelseCheckBox = new System.Windows.Forms.CheckBox();
            CheckBox AndetCheckBox = new System.Windows.Forms.CheckBox();
            Button OpretButton = new System.Windows.Forms.Button();
            // 
            // ItemPanel
            // 
            ItemPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            ItemPanel.Controls.Add(OmbygningsÅr);
            ItemPanel.Controls.Add(RenorveringsId);
            ItemPanel.Controls.Add(RedigerButton);
            ItemPanel.Controls.Add(SletButton);
            ItemPanel.Controls.Add(Checkboxes);
            ItemPanel.Location = new System.Drawing.Point(12, 12);
            ItemPanel.Name = "ItemPanel";
            ItemPanel.Size = new System.Drawing.Size(373, 125);
            ItemPanel.TabIndex = 0;
            // 
            // OpretButton
            // 
            OpretButton.Location = new System.Drawing.Point(149, 68);
            OpretButton.Name = "OpretButton";
            OpretButton.Size = new System.Drawing.Size(78, 23);
            OpretButton.TabIndex = 12;
            OpretButton.Text = "Opret";
            OpretButton.UseVisualStyleBackColor = true;
            OpretButton.Click += new System.EventHandler((object sender, EventArgs e) => OpretButton_Click(renorvering.RenorveringsId));
            // 
            // SletButton
            // 
            SletButton.AutoSize = true;
            SletButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            SletButton.Location = new System.Drawing.Point(265, 82);
            SletButton.Name = "SletButton";
            SletButton.Size = new System.Drawing.Size(94, 29);
            SletButton.TabIndex = 0;
            SletButton.Text = "Slet";
            SletButton.UseVisualStyleBackColor = true;
            SletButton.Click += new System.EventHandler((object sender, EventArgs e) => SletButton_Click(renorvering.RenorveringsId));
            // 
            // RedigerButton
            // 
            RedigerButton.AutoSize = true;
            RedigerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            RedigerButton.Location = new System.Drawing.Point(165, 82);
            RedigerButton.Name = "RedigerButton";
            RedigerButton.Size = new System.Drawing.Size(94, 29);
            RedigerButton.TabIndex = 1;
            RedigerButton.Text = "Rediger";
            RedigerButton.UseVisualStyleBackColor = true;
            RedigerButton.Click += new System.EventHandler((object sender, EventArgs e) => RedigerButton_Click(renorvering.RenorveringsId));
            // 
            // RenorveringsId
            // 
            RenorveringsId.AutoSize = true;
            RenorveringsId.Location = new System.Drawing.Point(9, 13);
            RenorveringsId.Name = "RenorveringsId";
            RenorveringsId.Size = new System.Drawing.Size(37, 20);
            RenorveringsId.TabIndex = 2;
            RenorveringsId.Text = $"Id: {renorvering.RenorveringsId}";
            // 
            // OmbygningsÅr
            // 
            OmbygningsÅr.AutoSize = true;
            OmbygningsÅr.Location = new System.Drawing.Point(9, 37);
            OmbygningsÅr.Name = "OmbygningsÅr";
            OmbygningsÅr.Size = new System.Drawing.Size(63, 20);
            OmbygningsÅr.TabIndex = 3;
            OmbygningsÅr.Text = $"OmbygningsÅr: {renorvering.Ombygningsår}";
            // 
            // KøkkenCheckBox
            // 
            KøkkenCheckBox.AutoSize = true;
            KøkkenCheckBox.Enabled = false;
            KøkkenCheckBox.Location = new System.Drawing.Point(199, 3);
            KøkkenCheckBox.Name = "KøkkenCheckBox";
            KøkkenCheckBox.Size = new System.Drawing.Size(79, 24);
            KøkkenCheckBox.TabIndex = 4;
            KøkkenCheckBox.Text = "Køkken";
            KøkkenCheckBox.Checked = renorvering.Køkken;
            KøkkenCheckBox.UseVisualStyleBackColor = true;
            // 
            // Checkboxes
            // 
            Checkboxes.AutoSize = true;
            Checkboxes.Controls.Add(KøkkenCheckBox);
            Checkboxes.Controls.Add(BadeværelseCheckBox);
            Checkboxes.Controls.Add(AndetCheckBox);
            Checkboxes.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            Checkboxes.Location = new System.Drawing.Point(78, 13);
            Checkboxes.Name = "Checkboxes";
            Checkboxes.Size = new System.Drawing.Size(281, 63);
            Checkboxes.TabIndex = 5;
            // 
            // BadeværelseCheckBox
            // 
            BadeværelseCheckBox.AutoSize = true;
            BadeværelseCheckBox.Enabled = false;
            BadeværelseCheckBox.Location = new System.Drawing.Point(78, 3);
            BadeværelseCheckBox.Name = "BadeværelseCheckBox";
            BadeværelseCheckBox.Size = new System.Drawing.Size(115, 24);
            BadeværelseCheckBox.TabIndex = 5;
            BadeværelseCheckBox.Text = "Badeværelse";
            BadeværelseCheckBox.Checked = renorvering.Badeværelse;
            BadeværelseCheckBox.UseVisualStyleBackColor = true;
            // 
            // AndetCheckBox
            // 
            AndetCheckBox.AutoSize = true;
            AndetCheckBox.Enabled = false;
            AndetCheckBox.Location = new System.Drawing.Point(207, 33);
            AndetCheckBox.Name = "AndetCheckBox";
            AndetCheckBox.Size = new System.Drawing.Size(71, 24);
            AndetCheckBox.TabIndex = 6;
            AndetCheckBox.Text = "Andet";
            AndetCheckBox.Checked = renorvering.Andet;
            AndetCheckBox.UseVisualStyleBackColor = true;

            RenorveringerFlow.Controls.Add(ItemPanel);
        }

        private void RedigerButton_Click(int renorveringsId)
        {
            baseform.ShowForm(new Renorvering.Renorvering(Models.Action.edit, baseform, new Ejendomme(Models.Action.edit, baseform, int.Parse(BolignrTextbox.Text)), renorveringsId));
        }

        private void SletButton_Click(int renorveringsId)
        {
            baseform.ShowForm(new Renorvering.Renorvering(Models.Action.delete, baseform, new Ejendomme(Models.Action.edit, baseform, int.Parse(BolignrTextbox.Text)), renorveringsId));
        }

        private void OpretButton_Click(int renorveringsId)
        {
            baseform.ShowForm(new Renorvering.Renorvering(Models.Action.delete, baseform, new Ejendomme(Models.Action.edit, baseform, int.Parse(BolignrTextbox.Text)), renorveringsId));
        }


        private void Ejendomme_Load(object sender, EventArgs e)
        {
            switch (action)
            {
                case Models.Action.create:
                    BolignrTextbox.ReadOnly = true;
                    RenorveringerFlow.Visible = false;
                    AddRenorveringButton.Visible = false;
                    SletButtonBolig.Visible = false;
                    OpdaterBoligKnap.Visible = false;
                    BeregnPrisButton.Visible = false;
                    break;

                case Models.Action.edit:
                    BolignrTextbox.ReadOnly = true;
                    OpretBoligKnap.Visible = false;
                    SletButtonBolig.Visible = false;
                    LoadData(boligNr);
                    break;

                case Models.Action.delete:
                    OpdaterBoligKnap.Visible = false;
                    OpretBoligKnap.Visible = false;
                    AddRenorveringButton.Visible = false;
                    BolignrTextbox.ReadOnly = true;
                    AdresseBolig.ReadOnly = true;
                    PrisTextBox.ReadOnly = true;
                    BoligArealTextBox.ReadOnly = true;
                    GrundArealBoligTextBox.ReadOnly = true;
                    PostNrTextBox.ReadOnly = true;
                    VæreslerBoligTextBox.ReadOnly = true;
                    EtagerBoligTextbox.ReadOnly = true;
                    TypeComboBox.Enabled = true;
                    ByggeårBoligTextBox.ReadOnly = true;
                    HaveCheckBox.Enabled = false;
                    BeregnPrisButton.Visible = false;
                    LoadData(boligNr);
                    
                    break;

                case Models.Action.view:
                    LoadData(boligNr);
					BolignrTextbox.ReadOnly = true;
                    AdresseBolig.ReadOnly = true;
                    PrisTextBox.ReadOnly = true;
                    BoligArealTextBox.ReadOnly = true;
                    GrundArealBoligTextBox.ReadOnly = true;
                    PostNrTextBox.ReadOnly = true;
                    VæreslerBoligTextBox.ReadOnly = true;
                    EtagerBoligTextbox.ReadOnly = true;
                    TypeComboBox.Enabled = true;
                    ByggeårBoligTextBox.ReadOnly = true;
                    HaveCheckBox.Enabled = false;
                    OpretBoligKnap.Visible = false;
                    SletButtonBolig.Visible = false;
                    OpdaterBoligKnap.Visible = false;
                    AddRenorveringButton.Visible = false;
                    BeregnPrisButton.Visible = false;
                    
                    break;
            }

        }

        private void TilbageKnap_Click(object sender, EventArgs e)
        {
            baseform.ShowForm(new EjendommeView(baseform));
        }

        private async void BeregnPrisButton_Click(object sender, EventArgs e)
        {
            if(RegexCheck.TalCheck(BoligArealTextBox.Text) && RegexCheck.TalCheck(GrundArealBoligTextBox.Text) && RegexCheck.TalCheck(PostNrTextBox.Text) && RegexCheck.TalCheck(VæreslerBoligTextBox.Text)
                && RegexCheck.TalCheck(EtagerBoligTextbox.Text) && RegexCheck.TalCheck(ByggeårBoligTextBox.Text) && RegexCheck.TalCheck(BolignrTextbox.Text))
            {
                var vurderetPris = await PrisBeregning.Beregn(
                    int.Parse(BoligArealTextBox.Text),
                    int.Parse(GrundArealBoligTextBox.Text),
                    int.Parse(PostNrTextBox.Text),
                    int.Parse(VæreslerBoligTextBox.Text),
                    int.Parse(EtagerBoligTextbox.Text),
                    int.Parse(ByggeårBoligTextBox.Text),
                    HaveCheckBox.Checked,
                    await Fetch.GetRenorveringerByBoligNr(int.Parse(BolignrTextbox.Text))
                );

                PrisTextBox.Text = vurderetPris.ToString();
            }
            else
            {
                MessageBox.Show("Fejl. Der er nogle af felterne som ikke har en ret format");
            }
        }
    }

}
