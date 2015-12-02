using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2015_NJ_SE2_BP3H_OO_Programma.Classes
{
    public class TechnischePiet : Piet
    {
        public override bool IsCreatief { get { return false; } }
        public override bool KanRijmen { get { return false; } }
        public override bool SnaptComputer { get { return true; } }
        public TechnischePiet()
        {

        }

        public override string ToString()
        {
            return this.GetType().ToString() + base.ToString();
        }
    }
}
