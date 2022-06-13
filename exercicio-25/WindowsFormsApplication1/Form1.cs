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
            txtTipoOperacao.Text = "";
            txtValor01.Text = "";
            txtValor02.Text = "";

            //Colocando o foco no local correto
            txtTipoOperacao.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Definindo as variáveis
            int tipoOperacao;
            double valor01;
            double valor02;
            double resultado = 0;

            //Armazenando os valores de entrada
            tipoOperacao = Convert.ToInt32(txtTipoOperacao.Text);
            valor01 = Convert.ToDouble(txtValor01.Text);
            valor02 = Convert.ToDouble(txtValor02.Text);

            //Executando o processamento
            if (tipoOperacao == 0)
            {
                resultado = valor01 + valor02;
            }
            else
            if (tipoOperacao == 1)
            {
                resultado = valor01 - valor02;
            }
            else
            if (tipoOperacao == 2)
            {
                resultado = valor01 * valor02;
            }
            else
            if (tipoOperacao == 3)
            {
                resultado = valor01 / valor02;
            }

            MessageBox.Show("Resultado: " + Convert.ToString(resultado),
            "Exercício 25", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
