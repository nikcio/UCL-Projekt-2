
namespace Bobedre.Templates.Sager
{
    partial class SagerElement
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Sælger = new System.Windows.Forms.Label();
            this.Medarbejder = new System.Windows.Forms.Label();
            this.SagNr = new System.Windows.Forms.Label();
            this.BoligNr = new System.Windows.Forms.Label();
            this.OprrettelsesDato = new System.Windows.Forms.Label();
            this.RedigerButton = new System.Windows.Forms.Button();
            this.VisButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.VisButton);
            this.panel1.Controls.Add(this.RedigerButton);
            this.panel1.Controls.Add(this.OprrettelsesDato);
            this.panel1.Controls.Add(this.BoligNr);
            this.panel1.Controls.Add(this.Sælger);
            this.panel1.Controls.Add(this.Medarbejder);
            this.panel1.Controls.Add(this.SagNr);
            this.panel1.Location = new System.Drawing.Point(29, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 158);
            this.panel1.TabIndex = 0;
            // 
            // Sælger
            // 
            this.Sælger.AutoSize = true;
            this.Sælger.Location = new System.Drawing.Point(11, 69);
            this.Sælger.Name = "Sælger";
            this.Sælger.Size = new System.Drawing.Size(77, 15);
            this.Sælger.TabIndex = 2;
            this.Sælger.Text = "Navn: Sælger";
            // 
            // Medarbejder
            // 
            this.Medarbejder.AutoSize = true;
            this.Medarbejder.Location = new System.Drawing.Point(11, 39);
            this.Medarbejder.Name = "Medarbejder";
            this.Medarbejder.Size = new System.Drawing.Size(74, 15);
            this.Medarbejder.TabIndex = 1;
            this.Medarbejder.Text = "Medarbejder";
            // 
            // SagNr
            // 
            this.SagNr.AutoSize = true;
            this.SagNr.Location = new System.Drawing.Point(11, 11);
            this.SagNr.Name = "SagNr";
            this.SagNr.Size = new System.Drawing.Size(39, 15);
            this.SagNr.TabIndex = 0;
            this.SagNr.Text = "SagNr";
            // 
            // BoligNr
            // 
            this.BoligNr.AutoSize = true;
            this.BoligNr.Location = new System.Drawing.Point(103, 11);
            this.BoligNr.Name = "BoligNr";
            this.BoligNr.Size = new System.Drawing.Size(47, 15);
            this.BoligNr.TabIndex = 3;
            this.BoligNr.Text = "BoligNr";
            // 
            // OprrettelsesDato
            // 
            this.OprrettelsesDato.AutoSize = true;
            this.OprrettelsesDato.Location = new System.Drawing.Point(11, 125);
            this.OprrettelsesDato.Name = "OprrettelsesDato";
            this.OprrettelsesDato.Size = new System.Drawing.Size(32, 15);
            this.OprrettelsesDato.TabIndex = 4;
            this.OprrettelsesDato.Text = "Dato";
            // 
            // RedigerButton
            // 
            this.RedigerButton.Location = new System.Drawing.Point(11, 99);
            this.RedigerButton.Name = "RedigerButton";
            this.RedigerButton.Size = new System.Drawing.Size(75, 23);
            this.RedigerButton.TabIndex = 5;
            this.RedigerButton.Text = "Rediger";
            this.RedigerButton.UseVisualStyleBackColor = true;
            // 
            // VisButton
            // 
            this.VisButton.Location = new System.Drawing.Point(92, 99);
            this.VisButton.Name = "VisButton";
            this.VisButton.Size = new System.Drawing.Size(75, 23);
            this.VisButton.TabIndex = 6;
            this.VisButton.Text = "Vis";
            this.VisButton.UseVisualStyleBackColor = true;
            // 
            // SagerElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 462);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SagerElement";
            this.Text = "SagerElement";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Sælger;
        private System.Windows.Forms.Label Medarbejder;
        private System.Windows.Forms.Label SagNr;
        private System.Windows.Forms.Button VisButton;
        private System.Windows.Forms.Button RedigerButton;
        private System.Windows.Forms.Label OprrettelsesDato;
        private System.Windows.Forms.Label BoligNr;
    }
}