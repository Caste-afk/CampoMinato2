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
    public partial class FSalva : Form
    {
        int[,] matrix;
        DataGridView dgv;
        int righe;
        int colonne;
        int ncelle;
        int nbombe;
        public FSalva(int[,] matrix, DataGridView dgv, int righe, int ncelle, int nbombe)
        {
            InitializeComponent();
            this.matrix = matrix;
            this.dgv = dgv;
            this.righe = righe;
            colonne = righe;
            this.ncelle = ncelle;
            this.nbombe = nbombe;
        }

        private void btn_Salva_Click(object sender, EventArgs e)
        {
            string nomeFile = tbx_NomeFile.Text;

            if (string.IsNullOrEmpty(nomeFile))
            {
                MessageBox.Show("Inserire un nome corretto");
            }
            else
            {
                string path = $@"salvataggi/{nomeFile}.csv";
                string matrice = $"{ncelle}, {nbombe}";

                for(int r=0; r< righe; r++)
                {
                    for(int c = 0; c <colonne; c++)
                    {
                        matrice += $"{matrix[r, c]}, ";
                    }
                    matrice += "\n";
                }

                File.WriteAllText(path, matrice);
                this.Close();
            }

        }
    }
}
