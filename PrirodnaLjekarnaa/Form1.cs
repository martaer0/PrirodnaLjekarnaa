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
    }
}
