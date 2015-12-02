using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2015_NJ_SE2_BP3H_OO_Programma.Classes
{
    public class Gemeente : IComparable<Gemeente>
    {
        public string Naam { get; set; }
        public int AantalKinderen { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Gemeente(string naam, Provincie provincie, int aantalKinderen, int x, int y)
        {
            this.Naam = naam;
            this.AantalKinderen = aantalKinderen;
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return Naam;
        }

        public int AfstandTot(Gemeente gemeente)
        {
            double x = this.X - gemeente.X;
            double y = this.Y - gemeente.Y;

            return Convert.ToInt32(Math.Sqrt((x * x) + (y * y)));
        }

        public int CompareTo(Gemeente other)
        {
            if (this.AantalKinderen > other.AantalKinderen)
            {
                return 1;
            }
            else if (this.AantalKinderen < other.AantalKinderen)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
