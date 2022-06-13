using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Limpando os componentes
            txtBase.Text = "";
            txtAltura.Clear();
            lblResultado.Text = "0";

            //Ajustando o foco
            txtBase.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Declarar as variáveis
            int base_triangulo;
            int altura_triangulo;
            int area;

            //Capturar os valores de entrada
            base_triangulo = Convert.ToInt32(txtBase.Text);
            altura_triangulo = Convert.ToInt32(txtAltura.Text);

            //Executando o processamento
            area = base_triangulo * altura_triangulo / 2;

            //Exibindo a saída
            lblResultado.Text = Convert.ToString(area);


        }
    }
}
