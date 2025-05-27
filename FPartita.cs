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
    public partial class FPartita : Form
    {
        public FPartita(double ncelle, int bombe)
        {
            InitializeComponent();
            CreaTabellone(ncelle);
        }

        private void CreaTabellone(double ncelle)
        {
            ncelle *= 10;

            dgv_main.Columns.Clear();
            dgv_main.Rows.Clear();
            dgv_main.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;


            dgv_main.ColumnCount = (int)ncelle;
            for(int i =0; i<ncelle; i++)
            {
                dgv_main.Rows.Add();
            }



            // calcola dimensione precisa celle

            int cellWidth = (int)dgv_main.ClientSize.Height/(int)ncelle;


            dgv_main.Columns[0].Width = cellWidth;

            for(int i =0; i<dgv_main.Rows.Count; i++)
            {
                dgv_main.Rows[i].Height = cellWidth;
            }
        }



        private void dgv_main_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("prrr!");
        }

        private void FPartita_Load(object sender, EventArgs e)
        { 
        }
    }
}
