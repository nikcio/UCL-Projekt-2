﻿
namespace Bobedre.Views
{
    partial class Baseform
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.FlowLayoutPanel();
            this.menuButton = new System.Windows.Forms.Button();
            this.kunderButton = new System.Windows.Forms.Button();
            this.ejendommeButton = new System.Windows.Forms.Button();
            this.ejendomsmæglereButton = new System.Windows.Forms.Button();
            this.sagerButton = new System.Windows.Forms.Button();
            this.statistikButton = new System.Windows.Forms.Button();
            this.søgningButton = new System.Windows.Forms.Button();
            this.åbenhusButton = new System.Windows.Forms.Button();
            this.content = new System.Windows.Forms.Panel();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu.AutoSize = true;
            this.menu.Controls.Add(this.menuButton);
            this.menu.Controls.Add(this.kunderButton);
            this.menu.Controls.Add(this.ejendommeButton);
            this.menu.Controls.Add(this.ejendomsmæglereButton);
            this.menu.Controls.Add(this.sagerButton);
            this.menu.Controls.Add(this.statistikButton);
            this.menu.Controls.Add(this.søgningButton);
            this.menu.Controls.Add(this.åbenhusButton);
            this.menu.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.menu.Location = new System.Drawing.Point(12, 12);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1176, 54);
            this.menu.TabIndex = 0;
            // 
            // menuButton
            // 
            this.menuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuButton.AutoSize = true;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuButton.Location = new System.Drawing.Point(1066, 5);
            this.menuButton.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(100, 40);
            this.menuButton.TabIndex = 0;
            this.menuButton.Text = "Menu";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // kunderButton
            // 
            this.kunderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kunderButton.AutoSize = true;
            this.kunderButton.Enabled = false;
            this.kunderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kunderButton.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kunderButton.Location = new System.Drawing.Point(946, 5);
            this.kunderButton.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.kunderButton.Name = "kunderButton";
            this.kunderButton.Size = new System.Drawing.Size(100, 40);
            this.kunderButton.TabIndex = 1;
            this.kunderButton.Text = "Kunder";
            this.kunderButton.UseVisualStyleBackColor = true;
            this.kunderButton.Visible = false;
            this.kunderButton.Click += new System.EventHandler(this.kunderButton_Click);
            // 
            // ejendommeButton
            // 
            this.ejendommeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ejendommeButton.AutoSize = true;
            this.ejendommeButton.Enabled = false;
            this.ejendommeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ejendommeButton.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ejendommeButton.Location = new System.Drawing.Point(797, 5);
            this.ejendommeButton.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.ejendommeButton.Name = "ejendommeButton";
            this.ejendommeButton.Size = new System.Drawing.Size(129, 40);
            this.ejendommeButton.TabIndex = 2;
            this.ejendommeButton.Text = "Ejendomme";
            this.ejendommeButton.UseVisualStyleBackColor = true;
            this.ejendommeButton.Visible = false;
            this.ejendommeButton.Click += new System.EventHandler(this.ejendommeButton_Click);
            // 
            // ejendomsmæglereButton
            // 
            this.ejendomsmæglereButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ejendomsmæglereButton.AutoSize = true;
            this.ejendomsmæglereButton.Enabled = false;
            this.ejendomsmæglereButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ejendomsmæglereButton.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ejendomsmæglereButton.Location = new System.Drawing.Point(587, 5);
            this.ejendomsmæglereButton.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.ejendomsmæglereButton.Name = "ejendomsmæglereButton";
            this.ejendomsmæglereButton.Size = new System.Drawing.Size(190, 40);
            this.ejendomsmæglereButton.TabIndex = 3;
            this.ejendomsmæglereButton.Text = "Ejendomsmæglere";
            this.ejendomsmæglereButton.UseVisualStyleBackColor = true;
            this.ejendomsmæglereButton.Visible = false;
            this.ejendomsmæglereButton.Click += new System.EventHandler(this.ejendomsmæglereButton_Click);
            // 
            // sagerButton
            // 
            this.sagerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sagerButton.AutoSize = true;
            this.sagerButton.Enabled = false;
            this.sagerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sagerButton.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sagerButton.Location = new System.Drawing.Point(467, 5);
            this.sagerButton.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.sagerButton.Name = "sagerButton";
            this.sagerButton.Size = new System.Drawing.Size(100, 40);
            this.sagerButton.TabIndex = 5;
            this.sagerButton.Text = "Sager";
            this.sagerButton.UseVisualStyleBackColor = true;
            this.sagerButton.Visible = false;
            this.sagerButton.Click += new System.EventHandler(this.sagerButton_Click);
            // 
            // statistikButton
            // 
            this.statistikButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.statistikButton.AutoSize = true;
            this.statistikButton.Enabled = false;
            this.statistikButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statistikButton.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statistikButton.Location = new System.Drawing.Point(347, 5);
            this.statistikButton.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.statistikButton.Name = "statistikButton";
            this.statistikButton.Size = new System.Drawing.Size(100, 40);
            this.statistikButton.TabIndex = 4;
            this.statistikButton.Text = "Statistik";
            this.statistikButton.UseVisualStyleBackColor = true;
            this.statistikButton.Visible = false;
            this.statistikButton.Click += new System.EventHandler(this.statistikButton_Click);
            // 
            // søgningButton
            // 
            this.søgningButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.søgningButton.AutoSize = true;
            this.søgningButton.Enabled = false;
            this.søgningButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.søgningButton.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.søgningButton.Location = new System.Drawing.Point(227, 5);
            this.søgningButton.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.søgningButton.Name = "søgningButton";
            this.søgningButton.Size = new System.Drawing.Size(100, 40);
            this.søgningButton.TabIndex = 6;
            this.søgningButton.Text = "Søgning";
            this.søgningButton.UseVisualStyleBackColor = true;
            this.søgningButton.Visible = false;
            this.søgningButton.Click += new System.EventHandler(this.søgningButton_Click);
            // 
            // åbenhusButton
            // 
            this.åbenhusButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.åbenhusButton.AutoSize = true;
            this.åbenhusButton.Enabled = false;
            this.åbenhusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.åbenhusButton.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.åbenhusButton.Location = new System.Drawing.Point(95, 5);
            this.åbenhusButton.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.åbenhusButton.Name = "åbenhusButton";
            this.åbenhusButton.Size = new System.Drawing.Size(112, 40);
            this.åbenhusButton.TabIndex = 7;
            this.åbenhusButton.Text = "Åbent hus";
            this.åbenhusButton.UseVisualStyleBackColor = true;
            this.åbenhusButton.Visible = false;
            this.åbenhusButton.Click += new System.EventHandler(this.åbenhusButton_Click);
            // 
            // content
            // 
            this.content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.content.AutoScroll = true;
            this.content.Location = new System.Drawing.Point(12, 72);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(1176, 616);
            this.content.TabIndex = 1;
            // 
            // Baseform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.content);
            this.Controls.Add(this.menu);
            this.Name = "Baseform";
            this.Text = "BoBedre mæglere A/S";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel menu;
        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Button kunderButton;
        private System.Windows.Forms.Button ejendommeButton;
        private System.Windows.Forms.Button ejendomsmæglereButton;
        private System.Windows.Forms.Button sagerButton;
        private System.Windows.Forms.Button statistikButton;
        private System.Windows.Forms.Button søgningButton;
        private System.Windows.Forms.Button åbenhusButton;
    }
}

