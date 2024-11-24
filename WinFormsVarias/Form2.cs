using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsVarias
{
    public partial class Form2 : Form
    {
        private string name = "";
        private static int numero;
        public Form2()
        {
            InitializeComponent();

        }

        public Form2(string name)
        {
            InitializeComponent();
            this.name = name;
            Form2.numero=Form1.num;
            this.textBoxNameForma2.Text = name;
            this.textBoxNumero.Text = Convert.ToString(Form2.numero);

        }

        private void BotonRegresar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Regresando a Form1");
            this.Close();
            
        }
    }
}
