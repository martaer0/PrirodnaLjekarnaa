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

namespace PrirodnaLjekarnaa
{
    public partial class DodajNovo : Form
    {
        public DodajNovo()
        {
            InitializeComponent();
        }


        
        private void btnDodajproizvod_Click(object sender, EventArgs e)
        {
            string ImeProizvoda = tbimeProizvoda.Text;
            string LjekovitaSvojstva = tbLjekovitaSvojstva.Text;
            string Opis = tbOpis.Text;
            string Cijena = tbCijena.Text;

            if(ImeProizvoda == "" || LjekovitaSvojstva == "" || Opis == "" || Cijena == "")
            {
                MessageBox.Show("Nisu uneseni podaci!");
            }


            if (rbCajevi.Checked && (ImeProizvoda != "" && LjekovitaSvojstva != "" && Opis != "" && Cijena != ""))
            {
                string linija = ImeProizvoda + "|" + LjekovitaSvojstva + "|" + Opis + "|" + Cijena + "\n";
                File.AppendAllText("..\\..\\Cajevi.txt", linija);

                tbimeProizvoda.Text = "";
                tbLjekovitaSvojstva.Text = "";
                tbOpis.Text = "";
                tbCijena.Text = "";

                MessageBox.Show("Uspješno unesen novi proizvod.");
                
            }


            else if (rbSokoviSirupi.Checked && (ImeProizvoda != "" && LjekovitaSvojstva != "" && Opis != "" && Cijena != ""))
            {
                string linija = ImeProizvoda + "|" + LjekovitaSvojstva + "|" + Opis + "|" + Cijena + "\n";
                File.AppendAllText("..\\..\\SokoviiSirupi.txt", linija);

                tbimeProizvoda.Text = "";
                tbLjekovitaSvojstva.Text = "";
                tbOpis.Text = "";
                tbCijena.Text = "";

                MessageBox.Show("Uspješno unesen novi proizvod.");
            }


            else if (rbEtericnaUlja.Checked && (ImeProizvoda != "" && LjekovitaSvojstva != "" && Opis != "" && Cijena != ""))
            {
                string linija = ImeProizvoda + "|" + LjekovitaSvojstva + "|" + Opis + "|" + Cijena + "\n";
                File.AppendAllText("..\\..\\EtericnaUlja.txt", linija);

                tbimeProizvoda.Text = "";
                tbLjekovitaSvojstva.Text = "";
                tbOpis.Text = "";
                tbCijena.Text = "";

                MessageBox.Show("Uspješno unesen novi proizvod.");
            }


            else if (rbKremeMasti.Checked && (ImeProizvoda != "" && LjekovitaSvojstva != "" && Opis != "" && Cijena != ""))
            {
                string linija = ImeProizvoda + "|" + LjekovitaSvojstva + "|" + Opis + "|" + Cijena + "\n";
                File.AppendAllText("..\\..\\KremeiMasti.txt", linija);

                tbimeProizvoda.Text = "";
                tbLjekovitaSvojstva.Text = "";
                tbOpis.Text = "";
                tbCijena.Text = "";

                MessageBox.Show("Uspješno unesen novi proizvod.");

            }

            else
            { 
                if (ImeProizvoda != "" && LjekovitaSvojstva != "" && Opis != "" && Cijena != "")
                MessageBox.Show("Nije odabrana klasifikacija proizvoda!");
            }

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            rbCajevi.Checked = false;
            rbSokoviSirupi.Checked = false;
            rbEtericnaUlja.Checked = false;
            rbKremeMasti.Checked = false;
            tbimeProizvoda.Text = "";
            tbLjekovitaSvojstva.Text = "";
            tbOpis.Text = "";
            tbCijena.Text = "";
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

        private void DodajNovo_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
