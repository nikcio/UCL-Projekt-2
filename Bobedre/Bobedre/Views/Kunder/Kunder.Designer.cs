
namespace Bobedre.Views.Kunder
{
    partial class Kunder
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
            this.KundeOpretKnap = new System.Windows.Forms.Button();
            this.KundeGemKnap = new System.Windows.Forms.Button();
            this.KundeSletKnap = new System.Windows.Forms.Button();
            this.KundeNr = new System.Windows.Forms.Label();
            this.KundeNrBox = new System.Windows.Forms.TextBox();
            this.KundeNavn = new System.Windows.Forms.Label();
            this.KundeNavnBox = new System.Windows.Forms.TextBox();
            this.KundeEmail = new System.Windows.Forms.Label();
            this.KundeEmailBox = new System.Windows.Forms.TextBox();
            this.KundeType = new System.Windows.Forms.Label();
            this.KundeTypeComboBox = new System.Windows.Forms.ComboBox();
            this.GåtilbageKnap = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.KundeOpretKnap);
            this.flowLayoutPanel1.Controls.Add(this.KundeGemKnap);
            this.flowLayoutPanel1.Controls.Add(this.KundeSletKnap);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 328);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(535, 110);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // KundeOpretKnap
            // 
            this.KundeOpretKnap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KundeOpretKnap.Location = new System.Drawing.Point(3, 3);
            this.KundeOpretKnap.Name = "KundeOpretKnap";
            this.KundeOpretKnap.Size = new System.Drawing.Size(168, 49);
            this.KundeOpretKnap.TabIndex = 0;
            this.KundeOpretKnap.Text = "Opret";
            this.KundeOpretKnap.UseVisualStyleBackColor = true;
            this.KundeOpretKnap.Click += new System.EventHandler(this.KundeOpretKnap_Click);
            // 
            // KundeGemKnap
            // 
            this.KundeGemKnap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KundeGemKnap.Location = new System.Drawing.Point(177, 3);
            this.KundeGemKnap.Name = "KundeGemKnap";
            this.KundeGemKnap.Size = new System.Drawing.Size(168, 49);
            this.KundeGemKnap.TabIndex = 1;
            this.KundeGemKnap.Text = "Gem";
            this.KundeGemKnap.UseVisualStyleBackColor = true;
            this.KundeGemKnap.Click += new System.EventHandler(this.KundeGemKnap_Click);
            // 
            // KundeSletKnap
            // 
            this.KundeSletKnap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KundeSletKnap.Location = new System.Drawing.Point(351, 3);
            this.KundeSletKnap.Name = "KundeSletKnap";
            this.KundeSletKnap.Size = new System.Drawing.Size(168, 49);
            this.KundeSletKnap.TabIndex = 2;
            this.KundeSletKnap.Text = "Slet";
            this.KundeSletKnap.UseVisualStyleBackColor = true;
            this.KundeSletKnap.Click += new System.EventHandler(this.KundeSletKnap_Click);
            // 
            // KundeNr
            // 
            this.KundeNr.AutoSize = true;
            this.KundeNr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KundeNr.Location = new System.Drawing.Point(12, 33);
            this.KundeNr.Name = "KundeNr";
            this.KundeNr.Size = new System.Drawing.Size(57, 15);
            this.KundeNr.TabIndex = 11;
            this.KundeNr.Text = "KundeNr:";
            // 
            // KundeNrBox
            // 
            this.KundeNrBox.Location = new System.Drawing.Point(83, 25);
            this.KundeNrBox.Name = "KundeNrBox";
            this.KundeNrBox.Size = new System.Drawing.Size(100, 23);
            this.KundeNrBox.TabIndex = 12;
            this.KundeNrBox.TextChanged += new System.EventHandler(this.KundeNrBox_TextChanged);
            // 
            // KundeNavn
            // 
            this.KundeNavn.AutoSize = true;
            this.KundeNavn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KundeNavn.Location = new System.Drawing.Point(15, 85);
            this.KundeNavn.Name = "KundeNavn";
            this.KundeNavn.Size = new System.Drawing.Size(38, 15);
            this.KundeNavn.TabIndex = 13;
            this.KundeNavn.Text = "Navn:";
            // 
            // KundeNavnBox
            // 
            this.KundeNavnBox.Location = new System.Drawing.Point(83, 77);
            this.KundeNavnBox.Name = "KundeNavnBox";
            this.KundeNavnBox.Size = new System.Drawing.Size(100, 23);
            this.KundeNavnBox.TabIndex = 14;
            // 
            // KundeEmail
            // 
            this.KundeEmail.AutoSize = true;
            this.KundeEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KundeEmail.Location = new System.Drawing.Point(15, 142);
            this.KundeEmail.Name = "KundeEmail";
            this.KundeEmail.Size = new System.Drawing.Size(39, 15);
            this.KundeEmail.TabIndex = 15;
            this.KundeEmail.Text = "Email:";
            // 
            // KundeEmailBox
            // 
            this.KundeEmailBox.Location = new System.Drawing.Point(83, 134);
            this.KundeEmailBox.Name = "KundeEmailBox";
            this.KundeEmailBox.Size = new System.Drawing.Size(100, 23);
            this.KundeEmailBox.TabIndex = 16;
            // 
            // KundeType
            // 
            this.KundeType.AutoSize = true;
            this.KundeType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KundeType.Location = new System.Drawing.Point(289, 33);
            this.KundeType.Name = "KundeType";
            this.KundeType.Size = new System.Drawing.Size(68, 15);
            this.KundeType.TabIndex = 17;
            this.KundeType.Text = "Kunde Type";
            // 
            // KundeTypeComboBox
            // 
            this.KundeTypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KundeTypeComboBox.FormattingEnabled = true;
            this.KundeTypeComboBox.Items.AddRange(new object[] {
            "Køber",
            "Sælger"});
            this.KundeTypeComboBox.Location = new System.Drawing.Point(363, 25);
            this.KundeTypeComboBox.Name = "KundeTypeComboBox";
            this.KundeTypeComboBox.Size = new System.Drawing.Size(121, 23);
            this.KundeTypeComboBox.TabIndex = 18;
            this.KundeTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.KundeTypeComboBox_SelectedIndexChanged);
            // 
            // GåtilbageKnap
            // 
            this.GåtilbageKnap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GåtilbageKnap.Location = new System.Drawing.Point(840, 30);
            this.GåtilbageKnap.Name = "GåtilbageKnap";
            this.GåtilbageKnap.Size = new System.Drawing.Size(75, 23);
            this.GåtilbageKnap.TabIndex = 19;
            this.GåtilbageKnap.Text = "Gå tilbage";
            this.GåtilbageKnap.UseVisualStyleBackColor = true;
            this.GåtilbageKnap.Click += new System.EventHandler(this.GåtilbageKnap_Click);
            // 
            // Kunder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1029, 462);
            this.Controls.Add(this.GåtilbageKnap);
            this.Controls.Add(this.KundeTypeComboBox);
            this.Controls.Add(this.KundeType);
            this.Controls.Add(this.KundeEmailBox);
            this.Controls.Add(this.KundeEmail);
            this.Controls.Add(this.KundeNavnBox);
            this.Controls.Add(this.KundeNavn);
            this.Controls.Add(this.KundeNrBox);
            this.Controls.Add(this.KundeNr);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Kunder";
            this.Text = "Kunder";
            this.Load += new System.EventHandler(this.Kunder_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button KundeOpretKnap;
        private System.Windows.Forms.Button KundeGemKnap;
        private System.Windows.Forms.Button KundeSletKnap;
        private System.Windows.Forms.Label KundeNr;
        private System.Windows.Forms.TextBox KundeNrBox;
        private System.Windows.Forms.Label KundeNavn;
        private System.Windows.Forms.TextBox KundeNavnBox;
        private System.Windows.Forms.Label KundeEmail;
        private System.Windows.Forms.TextBox KundeEmailBox;
        private System.Windows.Forms.Label KundeType;
        private System.Windows.Forms.ComboBox KundeTypeComboBox;
        private System.Windows.Forms.Button GåtilbageKnap;
    }
}