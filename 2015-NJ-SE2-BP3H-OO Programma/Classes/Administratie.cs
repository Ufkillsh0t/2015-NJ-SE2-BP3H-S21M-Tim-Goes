using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _2015_NJ_SE2_BP3H_OO_Programma.Classes
{
    public class Administratie
    {
        public List<Provincie> Provincies { get; set; }

        public Gemeente Thuisbasis { get; set; }

        public Administratie()
        {
            Provincies = new List<Provincie>();
        }

        /// <summary>
        /// Importeerd alle provincies en bijbehorende gemeenten.
        /// </summary>
        public void Importeer()
        {
            string path = FileName();
            if (path != "")
            {
                using (StreamReader sw = new StreamReader(path))
                {
                    string line;
                    while ((line = sw.ReadLine()) != null) //Leest alle lijnen uit het gegeven bestand totdat er geen meer zijn.
                    {
                        string[] informatie = line.Split(';'); //Maakt een array aan door alle letters in een zin te splitten in verschilende strings.
                        VoegToe(informatie[0], informatie[1], Convert.ToInt32(informatie[2]), Convert.ToInt32(informatie[3]), Convert.ToInt32(informatie[4]));
                    }
                }
            }
        }

        /// <summary>
        /// Voegt een gemeente toe afhankelijk van de gegeven data.
        /// </summary>
        /// <param name="gemeente"></param>
        /// <param name="provincie"></param>
        /// <param name="aantalKinderen"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void VoegToe(string gemeente, string provincie, int aantalKinderen, int x, int y)
        {
            Provincie prov = null;
            foreach (Provincie p in Provincies) //Doorloopt alle provincies om te kijken of de gegeven provincie al bestaat.
            {
                if (p != null)
                {
                    if (p.Naam == provincie)
                    {
                        prov = p;
                    }
                }
            }

            if (prov != null) //Indien er een provincie is gevonden voeg daar dan een nieuwe gemeente aan toe.
            {
                Gemeente g = new Gemeente(gemeente, prov, aantalKinderen, x, y);
                if (g.Naam == "Meppel")
                {
                    Thuisbasis = g;
                }
                prov.VoegGemeenteToe(g);
            }
            else //Maak zowel een nieuwe provincie als gemeente aan.
            {
                 prov = new Provincie(provincie);
                 Gemeente g = new Gemeente(gemeente, prov, aantalKinderen, x, y);
                 if (g.Naam == "Meppel")
                 {
                     Thuisbasis = g;
                 }
                 prov.VoegGemeenteToe(g);
                 Provincies.Add(prov);
            }

        }

        public Provincie ZoekOpNaam(string naam)
        {
            return null;
        }

        public string FileName()
        {
            System.Windows.Forms.OpenFileDialog ofd = new System.Windows.Forms.OpenFileDialog();
            ofd.Filter = ".csv file|*.csv";
            System.Windows.Forms.DialogResult d = ofd.ShowDialog();
            string file = "";
            if (d == System.Windows.Forms.DialogResult.OK)
            {
                file = ofd.FileName;
            }
            return file;
        }
    }
}
