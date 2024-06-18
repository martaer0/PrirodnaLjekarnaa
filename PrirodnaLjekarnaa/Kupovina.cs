using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrirodnaLjekarnaa
{
    public partial class Kupovina : Form
    {
        //List<string> stringList = new List<string>();

        public Kupovina()
        {
            InitializeComponent();
        }


        //da ne moram pisat isto nonstop za racunanje konacne cijene 
        public static double RacunanjeCijene(MaskedTextBox n, MaskedTextBox m, MaskedTextBox k)
        {
            int val = 1;
            if (n.Text != "1")
            {
                val = int.Parse(n.Text);
            }

            double cijena = double.Parse(m.Text) * val;
            k.Text = cijena.ToString();
            return cijena;
        }


        //rastvaljanje svake linije u cilom fileu za kosaricu
        public static void RastavljanjeSvLinije(StreamReader reader, int lNb, TextBox m, MaskedTextBox n)
        {
            string line;
            int currentLineNumber = 0;
            while ((line = reader.ReadLine()) != null)
            {
                currentLineNumber++;
                if (currentLineNumber == lNb)
                {
                    string[] linija1 = line.Split('|');
                    m.Text = linija1[0];
                    n.Text = linija1[3];
                    currentLineNumber = 0;
                    break;
                }

            }
        }


        //samo kad je jedan proizvod odabran - razlog ovomu je da se moze odmah samo jedan proizvod uzest bez koraka za kosaricu
        private void JedanProizvod_CheckedChanged(object sender, EventArgs e)
        {
            List<string> stringList = new List<string>();
            StreamReader sr = new StreamReader("..\\..\\KupovinaJedanProizvod.txt");
            string line = sr.ReadLine();
            int val1 = 1;

            while (line != null)
            {
                stringList.Add(line);
                line = sr.ReadLine();
            }
            
            string[] linija1 = line.Split('|');
            textBox11.Text = linija1[0];
            maskedTextBox16.Text = linija1[1];            

            if (maskedTextBox6.Text != "1")
            {                
                val1 = int.Parse(maskedTextBox11.Text);
            }

            double cijena = double.Parse(maskedTextBox16.Text) * val1;
            maskedTextBox11.Text = cijena.ToString();

            double ukcijena = cijena + int.Parse(textBox6.Text);
            textBox9.Text = ukcijena.ToString();

            
        }

        
        //cijela kosarica
        private void Kosarica_CheckedChanged(object sender, EventArgs e)
        {            
            using (StreamReader reader = new StreamReader("..\\..\\PotvrdenaKosarica.txt"))
            {              
                
                int lNb1 = 1, lNb2 = 2, lNb3 = 3, lNb4 = 4, lNb5 = 5, lNb6 = 6, lNb7 = 7;
                

                RastavljanjeSvLinije(reader, lNb1, textBox11, maskedTextBox16);
                RastavljanjeSvLinije(reader, lNb2, textBox2, maskedTextBox2);
                RastavljanjeSvLinije(reader, lNb3, textBox3, maskedTextBox3);
                RastavljanjeSvLinije(reader, lNb4, textBox4, maskedTextBox4);
                RastavljanjeSvLinije(reader, lNb5, textBox5, maskedTextBox5);
                RastavljanjeSvLinije(reader, lNb6, textBox7, maskedTextBox17);
                RastavljanjeSvLinije(reader, lNb7, textBox8, maskedTextBox18);               

                
            }

            double cijena1 = RacunanjeCijene(maskedTextBox6, maskedTextBox16, maskedTextBox11);
            double cijena2 = RacunanjeCijene(maskedTextBox7, maskedTextBox2, maskedTextBox12);
            double cijena3 = RacunanjeCijene(maskedTextBox8, maskedTextBox3, maskedTextBox13);
            double cijena4 = RacunanjeCijene(maskedTextBox9, maskedTextBox4, maskedTextBox14);
            double cijena5 = RacunanjeCijene(maskedTextBox10, maskedTextBox5, maskedTextBox15);
            double cijena6 = RacunanjeCijene(maskedTextBox21, maskedTextBox17, maskedTextBox25);
            double cijena7 = RacunanjeCijene(maskedTextBox22, maskedTextBox18, maskedTextBox26);


            double ukcijena = (cijena1 + cijena2 + cijena3 + cijena4 + cijena5 + cijena6 + cijena7) + int.Parse(textBox6.Text); 
            textBox9.Text = ukcijena.ToString();           

        }



        public static void BrisanjeLinije(TextBox a, MaskedTextBox b, MaskedTextBox c, MaskedTextBox d)
        {
            a.Text = "";
            b.Text = "";
            c.Text = "";
            d.Text = "";           

        }


        private void button9_Click(object sender, EventArgs e)
        {
            if(JedanProizvod.Checked == true)
            {
                BrisanjeLinije(textBox11, maskedTextBox16, maskedTextBox6, maskedTextBox11);

                File.Delete(Admin.FilePath5);

            }

            if (Kosarica.Checked == true)
            {
                BrisanjeLinije(textBox11, maskedTextBox16, maskedTextBox6, maskedTextBox11);
            }

        }
        

        private void button5_Click(object sender, EventArgs e)
        {
            if (Kosarica.Checked == true)
            {
                BrisanjeLinije(textBox2, maskedTextBox2, maskedTextBox7, maskedTextBox12);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Kosarica.Checked == true)
            {
                BrisanjeLinije(textBox3, maskedTextBox3, maskedTextBox8, maskedTextBox13);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Kosarica.Checked == true)
            {
                BrisanjeLinije(textBox4, maskedTextBox4, maskedTextBox9, maskedTextBox14);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Kosarica.Checked == true)
            {
                BrisanjeLinije(textBox5, maskedTextBox5, maskedTextBox10, maskedTextBox15);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Kosarica.Checked == true)
            {
                BrisanjeLinije(textBox7, maskedTextBox17, maskedTextBox21, maskedTextBox25);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Kosarica.Checked == true)
            {
                BrisanjeLinije(textBox8, maskedTextBox18, maskedTextBox22, maskedTextBox26);
            }
        }


        //potpuno brisanje
        private void button1_Click(object sender, EventArgs e)
        {
            if(JedanProizvod.Checked == true)
            {
                BrisanjeLinije(textBox11, maskedTextBox16, maskedTextBox6, maskedTextBox11);
                File.Delete(Admin.FilePath5);

            }


            if (Kosarica.Checked == true)
            {
                BrisanjeLinije(textBox11, maskedTextBox16, maskedTextBox6, maskedTextBox11);
                BrisanjeLinije(textBox2, maskedTextBox2, maskedTextBox7, maskedTextBox12);
                BrisanjeLinije(textBox3, maskedTextBox3, maskedTextBox8, maskedTextBox13);
                BrisanjeLinije(textBox4, maskedTextBox4, maskedTextBox9, maskedTextBox14);
                BrisanjeLinije(textBox5, maskedTextBox5, maskedTextBox10, maskedTextBox15);
                BrisanjeLinije(textBox7, maskedTextBox17, maskedTextBox21, maskedTextBox25);
                BrisanjeLinije(textBox8, maskedTextBox18, maskedTextBox22, maskedTextBox26);
                File.Delete(Admin.FilePath7);

            }

            else MessageBox.Show("Niste označili način kupnje.");

        }


        //ode nazad nista se ne sprema 
        private void button2_Click(object sender, EventArgs e)
        {
            Proizvodi odvestProizvodi = new Proizvodi();
            odvestProizvodi.ShowDialog();
            File.Delete(Admin.FilePath5);
            this.Close();
        }


        //konacno - zavrsetak
        private void button4_Click(object sender, EventArgs e)
        {
            if (Kosarica.Checked == true)
            {
                if ((textBox11.Text != "" || textBox2.Text != "" || textBox3.Text != "" || textBox4.Text != "" || textBox5.Text != "" || textBox7.Text != "" || textBox8.Text != "") && textBox1.Text != "" && maskedTextBox1.Text != "")
                {
                    string dolazak = DateTime.Now.ToString() + 5;
                    MessageBox.Show("Vaša kupnja je gotova. Očekivani dolazak pošiljke je {0}", dolazak);

                    File.Delete(Admin.FilePath5);
                    File.Delete(Admin.FilePath7);

                    NaslovnaStranicaPL frmDodaj = new NaslovnaStranicaPL();
                    frmDodaj.ShowDialog();
                    this.Close();
                }

                else if((textBox11.Text != "" || textBox2.Text != "" || textBox3.Text != "" || textBox4.Text != "" || textBox5.Text != "" || textBox7.Text != "" || textBox8.Text != "") && (textBox1.Text == "" || maskedTextBox1.Text == ""))
                {
                    MessageBox.Show("Nisu svi podaci uneseni. Pokušajte ponovno.");
                }
                
                else if(textBox11.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "" && textBox5.Text == "" && textBox7.Text == "" && textBox8.Text == "")
                {
                    MessageBox.Show("U košarici nema ničega. Vratite se nazad!");
                    File.Delete(Admin.FilePath7);

                }

            }

            if (JedanProizvod.Checked == true)
            {
                if((textBox11.Text != "") && (textBox1.Text != "") && (maskedTextBox1.Text != ""))
                {
                    string dolazak = DateTime.Now.ToString() + 3;
                    MessageBox.Show("Vaša kupnja je gotova. Očekivani dolazak pošiljke je {0}", dolazak);

                    File.Delete(Admin.FilePath7);
                    File.Delete(Admin.FilePath5);

                    NaslovnaStranicaPL frmDodaj = new NaslovnaStranicaPL();
                    frmDodaj.ShowDialog();
                    this.Close();
                }

                else if ((textBox11.Text != "") && ((textBox1.Text == "") || (maskedTextBox1.Text == "")))
                {
                    MessageBox.Show("Nisu svi podaci uneseni. Pokušajte ponovno.");
                }
                
                else if(textBox11.Text == "")
                {
                    MessageBox.Show("U poljima nema ničega. Vratite se na proizvode!");
                }
            }            

            else MessageBox.Show("Niste označili način kupnje!");

        }



        private void naslovnicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NaslovnaStranicaPL frmDodaj = new NaslovnaStranicaPL();
            frmDodaj.ShowDialog();
            File.Delete(Admin.FilePath5);
            this.Close();
        }

        private void proizvodiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Proizvodi frmDodaj = new Proizvodi();
            frmDodaj.ShowDialog();
            File.Delete(Admin.FilePath5);
            this.Close();
        }

        private void košaricaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kosarica frmDodaj = new Kosarica();
            frmDodaj.ShowDialog();
            File.Delete(Admin.FilePath5);
            this.Close();
        }

        private void dodajNovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodajNovo frmDodaj = new DodajNovo();
            frmDodaj.ShowDialog();
            File.Delete(Admin.FilePath5);
            this.Close();
        }

        private void najčešćeBolestiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NajcesceBolesti frmDodaj = new NajcesceBolesti();
            frmDodaj.ShowDialog();
            File.Delete(Admin.FilePath5);
            this.Close();
        }

        private void oNamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Onama2 frmDodaj = new Onama2();
            frmDodaj.ShowDialog();
            File.Delete(Admin.FilePath5);
            this.Close();
        }
    }
}
