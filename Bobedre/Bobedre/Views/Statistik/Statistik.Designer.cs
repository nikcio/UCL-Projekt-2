
namespace Bobedre.Views.Statistik
{
    partial class Statistik
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.PostnummerComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MedarbjederComboBox = new System.Windows.Forms.ComboBox();
            this.StartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SlutDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PrisComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.VisButton = new System.Windows.Forms.Button();
            this.GemButton = new System.Windows.Forms.Button();
            this.AntalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 90);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1134, 467);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // PostnummerComboBox
            // 
            this.PostnummerComboBox.FormattingEnabled = true;
            this.PostnummerComboBox.Location = new System.Drawing.Point(12, 56);
            this.PostnummerComboBox.Name = "PostnummerComboBox";
            this.PostnummerComboBox.Size = new System.Drawing.Size(151, 28);
            this.PostnummerComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Postnummer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Medarbejder";
            // 
            // MedarbjederComboBox
            // 
            this.MedarbjederComboBox.DropDownWidth = 251;
            this.MedarbjederComboBox.FormattingEnabled = true;
            this.MedarbjederComboBox.Location = new System.Drawing.Point(186, 56);
            this.MedarbjederComboBox.Name = "MedarbjederComboBox";
            this.MedarbjederComboBox.Size = new System.Drawing.Size(151, 28);
            this.MedarbjederComboBox.TabIndex = 3;
            // 
            // StartDateTimePicker
            // 
            this.StartDateTimePicker.Location = new System.Drawing.Point(363, 56);
            this.StartDateTimePicker.Name = "StartDateTimePicker";
            this.StartDateTimePicker.Size = new System.Drawing.Size(194, 27);
            this.StartDateTimePicker.TabIndex = 5;
            // 
            // SlutDateTimePicker
            // 
            this.SlutDateTimePicker.Location = new System.Drawing.Point(579, 54);
            this.SlutDateTimePicker.Name = "SlutDateTimePicker";
            this.SlutDateTimePicker.Size = new System.Drawing.Size(192, 27);
            this.SlutDateTimePicker.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Start dato";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(579, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Slut dato";
            // 
            // PrisComboBox
            // 
            this.PrisComboBox.FormattingEnabled = true;
            this.PrisComboBox.Location = new System.Drawing.Point(794, 53);
            this.PrisComboBox.Name = "PrisComboBox";
            this.PrisComboBox.Size = new System.Drawing.Size(151, 28);
            this.PrisComboBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(794, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Pris";
            // 
            // VisButton
            // 
            this.VisButton.AutoSize = true;
            this.VisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VisButton.Location = new System.Drawing.Point(1052, 49);
            this.VisButton.Name = "VisButton";
            this.VisButton.Size = new System.Drawing.Size(94, 32);
            this.VisButton.TabIndex = 11;
            this.VisButton.Text = "Vis";
            this.VisButton.UseVisualStyleBackColor = true;
            this.VisButton.Click += new System.EventHandler(this.VisButton_Click);
            // 
            // GemButton
            // 
            this.GemButton.AutoSize = true;
            this.GemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GemButton.Location = new System.Drawing.Point(1052, 12);
            this.GemButton.Name = "GemButton";
            this.GemButton.Size = new System.Drawing.Size(94, 32);
            this.GemButton.TabIndex = 12;
            this.GemButton.Text = "Gem";
            this.GemButton.UseVisualStyleBackColor = true;
            this.GemButton.Click += new System.EventHandler(this.GemButton_Click);
            // 
            // AntalLabel
            // 
            this.AntalLabel.AutoSize = true;
            this.AntalLabel.Location = new System.Drawing.Point(951, 25);
            this.AntalLabel.Name = "AntalLabel";
            this.AntalLabel.Size = new System.Drawing.Size(67, 20);
            this.AntalLabel.TabIndex = 13;
            this.AntalLabel.Text = "Antal: 10";
            // 
            // Statistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 569);
            this.Controls.Add(this.AntalLabel);
            this.Controls.Add(this.GemButton);
            this.Controls.Add(this.VisButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PrisComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SlutDateTimePicker);
            this.Controls.Add(this.StartDateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MedarbjederComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PostnummerComboBox);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Statistik";
            this.Text = "Statistik";
            this.Load += new System.EventHandler(this.Statistik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox PostnummerComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox MedarbjederComboBox;
        private System.Windows.Forms.DateTimePicker StartDateTimePicker;
        private System.Windows.Forms.DateTimePicker SlutDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox PrisComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button VisButton;
        private System.Windows.Forms.Button GemButton;
        private System.Windows.Forms.Label AntalLabel;
    }
}