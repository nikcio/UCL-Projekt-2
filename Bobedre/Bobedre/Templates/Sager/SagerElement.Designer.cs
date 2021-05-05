
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
            this.SagNr = new System.Windows.Forms.Label();
            this.Medarbejder = new System.Windows.Forms.Label();
            this.Sælger = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Sælger);
            this.panel1.Controls.Add(this.Medarbejder);
            this.panel1.Controls.Add(this.SagNr);
            this.panel1.Location = new System.Drawing.Point(29, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 210);
            this.panel1.TabIndex = 0;
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
            // Medarbejder
            // 
            this.Medarbejder.AutoSize = true;
            this.Medarbejder.Location = new System.Drawing.Point(11, 39);
            this.Medarbejder.Name = "Medarbejder";
            this.Medarbejder.Size = new System.Drawing.Size(74, 15);
            this.Medarbejder.TabIndex = 1;
            this.Medarbejder.Text = "Medarbejder";
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
    }
}