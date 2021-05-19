
namespace Bobedre.Views.ÅbentHus
{
    partial class ÅbentHus
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
            this.label1 = new System.Windows.Forms.Label();
            this.bogstav1comboBox = new System.Windows.Forms.ComboBox();
            this.bogstav2comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 76);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1134, 481);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Søg på bogstavs interval:";
            // 
            // bogstav1comboBox
            // 
            this.bogstav1comboBox.FormattingEnabled = true;
            this.bogstav1comboBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "Æ",
            "Ø",
            "Å"});
            this.bogstav1comboBox.Location = new System.Drawing.Point(194, 32);
            this.bogstav1comboBox.Name = "bogstav1comboBox";
            this.bogstav1comboBox.Size = new System.Drawing.Size(58, 28);
            this.bogstav1comboBox.TabIndex = 2;
            this.bogstav1comboBox.SelectedIndexChanged += new System.EventHandler(this.bogstav1comboBox_SelectedIndexChanged);
            // 
            // bogstav2comboBox
            // 
            this.bogstav2comboBox.FormattingEnabled = true;
            this.bogstav2comboBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "Æ",
            "Ø",
            "Å"});
            this.bogstav2comboBox.Location = new System.Drawing.Point(284, 32);
            this.bogstav2comboBox.Name = "bogstav2comboBox";
            this.bogstav2comboBox.Size = new System.Drawing.Size(58, 28);
            this.bogstav2comboBox.TabIndex = 3;
            this.bogstav2comboBox.SelectedIndexChanged += new System.EventHandler(this.bogstav2comboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "-";
            // 
            // ÅbentHus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 569);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bogstav2comboBox);
            this.Controls.Add(this.bogstav1comboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ÅbentHus";
            this.Text = "ÅbentHus";
            this.Load += new System.EventHandler(this.ÅbentHus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox bogstav1comboBox;
        private System.Windows.Forms.ComboBox bogstav2comboBox;
        private System.Windows.Forms.Label label2;
    }
}