namespace PrirodnaLjekarnaa
{
    partial class Racun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Racun));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbxRacun = new System.Windows.Forms.ListBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.btnOtkaziPosiljku = new System.Windows.Forms.Button();
            this.btnUcitajRacun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(47, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Račun:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(392, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dolazak pošiljke:";
            // 
            // lbxRacun
            // 
            this.lbxRacun.FormattingEnabled = true;
            this.lbxRacun.ItemHeight = 16;
            this.lbxRacun.Location = new System.Drawing.Point(52, 49);
            this.lbxRacun.Name = "lbxRacun";
            this.lbxRacun.Size = new System.Drawing.Size(292, 372);
            this.lbxRacun.TabIndex = 2;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(397, 140);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnPotvrdi.Location = new System.Drawing.Point(397, 371);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(98, 40);
            this.btnPotvrdi.TabIndex = 4;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // btnOtkaziPosiljku
            // 
            this.btnOtkaziPosiljku.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnOtkaziPosiljku.Location = new System.Drawing.Point(516, 371);
            this.btnOtkaziPosiljku.Name = "btnOtkaziPosiljku";
            this.btnOtkaziPosiljku.Size = new System.Drawing.Size(115, 40);
            this.btnOtkaziPosiljku.TabIndex = 5;
            this.btnOtkaziPosiljku.Text = "Otkaži pošiljku";
            this.btnOtkaziPosiljku.UseVisualStyleBackColor = true;
            // 
            // btnUcitajRacun
            // 
            this.btnUcitajRacun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnUcitajRacun.Location = new System.Drawing.Point(397, 49);
            this.btnUcitajRacun.Name = "btnUcitajRacun";
            this.btnUcitajRacun.Size = new System.Drawing.Size(123, 44);
            this.btnUcitajRacun.TabIndex = 6;
            this.btnUcitajRacun.Text = "Učitaj račun";
            this.btnUcitajRacun.UseVisualStyleBackColor = true;
            this.btnUcitajRacun.Click += new System.EventHandler(this.btnUcitajRacun_Click);
            // 
            // Racun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUcitajRacun);
            this.Controls.Add(this.btnOtkaziPosiljku);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.lbxRacun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Racun";
            this.Text = "Račun";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbxRacun;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnOtkaziPosiljku;
        private System.Windows.Forms.Button btnUcitajRacun;
    }
}