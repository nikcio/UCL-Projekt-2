
namespace Bobedre.Views.Fremvisning
{
    partial class Fremvisning
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
            this.MedarbejderNavn = new System.Windows.Forms.Label();
            this.MedarbjderNr = new System.Windows.Forms.Label();
            this.Afdeling = new System.Windows.Forms.Label();
            this.MæglerFirma = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MedarbejderNavn
            // 
            this.MedarbejderNavn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MedarbejderNavn.AutoSize = true;
            this.MedarbejderNavn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MedarbejderNavn.Location = new System.Drawing.Point(3, 20);
            this.MedarbejderNavn.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.MedarbejderNavn.Name = "MedarbejderNavn";
            this.MedarbejderNavn.Size = new System.Drawing.Size(179, 25);
            this.MedarbejderNavn.TabIndex = 0;
            this.MedarbejderNavn.Text = "Medarbejder Navn";
            this.MedarbejderNavn.Visible = false;
            // 
            // MedarbjderNr
            // 
            this.MedarbjderNr.AutoSize = true;
            this.MedarbjderNr.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MedarbjderNr.Location = new System.Drawing.Point(3, 65);
            this.MedarbjderNr.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.MedarbjderNr.Name = "MedarbjderNr";
            this.MedarbjderNr.Size = new System.Drawing.Size(121, 20);
            this.MedarbjderNr.TabIndex = 1;
            this.MedarbjderNr.Text = "MedarbjderNr 1";
            this.MedarbjderNr.Visible = false;
            // 
            // Afdeling
            // 
            this.Afdeling.AutoSize = true;
            this.Afdeling.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Afdeling.Location = new System.Drawing.Point(3, 105);
            this.Afdeling.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.Afdeling.Name = "Afdeling";
            this.Afdeling.Size = new System.Drawing.Size(66, 20);
            this.Afdeling.TabIndex = 2;
            this.Afdeling.Text = "Afdeling";
            this.Afdeling.Visible = false;
            // 
            // MæglerFirma
            // 
            this.MæglerFirma.AutoSize = true;
            this.MæglerFirma.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MæglerFirma.Location = new System.Drawing.Point(3, 145);
            this.MæglerFirma.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.MæglerFirma.Name = "MæglerFirma";
            this.MæglerFirma.Size = new System.Drawing.Size(95, 20);
            this.MæglerFirma.TabIndex = 3;
            this.MæglerFirma.Text = "Mæglerfirma";
            this.MæglerFirma.Visible = false;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Email.Location = new System.Drawing.Point(3, 185);
            this.Email.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(46, 20);
            this.Email.TabIndex = 4;
            this.Email.Text = "Email";
            this.Email.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.MedarbejderNavn);
            this.flowLayoutPanel1.Controls.Add(this.MedarbjderNr);
            this.flowLayoutPanel1.Controls.Add(this.Afdeling);
            this.flowLayoutPanel1.Controls.Add(this.MæglerFirma);
            this.flowLayoutPanel1.Controls.Add(this.Email);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(999, 438);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // Fremvisning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 462);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fremvisning";
            this.Text = "Fremvisning";
            this.Load += new System.EventHandler(this.Fremvisning_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label MedarbejderNavn;
        private System.Windows.Forms.Label MedarbjderNr;
        private System.Windows.Forms.Label Afdeling;
        private System.Windows.Forms.Label MæglerFirma;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}