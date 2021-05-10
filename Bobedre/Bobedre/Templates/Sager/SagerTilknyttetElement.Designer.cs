
namespace Bobedre.Templates.Sager
{
    partial class SagerTilknyttetElement
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
            this.TypeLabel = new System.Windows.Forms.Label();
            this.NrLabel = new System.Windows.Forms.Label();
            this.AttriLabel1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RedigerButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.VisButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.VisButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.RedigerButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AttriLabel1);
            this.panel1.Controls.Add(this.NrLabel);
            this.panel1.Controls.Add(this.TypeLabel);
            this.panel1.Location = new System.Drawing.Point(174, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 105);
            this.panel1.TabIndex = 0;
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(15, 16);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(73, 15);
            this.TypeLabel.TabIndex = 0;
            this.TypeLabel.Text = "Type: Sælger";
            // 
            // NrLabel
            // 
            this.NrLabel.AutoSize = true;
            this.NrLabel.Location = new System.Drawing.Point(15, 45);
            this.NrLabel.Name = "NrLabel";
            this.NrLabel.Size = new System.Drawing.Size(29, 15);
            this.NrLabel.TabIndex = 1;
            this.NrLabel.Text = "Id: 2";
            // 
            // AttriLabel1
            // 
            this.AttriLabel1.AutoSize = true;
            this.AttriLabel1.Location = new System.Drawing.Point(145, 16);
            this.AttriLabel1.Name = "AttriLabel1";
            this.AttriLabel1.Size = new System.Drawing.Size(28, 15);
            this.AttriLabel1.TabIndex = 2;
            this.AttriLabel1.Text = "Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Info";
            // 
            // RedigerButton
            // 
            this.RedigerButton.AutoSize = true;
            this.RedigerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RedigerButton.Location = new System.Drawing.Point(15, 68);
            this.RedigerButton.Name = "RedigerButton";
            this.RedigerButton.Size = new System.Drawing.Size(75, 27);
            this.RedigerButton.TabIndex = 5;
            this.RedigerButton.Text = "Rediger";
            this.RedigerButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Info";
            // 
            // VisButton
            // 
            this.VisButton.AutoSize = true;
            this.VisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VisButton.Location = new System.Drawing.Point(98, 68);
            this.VisButton.Name = "VisButton";
            this.VisButton.Size = new System.Drawing.Size(75, 27);
            this.VisButton.TabIndex = 7;
            this.VisButton.Text = "Vis";
            this.VisButton.UseVisualStyleBackColor = true;
            // 
            // SagerTilknyttetElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SagerTilknyttetElement";
            this.Text = "SagerTilknyttetElement";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label NrLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AttriLabel1;
        private System.Windows.Forms.Button VisButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RedigerButton;
    }
}