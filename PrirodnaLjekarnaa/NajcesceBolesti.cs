using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PrirodnaLjekarnaa
{
    public partial class NajcesceBolesti : Form
    {
        public NajcesceBolesti()
        {
            InitializeComponent();
        }

        private void lbxListaBolesti_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lbxListaBolesti.SelectedItem.ToString() == "Glavobolja")
            {
                StreamReader sr = new StreamReader("..\\..\\LjekoviGlavobolja.txt");
                string line = sr.ReadLine();
                List<string> LjekoviGlavobolja = new List<string>();

                while (line != null)
                {
                    LjekoviGlavobolja.Add(line);
                    line = sr.ReadLine();
                }

                lbxPreporuceniProizvodi.DataSource = LjekoviGlavobolja;
                sr.Close() ;
            }

            if (lbxListaBolesti.SelectedItem.ToString() == "Mučnina")
            {
                StreamReader sr = new StreamReader("..\\..\\LjekoviMucnina.txt");
                string line = sr.ReadLine();
                List<string> LjekoviMucnina = new List<string>();

                while (line != null)
                {
                    LjekoviMucnina.Add(line);
                    line = sr.ReadLine();
                }

                lbxPreporuceniProizvodi.DataSource = LjekoviMucnina;
                sr.Close();
            }

            if (lbxListaBolesti.SelectedItem.ToString() == "Grlobolja i kašalj")
            {
                StreamReader sr = new StreamReader("..\\..\\LjekoviGrloboljaiKasalj.txt");
                string line = sr.ReadLine();
                List<string> LjekoviGrloboljaiKasalj = new List<string>();

                while (line != null)
                {
                    LjekoviGrloboljaiKasalj.Add(line);
                    line = sr.ReadLine();
                }

                lbxPreporuceniProizvodi.DataSource = LjekoviGrloboljaiKasalj;
                sr.Close();
            }
        }

        private void lbxPreporuceniProizvodi_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbOdabraniProizvod.Visible = true;
            string[] linija = lbxPreporuceniProizvodi.SelectedItem.ToString().Split('|');
            tbIme.Text = linija[0];
            tbLjekovitaSvojstva.Text = linija[1];
            tbOpis.Text = linija[2];
            tbCijena.Text = linija[3];
        }

        private void btnKupiProizvod_Click(object sender, EventArgs e)
        {
            string linija1 = tbIme.Text;
            string linija2 = tbCijena.Text;

            if (lbxPreporuceniProizvodi.SelectedIndex != -1)
            {
                StreamWriter sw = new StreamWriter(Admin.FilePath5, true);
                if (linija1 != "")
                {
                    sw.WriteLine("{0}|{1}", linija1, linija2);
                    tbIme.Text = "";
                    tbLjekovitaSvojstva.Text = "";
                    tbOpis.Text = "";
                    tbCijena.Text = "";


                }

                sw.Close();

                Kupovina odvestKupovina = new Kupovina();
                odvestKupovina.ShowDialog();
                this.Close();
            }

            else
            {
                MessageBox.Show("Nije odabran proizvod! Odaberite proizvod koji želite kupiti!");
            }
        }



        private void btnUKosaricu_Click(object sender, EventArgs e)
        {
            string linija1 = tbIme.Text;
            string linija2 = tbLjekovitaSvojstva.Text;
            string linija3 = tbOpis.Text;
            string linija4 = tbCijena.Text;

            
            StreamWriter sw = new StreamWriter(Admin.FilePath6, true);
            if (lbxPreporuceniProizvodi.SelectedIndex != -1)
            {
                sw.WriteLine("{0}|{1}|{2}|{3}", linija1, linija2, linija3, linija4);
                tbIme.Text = "";
                tbLjekovitaSvojstva.Text = "";
                tbOpis.Text = "";
                tbCijena.Text = "";

                sw.Close();

                MessageBox.Show("Odabrani proizvod je spremljen u košaricu!");
            }

            else
            {
                MessageBox.Show("Nije odabran proizvod! Odaberite proizvod koji želite dodati u košaricu!");
            }

            sw.Close();
        }

        private void naslovnicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NaslovnaStranicaPL frmDodaj = new NaslovnaStranicaPL();
            frmDodaj.ShowDialog();
            this.Close();
        }

        private void proizvodiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Proizvodi frmDodaj = new Proizvodi();
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

        private void oNamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Onama2 frmDodaj = new Onama2();
            frmDodaj.ShowDialog();
            this.Close();
        }

        private void NajcesceBolesti_FormClosed(object sender, FormClosedEventArgs e)
        {
            File.Delete(Admin.FilePath5);
            File.Delete(Admin.FilePath7);
            File.WriteAllText(Admin.FilePath6, "");
        }
    }
}
