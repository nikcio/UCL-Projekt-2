
namespace Bobedre.Templates.Sager
{
    partial class SagerTilknytningElement
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
            this.AddButton = new System.Windows.Forms.Button();
            this.OpretButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.AddButton);
            this.flowLayoutPanel1.Controls.Add(this.OpretButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(139, 83);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(417, 105);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddButton.Location = new System.Drawing.Point(40, 15);
            this.AddButton.Margin = new System.Windows.Forms.Padding(15);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(148, 70);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Tilføj";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // OpretButton
            // 
            this.OpretButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpretButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OpretButton.Location = new System.Drawing.Point(218, 15);
            this.OpretButton.Margin = new System.Windows.Forms.Padding(15);
            this.OpretButton.Name = "OpretButton";
            this.OpretButton.Size = new System.Drawing.Size(148, 70);
            this.OpretButton.TabIndex = 1;
            this.OpretButton.Text = "Opret ny";
            this.OpretButton.UseVisualStyleBackColor = true;
            this.OpretButton.Click += new System.EventHandler(this.OpretButton_Click);
            // 
            // SagerTilknytningElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SagerTilknytningElement";
            this.Text = "SagerTilknytningElemetn";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button OpretButton;
    }
}