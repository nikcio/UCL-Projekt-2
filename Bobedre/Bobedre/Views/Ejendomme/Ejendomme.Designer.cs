
namespace Bobedre.Views.Ejendomme
{
    partial class Ejendomme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button OpretBoligKnap;
            System.Windows.Forms.Label EtagerBolig;
            System.Windows.Forms.Label OmbygningsårBolig;
            this.Bolignr = new System.Windows.Forms.Label();
            this.BolignrLabel = new System.Windows.Forms.TextBox();
            this.BoligAdresse = new System.Windows.Forms.Label();
            this.PrisBolig = new System.Windows.Forms.Label();
            this.AdresseBolig = new System.Windows.Forms.TextBox();
            this.PrisTextBox = new System.Windows.Forms.TextBox();
            this.BoligAreal = new System.Windows.Forms.Label();
            this.BoligArealTextBox = new System.Windows.Forms.TextBox();
            this.GrundAreal = new System.Windows.Forms.Label();
            this.GrundArealBoligTextBox = new System.Windows.Forms.TextBox();
            this.HaveBoligTextBox = new System.Windows.Forms.TextBox();
            this.VæreslerBoligTextBox = new System.Windows.Forms.TextBox();
            this.EtagerBoligTextbox = new System.Windows.Forms.TextBox();
            this.HaveBolig = new System.Windows.Forms.Label();
            this.VærelserBolig = new System.Windows.Forms.Label();
            this.TypeBolig = new System.Windows.Forms.Label();
            this.ByggeÅrBolig = new System.Windows.Forms.Label();
            this.TypeBoligTextBox = new System.Windows.Forms.TextBox();
            this.ByggeårBoligTextBox = new System.Windows.Forms.TextBox();
            this.RenoveretBoligCheckBox = new System.Windows.Forms.CheckBox();
            this.DetaljerBolig = new System.Windows.Forms.Label();
            this.RenoveringsIdBolig = new System.Windows.Forms.Label();
            this.KøkkenCheckbox = new System.Windows.Forms.CheckBox();
            this.Badeværelsecheckbox = new System.Windows.Forms.CheckBox();
            this.OmbygningsårLabel = new System.Windows.Forms.TextBox();
            this.DetalijerLabel = new System.Windows.Forms.TextBox();
            this.RenoveringsIdLabel = new System.Windows.Forms.TextBox();
            this.SletButtonBolig = new System.Windows.Forms.Button();
            this.OpdaterBoligKnap = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();

            this.Andetcheckbox = new System.Windows.Forms.CheckBox();

            OpretBoligKnap = new System.Windows.Forms.Button();
            EtagerBolig = new System.Windows.Forms.Label();
            OmbygningsårBolig = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpretBoligKnap
            // 
            OpretBoligKnap.Location = new System.Drawing.Point(2, 2);
            OpretBoligKnap.Margin = new System.Windows.Forms.Padding(2);
            OpretBoligKnap.Name = "OpretBoligKnap";
            OpretBoligKnap.Size = new System.Drawing.Size(100, 20);
            OpretBoligKnap.TabIndex = 34;
            OpretBoligKnap.Text = "Opret Bolig";
            OpretBoligKnap.UseVisualStyleBackColor = true;
            OpretBoligKnap.Click += new System.EventHandler(this.OpretBoligKnap_Click);
            // 
            // EtagerBolig
            // 
            EtagerBolig.AutoSize = true;
            EtagerBolig.Location = new System.Drawing.Point(223, 118);
            EtagerBolig.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            EtagerBolig.Name = "EtagerBolig";
            EtagerBolig.Size = new System.Drawing.Size(40, 15);
            EtagerBolig.TabIndex = 15;
            EtagerBolig.Text = "Etager";
            // 
            // OmbygningsårBolig
            // 
            OmbygningsårBolig.AutoSize = true;
            OmbygningsårBolig.Location = new System.Drawing.Point(762, 44);
            OmbygningsårBolig.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            OmbygningsårBolig.Name = "OmbygningsårBolig";
            OmbygningsårBolig.Size = new System.Drawing.Size(86, 15);
            OmbygningsårBolig.TabIndex = 24;
            OmbygningsårBolig.Text = "Ombygningsår";
            // 
            // Bolignr
            // 
            this.Bolignr.AutoSize = true;
            this.Bolignr.Location = new System.Drawing.Point(8, 23);
            this.Bolignr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Bolignr.Name = "Bolignr";
            this.Bolignr.Size = new System.Drawing.Size(47, 15);
            this.Bolignr.TabIndex = 0;
            this.Bolignr.Text = "BoligNr";
            // 
            // BolignrLabel
            // 
            this.BolignrLabel.Location = new System.Drawing.Point(76, 19);
            this.BolignrLabel.Margin = new System.Windows.Forms.Padding(2);
            this.BolignrLabel.Name = "BolignrLabel";

            this.BolignrLabel.ReadOnly = true;

            this.BolignrLabel.Size = new System.Drawing.Size(106, 23);
            this.BolignrLabel.TabIndex = 1;
            // 
            // BoligAdresse
            // 
            this.BoligAdresse.AutoSize = true;
            this.BoligAdresse.Location = new System.Drawing.Point(8, 50);
            this.BoligAdresse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BoligAdresse.Name = "BoligAdresse";
            this.BoligAdresse.Size = new System.Drawing.Size(48, 15);
            this.BoligAdresse.TabIndex = 2;
            this.BoligAdresse.Text = "Adresse";
            // 
            // PrisBolig
            // 
            this.PrisBolig.AutoSize = true;
            this.PrisBolig.Location = new System.Drawing.Point(8, 82);
            this.PrisBolig.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PrisBolig.Name = "PrisBolig";
            this.PrisBolig.Size = new System.Drawing.Size(26, 15);
            this.PrisBolig.TabIndex = 3;
            this.PrisBolig.Text = "Pris";
            // 
            // AdresseBolig
            // 
            this.AdresseBolig.Location = new System.Drawing.Point(76, 47);
            this.AdresseBolig.Margin = new System.Windows.Forms.Padding(2);
            this.AdresseBolig.Name = "AdresseBolig";
            this.AdresseBolig.Size = new System.Drawing.Size(106, 23);
            this.AdresseBolig.TabIndex = 4;
            // 
            // PrisTextBox
            // 
            this.PrisTextBox.Location = new System.Drawing.Point(76, 82);
            this.PrisTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PrisTextBox.Name = "PrisTextBox";
            this.PrisTextBox.Size = new System.Drawing.Size(106, 23);
            this.PrisTextBox.TabIndex = 5;
            // 
            // BoligAreal
            // 
            this.BoligAreal.AutoSize = true;
            this.BoligAreal.Location = new System.Drawing.Point(8, 118);
            this.BoligAreal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BoligAreal.Name = "BoligAreal";
            this.BoligAreal.Size = new System.Drawing.Size(61, 15);
            this.BoligAreal.TabIndex = 6;
            this.BoligAreal.Text = "BoligAreal";
            // 
            // BoligArealTextBox
            // 
            this.BoligArealTextBox.Location = new System.Drawing.Point(76, 115);
            this.BoligArealTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.BoligArealTextBox.Name = "BoligArealTextBox";
            this.BoligArealTextBox.Size = new System.Drawing.Size(106, 23);
            this.BoligArealTextBox.TabIndex = 7;
            // 
            // GrundAreal
            // 
            this.GrundAreal.AutoSize = true;
            this.GrundAreal.Location = new System.Drawing.Point(223, 23);
            this.GrundAreal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GrundAreal.Name = "GrundAreal";
            this.GrundAreal.Size = new System.Drawing.Size(67, 15);
            this.GrundAreal.TabIndex = 8;
            this.GrundAreal.Text = "GrundAreal";
            // 
            // GrundArealBoligTextBox
            // 
            this.GrundArealBoligTextBox.Location = new System.Drawing.Point(309, 19);
            this.GrundArealBoligTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.GrundArealBoligTextBox.Name = "GrundArealBoligTextBox";
            this.GrundArealBoligTextBox.Size = new System.Drawing.Size(106, 23);
            this.GrundArealBoligTextBox.TabIndex = 9;
            // 
            // HaveBoligTextBox
            // 
            this.HaveBoligTextBox.Location = new System.Drawing.Point(309, 47);
            this.HaveBoligTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.HaveBoligTextBox.Name = "HaveBoligTextBox";
            this.HaveBoligTextBox.Size = new System.Drawing.Size(106, 23);
            this.HaveBoligTextBox.TabIndex = 10;
            // 
            // VæreslerBoligTextBox
            // 
            this.VæreslerBoligTextBox.Location = new System.Drawing.Point(309, 78);
            this.VæreslerBoligTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.VæreslerBoligTextBox.Name = "VæreslerBoligTextBox";
            this.VæreslerBoligTextBox.Size = new System.Drawing.Size(106, 23);
            this.VæreslerBoligTextBox.TabIndex = 11;
            // 
            // EtagerBoligTextbox
            // 
            this.EtagerBoligTextbox.Location = new System.Drawing.Point(309, 118);
            this.EtagerBoligTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.EtagerBoligTextbox.Name = "EtagerBoligTextbox";
            this.EtagerBoligTextbox.Size = new System.Drawing.Size(106, 23);
            this.EtagerBoligTextbox.TabIndex = 12;
            // 
            // HaveBolig
            // 
            this.HaveBolig.AutoSize = true;
            this.HaveBolig.Location = new System.Drawing.Point(223, 50);
            this.HaveBolig.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HaveBolig.Name = "HaveBolig";
            this.HaveBolig.Size = new System.Drawing.Size(34, 15);
            this.HaveBolig.TabIndex = 13;
            this.HaveBolig.Text = "Have";
            // 
            // VærelserBolig
            // 
            this.VærelserBolig.AutoSize = true;
            this.VærelserBolig.Location = new System.Drawing.Point(223, 77);
            this.VærelserBolig.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.VærelserBolig.Name = "VærelserBolig";
            this.VærelserBolig.Size = new System.Drawing.Size(51, 15);
            this.VærelserBolig.TabIndex = 14;
            this.VærelserBolig.Text = "Værelser";
            // 
            // TypeBolig
            // 
            this.TypeBolig.AutoSize = true;
            this.TypeBolig.Location = new System.Drawing.Point(437, 23);
            this.TypeBolig.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TypeBolig.Name = "TypeBolig";
            this.TypeBolig.Size = new System.Drawing.Size(31, 15);
            this.TypeBolig.TabIndex = 16;
            this.TypeBolig.Text = "Type";
            this.TypeBolig.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ByggeÅrBolig
            // 
            this.ByggeÅrBolig.AutoSize = true;
            this.ByggeÅrBolig.Location = new System.Drawing.Point(437, 56);
            this.ByggeÅrBolig.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ByggeÅrBolig.Name = "ByggeÅrBolig";
            this.ByggeÅrBolig.Size = new System.Drawing.Size(50, 15);
            this.ByggeÅrBolig.TabIndex = 17;
            this.ByggeÅrBolig.Text = "Byggeår";
            // 
            // TypeBoligTextBox
            // 
            this.TypeBoligTextBox.Location = new System.Drawing.Point(504, 19);
            this.TypeBoligTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.TypeBoligTextBox.Name = "TypeBoligTextBox";
            this.TypeBoligTextBox.Size = new System.Drawing.Size(106, 23);
            this.TypeBoligTextBox.TabIndex = 18;
            // 
            // ByggeårBoligTextBox
            // 
            this.ByggeårBoligTextBox.Location = new System.Drawing.Point(504, 56);
            this.ByggeårBoligTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ByggeårBoligTextBox.Name = "ByggeårBoligTextBox";
            this.ByggeårBoligTextBox.Size = new System.Drawing.Size(106, 23);
            this.ByggeårBoligTextBox.TabIndex = 19;
            // 
            // RenoveretBoligCheckBox
            // 
            this.RenoveretBoligCheckBox.AutoSize = true;
            this.RenoveretBoligCheckBox.Location = new System.Drawing.Point(645, 20);
            this.RenoveretBoligCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.RenoveretBoligCheckBox.Name = "RenoveretBoligCheckBox";
            this.RenoveretBoligCheckBox.Size = new System.Drawing.Size(79, 19);
            this.RenoveretBoligCheckBox.TabIndex = 20;
            this.RenoveretBoligCheckBox.Text = "Renoveret";
            this.RenoveretBoligCheckBox.UseVisualStyleBackColor = true;
            this.RenoveretBoligCheckBox.CheckedChanged += new System.EventHandler(this.RenoveretBoligCheckBox_CheckedChanged);
            // 
            // DetaljerBolig
            // 
            this.DetaljerBolig.AutoSize = true;

            this.DetaljerBolig.Location = new System.Drawing.Point(762, 68);

            this.DetaljerBolig.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DetaljerBolig.Name = "DetaljerBolig";
            this.DetaljerBolig.Size = new System.Drawing.Size(47, 15);
            this.DetaljerBolig.TabIndex = 25;
            this.DetaljerBolig.Text = "Detaljer";
            // 
            // RenoveringsIdBolig
            // 
            this.RenoveringsIdBolig.AutoSize = true;

            this.RenoveringsIdBolig.Location = new System.Drawing.Point(762, 95);

            this.RenoveringsIdBolig.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RenoveringsIdBolig.Name = "RenoveringsIdBolig";
            this.RenoveringsIdBolig.Size = new System.Drawing.Size(82, 15);
            this.RenoveringsIdBolig.TabIndex = 26;
            this.RenoveringsIdBolig.Text = "RenoveringsId";
            // 
            // KøkkenCheckbox
            // 
            this.KøkkenCheckbox.AutoSize = true;
            this.KøkkenCheckbox.Enabled = false;
            this.KøkkenCheckbox.Location = new System.Drawing.Point(645, 46);
            this.KøkkenCheckbox.Margin = new System.Windows.Forms.Padding(2);
            this.KøkkenCheckbox.Name = "KøkkenCheckbox";
            this.KøkkenCheckbox.Size = new System.Drawing.Size(65, 19);
            this.KøkkenCheckbox.TabIndex = 27;
            this.KøkkenCheckbox.Text = "Køkken";
            this.KøkkenCheckbox.UseVisualStyleBackColor = true;
            // 
            // Badeværelsecheckbox
            // 
            this.Badeværelsecheckbox.AutoSize = true;
            this.Badeværelsecheckbox.Enabled = false;
            this.Badeværelsecheckbox.Location = new System.Drawing.Point(645, 68);
            this.Badeværelsecheckbox.Margin = new System.Windows.Forms.Padding(2);
            this.Badeværelsecheckbox.Name = "Badeværelsecheckbox";
            this.Badeværelsecheckbox.Size = new System.Drawing.Size(92, 19);
            this.Badeværelsecheckbox.TabIndex = 28;
            this.Badeværelsecheckbox.Text = "Badeværelse";
            this.Badeværelsecheckbox.UseVisualStyleBackColor = true;
            // 
            // OmbygningsårLabel
            // 
            this.OmbygningsårLabel.Enabled = false;

            this.OmbygningsårLabel.Location = new System.Drawing.Point(865, 44);

            this.OmbygningsårLabel.Margin = new System.Windows.Forms.Padding(2);
            this.OmbygningsårLabel.Name = "OmbygningsårLabel";
            this.OmbygningsårLabel.Size = new System.Drawing.Size(67, 23);
            this.OmbygningsårLabel.TabIndex = 30;
            // 
            // DetalijerLabel
            // 
            this.DetalijerLabel.Enabled = false;

            this.DetalijerLabel.Location = new System.Drawing.Point(865, 68);

            this.DetalijerLabel.Margin = new System.Windows.Forms.Padding(2);
            this.DetalijerLabel.Name = "DetalijerLabel";
            this.DetalijerLabel.Size = new System.Drawing.Size(67, 23);
            this.DetalijerLabel.TabIndex = 31;
            // 
            // RenoveringsIdLabel
            // 
            this.RenoveringsIdLabel.Enabled = false;
            this.RenoveringsIdLabel.Location = new System.Drawing.Point(865, 95);
            this.RenoveringsIdLabel.Margin = new System.Windows.Forms.Padding(2);
            this.RenoveringsIdLabel.Name = "RenoveringsIdLabel";
            this.RenoveringsIdLabel.Size = new System.Drawing.Size(67, 23);
            this.RenoveringsIdLabel.TabIndex = 32;
            // 
            // SletButtonBolig
            // 
            this.SletButtonBolig.Location = new System.Drawing.Point(106, 2);
            this.SletButtonBolig.Margin = new System.Windows.Forms.Padding(2);
            this.SletButtonBolig.Name = "SletButtonBolig";
            this.SletButtonBolig.Size = new System.Drawing.Size(104, 20);
            this.SletButtonBolig.TabIndex = 33;
            this.SletButtonBolig.Text = "Slet Bolig";
            this.SletButtonBolig.UseVisualStyleBackColor = true;
            this.SletButtonBolig.Click += new System.EventHandler(this.SletButtonBolig_Click);
            // 
            // OpdaterBoligKnap
            // 
            this.OpdaterBoligKnap.Location = new System.Drawing.Point(214, 2);
            this.OpdaterBoligKnap.Margin = new System.Windows.Forms.Padding(2);
            this.OpdaterBoligKnap.Name = "OpdaterBoligKnap";
            this.OpdaterBoligKnap.Size = new System.Drawing.Size(106, 20);
            this.OpdaterBoligKnap.TabIndex = 35;
            this.OpdaterBoligKnap.Text = "Opdater Bolig";
            this.OpdaterBoligKnap.UseVisualStyleBackColor = true;
            this.OpdaterBoligKnap.Click += new System.EventHandler(this.OpdaterBoligKnap_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(OpretBoligKnap);
            this.flowLayoutPanel1.Controls.Add(this.SletButtonBolig);
            this.flowLayoutPanel1.Controls.Add(this.OpdaterBoligKnap);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 164);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(349, 90);
            this.flowLayoutPanel1.TabIndex = 36;
            // 

            // Andetcheckbox
            // 
            this.Andetcheckbox.AutoSize = true;
            this.Andetcheckbox.Enabled = false;
            this.Andetcheckbox.Location = new System.Drawing.Point(645, 90);
            this.Andetcheckbox.Name = "Andetcheckbox";
            this.Andetcheckbox.Size = new System.Drawing.Size(58, 19);
            this.Andetcheckbox.TabIndex = 37;
            this.Andetcheckbox.Text = "Andet";
            this.Andetcheckbox.UseVisualStyleBackColor = true;

            // 
            // Ejendomme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1023, 462);

            this.Controls.Add(this.Andetcheckbox);

            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.RenoveringsIdLabel);
            this.Controls.Add(this.DetalijerLabel);
            this.Controls.Add(this.OmbygningsårLabel);
            this.Controls.Add(this.Badeværelsecheckbox);
            this.Controls.Add(this.KøkkenCheckbox);
            this.Controls.Add(this.RenoveringsIdBolig);
            this.Controls.Add(this.DetaljerBolig);
            this.Controls.Add(OmbygningsårBolig);
            this.Controls.Add(this.RenoveretBoligCheckBox);
            this.Controls.Add(this.ByggeårBoligTextBox);
            this.Controls.Add(this.TypeBoligTextBox);
            this.Controls.Add(this.ByggeÅrBolig);
            this.Controls.Add(this.TypeBolig);
            this.Controls.Add(EtagerBolig);
            this.Controls.Add(this.VærelserBolig);
            this.Controls.Add(this.HaveBolig);
            this.Controls.Add(this.EtagerBoligTextbox);
            this.Controls.Add(this.VæreslerBoligTextBox);
            this.Controls.Add(this.HaveBoligTextBox);
            this.Controls.Add(this.GrundArealBoligTextBox);
            this.Controls.Add(this.GrundAreal);
            this.Controls.Add(this.BoligArealTextBox);
            this.Controls.Add(this.BoligAreal);
            this.Controls.Add(this.PrisTextBox);
            this.Controls.Add(this.AdresseBolig);
            this.Controls.Add(this.PrisBolig);
            this.Controls.Add(this.BoligAdresse);
            this.Controls.Add(this.BolignrLabel);
            this.Controls.Add(this.Bolignr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Ejendomme";
            this.Text = "GrundAreal";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.Label EtagerBolig;
        private System.Windows.Forms.Label OmbygningsårBolig;
        private System.Windows.Forms.Button OpretBoligKnap;
        private System.Windows.Forms.Label Bolignr;
        private System.Windows.Forms.TextBox BolignrLabel;
        private System.Windows.Forms.Label BoligAdresse;
        private System.Windows.Forms.Label PrisBolig;
        private System.Windows.Forms.TextBox AdresseBolig;
        private System.Windows.Forms.TextBox PrisTextBox;
        private System.Windows.Forms.Label BoligAreal;
        private System.Windows.Forms.TextBox BoligArealTextBox;
        private System.Windows.Forms.Label GrundAreal;
        private System.Windows.Forms.TextBox GrundArealBoligTextBox;
        private System.Windows.Forms.TextBox HaveBoligTextBox;
        private System.Windows.Forms.TextBox VæreslerBoligTextBox;
        private System.Windows.Forms.TextBox EtagerBoligTextbox;
        private System.Windows.Forms.Label HaveBolig;
        private System.Windows.Forms.Label VærelserBolig;
        private System.Windows.Forms.Label TypeBolig;
        private System.Windows.Forms.Label ByggeÅrBolig;
        private System.Windows.Forms.TextBox TypeBoligTextBox;
        private System.Windows.Forms.TextBox ByggeårBoligTextBox;
        private System.Windows.Forms.CheckBox RenoveretBoligCheckBox;
        private System.Windows.Forms.Label DetaljerBolig;
        private System.Windows.Forms.Label RenoveringsIdBolig;
        private System.Windows.Forms.CheckBox KøkkenCheckbox;
        private System.Windows.Forms.CheckBox Badeværelsecheckbox;
        private System.Windows.Forms.TextBox OmbygningsårLabel;
        private System.Windows.Forms.TextBox DetalijerLabel;
        private System.Windows.Forms.TextBox RenoveringsIdLabel;
        private System.Windows.Forms.Button SletButtonBolig;
        private System.Windows.Forms.Button OpdaterBoligKnap;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox Andetcheckbox;

    }
}