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
            cbProvincie.DataSource = admin.Provincies;
            lbProvincies.DataSource = admin.Provincies;
        }

        private void cbProvincie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbProvincies_SelectedIndexChanged(object sender, EventArgs e)
        {
            LaatGemeentesZienOpProvincie();
        }

        private void LaatGemeentesZienOpProvincie()
        {
            if (lbProvincies.SelectedItem != null)
            {
                Provincie p = (Provincie)lbProvincies.SelectedItem;
                if (p != null)
                {
                    lbGemeenten.DataSource = p.Gemeentes;
                }
            }
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            if (cbProvincie.SelectedItem != null)
            {
                Provincie p = (Provincie)cbProvincie.SelectedItem;
                p.VoegGemeenteToe(new Gemeente(tbGemeente.Text, p, Convert.ToInt32(nudAantalKinderen.Value), Convert.ToInt32(nudX.Value), Convert.ToInt32(nudY.Value)));
                LaatGemeentesZienOpProvincie(); //listbox updaten....
            }
        }

        private void lbGemeenten_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbGemeenten.SelectedItem != null)
            {
                Gemeente g = (Gemeente)lbGemeenten.SelectedItem;
                lblAfstand.Text = admin.Thuisbasis.AfstandTot(g).ToString();
            }
        }

        private void btnMaakPosse_Click(object sender, EventArgs e)
        {
            if(lbGemeenten.SelectedItem != null){
            List<CadeauType> cadeauTypes = new List<CadeauType>();
            if (chkDigitaal.Checked)
            {
                cadeauTypes.Add(CadeauType.Digitaal);
            }
            if (chkEducatief.Checked)
            {
                cadeauTypes.Add(CadeauType.Educatief);
            }
            if (chkGedicht.Checked)
            {
                cadeauTypes.Add(CadeauType.Gedicht);
            }
            if (chkSpeelgoed.Checked)
            {
                cadeauTypes.Add(CadeauType.Speelgoed);
            }

            lbPosse.DataSource = admin.StelPosseSamen((Gemeente)lbGemeenten.SelectedItem, cadeauTypes);
            }
        }
    }
}
