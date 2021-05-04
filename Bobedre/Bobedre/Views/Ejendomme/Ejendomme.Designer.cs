
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
            this.Bolignr = new System.Windows.Forms.Label();
            this.BolignrTextbox = new System.Windows.Forms.TextBox();
            this.BoligAdresse = new System.Windows.Forms.Label();
            this.PrisBolig = new System.Windows.Forms.Label();
            this.AdresseBolig = new System.Windows.Forms.TextBox();
            this.PrisTextBox = new System.Windows.Forms.TextBox();
            this.BoligAreal = new System.Windows.Forms.Label();
            this.BoligArealTextBox = new System.Windows.Forms.TextBox();
            this.GrundAreal = new System.Windows.Forms.Label();
            this.GrundArealBoligTextBox = new System.Windows.Forms.TextBox();
            this.VæreslerBoligTextBox = new System.Windows.Forms.TextBox();
            this.EtagerBoligTextbox = new System.Windows.Forms.TextBox();
            this.VærelserBolig = new System.Windows.Forms.Label();
            this.TypeBolig = new System.Windows.Forms.Label();
            this.ByggeÅrBolig = new System.Windows.Forms.Label();
            this.TypeBoligTextBox = new System.Windows.Forms.TextBox();
            this.ByggeårBoligTextBox = new System.Windows.Forms.TextBox();
            this.SletButtonBolig = new System.Windows.Forms.Button();
            this.OpdaterBoligKnap = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.HaveCheckBox = new System.Windows.Forms.CheckBox();
            this.PostNrLabel = new System.Windows.Forms.Label();
            this.PostNrTextBox = new System.Windows.Forms.TextBox();
            this.RenorveringerFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.AddRenorveringButton = new System.Windows.Forms.Button();
            OpretBoligKnap = new System.Windows.Forms.Button();
            EtagerBolig = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpretBoligKnap
            // 
            OpretBoligKnap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            OpretBoligKnap.Location = new System.Drawing.Point(2, 2);
            OpretBoligKnap.Margin = new System.Windows.Forms.Padding(2);
            OpretBoligKnap.Name = "OpretBoligKnap";
            OpretBoligKnap.Size = new System.Drawing.Size(250, 50);
            OpretBoligKnap.TabIndex = 34;
            OpretBoligKnap.Text = "Opret Bolig";
            OpretBoligKnap.UseVisualStyleBackColor = true;
            OpretBoligKnap.Click += new System.EventHandler(this.OpretBoligKnap_Click);
            // 
            // EtagerBolig
            // 
            EtagerBolig.AutoSize = true;
            EtagerBolig.Location = new System.Drawing.Point(319, 198);
            EtagerBolig.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            EtagerBolig.Name = "EtagerBolig";
            EtagerBolig.Size = new System.Drawing.Size(62, 25);
            EtagerBolig.TabIndex = 15;
            EtagerBolig.Text = "Etager";
            // 
            // Bolignr
            // 
            this.Bolignr.AutoSize = true;
            this.Bolignr.Location = new System.Drawing.Point(11, 38);
            this.Bolignr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Bolignr.Name = "Bolignr";
            this.Bolignr.Size = new System.Drawing.Size(71, 25);
            this.Bolignr.TabIndex = 0;
            this.Bolignr.Text = "BoligNr";
            // 
            // BolignrTextbox
            // 
            this.BolignrTextbox.Location = new System.Drawing.Point(109, 32);
            this.BolignrTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.BolignrTextbox.Name = "BolignrTextbox";
            this.BolignrTextbox.Size = new System.Drawing.Size(150, 31);
            this.BolignrTextbox.TabIndex = 1;
            // 
            // BoligAdresse
            // 
            this.BoligAdresse.AutoSize = true;
            this.BoligAdresse.Location = new System.Drawing.Point(11, 96);
            this.BoligAdresse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BoligAdresse.Name = "BoligAdresse";
            this.BoligAdresse.Size = new System.Drawing.Size(75, 25);
            this.BoligAdresse.TabIndex = 2;
            this.BoligAdresse.Text = "Adresse";
            // 
            // PrisBolig
            // 
            this.PrisBolig.AutoSize = true;
            this.PrisBolig.Location = new System.Drawing.Point(14, 142);
            this.PrisBolig.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PrisBolig.Name = "PrisBolig";
            this.PrisBolig.Size = new System.Drawing.Size(40, 25);
            this.PrisBolig.TabIndex = 3;
            this.PrisBolig.Text = "Pris";
            // 
            // AdresseBolig
            // 
            this.AdresseBolig.Location = new System.Drawing.Point(109, 88);
            this.AdresseBolig.Margin = new System.Windows.Forms.Padding(2);
            this.AdresseBolig.Name = "AdresseBolig";
            this.AdresseBolig.Size = new System.Drawing.Size(150, 31);
            this.AdresseBolig.TabIndex = 4;
            // 
            // PrisTextBox
            // 
            this.PrisTextBox.Location = new System.Drawing.Point(109, 138);
            this.PrisTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PrisTextBox.Name = "PrisTextBox";
            this.PrisTextBox.Size = new System.Drawing.Size(150, 31);
            this.PrisTextBox.TabIndex = 5;
            // 
            // BoligAreal
            // 
            this.BoligAreal.AutoSize = true;
            this.BoligAreal.Location = new System.Drawing.Point(11, 198);
            this.BoligAreal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BoligAreal.Name = "BoligAreal";
            this.BoligAreal.Size = new System.Drawing.Size(92, 25);
            this.BoligAreal.TabIndex = 6;
            this.BoligAreal.Text = "BoligAreal";
            // 
            // BoligArealTextBox
            // 
            this.BoligArealTextBox.Location = new System.Drawing.Point(109, 192);
            this.BoligArealTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.BoligArealTextBox.Name = "BoligArealTextBox";
            this.BoligArealTextBox.Size = new System.Drawing.Size(150, 31);
            this.BoligArealTextBox.TabIndex = 7;
            // 
            // GrundAreal
            // 
            this.GrundAreal.AutoSize = true;
            this.GrundAreal.Location = new System.Drawing.Point(319, 38);
            this.GrundAreal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GrundAreal.Name = "GrundAreal";
            this.GrundAreal.Size = new System.Drawing.Size(101, 25);
            this.GrundAreal.TabIndex = 8;
            this.GrundAreal.Text = "GrundAreal";
            // 
            // GrundArealBoligTextBox
            // 
            this.GrundArealBoligTextBox.Location = new System.Drawing.Point(441, 32);
            this.GrundArealBoligTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.GrundArealBoligTextBox.Name = "GrundArealBoligTextBox";
            this.GrundArealBoligTextBox.Size = new System.Drawing.Size(150, 31);
            this.GrundArealBoligTextBox.TabIndex = 9;
            // 
            // VæreslerBoligTextBox
            // 
            this.VæreslerBoligTextBox.Location = new System.Drawing.Point(441, 138);
            this.VæreslerBoligTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.VæreslerBoligTextBox.Name = "VæreslerBoligTextBox";
            this.VæreslerBoligTextBox.Size = new System.Drawing.Size(150, 31);
            this.VæreslerBoligTextBox.TabIndex = 11;
            // 
            // EtagerBoligTextbox
            // 
            this.EtagerBoligTextbox.Location = new System.Drawing.Point(441, 194);
            this.EtagerBoligTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.EtagerBoligTextbox.Name = "EtagerBoligTextbox";
            this.EtagerBoligTextbox.Size = new System.Drawing.Size(150, 31);
            this.EtagerBoligTextbox.TabIndex = 12;
            // 
            // VærelserBolig
            // 
            this.VærelserBolig.AutoSize = true;
            this.VærelserBolig.Location = new System.Drawing.Point(319, 140);
            this.VærelserBolig.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.VærelserBolig.Name = "VærelserBolig";
            this.VærelserBolig.Size = new System.Drawing.Size(79, 25);
            this.VærelserBolig.TabIndex = 14;
            this.VærelserBolig.Text = "Værelser";
            // 
            // TypeBolig
            // 
            this.TypeBolig.AutoSize = true;
            this.TypeBolig.Location = new System.Drawing.Point(624, 38);
            this.TypeBolig.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TypeBolig.Name = "TypeBolig";
            this.TypeBolig.Size = new System.Drawing.Size(49, 25);
            this.TypeBolig.TabIndex = 16;
            this.TypeBolig.Text = "Type";
            this.TypeBolig.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ByggeÅrBolig
            // 
            this.ByggeÅrBolig.AutoSize = true;
            this.ByggeÅrBolig.Location = new System.Drawing.Point(624, 92);
            this.ByggeÅrBolig.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ByggeÅrBolig.Name = "ByggeÅrBolig";
            this.ByggeÅrBolig.Size = new System.Drawing.Size(77, 25);
            this.ByggeÅrBolig.TabIndex = 17;
            this.ByggeÅrBolig.Text = "Byggeår";
            // 
            // TypeBoligTextBox
            // 
            this.TypeBoligTextBox.Location = new System.Drawing.Point(720, 32);
            this.TypeBoligTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.TypeBoligTextBox.Name = "TypeBoligTextBox";
            this.TypeBoligTextBox.Size = new System.Drawing.Size(150, 31);
            this.TypeBoligTextBox.TabIndex = 18;
            // 
            // ByggeårBoligTextBox
            // 
            this.ByggeårBoligTextBox.Location = new System.Drawing.Point(720, 92);
            this.ByggeårBoligTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ByggeårBoligTextBox.Name = "ByggeårBoligTextBox";
            this.ByggeårBoligTextBox.Size = new System.Drawing.Size(150, 31);
            this.ByggeårBoligTextBox.TabIndex = 19;
            // 
            // SletButtonBolig
            // 
            this.SletButtonBolig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SletButtonBolig.Location = new System.Drawing.Point(256, 2);
            this.SletButtonBolig.Margin = new System.Windows.Forms.Padding(2);
            this.SletButtonBolig.Name = "SletButtonBolig";
            this.SletButtonBolig.Size = new System.Drawing.Size(250, 50);
            this.SletButtonBolig.TabIndex = 33;
            this.SletButtonBolig.Text = "Slet Bolig";
            this.SletButtonBolig.UseVisualStyleBackColor = true;
            this.SletButtonBolig.Click += new System.EventHandler(this.SletButtonBolig_Click);
            // 
            // OpdaterBoligKnap
            // 
            this.OpdaterBoligKnap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpdaterBoligKnap.Location = new System.Drawing.Point(510, 2);
            this.OpdaterBoligKnap.Margin = new System.Windows.Forms.Padding(2);
            this.OpdaterBoligKnap.Name = "OpdaterBoligKnap";
            this.OpdaterBoligKnap.Size = new System.Drawing.Size(250, 50);
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(11, 578);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(832, 150);
            this.flowLayoutPanel1.TabIndex = 36;
            // 
            // HaveCheckBox
            // 
            this.HaveCheckBox.AutoSize = true;
            this.HaveCheckBox.Location = new System.Drawing.Point(624, 136);
            this.HaveCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.HaveCheckBox.Name = "HaveCheckBox";
            this.HaveCheckBox.Size = new System.Drawing.Size(78, 29);
            this.HaveCheckBox.TabIndex = 38;
            this.HaveCheckBox.Text = "Have";
            this.HaveCheckBox.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.HaveCheckBox.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.HaveCheckBox.UseVisualStyleBackColor = true;
            // 
            // PostNrLabel
            // 
            this.PostNrLabel.AutoSize = true;
            this.PostNrLabel.Location = new System.Drawing.Point(318, 84);
            this.PostNrLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PostNrLabel.Name = "PostNrLabel";
            this.PostNrLabel.Size = new System.Drawing.Size(62, 25);
            this.PostNrLabel.TabIndex = 39;
            this.PostNrLabel.Text = "Postnr";
            // 
            // PostNrTextBox
            // 
            this.PostNrTextBox.Location = new System.Drawing.Point(441, 80);
            this.PostNrTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PostNrTextBox.Name = "PostNrTextBox";
            this.PostNrTextBox.Size = new System.Drawing.Size(150, 31);
            this.PostNrTextBox.TabIndex = 40;
            // 
            // RenorveringerFlow
            // 
            this.RenorveringerFlow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RenorveringerFlow.AutoScroll = true;
            this.RenorveringerFlow.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.RenorveringerFlow.Location = new System.Drawing.Point(950, 136);
            this.RenorveringerFlow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RenorveringerFlow.Name = "RenorveringerFlow";
            this.RenorveringerFlow.Size = new System.Drawing.Size(496, 591);
            this.RenorveringerFlow.TabIndex = 41;
            // 
            // AddRenorveringButton
            // 
            this.AddRenorveringButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRenorveringButton.Location = new System.Drawing.Point(1156, 62);
            this.AddRenorveringButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddRenorveringButton.Name = "AddRenorveringButton";
            this.AddRenorveringButton.Size = new System.Drawing.Size(290, 55);
            this.AddRenorveringButton.TabIndex = 42;
            this.AddRenorveringButton.Text = "Tilføj renorvering";
            this.AddRenorveringButton.UseVisualStyleBackColor = true;
            this.AddRenorveringButton.Click += new System.EventHandler(this.AddRenorveringButton_Click);
            // 
            // Ejendomme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1461, 770);
            this.Controls.Add(this.AddRenorveringButton);
            this.Controls.Add(this.RenorveringerFlow);
            this.Controls.Add(this.PostNrTextBox);
            this.Controls.Add(this.PostNrLabel);
            this.Controls.Add(this.HaveCheckBox);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.ByggeårBoligTextBox);
            this.Controls.Add(this.TypeBoligTextBox);
            this.Controls.Add(this.ByggeÅrBolig);
            this.Controls.Add(this.TypeBolig);
            this.Controls.Add(EtagerBolig);
            this.Controls.Add(this.VærelserBolig);
            this.Controls.Add(this.EtagerBoligTextbox);
            this.Controls.Add(this.VæreslerBoligTextBox);
            this.Controls.Add(this.GrundArealBoligTextBox);
            this.Controls.Add(this.GrundAreal);
            this.Controls.Add(this.BoligArealTextBox);
            this.Controls.Add(this.BoligAreal);
            this.Controls.Add(this.PrisTextBox);
            this.Controls.Add(this.AdresseBolig);
            this.Controls.Add(this.PrisBolig);
            this.Controls.Add(this.BoligAdresse);
            this.Controls.Add(this.BolignrTextbox);
            this.Controls.Add(this.Bolignr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Ejendomme";
            this.Text = "GrundAreal";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.Label EtagerBolig;
        private System.Windows.Forms.Label OmbygningsårLabel;
        private System.Windows.Forms.Button OpretBoligKnap;
        private System.Windows.Forms.Label Bolignr;
        private System.Windows.Forms.TextBox BolignrTextbox;
        private System.Windows.Forms.Label BoligAdresse;
        private System.Windows.Forms.Label PrisBolig;
        private System.Windows.Forms.TextBox AdresseBolig;
        private System.Windows.Forms.TextBox PrisTextBox;
        private System.Windows.Forms.Label BoligAreal;
        private System.Windows.Forms.TextBox BoligArealTextBox;
        private System.Windows.Forms.Label GrundAreal;
        private System.Windows.Forms.TextBox GrundArealBoligTextBox;
        private System.Windows.Forms.TextBox VæreslerBoligTextBox;
        private System.Windows.Forms.TextBox EtagerBoligTextbox;
        private System.Windows.Forms.Label VærelserBolig;
        private System.Windows.Forms.Label TypeBolig;
        private System.Windows.Forms.Label ByggeÅrBolig;
        private System.Windows.Forms.TextBox TypeBoligTextBox;
        private System.Windows.Forms.TextBox ByggeårBoligTextBox;
        private System.Windows.Forms.Button SletButtonBolig;
        private System.Windows.Forms.Button OpdaterBoligKnap;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox HaveCheckBox;
        private System.Windows.Forms.Label PostNrLabel;
        private System.Windows.Forms.TextBox PostNrTextBox;
        private System.Windows.Forms.FlowLayoutPanel RenorveringerFlow;
        private System.Windows.Forms.Button AddRenorveringButton;
    }
}