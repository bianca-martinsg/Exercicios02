using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercício01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Declaração de variáveis
            int valor01;
            int valor02;
            int resultado;

            //Capturando o que o usuário informou
            valor01 = Convert.ToInt32(txtValor01.Text);
            valor02 = Convert.ToInt32(txtValor02.Text);

            //Executando o processamento
            resultado = valor01 + valor02;

            //Exibindo a saída
            lblResultado.Text = Convert.ToString(resultado);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Limpando os componentes
            txtValor01.Text = "";
            txtValor02.Clear();
            lblResultado.Text = "0";

            //Voltando o foco para o txtValor01
            txtValor01.Focus();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtValor01_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
