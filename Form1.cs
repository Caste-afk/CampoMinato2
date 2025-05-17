namespace CampoMinato2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Lazza-rone");
        }

        private void btn_gioca_Click(object sender, EventArgs e)
        {
            using(var FormGioca = new FGioca())
            {
                if(FormGioca.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }
    }
}