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
            Importeer();
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
            Provincies = Provincies.OrderBy(x => x.Naam).ToList(); //Sorteerd de provincies op basis van naam.
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
            Provincie prov = ZoekOpNaam(provincie);

            if (prov != null) //Indien er een provincie is gevonden voeg daar dan een nieuwe gemeente aan toe.
            {
                Gemeente g = new Gemeente(gemeente, prov, aantalKinderen, x, y);
                if (g.Naam == "Meppel")
                {
                    Thuisbasis = g;
                }
                prov.VoegGemeenteToe(g);
                prov.Gemeentes.Sort(); //Sorteert de gemeentes in de lijst van provincies op basis van kinderen.
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

        /// <summary>
        /// Zoekt een provincie in de lijst met provincies op basis van naam.
        /// </summary>
        /// <param name="naam"></param>
        /// <returns></returns>
        public Provincie ZoekOpNaam(string naam)
        {
            foreach (Provincie p in Provincies)
            {
                if (p != null)
                {
                    if (p.Naam == naam)
                    {
                        return p;
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// Stelt een posse van pieten samen.
        /// </summary>
        /// <param name="gemeente"></param>
        /// <param name="cadeauTypes"></param>
        /// <returns></returns>
        public List<Piet> StelPosseSamen(Gemeente gemeente, List<CadeauType> cadeauTypes)
        {
            List<Piet> posse = new List<Piet>();
            if (Thuisbasis != null)
            {
                if (gemeente.AfstandTot(Thuisbasis) > 2500) //gebruik 2500 als 25km anders zijn er te weinig waarden.
                {
                    posse.Add(new WegWijsPiet());
                }
            }

            if (cadeauTypes.Contains(CadeauType.Gedicht))
            {
                posse.Add(new RijmPiet());
            }

            if (cadeauTypes.Contains(CadeauType.Digitaal))
            {
                posse.Add(new TechnischePiet());
            }

            if (cadeauTypes.Contains(CadeauType.Speelgoed))
            {
                posse.Add(new KnutselPiet());
            }

            if (cadeauTypes.Contains(CadeauType.Educatief))
            {
                posse.Add(new TechnischePiet());
                posse.Add(new KnutselPiet());
            }

            if (gemeente.AantalKinderen > 10000)
            {
                foreach (Piet p in posse.ToList())
                {
                    if (!(p is WegWijsPiet))
                    {
                        posse.Add(p);
                    }
                }
            }
            return posse;
        }

        /// <summary>
        /// Verkrijgt het bestand wat geïmporteerd moet worden.
        /// </summary>
        /// <returns></returns>
        private string FileName()
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
