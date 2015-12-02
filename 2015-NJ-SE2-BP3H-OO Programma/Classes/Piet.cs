using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2015_NJ_SE2_BP3H_OO_Programma.Classes
{
    public abstract class Piet
    {
        public abstract bool IsCreatief { get; }
        public abstract bool KanRijmen { get; }
        public abstract bool SnaptComputer { get; }

        public Piet()
        {
            try
            {
                if (IsCreatief && KanRijmen || IsCreatief && SnaptComputer || KanRijmen && SnaptComputer)
                {
                    throw new OngeldigePietException("De piet kan teveel dingen!");
                }
            }
            catch (OngeldigePietException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }

        public virtual string ToString()
        {
            return "Creatief: " + IsCreatief.ToString() + "KanRijmen: " + KanRijmen.ToString() + "SnapComputers: " + SnaptComputer.ToString();
        }
    }
}
