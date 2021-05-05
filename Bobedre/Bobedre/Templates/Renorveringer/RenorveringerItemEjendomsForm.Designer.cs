
namespace Bobedre.Templates.Renorveringer
{
    partial class RenorveringerItemEjendomsForm
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
            this.ItemPanel = new System.Windows.Forms.Panel();
            this.Checkboxes = new System.Windows.Forms.FlowLayoutPanel();
            this.KøkkenCheckBox = new System.Windows.Forms.CheckBox();
            this.BadeværelseCheckBox = new System.Windows.Forms.CheckBox();
            this.AndetCheckBox = new System.Windows.Forms.CheckBox();
            this.OmbygningsÅr = new System.Windows.Forms.Label();
            this.RenorveringsId = new System.Windows.Forms.Label();
            this.RedigerButton = new System.Windows.Forms.Button();
            this.SletButton = new System.Windows.Forms.Button();
            this.ItemPanel.SuspendLayout();
            this.Checkboxes.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemPanel
            // 
            this.ItemPanel.AutoSize = true;
            this.ItemPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemPanel.Controls.Add(this.Checkboxes);
            this.ItemPanel.Controls.Add(this.OmbygningsÅr);
            this.ItemPanel.Controls.Add(this.RenorveringsId);
            this.ItemPanel.Controls.Add(this.RedigerButton);
            this.ItemPanel.Controls.Add(this.SletButton);
            this.ItemPanel.Location = new System.Drawing.Point(12, 12);
            this.ItemPanel.Name = "ItemPanel";
            this.ItemPanel.Size = new System.Drawing.Size(373, 125);
            this.ItemPanel.TabIndex = 0;
            // 
            // Checkboxes
            // 
            this.Checkboxes.Controls.Add(this.KøkkenCheckBox);
            this.Checkboxes.Controls.Add(this.BadeværelseCheckBox);
            this.Checkboxes.Controls.Add(this.AndetCheckBox);
            this.Checkboxes.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.Checkboxes.Location = new System.Drawing.Point(78, 13);
            this.Checkboxes.Name = "Checkboxes";
            this.Checkboxes.Size = new System.Drawing.Size(281, 63);
            this.Checkboxes.TabIndex = 5;
            // 
            // KøkkenCheckBox
            // 
            this.KøkkenCheckBox.AutoSize = true;
            this.KøkkenCheckBox.Enabled = false;
            this.KøkkenCheckBox.Location = new System.Drawing.Point(199, 3);
            this.KøkkenCheckBox.Name = "KøkkenCheckBox";
            this.KøkkenCheckBox.Size = new System.Drawing.Size(79, 24);
            this.KøkkenCheckBox.TabIndex = 4;
            this.KøkkenCheckBox.Text = "Køkken";
            this.KøkkenCheckBox.UseVisualStyleBackColor = true;
            // 
            // BadeværelseCheckBox
            // 
            this.BadeværelseCheckBox.AutoSize = true;
            this.BadeværelseCheckBox.Enabled = false;
            this.BadeværelseCheckBox.Location = new System.Drawing.Point(78, 3);
            this.BadeværelseCheckBox.Name = "BadeværelseCheckBox";
            this.BadeværelseCheckBox.Size = new System.Drawing.Size(115, 24);
            this.BadeværelseCheckBox.TabIndex = 5;
            this.BadeværelseCheckBox.Text = "Badeværelse";
            this.BadeværelseCheckBox.UseVisualStyleBackColor = true;
            // 
            // AndetCheckBox
            // 
            this.AndetCheckBox.AutoSize = true;
            this.AndetCheckBox.Enabled = false;
            this.AndetCheckBox.Location = new System.Drawing.Point(207, 33);
            this.AndetCheckBox.Name = "AndetCheckBox";
            this.AndetCheckBox.Size = new System.Drawing.Size(71, 24);
            this.AndetCheckBox.TabIndex = 6;
            this.AndetCheckBox.Text = "Andet";
            this.AndetCheckBox.UseVisualStyleBackColor = true;
            // 
            // OmbygningsÅr
            // 
            this.OmbygningsÅr.AutoSize = true;
            this.OmbygningsÅr.Location = new System.Drawing.Point(9, 37);
            this.OmbygningsÅr.Name = "OmbygningsÅr";
            this.OmbygningsÅr.Size = new System.Drawing.Size(63, 20);
            this.OmbygningsÅr.TabIndex = 3;
            this.OmbygningsÅr.Text = "År: 2020";
            // 
            // RenorveringsId
            // 
            this.RenorveringsId.AutoSize = true;
            this.RenorveringsId.Location = new System.Drawing.Point(9, 13);
            this.RenorveringsId.Name = "RenorveringsId";
            this.RenorveringsId.Size = new System.Drawing.Size(37, 20);
            this.RenorveringsId.TabIndex = 2;
            this.RenorveringsId.Text = "Id: 1";
            // 
            // RedigerButton
            // 
            this.RedigerButton.AutoSize = true;
            this.RedigerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RedigerButton.Location = new System.Drawing.Point(165, 82);
            this.RedigerButton.Name = "RedigerButton";
            this.RedigerButton.Size = new System.Drawing.Size(94, 32);
            this.RedigerButton.TabIndex = 1;
            this.RedigerButton.Text = "Rediger";
            this.RedigerButton.UseVisualStyleBackColor = true;
            this.RedigerButton.Click += new System.EventHandler(this.RedigerButton_Click);
            // 
            // SletButton
            // 
            this.SletButton.AutoSize = true;
            this.SletButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SletButton.Location = new System.Drawing.Point(265, 82);
            this.SletButton.Name = "SletButton";
            this.SletButton.Size = new System.Drawing.Size(94, 32);
            this.SletButton.TabIndex = 0;
            this.SletButton.Text = "Slet";
            this.SletButton.UseVisualStyleBackColor = true;
            this.SletButton.Click += new System.EventHandler(this.SletButton_Click);
            // 
            // RenorveringerItemEjendomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 473);
            this.Controls.Add(this.ItemPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RenorveringerItemEjendomsForm";
            this.Text = "RenorveringerItemEjendomsForm";
            this.ItemPanel.ResumeLayout(false);
            this.ItemPanel.PerformLayout();
            this.Checkboxes.ResumeLayout(false);
            this.Checkboxes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ItemPanel;
        private System.Windows.Forms.Label RenorveringsId;
        private System.Windows.Forms.Button RedigerButton;
        private System.Windows.Forms.Button SletButton;
        private System.Windows.Forms.FlowLayoutPanel Checkboxes;
        private System.Windows.Forms.CheckBox KøkkenCheckBox;
        private System.Windows.Forms.CheckBox BadeværelseCheckBox;
        private System.Windows.Forms.CheckBox AndetCheckBox;
        private System.Windows.Forms.Label OmbygningsÅr;
    }
}