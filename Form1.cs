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
            InizializzazioneGrafica();
        }

        private void btn_Impostazioni_Click(object sender, EventArgs e)
        {
            impostazioni.pulsantePremuto();
            impostazioni.ShowDialog();
        }

        private void InizializzazioneGrafica()
        {
            //metto a schermo intero
            this.FormBorderStyle = FormBorderStyle.None; //Tolgo il bordo della finestra
            this.WindowState = FormWindowState.Maximized; //Metto a schermo intero

            //prendo i dati della finestra
            int width = this.Width = Screen.PrimaryScreen.Bounds.Width; //Larghezza della finestra
            int height = this.Height = Screen.PrimaryScreen.Bounds.Height; //Altezza della finestra

            //centro la picturebox "Entrate Esplosive"
            EntrateEsplosive.Left = (width - EntrateEsplosive.Width) / 2; //centro in orizzontale
            EntrateEsplosive.Top = ((height - EntrateEsplosive.Height) / 2) - 350; //centro in verticale

            //pulsante esci
            btn_esci.Size = new Size(500, 150); //dimensione del pulsante
            btn_esci.Left = (width - btn_esci.Width) / 2; //centro in orizzontale
            btn_esci.Top = ((height - btn_esci.Height) / 2) + 400; //centro in verticale
            

            //pulsante gioca
            btn_gioca.Size = new Size(500, 170); //dimensione del pulsante
            btn_gioca.Left = (width - btn_gioca.Width) / 2; //centro in orizzontale
            btn_gioca.Top = ((height - btn_gioca.Height) / 2); //centro in verticale
            btn_gioca.BackgroundImage = Image.FromFile("btn_play.png"); // immagine
            btn_gioca.BackgroundImageLayout = ImageLayout.Stretch; //adatto l'immagine al pulsante
            btn_gioca.FlatStyle = FlatStyle.Flat; //pulsante senza bordo
            btn_gioca.FlatAppearance.BorderSize = 0; //pulsante senza bordo


            //pulsante impostazioni
            btn_Impostazioni.Size = new Size(500, 150); //dimensione del pulsante
            btn_Impostazioni.Left = (width - btn_Impostazioni.Width) / 2; //centro in orizzontale
            btn_Impostazioni.Top = ((height - btn_Impostazioni.Height) / 2) +200; //centro in verticale
        }
        public void Inizializzazioni()
        {
            impostazioni.Show();
            impostazioni.Hide();
        }

        private void btn_gioca_Click(object sender, EventArgs e)
        {
            FGioca gioca = new FGioca(impostazioni);

            impostazioni.pulsantePremuto();
            gioca.Show();
        }

        private void btn_esci_Click(object sender, EventArgs e)
        {
            impostazioni.pulsantePremuto();
            Application.Exit();
        }
    }
}
