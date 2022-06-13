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
            lblResultado.Text = "Status";

            //Colocando o foco no local correto
            txtValor01.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Definindo as variáveis
            int valor01;
            int valor02;
            String resultado;

            //Armazenando os valores de entrada
            valor01 = Convert.ToInt32(txtValor01.Text);
            valor02 = Convert.ToInt32(txtValor02.Text);

            //Executando o processamento
            if (valor01 == valor02)
            {
                resultado = "Números iguais";
            }
            else
            if (valor01 > valor02)
            {
                resultado = Convert.ToString(valor01) + 
                    " é o maior";
            }
            else
            {
                resultado = Convert.ToString(valor02) + 
                    " é o maior";
            }

            //Exibindo o resultado
            lblResultado.Text = resultado;
        }
    }
}
