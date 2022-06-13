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
            lblResultado25.Text = "0";
            lblResultado50.Text = "0";
            lblResultado100.Text = "0";
            lblResultado150.Text = "0";

            //Colocando o foco no local correto
            txtValor.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Definindo as variáveis
            double valor;
            double resultado25;
            double resultado50;
            double resultado100;
            double resultado150;

            //Armazenando os valores de entrada
            valor = Convert.ToDouble(txtValor.Text);

            //Executando o processamento
            resultado25 = valor * 0.25;
            resultado50 = valor * .5;
            resultado100 = valor;
            resultado150 = valor * 1.5;

            //Exibindo o resultado
            lblResultado25.Text = Convert.ToString(resultado25);
            lblResultado50.Text = Convert.ToString(resultado50);
            lblResultado100.Text = Convert.ToString(resultado100);
            lblResultado150.Text = Convert.ToString(resultado150);
        }
    }
}
