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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void lbxListaBolesti_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lbxListaBolesti.SelectedItem.ToString() == "Glavobolja")
            {
                StreamReader sr = new StreamReader("..\\..\\LjekoviGlavobolja.txt");
                string line = sr.ReadLine();
                List<string> LjekoviGlavobolja = new List<string>();

                while (line != null)
                {
                    LjekoviGlavobolja.Add(line);
                    line = sr.ReadLine();
                }

                lbxPreporuceniProizvodi.DataSource = LjekoviGlavobolja;
                sr.Close() ;
            }

            if (lbxListaBolesti.SelectedItem.ToString() == "Mučnina")
            {
                StreamReader sr = new StreamReader("..\\..\\LjekoviMucnina.txt");
                string line = sr.ReadLine();
                List<string> LjekoviMucnina = new List<string>();

                while (line != null)
                {
                    LjekoviMucnina.Add(line);
                    line = sr.ReadLine();
                }

                lbxPreporuceniProizvodi.DataSource = LjekoviMucnina;
                sr.Close();
            }

            if (lbxListaBolesti.SelectedItem.ToString() == "Žgaravica")
            {
                StreamReader sr = new StreamReader("..\\..\\LjekoviZgaravica.txt");
                string line = sr.ReadLine();
                List<string> LjekoviZgaravica = new List<string>();

                while (line != null)
                {
                    LjekoviZgaravica.Add(line);
                    line = sr.ReadLine();
                }

                lbxPreporuceniProizvodi.DataSource = LjekoviZgaravica;
                sr.Close();
            }
        }

        private void lbxPreporuceniProizvodi_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbOdabraniProizvod.Visible = true;
        }
    }
}
