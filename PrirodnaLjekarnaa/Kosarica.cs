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

        private BindingList<string> proizvodi;
        private void Kosarica_Load(object sender, EventArgs e)
        {
            proizvodi = new BindingList<string>();
            using (StreamReader reader = new StreamReader(Admin.FilePath6))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    proizvodi.Add(line);
                }
            }


            lbxProizvodiKosarica.DataSource = proizvodi;



        }

        private void btnObrisiProizvod_Click(object sender, EventArgs e)
        {
            if (lbxProizvodiKosarica.SelectedItem != null)
            {
                proizvodi.Remove((string)lbxProizvodiKosarica.SelectedItem);
            }
            else
            {
                MessageBox.Show("Proizvod nije odabran, odaberite proizvod koji želite izbrisati!");
            }
        }



        private void btnVodiNaKupovinu_Click(object sender, EventArgs e)
        {
            if (gbProizvodiKosarica.Enabled == false) { 
            Kupovina odvestKupovina = new Kupovina();
            odvestKupovina.ShowDialog();
            }
        }   
         


        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            if (lbxProizvodiKosarica.Items.Count != 0)
            {
                List<string> stringPotvrdeniProizvodi = new List<string>();
                StreamWriter sw = new StreamWriter(Admin.FilePath7, true);

                foreach (var item in lbxProizvodiKosarica.Items)
                {
                    sw.WriteLine(item.ToString());
                }

                sw.Close();


                File.WriteAllText(Admin.FilePath6, "");

                MessageBox.Show("Uspješno potvrđen sadržaj košarice!");
                gbProizvodiKosarica.Enabled = false;
                btnObrisiProizvod.Enabled = false;
            }

            else MessageBox.Show("Košarica je prazna, dodajte proizvode u košaricu.");
            

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
            File.Delete(Admin.FilePath5);
            File.Delete(Admin.FilePath7);
            File.WriteAllText(Admin.FilePath6, "");
        }
    }
}
