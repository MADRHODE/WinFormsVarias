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
    public partial class Form3 : Form
    {
        private int num = 0;

        public Form3()
        {
            InitializeComponent();
        }

        public Form3(int num)
        {
            InitializeComponent();
            this.num = num;
            this.textBoxNumero.Text = Convert.ToString(this.num);
            this.tablamultiplicar();
        }

        private void tablamultiplicar()
        {
            int n = this.num;
            string tabla = "";
            for (int i = 1; i <= 10; i++)
            {
                if (i * n < 10)
                {
                    tabla = tabla + n + " x " + i + " = " + "\t" + (n * i) + "\n";
                }
                else
                {
                    tabla = tabla + n + " x " + i + " = " + (n * i) + "\n";
                }
            }

            this.richTextBoxTabla.AppendText(tabla);
        }



        private void BotonRegresar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Regresando a Form1");
            this.Close();
        }

        private void BotonRegresar_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Regresando a Form1");
            this.Close();
        }
    }
}
