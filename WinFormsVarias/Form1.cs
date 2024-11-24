namespace WinFormsVarias
{
    public partial class Form1 : Form
    {
        public static int num = 21;
        public int numero = 0;
        public Form1()
        {
            InitializeComponent();
            this.textBoxNombre.Text = "";
        }

        private void BotonFormulario2_Click(object sender, EventArgs e)
        {
            string dato = this.textBoxNombre.Text;
            Form2 form2 = new Form2(dato);
            this.Hide();
            form2.ShowDialog();
            this.Show();
        }

        private void BotonSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BotonFormulario3_Click(object sender, EventArgs e)
        {
            int dato = Convert.ToInt32(this.textBoxNumero.Text);
            Form3 form3 = new Form3(dato);
            this.Hide();
            form3.ShowDialog();
            this.Show();
        }
    }
}
