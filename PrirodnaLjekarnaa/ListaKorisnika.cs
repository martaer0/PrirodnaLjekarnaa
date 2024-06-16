using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrirodnaLjekarnaa
{
    public class ListaKorisnika
    {
      
            public List<Korisnik> korisnici = new List<Korisnik>();

            public ListaKorisnika()
            {
                StreamReader sr = new StreamReader("..\\..\\KorisniciLjekarne.txt");
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    if (line != null)
                    {
                        string[] columns = line.Split('|');
                        if (columns.Length > 0)
                        {
                            Korisnik k = new Korisnik();
                            k.Ime = columns[0];
                            k.Prezime = columns[1];
                            korisnici.Add(k);
                        }
                    }


                }
                sr.Close();
            }
    }

    
}

