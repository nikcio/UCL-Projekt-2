
namespace Bobedre.Views.Sager
{
    partial class Sager
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
            this.SagNr = new System.Windows.Forms.Label();
            this.SagNrTextBox = new System.Windows.Forms.TextBox();
            this.GebyrTextBox = new System.Windows.Forms.TextBox();
            this.Gebyr = new System.Windows.Forms.Label();
            this.SalærTextBox = new System.Windows.Forms.TextBox();
            this.Salær = new System.Windows.Forms.Label();
            this.TilknytningerFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.GemButton = new System.Windows.Forms.Button();
            this.SletButton = new System.Windows.Forms.Button();
            this.LukButton = new System.Windows.Forms.Button();
            this.OprettelsesDato = new System.Windows.Forms.DateTimePicker();
            this.TilSalgDato = new System.Windows.Forms.DateTimePicker();
            this.OverdragelsesDato = new System.Windows.Forms.DateTimePicker();
            this.AfsllutningsDato = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SolgtCheckBox = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SagNr
            // 
            this.SagNr.AutoSize = true;
            this.SagNr.Location = new System.Drawing.Point(43, 24);
            this.SagNr.Name = "SagNr";
            this.SagNr.Size = new System.Drawing.Size(39, 15);
            this.SagNr.TabIndex = 0;
            this.SagNr.Text = "SagNr";
            // 
            // SagNrTextBox
            // 
            this.SagNrTextBox.Location = new System.Drawing.Point(163, 21);
            this.SagNrTextBox.Name = "SagNrTextBox";
            this.SagNrTextBox.ReadOnly = true;
            this.SagNrTextBox.Size = new System.Drawing.Size(200, 23);
            this.SagNrTextBox.TabIndex = 1;
            // 
            // GebyrTextBox
            // 
            this.GebyrTextBox.Location = new System.Drawing.Point(163, 50);
            this.GebyrTextBox.Name = "GebyrTextBox";
            this.GebyrTextBox.Size = new System.Drawing.Size(200, 23);
            this.GebyrTextBox.TabIndex = 3;
            // 
            // Gebyr
            // 
            this.Gebyr.AutoSize = true;
            this.Gebyr.Location = new System.Drawing.Point(43, 53);
            this.Gebyr.Name = "Gebyr";
            this.Gebyr.Size = new System.Drawing.Size(38, 15);
            this.Gebyr.TabIndex = 2;
            this.Gebyr.Text = "Gebyr";
            // 
            // SalærTextBox
            // 
            this.SalærTextBox.Location = new System.Drawing.Point(163, 79);
            this.SalærTextBox.Name = "SalærTextBox";
            this.SalærTextBox.Size = new System.Drawing.Size(200, 23);
            this.SalærTextBox.TabIndex = 5;
            // 
            // Salær
            // 
            this.Salær.AutoSize = true;
            this.Salær.Location = new System.Drawing.Point(43, 82);
            this.Salær.Name = "Salær";
            this.Salær.Size = new System.Drawing.Size(36, 15);
            this.Salær.TabIndex = 4;
            this.Salær.Text = "Salær";
            // 
            // TilknytningerFlowLayoutPanel
            // 
            this.TilknytningerFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TilknytningerFlowLayoutPanel.AutoScroll = true;
            this.TilknytningerFlowLayoutPanel.Location = new System.Drawing.Point(467, 21);
            this.TilknytningerFlowLayoutPanel.Name = "TilknytningerFlowLayoutPanel";
            this.TilknytningerFlowLayoutPanel.Size = new System.Drawing.Size(534, 394);
            this.TilknytningerFlowLayoutPanel.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.GemButton);
            this.flowLayoutPanel1.Controls.Add(this.SletButton);
            this.flowLayoutPanel1.Controls.Add(this.LukButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(43, 315);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(328, 66);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // GemButton
            // 
            this.GemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GemButton.Location = new System.Drawing.Point(3, 3);
            this.GemButton.Name = "GemButton";
            this.GemButton.Size = new System.Drawing.Size(83, 35);
            this.GemButton.TabIndex = 0;
            this.GemButton.Text = "Gem";
            this.GemButton.UseVisualStyleBackColor = true;
            this.GemButton.Click += new System.EventHandler(this.GemButton_Click);
            // 
            // SletButton
            // 
            this.SletButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SletButton.Location = new System.Drawing.Point(92, 3);
            this.SletButton.Name = "SletButton";
            this.SletButton.Size = new System.Drawing.Size(83, 35);
            this.SletButton.TabIndex = 1;
            this.SletButton.Text = "Slet";
            this.SletButton.UseVisualStyleBackColor = true;
            this.SletButton.Click += new System.EventHandler(this.SletButton_Click);
            // 
            // LukButton
            // 
            this.LukButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LukButton.Location = new System.Drawing.Point(181, 3);
            this.LukButton.Name = "LukButton";
            this.LukButton.Size = new System.Drawing.Size(83, 35);
            this.LukButton.TabIndex = 2;
            this.LukButton.Text = "Luk";
            this.LukButton.UseVisualStyleBackColor = true;
            this.LukButton.Click += new System.EventHandler(this.LukButton_Click);
            // 
            // OprettelsesDato
            // 
            this.OprettelsesDato.Location = new System.Drawing.Point(163, 108);
            this.OprettelsesDato.Name = "OprettelsesDato";
            this.OprettelsesDato.Size = new System.Drawing.Size(200, 23);
            this.OprettelsesDato.TabIndex = 8;
            this.OprettelsesDato.Value = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            // 
            // TilSalgDato
            // 
            this.TilSalgDato.Location = new System.Drawing.Point(163, 137);
            this.TilSalgDato.Name = "TilSalgDato";
            this.TilSalgDato.Size = new System.Drawing.Size(200, 23);
            this.TilSalgDato.TabIndex = 9;
            this.TilSalgDato.Value = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            // 
            // OverdragelsesDato
            // 
            this.OverdragelsesDato.Location = new System.Drawing.Point(163, 166);
            this.OverdragelsesDato.Name = "OverdragelsesDato";
            this.OverdragelsesDato.Size = new System.Drawing.Size(200, 23);
            this.OverdragelsesDato.TabIndex = 10;
            this.OverdragelsesDato.Value = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            // 
            // AfsllutningsDato
            // 
            this.AfsllutningsDato.Location = new System.Drawing.Point(163, 195);
            this.AfsllutningsDato.Name = "AfsllutningsDato";
            this.AfsllutningsDato.Size = new System.Drawing.Size(200, 23);
            this.AfsllutningsDato.TabIndex = 11;
            this.AfsllutningsDato.Value = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Oprettelses dato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Til salg dato";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Overdragelses dato";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Afslutnings dato";
            // 
            // SolgtCheckBox
            // 
            this.SolgtCheckBox.AutoSize = true;
            this.SolgtCheckBox.Location = new System.Drawing.Point(163, 247);
            this.SolgtCheckBox.Name = "SolgtCheckBox";
            this.SolgtCheckBox.Size = new System.Drawing.Size(53, 19);
            this.SolgtCheckBox.TabIndex = 16;
            this.SolgtCheckBox.Text = "Solgt";
            this.SolgtCheckBox.UseVisualStyleBackColor = true;
            // 
            // Sager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 427);
            this.Controls.Add(this.SolgtCheckBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AfsllutningsDato);
            this.Controls.Add(this.OverdragelsesDato);
            this.Controls.Add(this.TilSalgDato);
            this.Controls.Add(this.OprettelsesDato);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.TilknytningerFlowLayoutPanel);
            this.Controls.Add(this.SalærTextBox);
            this.Controls.Add(this.Salær);
            this.Controls.Add(this.GebyrTextBox);
            this.Controls.Add(this.Gebyr);
            this.Controls.Add(this.SagNrTextBox);
            this.Controls.Add(this.SagNr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Sager";
            this.Text = "Sager";
            this.Load += new System.EventHandler(this.Sager_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SagNr;
        private System.Windows.Forms.TextBox SagNrTextBox;
        private System.Windows.Forms.TextBox GebyrTextBox;
        private System.Windows.Forms.Label Gebyr;
        private System.Windows.Forms.TextBox SalærTextBox;
        private System.Windows.Forms.Label Salær;
        private System.Windows.Forms.FlowLayoutPanel TilknytningerFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button GemButton;
        private System.Windows.Forms.Button SletButton;
        private System.Windows.Forms.Button LukButton;
        private System.Windows.Forms.DateTimePicker OprettelsesDato;
        private System.Windows.Forms.DateTimePicker TilSalgDato;
        private System.Windows.Forms.DateTimePicker OverdragelsesDato;
        private System.Windows.Forms.DateTimePicker AfsllutningsDato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox SolgtCheckBox;
    }
}