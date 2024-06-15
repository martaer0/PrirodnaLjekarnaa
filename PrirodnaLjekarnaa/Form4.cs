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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnUcitajRacun_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(""/*Tu ide file za racun */); 
            string line = sr.ReadLine();
            List<string> Racun = new List<string>();

            while (line != null)
            {
                Racun.Add(line);
                line = sr.ReadLine();
            }

            lbxRacun.DataSource = Racun;
            sr.Close();
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            lbxRacun.Text = string.Empty;

        }
    }
}
