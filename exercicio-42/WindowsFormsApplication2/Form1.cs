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

            int valorInicial = -200;
            int valorFinal = 200;
            int soma = 0;

            //Limpar o textArea
            memValores.Text = "";

            for (int i = valorInicial; i <= valorFinal; i++)
            {
                //Somente os ímpares E divisíveis por 5
                if ((i % 2 == 1) && (i % 5 == 0)) {
                    //A expressão abaixo equivale a: soma = soma + i
                    soma += i;
                    memValores.AppendText(Convert.ToString(soma) + Environment.NewLine);
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

            int valorInicial = -200;
            int valorFinal = 200;
            int soma = 0;

            //Limpar o textarea
            memValores.Text = "";

            int i = valorInicial;
            while (i <= valorFinal)
            {
                //Somente os ímpares E divisíveis por 5
                if ((i % 2 == 1) && (i % 5 == 0))
                {
                    //A expressão abaixo equivale a: soma = soma + i
                    soma += i;
                    memValores.AppendText(Convert.ToString(soma) + Environment.NewLine);
                }

                i++;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            memValores.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }
    }
}
