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
            //StreamReader sr = new StreamReader(Admin.FilePath6);
            //string line = sr.ReadLine();
            //List<string> ProizvodiKosarica = new List<string>();

            //while (line != null)
            //{
            //    ProizvodiKosarica.Add(line);
            //    line = sr.ReadLine();
            //}

            //lbxProizvodiKosarica.DataSource = ProizvodiKosarica;
            //sr.Close();
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

            MessageBox.Show("Uspješno potvrđen sadržaj košarice!");
            gbProizvodiKosarica.Enabled = false;
        }
    }
}
