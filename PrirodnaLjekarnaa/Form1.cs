using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
