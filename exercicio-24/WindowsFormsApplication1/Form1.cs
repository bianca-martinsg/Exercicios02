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
            txtValor04.Text = "";

            //Colocando o foco no local correto
            txtValor01.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Definindo as variáveis
            double valor01;
            double valor02;
            double valor03;
            double valor04;
            string valor01_status;
            string valor01_divisivel4;
            string valor02_status;
            string valor02_divisivel4;
            string valor03_status;
            string valor03_divisivel4;
            string valor04_status;
            string valor04_divisivel4;

            //Armazenando os valores de entrada
            valor01 = Convert.ToInt32(txtValor01.Text);
            valor02 = Convert.ToInt32(txtValor02.Text);
            valor03 = Convert.ToInt32(txtValor03.Text);
            valor04 = Convert.ToInt32(txtValor04.Text);

            //Executando o processamento

            //Determinando o status de cada número
            if (valor01 == 0)
            {
                valor01_status = "ZERO";
            }
            else
            {
                //Uso do if ternário
                /*
                 A alternativa a esse código seria:
                 if (valor01 > 0)
                 {
                    valor01_status = "POSITIVO";
                 }
                 else
                 {
                    valor01_status = "NEGATIVO";
                 }
                 */
                
                //Usando o if ternário.
                valor01_status = (valor01 > 0)  ? "POSITIVO" : "NEGATIVO";
            }

            if (valor02 == 0)
            {
                valor02_status = "ZERO";
            }
            else
            {
                valor02_status = valor02 > 0 ? "POSITIVO" : "NEGATIVO";
            }

            if (valor03 == 0)
            {
                valor03_status = "ZERO";
            }
            else
            {
                valor03_status = valor03 > 0 ? "POSITIVO" : "NEGATIVO";
            }

            if (valor04 == 0)
            {
                valor04_status = "ZERO";
            }
            else
            {
                valor04_status = valor04 > 0 ? "POSITIVO" : "NEGATIVO";
            }

            //Determinando se o número é divisível por 4
            valor01_divisivel4 = (valor01 % 4 == 0) ? "SIM" : "NÃO";
            valor02_divisivel4 = (valor02 % 4 == 0) ? "SIM" : "NÃO";
            valor03_divisivel4 = (valor03 % 4 == 0) ? "SIM" : "NÃO";
            valor04_divisivel4 = (valor04 % 4 == 0) ? "SIM" : "NÃO";

            MessageBox.Show("Valor: " + Convert.ToString(valor01) + Environment.NewLine +
                "Status: " + valor01_status + Environment.NewLine +
                "Divisível por 4: " + valor01_divisivel4, 
                "Exercício 24", MessageBoxButtons.OK, MessageBoxIcon.Information);

            MessageBox.Show("Valor: " + Convert.ToString(valor02) + Environment.NewLine +
                "Status: " + valor02_status + Environment.NewLine +
                "Divisível por 4: " + valor02_divisivel4,
                "Exercício 24", MessageBoxButtons.OK, MessageBoxIcon.Information);

            MessageBox.Show("Valor: " + Convert.ToString(valor03) + Environment.NewLine +
                "Status: " + valor03_status + Environment.NewLine +
                "Divisível por 4: " + valor03_divisivel4,
                "Exercício 24", MessageBoxButtons.OK, MessageBoxIcon.Information);

            MessageBox.Show("Valor: " + Convert.ToString(valor04) + Environment.NewLine +
                "Status: " + valor04_status + Environment.NewLine +
                "Divisível por 4: " + valor04_divisivel4,
                "Exercício 24", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
