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


        //Dio za prijavu:

        List<string> stringList = new List<string>();
        

        string FilePath = "KorisniciLjekarne.txt";

        private void buttonPrijaviSe_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonRegistracija_Click(object sender, EventArgs e)
        {
            string linijaIme = tbIme.Text;
            string linijaPrezime = tbPrezime.Text;

            StreamWriter sw = new StreamWriter(FilePath, true);
            if (linijaIme != "")
            {
                sw.WriteLine("{0}|{1}", linijaIme, linijaPrezime);
                tbIme.Text = "";
                tbPrezime.Text = "";

                MessageBox.Show("Uspješna prijava!");

            }


            else
            {
                MessageBox.Show("Nisu uneseni podaci!");
            }

            sw.Close();
        }
    }
}
