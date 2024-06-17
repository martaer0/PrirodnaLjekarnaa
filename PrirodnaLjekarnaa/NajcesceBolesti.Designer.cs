namespace PrirodnaLjekarnaa
{
    partial class NajcesceBolesti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NajcesceBolesti));
            this.label1 = new System.Windows.Forms.Label();
            this.lbxListaBolesti = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbxPreporuceniProizvodi = new System.Windows.Forms.ListBox();
            this.gbOdabraniProizvod = new System.Windows.Forms.GroupBox();
            this.tbOpis = new System.Windows.Forms.TextBox();
            this.tbLjekovitaSvojstva = new System.Windows.Forms.TextBox();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnUKosaricu = new System.Windows.Forms.Button();
            this.btnKupiProizvod = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.naslovnicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ispisKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proizvodiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.košaricaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kupiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNovoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.najčešćeBolestiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomoćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oNamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label9 = new System.Windows.Forms.Label();
            this.tbCijena = new System.Windows.Forms.TextBox();
            this.gbOdabraniProizvod.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Najčešće bolesti i rješenja";
            // 
            // lbxListaBolesti
            // 
            this.lbxListaBolesti.FormattingEnabled = true;
            this.lbxListaBolesti.ItemHeight = 16;
            this.lbxListaBolesti.Items.AddRange(new object[] {
            "Glavobolja",
            "Mučnina",
            "Žgaravica"});
            this.lbxListaBolesti.Location = new System.Drawing.Point(19, 121);
            this.lbxListaBolesti.Name = "lbxListaBolesti";
            this.lbxListaBolesti.Size = new System.Drawing.Size(347, 148);
            this.lbxListaBolesti.TabIndex = 1;
            this.lbxListaBolesti.SelectedIndexChanged += new System.EventHandler(this.lbxListaBolesti_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(14, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Odaberite bolest:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(14, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Preporučeni proizvodi:";
            // 
            // lbxPreporuceniProizvodi
            // 
            this.lbxPreporuceniProizvodi.FormattingEnabled = true;
            this.lbxPreporuceniProizvodi.ItemHeight = 16;
            this.lbxPreporuceniProizvodi.Location = new System.Drawing.Point(19, 307);
            this.lbxPreporuceniProizvodi.Name = "lbxPreporuceniProizvodi";
            this.lbxPreporuceniProizvodi.Size = new System.Drawing.Size(347, 116);
            this.lbxPreporuceniProizvodi.TabIndex = 4;
            this.lbxPreporuceniProizvodi.SelectedIndexChanged += new System.EventHandler(this.lbxPreporuceniProizvodi_SelectedIndexChanged);
            // 
            // gbOdabraniProizvod
            // 
            this.gbOdabraniProizvod.Controls.Add(this.tbCijena);
            this.gbOdabraniProizvod.Controls.Add(this.label9);
            this.gbOdabraniProizvod.Controls.Add(this.tbOpis);
            this.gbOdabraniProizvod.Controls.Add(this.tbLjekovitaSvojstva);
            this.gbOdabraniProizvod.Controls.Add(this.tbIme);
            this.gbOdabraniProizvod.Controls.Add(this.label7);
            this.gbOdabraniProizvod.Controls.Add(this.label6);
            this.gbOdabraniProizvod.Controls.Add(this.label5);
            this.gbOdabraniProizvod.Location = new System.Drawing.Point(410, 89);
            this.gbOdabraniProizvod.Name = "gbOdabraniProizvod";
            this.gbOdabraniProizvod.Size = new System.Drawing.Size(378, 300);
            this.gbOdabraniProizvod.TabIndex = 5;
            this.gbOdabraniProizvod.TabStop = false;
            this.gbOdabraniProizvod.Visible = false;
            // 
            // tbOpis
            // 
            this.tbOpis.Location = new System.Drawing.Point(15, 183);
            this.tbOpis.Multiline = true;
            this.tbOpis.Name = "tbOpis";
            this.tbOpis.Size = new System.Drawing.Size(282, 68);
            this.tbOpis.TabIndex = 6;
            // 
            // tbLjekovitaSvojstva
            // 
            this.tbLjekovitaSvojstva.Location = new System.Drawing.Point(15, 74);
            this.tbLjekovitaSvojstva.Multiline = true;
            this.tbLjekovitaSvojstva.Name = "tbLjekovitaSvojstva";
            this.tbLjekovitaSvojstva.Size = new System.Drawing.Size(282, 73);
            this.tbLjekovitaSvojstva.TabIndex = 5;
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(57, 16);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(166, 22);
            this.tbIme.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.4F);
            this.label7.Location = new System.Drawing.Point(11, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Opis:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.4F);
            this.label6.Location = new System.Drawing.Point(11, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ljekovita svojstva:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.4F);
            this.label5.Location = new System.Drawing.Point(11, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ime:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(405, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Odabrani proizvod";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(393, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 16);
            this.label8.TabIndex = 7;
            // 
            // btnUKosaricu
            // 
            this.btnUKosaricu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnUKosaricu.Location = new System.Drawing.Point(534, 395);
            this.btnUKosaricu.Name = "btnUKosaricu";
            this.btnUKosaricu.Size = new System.Drawing.Size(173, 33);
            this.btnUKosaricu.TabIndex = 8;
            this.btnUKosaricu.Text = "Dodaj u košaricu";
            this.btnUKosaricu.UseVisualStyleBackColor = true;
            this.btnUKosaricu.Click += new System.EventHandler(this.btnUKosaricu_Click);
            // 
            // btnKupiProizvod
            // 
            this.btnKupiProizvod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnKupiProizvod.Location = new System.Drawing.Point(713, 395);
            this.btnKupiProizvod.Name = "btnKupiProizvod";
            this.btnKupiProizvod.Size = new System.Drawing.Size(75, 33);
            this.btnKupiProizvod.TabIndex = 9;
            this.btnKupiProizvod.Text = "Kupi";
            this.btnKupiProizvod.UseVisualStyleBackColor = true;
            this.btnKupiProizvod.Click += new System.EventHandler(this.btnKupiProizvod_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.naslovnicaToolStripMenuItem,
            this.proizvodiToolStripMenuItem,
            this.doktorToolStripMenuItem,
            this.pomoćToolStripMenuItem,
            this.oNamaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // naslovnicaToolStripMenuItem
            // 
            this.naslovnicaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ispisKorisnikaToolStripMenuItem});
            this.naslovnicaToolStripMenuItem.Name = "naslovnicaToolStripMenuItem";
            this.naslovnicaToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.naslovnicaToolStripMenuItem.Text = "Naslovnica";
            // 
            // ispisKorisnikaToolStripMenuItem
            // 
            this.ispisKorisnikaToolStripMenuItem.Name = "ispisKorisnikaToolStripMenuItem";
            this.ispisKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.ispisKorisnikaToolStripMenuItem.Text = "Ispis korisnika";
            // 
            // proizvodiToolStripMenuItem
            // 
            this.proizvodiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.košaricaToolStripMenuItem,
            this.kupiToolStripMenuItem,
            this.dodajNovoToolStripMenuItem});
            this.proizvodiToolStripMenuItem.Name = "proizvodiToolStripMenuItem";
            this.proizvodiToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.proizvodiToolStripMenuItem.Text = "Proizvodi";
            // 
            // košaricaToolStripMenuItem
            // 
            this.košaricaToolStripMenuItem.Name = "košaricaToolStripMenuItem";
            this.košaricaToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.košaricaToolStripMenuItem.Text = "Košarica";
            // 
            // kupiToolStripMenuItem
            // 
            this.kupiToolStripMenuItem.Name = "kupiToolStripMenuItem";
            this.kupiToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.kupiToolStripMenuItem.Text = "Kupi";
            // 
            // dodajNovoToolStripMenuItem
            // 
            this.dodajNovoToolStripMenuItem.Name = "dodajNovoToolStripMenuItem";
            this.dodajNovoToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.dodajNovoToolStripMenuItem.Text = "Dodaj novo";
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
            // 
            // pomoćToolStripMenuItem
            // 
            this.pomoćToolStripMenuItem.Name = "pomoćToolStripMenuItem";
            this.pomoćToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.pomoćToolStripMenuItem.Text = "Pomoć";
            // 
            // oNamaToolStripMenuItem
            // 
            this.oNamaToolStripMenuItem.Name = "oNamaToolStripMenuItem";
            this.oNamaToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.oNamaToolStripMenuItem.Text = "O nama";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.4F);
            this.label9.Location = new System.Drawing.Point(11, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Cijena:";
            // 
            // tbCijena
            // 
            this.tbCijena.Location = new System.Drawing.Point(74, 263);
            this.tbCijena.Name = "tbCijena";
            this.tbCijena.Size = new System.Drawing.Size(149, 22);
            this.tbCijena.TabIndex = 8;
            // 
            // NajcesceBolesti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnKupiProizvod);
            this.Controls.Add(this.btnUKosaricu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gbOdabraniProizvod);
            this.Controls.Add(this.lbxPreporuceniProizvodi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbxListaBolesti);
            this.Controls.Add(this.label1);
            this.Name = "NajcesceBolesti";
            this.Text = "Najčešće bolesti";
            this.gbOdabraniProizvod.ResumeLayout(false);
            this.gbOdabraniProizvod.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxListaBolesti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbxPreporuceniProizvodi;
        private System.Windows.Forms.GroupBox gbOdabraniProizvod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbOpis;
        private System.Windows.Forms.TextBox tbLjekovitaSvojstva;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.Button btnUKosaricu;
        private System.Windows.Forms.Button btnKupiProizvod;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem naslovnicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ispisKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proizvodiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem košaricaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kupiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNovoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem najčešćeBolestiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomoćToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oNamaToolStripMenuItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbCijena;
    }
}