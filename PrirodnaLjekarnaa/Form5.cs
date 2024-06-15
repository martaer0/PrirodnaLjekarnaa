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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image|*.png;*.jpg;*.bmp;*.gif;*.pdf";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(@openFileDialog.FileName);
                }
            }
        }

        
        private void btnDodajproizvod_Click(object sender, EventArgs e)
        {
            string ImeProizvoda = tbimeProizvoda.Text;
            string LjekovitaSvojstva = tbLjekovitaSvojstva.Text;
            string Opis = tbOpis.Text;

            if(ImeProizvoda == "" || LjekovitaSvojstva == "" || Opis == "")
            {
                MessageBox.Show("Nisu uneseni podaci!");
            }

            if (rbCajevi.Checked)
            {
                
                StreamWriter sw = new StreamWriter(Admin.FilePath1, true);
                if (ImeProizvoda != "" && LjekovitaSvojstva != "" && Opis != "")
                {
                    sw.WriteLine("{0}\n{1}\n{2}\n\n", ImeProizvoda, LjekovitaSvojstva, Opis);

                    MessageBox.Show("Vaš proizvod uspješno je unesen!");

                    tbimeProizvoda.Text = "";
                    tbLjekovitaSvojstva.Text = "";
                    tbOpis.Text = "";
                }

                sw.Close();
            }

            else if (rbSokoviSirupi.Checked)
            {
                StreamWriter sw = new StreamWriter(Admin.FilePath2, true);
                if (ImeProizvoda != "" && LjekovitaSvojstva != "" && Opis != "")
                {
                    sw.WriteLine("{0}\n{1}\n{2}\n\n", ImeProizvoda, LjekovitaSvojstva, Opis);

                    MessageBox.Show("Vaš proizvod uspješno je unesen!");

                    tbimeProizvoda.Text = "";
                    tbLjekovitaSvojstva.Text = "";
                    tbOpis.Text = "";
                }

                sw.Close();
            }

            else if (rbEtericnaUlja.Checked)
            {
                StreamWriter sw = new StreamWriter(Admin.FilePath3, true);
                if (ImeProizvoda != "" && LjekovitaSvojstva != "" && Opis != "")
                {
                    sw.WriteLine("{0}\n{1}\n{2}\n\n", ImeProizvoda, LjekovitaSvojstva, Opis);

                    MessageBox.Show("Vaš proizvod uspješno je unesen!");

                    tbimeProizvoda.Text = "";
                    tbLjekovitaSvojstva.Text = "";
                    tbOpis.Text = "";
                }

                sw.Close();
            }

            else if (rbKremeMasti.Checked)
            {
                StreamWriter sw = new StreamWriter(Admin.FilePath4, true);
                if (ImeProizvoda != "" && LjekovitaSvojstva != "" && Opis != "")
                {
                    sw.WriteLine("{0}\n{1}\n{2}\n\n", ImeProizvoda, LjekovitaSvojstva, Opis);

                    MessageBox.Show("Vaš proizvod uspješno je unesen!");

                    tbimeProizvoda.Text = "";
                    tbLjekovitaSvojstva.Text = "";
                    tbOpis.Text = "";
                }

                sw.Close();
            }

            else
            { if(ImeProizvoda != "" && LjekovitaSvojstva != "" && Opis != "")
                MessageBox.Show("Nije odabrana klasifikacija proizvoda!");
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            rbCajevi.Checked = false;
            rbSokoviSirupi.Checked = false;
            rbEtericnaUlja.Checked = false;
            rbKremeMasti.Checked = false;
            tbimeProizvoda.Text = "";
            tbLjekovitaSvojstva.Text = "";
            tbOpis.Text = "";
        }
    }
}
