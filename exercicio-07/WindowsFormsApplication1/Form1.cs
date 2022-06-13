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
            lblDobro.Text = "0";
            lblTriplo.Text = "0";

            //Colocando o foco no local correto
            txtValor.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Definindo as variáveis
            double valor;
            double dobro;
            double triplo;
            //Armazenando os valores de entrada
            valor = Convert.ToDouble(txtValor.Text);

            //Executando o processamento
            dobro = valor * 2;
            triplo = valor * 3;

            //Exibindo o resultado
            lblDobro.Text = Convert.ToString(dobro);
            lblTriplo.Text = Convert.ToString(triplo);
        }
    }
}
