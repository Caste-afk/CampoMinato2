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

        int[,] campo;
        int clickAttuale;
        FImpostazioni impostazioni;

        public FPartita(double ncelle, int bombe, FImpostazioni i)
        {
            clickAttuale = 0;
            impostazioni = i;
            InitializeComponent();
            CreaTabellone(ncelle);
            generaMine(bombe, ncelle);
        }

        private void CreaTabellone(double ncelle)
        {
            ncelle *= 10;

            dgv_main.ColumnCount = (int)ncelle;
            dgv_main.RowCount = (int)ncelle;
            dgv_main.CellClick += dgv_main_CellClick;
            dgv_main.CellMouseDown += dgv_main_CellMouseDown;
            //dimensiono in base al numero di celle

            //genero le celle del DataGridView
            for (int i = 0; i < ncelle; i++)
            {
                for (int j = 0; j < ncelle; j++)
                {
                    dgv_main.Rows[i].Cells[j].Value = ""; // inizializzo le celle con una stringa vuota
                    dgv_main.Rows[i].Cells[j].Style.BackColor = Color.LightGray; // imposta il colore di sfondo delle celle
                    dgv_main.Rows[i].Cells[j].Style.ForeColor = Color.Black; // imposta il colore del testo delle celle
                }
            }

        }

        private void generaMine(int nMine, double larghezza)
        {

            larghezza *= 10;
            Random rnd = new Random();
            int area = (int)(larghezza * larghezza); // calcolo l'area del campo di gioco

            //le mine sono passate come percentuale del numero di celle
            nMine = (int)(area * (nMine / 100.0)); // calcolo il numero di mine in base alla percentuale

            // genero una matrice di interi per gestire il campo di gioco
            campo = new int[(int)larghezza, (int)larghezza];

            // genero le mine
            for (int i = 0; i < nMine; i++)
            {
                int x, y;
                do
                {
                    x = rnd.Next(0, (int)larghezza);
                    y = rnd.Next(0, (int)larghezza);
                } while (campo[x, y] == -1);
                campo[x, y] = -1;
            }

            // calcolo i numeri delle celle
            for (int i = 0; i < larghezza; i++)
            {
                for (int j = 0; j < larghezza; j++)
                {
                    if (campo[i, j] != -1)
                    {
                        int count = 0;
                        // controllo le celle vicine
                        for (int x = -1; x <= 1; x++)
                        {
                            for (int y = -1; y <= 1; y++)
                            {
                                if (x == 0 && y == 0) continue; // salto la cella corrente
                                int newX = i + x;
                                int newY = j + y;
                                if (newX >= 0 && newX < larghezza && newY >= 0 && newY < larghezza && campo[newX, newY] == -1)
                                {
                                    count++;
                                }
                            }
                        }
                        campo[i, j] = count;
                    }
                }

                //mostra le celle con le mine nere per debug
                for (int x = 0; x < larghezza; x++)
                {
                    for (int y = 0; y < larghezza; y++)
                    {
                        if (campo[x, y] == -1)
                        {
                            dgv_main.Rows[x].Cells[y].Value = ""; // mostra una mina
                            dgv_main.Rows[x].Cells[y].Style.BackColor = Color.Black; // cambio colore della cella
                        }
                    }
                }
            }
        }

        private void dgv_main_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            impostazioni.cellaCliccata(); // trigger del suono quando si preme una cella

            //controllo quale cella è stata cliccata
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return; // esce se la cella non è valida
            int x = e.RowIndex;
            int y = e.ColumnIndex;

            if (campo[x, y] == -1)
            {
                dgv_main.Rows[x].Cells[y].Value = "💣"; // mostra una mina
                dgv_main.Rows[x].Cells[y].Style.BackColor = Color.Red; // cambio colore della cella
                MessageBox.Show("Hai perso! Hai cliccato su una mina.", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit(); // chiude l'applicazione
            }
            if (campo[x, y] >= 0)
            {
                //"scopro" tutte le celle che hanno 0 nelle vicinanze fino to a che non trovo celle con numeri
                if (campo[x, y] == 0)
                {
                    ScopriCelle(x, y);
                }
                else
                {
                    dgv_main.Rows[x].Cells[y].Value = campo[x, y]; // mostra il numero della cella
                    dgv_main.Rows[x].Cells[y].Style.BackColor = Color.LightBlue; // cambio colore della cella
                }
            }

            // quando clicco una cella numerata scopro le celle vicine, a parte quelle flaggate come mine
            for (int dx = -1; dx <= 1; dx++)
            {
                for (int dy = -1; dy <= 1; dy++)
                {
                    int newX = x + dx;
                    int newY = y + dy;

                    if (newX >= 0 && newX < campo.GetLength(0) &&
                        newY >= 0 && newY < campo.GetLength(1) &&
                        !(dx == 0 && dy == 0))
                    {
                        var cellValue = dgv_main.Rows[newX].Cells[newY].Value;

                        // Se la cella non è stata cliccata ancora e non è flaggata
                        if (cellValue == null || (cellValue.ToString() != "F" && cellValue.ToString() == ""))
                        {
                            if (campo[newX, newY] == 0)
                            {
                                ScopriCelle(newX, newY);
                            }
                            else if (campo[newX, newY] > 0)
                            {
                                dgv_main.Rows[newX].Cells[newY].Value = campo[newX, newY];
                                dgv_main.Rows[newX].Cells[newY].Style.BackColor = Color.LightBlue;
                            }
                        }
                    }
                }
            }

            clickAttuale++;
            if (clickAttuale == campo.GetLength(0) * campo.GetLength(1) - 10) // se ho cliccato tutte le celle tranne le mine
            {
                MessageBox.Show("Hai vinto! Hai scoperto tutte le celle senza cliccare su una mina.", "Vittoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit(); // chiude l'applicazione
            }
        }

        private void ScopriCelle(int x, int y)
        {
            if (x < 0 || x >= campo.GetLength(0) || y < 0 || y >= campo.GetLength(1)) return; // esce se la cella non è valida
            if (dgv_main.Rows[x].Cells[y].Value != null && dgv_main.Rows[x].Cells[y].Value.ToString() != "") return; // esce se la cella è già scoperta
            dgv_main.Rows[x].Cells[y].Value = campo[x, y]; // mostra il numero della cella
            dgv_main.Rows[x].Cells[y].Style.BackColor = Color.LightBlue; // cambio colore della cella
            if (campo[x, y] == 0)
            {
                //scopro le celle vicine
                ScopriCelle(x - 1, y - 1);
                ScopriCelle(x - 1, y);
                ScopriCelle(x - 1, y + 1);
                ScopriCelle(x, y - 1);
                ScopriCelle(x, y + 1);
                ScopriCelle(x + 1, y - 1);
                ScopriCelle(x + 1, y);
                ScopriCelle(x + 1, y + 1);
            }
        }
        private void dgv_main_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex < 0 || e.ColumnIndex < 0) return; // esce se la cella non è valida

                //prendo le coordinate della cella
                int x = e.RowIndex;
                int y = e.ColumnIndex;

                //se la cella è flaggata la rimuovo, altrimenti la flaggo come mina

                if (dgv_main.Rows[x].Cells[y].Value == null || dgv_main.Rows[x].Cells[y].Value.ToString() == "")
                {
                    dgv_main.Rows[x].Cells[y].Value = "F"; // segna la cella come mina
                    dgv_main.Rows[x].Cells[y].Style.BackColor = Color.Yellow; // cambio colore della cella
                }

                else if (dgv_main.Rows[x].Cells[y].Value.ToString() == "F")
                {
                    dgv_main.Rows[x].Cells[y].Value = ""; // rimuove la segnalazione della mina
                    dgv_main.Rows[x].Cells[y].Style.BackColor = Color.LightGray; // ripristina il colore originale della cella
                }
            }
        }
    }
}
