using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2015_NJ_SE2_BP3H_OO_Programma.Classes;

namespace _2015_NJ_SE2_BP3H_OO_Programma
{
    public partial class Form1 : Form
    {
        private Administratie admin;

        public Form1()
        {
            InitializeComponent();
            admin = new Administratie();
            admin.Importeer();
        }
    }
}
