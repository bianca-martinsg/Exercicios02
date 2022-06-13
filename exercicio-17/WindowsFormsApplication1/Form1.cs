using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Limpar os componentes
            txtValor.Text = "";
            lblResultado.Text = "Status";

            //Colocando o foco no local correto
            txtValor.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Definindo as variáveis
            int valor;
            string positivo_negativo;
            string par_impar;

            //Armazenando os valores de entrada
            valor = Convert.ToInt32(txtValor.Text);

            //Executando o processamento
            if (valor >= 0)
            {
                positivo_negativo = "POSITIVO";
            }
            else
            {
                positivo_negativo = "NEGATIVO";
            }

            //Indicando se é par ou ímpar
            if (valor % 2 == 0)
            {
                par_impar = "PAR";
            }
            else
            {
                par_impar = "ÍMPAR";
            }

            //Exibindo o resultado
            lblResultado.Text = positivo_negativo + ". " + par_impar;
        }
    }
}
