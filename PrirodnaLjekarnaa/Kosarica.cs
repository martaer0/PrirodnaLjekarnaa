using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PrirodnaLjekarnaa
{
    public partial class Kosarica : Form
    {
        public Kosarica()
        {
            InitializeComponent();
        }

        private void Kosarica_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("..\\..\\DodavanjeUKosaricu.txt");
            StreamReader sr1 = new StreamReader("..\\..\\DodavanjeUKosaricuPrekoBolesti.txt");
            string line = sr.ReadLine();
            string line1 = sr.ReadLine();

            List<string> ProizvodiKosarica = new List<string>();

            while (line != null)
            {
                ProizvodiKosarica.Add(line);
                line = sr.ReadLine();
            }

            while (line1 != null)
            {
                ProizvodiKosarica.Add(line1);
                line1 = sr1.ReadLine();
            }



            lbxProizvodiKosarica.DataSource = ProizvodiKosarica;
            sr.Close();
        }

        private void btnVodiNaKupovinu_Click(object sender, EventArgs e)
        {
            if (gbProizvodiKosarica.Enabled == false) { 
            Kupovina odvestKupovina = new Kupovina();
            odvestKupovina.ShowDialog();
            }
        }

        private void btnObrisiProizvod_Click(object sender, EventArgs e)
        {
            if (lbxProizvodiKosarica.SelectedIndex == -1)
            {
                MessageBox.Show("Nije odabran proizvod. Odaberite proizvod koji želite izbrisati!");
            }
            else
            {
                lbxProizvodiKosarica.Items.Remove(lbxProizvodiKosarica.SelectedItem);
            }
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            List<string> stringPotvrdeniProizvodi = new List<string>();
            StreamWriter sw = new StreamWriter(Admin.FilePath7, true);

            foreach (var item in lbxProizvodiKosarica.Items)
            {
                sw.WriteLine(item.ToString());
            }

            sw.Close();

            File.Delete(Admin.FilePath6);
            File.Delete(Admin.FilePath6_1);


            MessageBox.Show("Uspješno potvrđen sadržaj košarice!");
            gbProizvodiKosarica.Enabled = false;
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

        private void Kosarica_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
