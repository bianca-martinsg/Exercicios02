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
            lblResultado.Text = "0";

            //Colocando o foco no local correto
            txtNota01.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Definindo as variáveis
            double nota01;
            double nota02;
            double nota03;
            double nota04;
            double media;

            //Armazenando os valores de entrada
            nota01 = Convert.ToDouble(txtNota01.Text);
            nota02 = Convert.ToDouble(txtNota02.Text);
            nota03 = Convert.ToDouble(txtNota03.Text);
            nota04 = Convert.ToDouble(txtNota04.Text);

            //Executando o processamento
            media = (((nota01 + nota02 + nota03) / 3) * 0.3) + (nota04 * 0.7);

            //Exibindo o resultado
            lblResultado.Text = Convert.ToString(media);
        }
    }
}
