namespace CampoMinato2
{
    using System;
    using NAudio.Wave;
    public partial class Form1 : Form
    {

        FImpostazioni impostazioni = new FImpostazioni();
        
        


        public Form1()
        {
            InitializeComponent();
            Inizializzazioni();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btn_Impostazioni_Click(object sender, EventArgs e)
        {
            //prendo l'istanza del suono dal form impostazioni
            
            impostazioni.pulsantePremuto();

            impostazioni.ShowDialog();

            
        }

        public void Inizializzazioni()
        {
            impostazioni.Show();
            impostazioni.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void btn_gioca_Click(object sender, EventArgs e)
        {

            var FormGioca = new FGioca(this);
            if (FormGioca.ShowDialog() == DialogResult.OK)
            {
                FormGioca.Close();
            }
        }
    }
}
