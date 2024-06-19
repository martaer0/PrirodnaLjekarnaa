using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

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
        public static double RacunanjeCijene(NumericUpDown n, MaskedTextBox m, MaskedTextBox k)
        {                      

            double cijena = double.Parse(m.Text) * Convert.ToInt32(n.Value);
            k.Text = cijena.ToString();
            return cijena;

            
        }


        //rastvaljanje svake linije u cilom fileu za kosaricu
        //public static void RastavljanjeSvLinije(List<string> n)
        //{

        //    //List<string> stringList = new List<string>();
        //    using (StreamReader sr = new StreamReader("..\\..\\PotvrdenaKosarica.txt"))
        //    {
        //        string line = sr.ReadLine();

        //        while (line != null)
        //        {
        //            n.Add(line);
        //            line = sr.ReadLine();
        //        }
        //    }

            
            
            
        //}


        //samo kad je jedan proizvod odabran - razlog ovomu je da se moze odmah samo jedan proizvod uzest bez koraka za kosaricu
        private void JedanProizvod_CheckedChanged(object sender, EventArgs e)
        {
                       

            List<string> stringList = new List<string>();
            using (StreamReader sr = new StreamReader("..\\..\\KupovinaJedanProizvod.txt"))
            {
                string line = sr.ReadLine();               

                while (line != null)
                {
                    stringList.Add(line);
                    line = sr.ReadLine();
                }
            }

            
            if (stringList.Count > 0)            {
                
                string firstLine = stringList[0];
                string[] linija1 = firstLine.Split('|');
                textBox11.Text = linija1[0];
                maskedTextBox16.Text = linija1[1];
            }
            
            
                  
            //double cijena = double.Parse(maskedTextBox16.Text) * Convert.ToInt32(numericUpDown1.Value);
            //maskedTextBox11.Text = cijena.ToString();
            //double ukcijena = cijena + int.Parse(textBox6.Text);
            //textBox9.Text = ukcijena.ToString();
            

            
        }

        
        //cijela kosarica
        private void Kosarica_CheckedChanged(object sender, EventArgs e)
        {
            List<string> stringList = new List<string>();


            using (StreamReader sr = new StreamReader("..\\..\\PotvrdenaKosarica.txt"))
            {
                string line = sr.ReadLine();

                while (line != null)
                {
                    stringList.Add(line);
                    line = sr.ReadLine();
                }
            }


            if (stringList.Count > 0)
            {
                //1.linija
                string line1 = stringList[0];
                string[] linija1 = line1.Split('|');
                textBox11.Text = linija1[0];
                maskedTextBox16.Text = linija1[3];

                if (stringList.Count > 1)
                {
                    //2.linija
                    string line2 = stringList[1];
                    string[] linija2 = line2.Split('|');
                    textBox2.Text = linija2[0];
                    maskedTextBox2.Text = linija2[3];

                    if (stringList.Count > 2)
                    {
                        //3.linija
                        string line3 = stringList[2];
                        string[] linija3 = line3.Split('|');
                        textBox3.Text = linija3[0];
                        maskedTextBox3.Text = linija3[3];

                        if (stringList.Count > 3)
                        {
                            //4.linija
                            string line4 = stringList[3];
                            string[] linija4 = line4.Split('|');
                            textBox4.Text = linija4[0];
                            maskedTextBox4.Text = linija4[3];

                            if (stringList.Count > 4)
                            {
                                //5.linija
                                string line5 = stringList[4];
                                string[] linija5 = line5.Split('|');
                                textBox5.Text = linija5[0];
                                maskedTextBox5.Text = linija5[3];

                                if (stringList.Count > 5)
                                {
                                    //6.linija
                                    string line6 = stringList[5];
                                    string[] linija6 = line6.Split('|');
                                    textBox7.Text = linija6[0];
                                    maskedTextBox17.Text = linija6[3];

                                    if (stringList.Count > 6)
                                    {
                                        //7.linija
                                        string line7 = stringList[6];
                                        string[] linija7 = line7.Split('|');
                                        textBox8.Text = linija7[0];
                                        maskedTextBox18.Text = linija7[3];

                                    }
                                }
                            }
                        }
                    }
                }
            }






            //double cijena1 = RacunanjeCijene(numericUpDown1, maskedTextBox16, maskedTextBox11);
            //double cijena2 = RacunanjeCijene(numericUpDown2, maskedTextBox2, maskedTextBox12);
            //double cijena3 = RacunanjeCijene(numericUpDown3, maskedTextBox3, maskedTextBox13);
            //double cijena4 = RacunanjeCijene(numericUpDown4, maskedTextBox4, maskedTextBox14);
            //double cijena5 = RacunanjeCijene(numericUpDown5, maskedTextBox5, maskedTextBox15);
            //double cijena6 = RacunanjeCijene(numericUpDown6, maskedTextBox17, maskedTextBox25);
            //double cijena7 = RacunanjeCijene(numericUpDown7, maskedTextBox18, maskedTextBox26);


            //double ukcijena = (cijena1 + cijena2 + cijena3 + cijena4 + cijena5 + cijena6 + cijena7) + int.Parse(textBox6.Text); 
            //textBox9.Text = ukcijena.ToString();           

        }



        public static void BrisanjeLinije(TextBox a, MaskedTextBox b, NumericUpDown c, MaskedTextBox d)
        {
            a.Text = "";
            b.Text = "";
            c.Value = 0;
            d.Text = "";           

        }


        private void button9_Click(object sender, EventArgs e)
        {
            if(JedanProizvod.Checked == true)
            {
                BrisanjeLinije(textBox11, maskedTextBox16, numericUpDown1, maskedTextBox11);

                File.Delete(Admin.FilePath5);

            }

            if (Kosarica.Checked == true)
            {
                BrisanjeLinije(textBox11, maskedTextBox16, numericUpDown1, maskedTextBox11);
            }

        }
        

        private void button5_Click(object sender, EventArgs e)
        {
            if (Kosarica.Checked == true)
            {
                BrisanjeLinije(textBox2, maskedTextBox2, numericUpDown2, maskedTextBox12);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Kosarica.Checked == true)
            {
                BrisanjeLinije(textBox3, maskedTextBox3, numericUpDown3, maskedTextBox13);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Kosarica.Checked == true)
            {
                BrisanjeLinije(textBox4, maskedTextBox4, numericUpDown4, maskedTextBox14);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Kosarica.Checked == true)
            {
                BrisanjeLinije(textBox5, maskedTextBox5, numericUpDown5, maskedTextBox15);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Kosarica.Checked == true)
            {
                BrisanjeLinije(textBox7, maskedTextBox17, numericUpDown6, maskedTextBox25);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Kosarica.Checked == true)
            {
                BrisanjeLinije(textBox8, maskedTextBox18, numericUpDown7, maskedTextBox26);
            }
        }


        //potpuno brisanje
        private void button1_Click(object sender, EventArgs e)
        {
            if(JedanProizvod.Checked == true)
            {
                BrisanjeLinije(textBox11, maskedTextBox16, numericUpDown1, maskedTextBox11);
                File.Delete(Admin.FilePath5);

            }


            if (Kosarica.Checked == true)
            {
                BrisanjeLinije(textBox11, maskedTextBox16, numericUpDown1, maskedTextBox11);
                BrisanjeLinije(textBox2, maskedTextBox2, numericUpDown2, maskedTextBox12);
                BrisanjeLinije(textBox3, maskedTextBox3, numericUpDown3, maskedTextBox13);
                BrisanjeLinije(textBox4, maskedTextBox4, numericUpDown4, maskedTextBox14);
                BrisanjeLinije(textBox5, maskedTextBox5, numericUpDown5, maskedTextBox15);
                BrisanjeLinije(textBox7, maskedTextBox17, numericUpDown6, maskedTextBox25);
                BrisanjeLinije(textBox8, maskedTextBox18, numericUpDown7, maskedTextBox26);
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
                   
                    MessageBox.Show("Vaša kupnja je gotova. Očekivani dolazak pošiljke je 4.7.2024.");

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
                    MessageBox.Show("Vaša kupnja je gotova. Očekivani dolazak pošiljke je 4.7.2024.");

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




        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if(JedanProizvod.Checked == true)
            {
                double cijena = double.Parse(maskedTextBox16.Text) * Convert.ToInt32(numericUpDown1.Value);
                maskedTextBox11.Text = cijena.ToString();
                double ukcijena = cijena + int.Parse(textBox6.Text);
                textBox9.Text = ukcijena.ToString();
            }

            if(Kosarica.Checked == true)
            {
                RacunanjeCijene(numericUpDown1, maskedTextBox16, maskedTextBox11);
                //double cijena = double.Parse(maskedTextBox16.Text) * Convert.ToInt32(numericUpDown1.Value);
                //maskedTextBox11.Text = cijena.ToString();
            }
            
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            RacunanjeCijene(numericUpDown2, maskedTextBox2, maskedTextBox12);
            //double cijena = double.Parse(maskedTextBox16.Text) * Convert.ToInt32(numericUpDown1.Value);
            //maskedTextBox11.Text = cijena.ToString();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            RacunanjeCijene(numericUpDown3, maskedTextBox3, maskedTextBox13);
            //double cijena = double.Parse(maskedTextBox16.Text) * Convert.ToInt32(numericUpDown1.Value);
            //maskedTextBox11.Text = cijena.ToString();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            RacunanjeCijene(numericUpDown4, maskedTextBox4, maskedTextBox14);
            //double cijena = double.Parse(maskedTextBox16.Text) * Convert.ToInt32(numericUpDown1.Value);
            //maskedTextBox11.Text = cijena.ToString();
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            RacunanjeCijene(numericUpDown5, maskedTextBox5, maskedTextBox15);
            //double cijena = double.Parse(maskedTextBox16.Text) * Convert.ToInt32(numericUpDown1.Value);
            //maskedTextBox11.Text = cijena.ToString();
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            RacunanjeCijene(numericUpDown6, maskedTextBox17, maskedTextBox25);
            //double cijena = double.Parse(maskedTextBox16.Text) * Convert.ToInt32(numericUpDown1.Value);
            //maskedTextBox11.Text = cijena.ToString();
        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            RacunanjeCijene(numericUpDown7, maskedTextBox18, maskedTextBox26);
            //double cijena = double.Parse(maskedTextBox16.Text) * Convert.ToInt32(numericUpDown1.Value);
            //maskedTextBox11.Text = cijena.ToString();
        }

        private void Kupovina_FormClosed(object sender, FormClosedEventArgs e)
        {
            File.Delete(Admin.FilePath5);
            File.Delete(Admin.FilePath7);
            File.WriteAllText(Admin.FilePath6, "");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if(Kosarica.Checked == true)
            {
                //double ukcijena = double.Parse(maskedTextBox11.Text) + double.Parse(maskedTextBox12.Text) + double.Parse(maskedTextBox13.Text) + double.Parse(maskedTextBox14.Text) + double.Parse(maskedTextBox15.Text) + double.Parse(maskedTextBox25.Text) + double.Parse(maskedTextBox26.Text) + double.Parse(textBox6.Text);
                double ukcijena = Convert.ToDouble(maskedTextBox11.Text) + Convert.ToDouble(maskedTextBox12.Text) + Convert.ToDouble(maskedTextBox13.Text) + Convert.ToDouble(maskedTextBox14.Text) + Convert.ToDouble(maskedTextBox15.Text) + Convert.ToDouble(maskedTextBox25.Text) + Convert.ToDouble(maskedTextBox26.Text);
                double ukcijena1 = ukcijena + double.Parse(textBox6.Text);

                textBox9.Text = ukcijena1.ToString();

                
            }
        }
    }
}
