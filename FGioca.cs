using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampoMinato2
{
    public partial class FGioca : Form
    {
        public FGioca()
        {
            InitializeComponent();
        }


        private void btn_Esci_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Gioca_Click(object sender, EventArgs e)
        {
            int grandezza;
            int gScelta = tbr_Griglia.Value;
            int bombe;
            int bScelta = tbr_Bombe.Value;

            switch (gScelta)
            {
                case 1:
                    grandezza = 1;
                    break;

                case 2:
                    grandezza = 2;
                    break;

                case 3:
                    grandezza = 3;
                    break;

                case 4:
                    grandezza = 4;
                    break;

                case 5:
                    grandezza = 5;
                    break;
            }

            switch (gScelta)
            {
                case 1:
                    bombe= 10;
                    break;

                case 2:
                    bombe = 25;
                    break;

                case 3:
                    bombe = 50;
                    break;
            }
        }
    }
}
