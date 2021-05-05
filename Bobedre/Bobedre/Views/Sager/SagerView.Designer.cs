
namespace Bobedre.Views.Sager
{
    partial class SagerView
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
            this.OpretSagButton = new System.Windows.Forms.Button();
            this.MedarbjederComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 45);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(999, 405);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // OpretSagButton
            // 
            this.OpretSagButton.AutoSize = true;
            this.OpretSagButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpretSagButton.Location = new System.Drawing.Point(141, 12);
            this.OpretSagButton.Name = "OpretSagButton";
            this.OpretSagButton.Size = new System.Drawing.Size(98, 27);
            this.OpretSagButton.TabIndex = 1;
            this.OpretSagButton.Text = "Opret sag";
            this.OpretSagButton.UseVisualStyleBackColor = true;
            this.OpretSagButton.Click += new System.EventHandler(this.OpretSagButton_Click);
            // 
            // MedarbjederComboBox
            // 
            this.MedarbjederComboBox.FormattingEnabled = true;
            this.MedarbjederComboBox.Location = new System.Drawing.Point(12, 12);
            this.MedarbjederComboBox.Name = "MedarbjederComboBox";
            this.MedarbjederComboBox.Size = new System.Drawing.Size(121, 23);
            this.MedarbjederComboBox.TabIndex = 2;
            // 
            // SagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 462);
            this.Controls.Add(this.MedarbjederComboBox);
            this.Controls.Add(this.OpretSagButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SagerView";
            this.Text = "SagerView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button OpretSagButton;
        private System.Windows.Forms.ComboBox MedarbjederComboBox;
    }
}