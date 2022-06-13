using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercício_05
{
    public partial class Exercício05 : Form
    {
        public Exercício05()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Limpando os componentes
            txtValor.Text = "";
            lblResultado.Text = "0";

            // Ajustando o foco
            txtValor.Focus();
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Declarar as variáveis
            int valor_numerico;
            int resultado;

            //Armazenando os valores de entrada
            valor_numerico = Convert.ToInt32(txtValor.Text);

            //Executando o processamento
            resultado = valor_numerico - 1;

            //Exibindo o resultado
            lblResultado.Text = Convert.ToString(resultado);
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
