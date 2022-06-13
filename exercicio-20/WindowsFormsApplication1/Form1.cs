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
            txtNota01.Text = "";
            txtNota02.Text = "";
            txtNota03.Text = "";
            txtNota04.Text = "";
            lblResultado.Text = "Status";

            //Colocando o foco no local correto
            txtNota01.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Definindo as variáveis
            double valor01;
            double valor02;
            double valor03;
            double valor04;
            double media;
            String resultado;

            //Armazenando os valores de entrada
            valor01 = Convert.ToInt32(txtNota01.Text);
            valor02 = Convert.ToInt32(txtNota02.Text);
            valor03 = Convert.ToInt32(txtNota03.Text);
            valor04 = Convert.ToInt32(txtNota04.Text);

            //Executando o processamento
            media = (valor01 + valor02 + valor03 + valor04) / 4;
            MessageBox.Show("A média é: " + Convert.ToString(media), "Exercício 20", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            if (media >= 6)
            {
                resultado = "APROVADO";
            }
            else
            {
                resultado = "REPROVADO";
            }

            //Exibindo o resultado
            lblResultado.Text = resultado;
        }
    }
}
