using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2015_NJ_SE2_BP3H_OO_Programma.Classes
{
    public class KnutselPiet : Piet
    {
        public override bool IsCreatief { get { return true; } }
        public override bool KanRijmen { get { return false; } }
        public override bool SnaptComputer { get { return false; } }
        public KnutselPiet()
        {

        }

        public override string ToString()
        {
            return "[KnutselPiet] " + base.ToString();
        }
    }
}
