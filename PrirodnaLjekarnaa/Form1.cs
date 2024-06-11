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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    //povezivanje formi na MenuStrip
        private void dodajNovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 frmDodaj = new Form5();
            frmDodaj.ShowDialog();  
        }

        private void proizvodiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void najčešćeBolestiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frmDodaj = new Form3();
            frmDodaj.ShowDialog();
        }

        private void oNamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 frmDodaj = new Form6();
            frmDodaj.ShowDialog();
        }

        private void košaricaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frmDodaj = new Form2();
            frmDodaj.ShowDialog();
        }

        private void buttonPrijava_Click(object sender, EventArgs e)
        {
            gbPrijava.Visible = true;
            
        }


        //Dio za prijavu i registraciju:

        List<string> stringList = new List<string>();
        ListaKorisnika listakorisnika = new ListaKorisnika();


        string FilePath = "KorisniciLjekarne.txt";

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
                    MessageBox.Show("Uspješna prijava!");
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

            StreamWriter sw = new StreamWriter(FilePath, true);
            if (linijaIme != "" && linijaPrezime != "")
            {
                sw.WriteLine("{0}|{1}", linijaIme, linijaPrezime);
                //tbIme.Text = "";
                //tbPrezime.Text = "";

                MessageBox.Show("Uspješna registracija!");
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
    }
}
