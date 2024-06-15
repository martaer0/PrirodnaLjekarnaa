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
        List<string> stringList = new List<string>();
        //filepath na onoj odvojenoj
        string path = "ucenici.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void cajevi_CheckedChanged(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("cajevi.txt");
            string line = sr.ReadLine();

            while (line != null)
            {
                stringList.Add(line);
                line = sr.ReadLine();
            }

            listBox1.DataSource = stringList;
        }

        private void sokoviSirupi_CheckedChanged(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("sokoviSirupi.txt");
            string line = sr.ReadLine();

            while (line != null)
            {
                stringList.Add(line);
                line = sr.ReadLine();
            }

            listBox1.DataSource = stringList;
        }

        private void etericnaUlja_CheckedChanged(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("etericnaUlja.txt");
            string line = sr.ReadLine();

            while (line != null)
            {
                stringList.Add(line);
                line = sr.ReadLine();
            }

            listBox1.DataSource = stringList;
        }

        private void kremeMasti_CheckedChanged(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("kremeMasti.txt");
            string line = sr.ReadLine();

            while (line != null)
            {
                stringList.Add(line);
                line = sr.ReadLine();
            }

            listBox1.DataSource = stringList;

        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string[] linija = listBox1.SelectedItem.ToString().Split(';');
            textBox2.Text = linija[0];
            textBox3.Text = linija[1];
            textBox4.Text = linija[2];
            
            // izvest to sa slikama nemam blage veze kako 

        }

        //za direkt na kupovinu 
        private void button1_Click(object sender, EventArgs e)
        {

            string linija1 = textBox2.Text;
            string linija2 = textBox3.Text;
            string linija3 = textBox4.Text;
            

            StreamWriter sw = new StreamWriter(path, true);
            if (linija1 != "")
            {
                sw.WriteLine("{0}|{1}|{2}|{3}", linija1, linija2, linija3);
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";

                

            }            

            sw.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
