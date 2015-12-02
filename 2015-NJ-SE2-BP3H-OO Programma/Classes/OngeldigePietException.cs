using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2015_NJ_SE2_BP3H_OO_Programma.Classes
{
    public class OngeldigePietException : Exception
    {
        public OngeldigePietException(string foutmelding)
            : base(foutmelding)
        {

        }
    }
}
