using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2015_NJ_SE2_BP3H_OO_Programma.Classes
{
    public class Provincie
    {
        public List<Gemeente> Gemeentes { get; set; }
        public string Naam { get; set; }

        public Provincie(string naam)
        {
            Gemeentes = new List<Gemeente>();
        }

        /// <summary>
        /// Voegt een gemeente toe aan de lijst met gemeentes uit deze provincie.
        /// </summary>
        /// <param name="gemeente">De gemeente die moet worden toegevoegd.</param>
        public void VoegGemeenteToe(Gemeente gemeente)
        {
            Gemeentes.Add(gemeente);
        }

        public Gemeente ZoekGemeente(string naam)
        {
            return null;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
