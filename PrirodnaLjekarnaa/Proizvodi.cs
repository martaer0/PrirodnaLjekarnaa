using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PrirodnaLjekarnaa
{
    public partial class Proizvodi : Form
    {

        int n = 0;
        public Proizvodi()
        {
            InitializeComponent();
        }

        private void cajevi_CheckedChanged(object sender, EventArgs e)
        {
            List<string> stringList = new List<string>();
            StreamReader sr = new StreamReader("..\\..\\Cajevi.txt");
            string line = sr.ReadLine();

            while (line != null)
            {
                stringList.Add(line);
                line = sr.ReadLine();
            }

            listBox1.DataSource = stringList;
        }

        private void sokoviSirupi_CheckedChanged(object sender, EventArgs e)
        {
            List<string> stringList = new List<string>();
            StreamReader sr = new StreamReader("..\\..\\SokoviiSirupi.txt");
            string line = sr.ReadLine();

            while (line != null)
            {
                stringList.Add(line);
                line = sr.ReadLine();
            }

            listBox1.DataSource = stringList;
        }

        private void etericnaUlja_CheckedChanged(object sender, EventArgs e)
        {
            List<string> stringList = new List<string>();
            StreamReader sr = new StreamReader("..\\..\\EtericnaUlja.txt");
            string line = sr.ReadLine();

            while (line != null)
            {
                stringList.Add(line);
                line = sr.ReadLine();
            }

            listBox1.DataSource = stringList;
        }

        private void kremeMasti_CheckedChanged(object sender, EventArgs e)
        {
            List<string> stringList = new List<string>();
            StreamReader sr = new StreamReader("..\\..\\KremeiMasti.txt");
            string line = sr.ReadLine();

            while (line != null)
            {
                stringList.Add(line);
                line = sr.ReadLine();
            }

            listBox1.DataSource = stringList;

        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string[] linija = listBox1.SelectedItem.ToString().Split('|');
            textBox2.Text = linija[0];
            textBox3.Text = linija[1];
            textBox4.Text = linija[2];
            textBox1.Text = linija[3];

            //slike

            if (cajevi.Checked == true)
            {
                pictureBox1.Load("..\\..\\slike\\cajevi.jpeg");
            }

            if (etericnaUlja.Checked == true)
            {
                pictureBox1.Load("..\\..\\slike\\etericnaUlja.jpeg");
            }

            if (sokoviSirupi.Checked == true)
            {
                pictureBox1.Load("..\\..\\slike\\sokoviSirupi.jpeg");
            }

            if (kremeMasti.Checked == true)
            {
                pictureBox1.Load("..\\..\\slike\\kremeMasti.jpeg");
            }

        }

        //za direkt na kupovinu jedan proizvod
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                string linija1 = textBox2.Text;
                string linija2 = textBox1.Text;

                StreamWriter sw = new StreamWriter(Admin.FilePath5, true);
                if (linija1 != "")
                {
                    sw.WriteLine("{0}|{1}", linija1, linija2);
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox1.Text = "";

                }

                sw.Close();

                Kupovina odvestKosarica = new Kupovina();
                odvestKosarica.ShowDialog();
                this.Close();


            }

            else MessageBox.Show("U poljima nema ničega, pokušajte ponovno.");


        }

       
        //dodavanje u kosaricu do 7 proizvoda 
        private void button2_Click(object sender, EventArgs e)
        {
            string linija1 = textBox2.Text;
            string linija2 = textBox3.Text;
            string linija3 = textBox4.Text;
            string linija4 = textBox1.Text;
            

            if (n < 7)
            {
                StreamWriter sw = new StreamWriter(Admin.FilePath6, true);
                if (linija1 != "")
                {
                    sw.WriteLine("{0}|{1}|{2}|{3}", linija1, linija2, linija3, linija4);
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox1.Text = "";


                    MessageBox.Show("Proizvodi su spremljeni u košaricu!");
                    n++;
                }
                else
                {
                    MessageBox.Show("Nema unesenih proizvoda!");
                }

                sw.Close();
            }

            else
            {
                MessageBox.Show("U košarici više nema mjesta! Idite u košaricu!");
            }


        }

        //odvest ce na kosaricu 
        private void button3_Click(object sender, EventArgs e)
        {
            Kosarica odvestKosarica = new Kosarica();
            odvestKosarica.ShowDialog();
            this.Close();
        }




        private void naslovnicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NaslovnaStranicaPL frmDodaj = new NaslovnaStranicaPL();
            frmDodaj.ShowDialog();
            this.Close();
        }        

        private void košaricaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kosarica frmDodaj = new Kosarica();
            frmDodaj.ShowDialog();
            this.Close();
        }

        private void kupiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kupovina frmDodaj = new Kupovina();
            frmDodaj.ShowDialog();
            this.Close();
        }

        private void dodajNovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodajNovo frmDodaj = new DodajNovo();
            frmDodaj.ShowDialog();
            this.Close();
        }

        private void najčešćeBolestiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NajcesceBolesti frmDodaj = new NajcesceBolesti();
            frmDodaj.ShowDialog();
            this.Close();
        }

        private void oNamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Onama2 frmDodaj = new Onama2();
            frmDodaj.ShowDialog();
            this.Close();
        }

        
    }
}
