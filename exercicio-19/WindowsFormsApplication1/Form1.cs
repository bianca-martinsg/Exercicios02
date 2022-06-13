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
            txtValor01.Text = "";
            txtValor02.Text = "";
            txtValor03.Text = "";

            //Colocando o foco no local correto
            txtValor01.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Definindo as variáveis
            int valor01;
            int valor02;
            int valor03;
            String resultado01;
            String resultado02;
            String resultado03;

            //Armazenando os valores de entrada
            valor01 = Convert.ToInt32(txtValor01.Text);
            valor02 = Convert.ToInt32(txtValor02.Text);
            valor03 = Convert.ToInt32(txtValor03.Text);

            //Executando o processamento
            
            //Parte 01:
            if (valor01 > 0)
            {
                resultado01 = Convert.ToString(valor01 * 2);
            }
            else
            {
                resultado01 = Convert.ToString(valor01 * 3);
            }

            //Parte 02:
            if ((valor02 > 10) && (valor02 < 100))
            {
                resultado02 = "Intervalo permitido";
            }
            else
            {
                resultado02 = "";
            }

            //Parte 03:
            if (valor03 < valor02)
            {
                resultado03 = Convert.ToString(valor03 - valor02);
            }
            else
            {
                resultado03 = Convert.ToString(valor03 + 1);
            }

            //Exibindo o resultado em uma caixa de texto
            MessageBox.Show(resultado01 + Environment.NewLine + resultado02 + Environment.NewLine + resultado03, "Exercício 19", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
