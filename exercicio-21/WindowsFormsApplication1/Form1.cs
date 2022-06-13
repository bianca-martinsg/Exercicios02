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
            lblResultado.Text = "Status";

            //Colocando o foco no local correto
            txtValor01.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Definindo as variáveis
            double valor01;
            double valor02;
            double valor03;
            double maior;

            //Armazenando os valores de entrada
            valor01 = Convert.ToDouble(txtValor01.Text);
            valor02 = Convert.ToDouble(txtValor02.Text);
            valor03 = Convert.ToDouble(txtValor03.Text);

            //Executando o processamento
            if (valor01 >= valor02)
            {
                if (valor01 > valor03)
                {
                    maior = valor01;
                }
                else
                {
                    maior = valor03;
                }
            }
            else
            {
                if (valor02 > valor03)
                {
                    maior = valor02;
                }
                else
                {
                    maior = valor03;
                }
            }

            //Exibindo o resultado
            lblResultado.Text = Convert.ToString(maior);
        }
    }
}
