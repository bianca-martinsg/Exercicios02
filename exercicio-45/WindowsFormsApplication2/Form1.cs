using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Usando o comando "FOR"
            int valorInicial;
            int valorFinal;

            //Limpar o textArea
            memTodos.Text = "";

            valorInicial = Convert.ToInt32(txtValorInicial.Text);
            valorFinal = Convert.ToInt32(txtValorFinal.Text);

            if (valorInicial > valorFinal)
            {
                MessageBox.Show("O valor inicial deve ser menor que o final", 
                    "Atenção", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Exclamation);
                txtValorInicial.Focus();
                return;
            }

            //Calculando a somatória e a quantidade de elementos
            for (int numeroAtual = valorInicial; numeroAtual <= valorFinal; numeroAtual++)
            {
                int quantidadeDivisiveis = 0;
                for (int auxiliar = 2; auxiliar <= numeroAtual - 1; auxiliar++)
                {
                    if (numeroAtual % auxiliar == 0)
                    {
                        quantidadeDivisiveis++;
                    }
                }

                //Se for número primo, adiciona no memTodos
                if (quantidadeDivisiveis == 0)
                {
                    memTodos.AppendText(Convert.ToString(numeroAtual) + Environment.NewLine);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Usando o comando "WHILE"
            int valorInicial;
            int valorFinal;

            //Limpar o textArea
            memTodos.Text = "";

            valorInicial = Convert.ToInt32(txtValorInicial.Text);
            valorFinal = Convert.ToInt32(txtValorFinal.Text);

            if (valorInicial > valorFinal)
            {
                MessageBox.Show("O valor inicial deve ser menor que o final",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                txtValorInicial.Focus();
                return;
            }

            //Calculando a somatória e a quantidade de elementos
            int numeroAtual = valorInicial;
            while (numeroAtual <= valorFinal)
            {
                int quantidadeDivisiveis = 0;
                int auxiliar = 2;
                while (auxiliar <= numeroAtual - 1)
                {
                    if (numeroAtual % auxiliar == 0)
                    {
                        quantidadeDivisiveis++;
                    }
                    auxiliar++;
                }

                //Se for número primo, adiciona no memTodos
                if (quantidadeDivisiveis == 0)
                {
                    memTodos.AppendText(Convert.ToString(numeroAtual) + Environment.NewLine);
                }

                numeroAtual++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtValorInicial.Text = "";
            txtValorFinal.Text = "";
            memTodos.Text = "";

            txtValorInicial.Focus();
        }
    }
}
