using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2015_NJ_SE2_BP3H_OO_Programma.Classes
{
    public class RijmPiet : Piet
    {
        public override bool IsCreatief { get { return false; } }
        public override bool KanRijmen { get { return true; } }
        public override bool SnaptComputer { get { return false; } }
        public RijmPiet()
        {

        }

        public override string ToString()
        {
            return "[Rijmpiet] " + base.ToString();
        }
    }
}
