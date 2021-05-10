
namespace Bobedre.Views.Annoncering
{
    partial class AnnonceringView
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
            this.TilføjKnap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 45);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(999, 405);
            this.flowLayoutPanel1.TabIndex = 1;
           
            // 
            // TilføjKnap
            // 
            this.TilføjKnap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TilføjKnap.Location = new System.Drawing.Point(2, 12);
            this.TilføjKnap.Name = "TilføjKnap";
            this.TilføjKnap.Size = new System.Drawing.Size(172, 26);
            this.TilføjKnap.TabIndex = 2;
            this.TilføjKnap.Text = "Tilføj Annoncering";
            this.TilføjKnap.UseVisualStyleBackColor = true;
            this.TilføjKnap.Click += new System.EventHandler(this.TilføjKnap_Click);
            // 
            // AnnonceringView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 462);
            this.Controls.Add(this.TilføjKnap);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnnonceringView";
            this.Text = "AnnonceringView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button TilføjKnap;
    }
}