using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrirodnaLjekarnaa
{
    public partial class Kupovina : Form
    {
        List<string> stringList = new List<string>();

        public Kupovina()
        {
            InitializeComponent();
        }

        private void JedanProizvod_CheckedChanged(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("Kupovina.txt");
            string line = sr.ReadLine();
            int val1 = 1;

            while (line != null)
            {
                stringList.Add(line);
                line = sr.ReadLine();
            }
            
            string[] linija1 = line.Split('|');
            textBox11.Text = linija1[0];
            maskedTextBox16.Text = linija1[1];            

            if (maskedTextBox6.Text != "1")
            {                
                val1 = int.Parse(maskedTextBox11.Text);
            }

            double cijena = int.Parse(maskedTextBox6.Text) * val1;

            maskedTextBox11.Text = cijena.ToString();            
        }

        

        private void Kosarica_CheckedChanged(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader(Admin.FilePath6))
            {
                string line;
                int lNb1 = 1, lNb2 = 2, lNb3 = 3, lNb4 = 4, lNb5 = 5, lNb6 = 6, lNb7 = 7;
                int currentLineNumber = 0; 

                while ((line = reader.ReadLine()) != null)
                {
                    currentLineNumber++;
                    if (currentLineNumber == lNb1)
                    {
                        string[] linija1 = line.Split('|');
                        linija1[0] = textBox11.Text;
                        linija1[3] =;
                        currentLineNumber = 0;
                        break;
                    }             

                }

                while ((line = reader.ReadLine()) != null)
                {
                    currentLineNumber++;
                    if (currentLineNumber == lNb2)
                    {
                        string[] linija1 = line.Split('|');
                        linija1[0] = textBox2.Text;
                        linija1[3] =;
                        currentLineNumber = 0;
                        break;
                    }

                }

                while ((line = reader.ReadLine()) != null)
                {
                    currentLineNumber++;
                    if (currentLineNumber == lNb3)
                    {
                        string[] linija1 = line.Split('|');
                        linija1[0] = textBox3.Text;
                        linija1[3] =;
                        currentLineNumber = 0;
                        break;
                    }

                }

                while ((line = reader.ReadLine()) != null)
                {
                    currentLineNumber++;
                    if (currentLineNumber == lNb4)
                    {
                        string[] linija1 = line.Split('|');
                        linija1[0] = textBox4.Text;
                        linija1[3] =;
                        currentLineNumber = 0;
                        break;
                    }

                }

                while ((line = reader.ReadLine()) != null)
                {
                    currentLineNumber++;
                    if (currentLineNumber == lNb5)
                    {
                        string[] linija1 = line.Split('|');
                        linija1[0] = textBox5.Text;
                        linija1[3] =;
                        currentLineNumber = 0;
                        break;
                    }

                }

                while ((line = reader.ReadLine()) != null)
                {
                    currentLineNumber++;
                    if (currentLineNumber == lNb6)
                    {
                        string[] linija1 = line.Split('|');
                        linija1[0] = textBox6.Text;
                        linija1[3] =;
                        currentLineNumber = 0;
                        break;
                    }

                }

                while ((line = reader.ReadLine()) != null)
                {
                    currentLineNumber++;
                    if (currentLineNumber == lNb7)
                    {
                        string[] linija1 = line.Split('|');
                        linija1[0] = textBox7.Text;
                        linija1[3] =;
                        currentLineNumber = 0;
                        break;
                    }

                }

                
            }


        }



        private void button9_Click(object sender, EventArgs e)
        {
            if(textBox11.Text != "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "" && textBox5.Text == "" && textBox6.Text == "" && textBox7.Text == "")
            {
                textBox11.Text = "";
                maskedTextBox16.Text = "";
                maskedTextBox6.Text = "";
                maskedTextBox11.Text = "";

                File.WriteAllText(Admin.FilePath5, "");
            }
        }
    }
}
