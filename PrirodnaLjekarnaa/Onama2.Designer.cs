using System;

namespace PrirodnaLjekarnaa
{
    partial class Onama2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Onama2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.naslovnicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proizvodiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proizvodiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.košaricaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kupiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNovoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.najčešćeBolestiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oNamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Enabled = false;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.naslovnicaToolStripMenuItem,
            this.proizvodiToolStripMenuItem,
            this.doktorToolStripMenuItem,
            this.oNamaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // naslovnicaToolStripMenuItem
            // 
            this.naslovnicaToolStripMenuItem.Name = "naslovnicaToolStripMenuItem";
            this.naslovnicaToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.naslovnicaToolStripMenuItem.Text = "Naslovnica";
            this.naslovnicaToolStripMenuItem.Click += new System.EventHandler(this.naslovnicaToolStripMenuItem_Click);
            // 
            // proizvodiToolStripMenuItem
            // 
            this.proizvodiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proizvodiToolStripMenuItem1,
            this.košaricaToolStripMenuItem,
            this.kupiToolStripMenuItem,
            this.dodajNovoToolStripMenuItem});
            this.proizvodiToolStripMenuItem.Name = "proizvodiToolStripMenuItem";
            this.proizvodiToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.proizvodiToolStripMenuItem.Text = "Ljekarna";
            // 
            // proizvodiToolStripMenuItem1
            // 
            this.proizvodiToolStripMenuItem1.Name = "proizvodiToolStripMenuItem1";
            this.proizvodiToolStripMenuItem1.Size = new System.Drawing.Size(170, 26);
            this.proizvodiToolStripMenuItem1.Text = "Proizvodi";
            this.proizvodiToolStripMenuItem1.Click += new System.EventHandler(this.proizvodiToolStripMenuItem1_Click);
            // 
            // košaricaToolStripMenuItem
            // 
            this.košaricaToolStripMenuItem.Name = "košaricaToolStripMenuItem";
            this.košaricaToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.košaricaToolStripMenuItem.Text = "Košarica";
            this.košaricaToolStripMenuItem.Click += new System.EventHandler(this.košaricaToolStripMenuItem_Click);
            // 
            // kupiToolStripMenuItem
            // 
            this.kupiToolStripMenuItem.Name = "kupiToolStripMenuItem";
            this.kupiToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.kupiToolStripMenuItem.Text = "Kupi";
            this.kupiToolStripMenuItem.Click += new System.EventHandler(this.kupiToolStripMenuItem_Click);
            // 
            // dodajNovoToolStripMenuItem
            // 
            this.dodajNovoToolStripMenuItem.Name = "dodajNovoToolStripMenuItem";
            this.dodajNovoToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.dodajNovoToolStripMenuItem.Text = "Dodaj novo";
            this.dodajNovoToolStripMenuItem.Click += new System.EventHandler(this.dodajNovoToolStripMenuItem_Click);
            // 
            // doktorToolStripMenuItem
            // 
            this.doktorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.najčešćeBolestiToolStripMenuItem});
            this.doktorToolStripMenuItem.Name = "doktorToolStripMenuItem";
            this.doktorToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.doktorToolStripMenuItem.Text = "Doktor";
            // 
            // najčešćeBolestiToolStripMenuItem
            // 
            this.najčešćeBolestiToolStripMenuItem.Name = "najčešćeBolestiToolStripMenuItem";
            this.najčešćeBolestiToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.najčešćeBolestiToolStripMenuItem.Text = "Najčešće bolesti";
            this.najčešćeBolestiToolStripMenuItem.Click += new System.EventHandler(this.najčešćeBolestiToolStripMenuItem_Click);
            // 
            // oNamaToolStripMenuItem
            // 
            this.oNamaToolStripMenuItem.Name = "oNamaToolStripMenuItem";
            this.oNamaToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.oNamaToolStripMenuItem.Text = "O nama";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(458, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 272);
            this.label1.TabIndex = 3;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(222, 75);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(204, 231);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Marta Ercegović";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(219, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tea Šušnjar";
            // 
            // Onama2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Onama2";
            this.Text = "Onama2";
            
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            this.Closed += new EventHandler(Onama2_Closed);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem naslovnicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proizvodiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proizvodiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem košaricaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kupiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNovoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem najčešćeBolestiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oNamaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}