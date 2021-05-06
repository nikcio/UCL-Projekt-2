
namespace Bobedre.Views.Ejendomme
{
    partial class EjendommeView
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
            this.TilføjBoligKnap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;

            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 36);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1006, 419);

            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // TilføjBoligKnap
            // 
            this.TilføjBoligKnap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TilføjBoligKnap.Location = new System.Drawing.Point(8, 8);
            this.TilføjBoligKnap.Name = "TilføjBoligKnap";
            this.TilføjBoligKnap.Size = new System.Drawing.Size(126, 23);
            this.TilføjBoligKnap.TabIndex = 0;
            this.TilføjBoligKnap.Text = "Tilføj Bolig";
            this.TilføjBoligKnap.Click += new System.EventHandler(this.TilføjBoligKnap_Click);
            // 
            // EjendommeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 462);

            this.Controls.Add(this.TilføjBoligKnap);

            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EjendommeView";
            this.Text = "EjendommeView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button TilføjBoligKnap;

    }
}