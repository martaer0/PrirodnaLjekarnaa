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
    public partial class NaslovnaStranicaPL : Form
    {
        public NaslovnaStranicaPL()
        {
            InitializeComponent();
        }
        //povezivanje formi na MenuStrip
        

        private void dodajNovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodajNovo frmDodaj = new DodajNovo();
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

        private void košaricaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kosarica frmDodaj = new Kosarica();
            frmDodaj.ShowDialog();
            this.Close();
        }

        private void buttonPrijava_Click(object sender, EventArgs e)
        {
            gbPrijava.Visible = true;
            
        }


        //Dio za prijavu i registraciju:

        List<string> stringList = new List<string>();
        ListaKorisnika listakorisnika = new ListaKorisnika();


        

        private void buttonPrijaviSe_Click(object sender, EventArgs e)
        {
            string linijaIme = tbIme.Text;
            string linijaPrezime = tbPrezime.Text;

            if (linijaIme == "" && linijaPrezime == "")
            {
                MessageBox.Show("Nisu uneseni podaci!");
            }

            //Provjeravanje postoji li korisnicki racun.
            if (linijaIme != "" && linijaPrezime != "")
            {
                bool PronadenKorisnik = false;

                foreach (Korisnik k in listakorisnika.korisnici)
                {
                    if (k.Ime == linijaIme && k.Prezime == linijaPrezime)
                    {
                        PronadenKorisnik = true;
                        break;
                    }
                }

                if (PronadenKorisnik)
                {
                    MessageBox.Show("Uspješna prijava! Idite dalje!");
                    gbPrijava.Visible = false;
                    menuStrip1.Enabled = true;
                    buttonPrijava.Enabled = false;

                    
                    

                }

                else
                {
                    MessageBox.Show("Ne postoji uneseno korisničko ime! Registrirajte se!");
                }
            }
            

        }

        private void buttonRegistracija_Click(object sender, EventArgs e)
        {
            string linijaIme = tbIme.Text;
            string linijaPrezime = tbPrezime.Text;

            StreamWriter sw = new StreamWriter(Admin.FilePath, true);
            if (linijaIme != "" && linijaPrezime != "")
            {
                sw.WriteLine("{0}|{1}", linijaIme, linijaPrezime);

                MessageBox.Show("Uspješna registracija! Idite dalje!");
                gbPrijava.Visible = false;
                menuStrip1.Enabled = true;
                buttonPrijava.Enabled = false;

                

            }


            else
            {
                MessageBox.Show("Nisu uneseni podaci!");
            }

            sw.Close();
        }

        private void NaslovnaStranicaPL_FormClosed(object sender, FormClosedEventArgs e)
        {
            File.Delete(Admin.FilePath5);
            File.Delete(Admin.FilePath7);
            File.WriteAllText(Admin.FilePath6, "");
        }
    }
}
