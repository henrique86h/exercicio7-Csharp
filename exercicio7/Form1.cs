using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
    
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double valor1, valor2;
            if (double.TryParse(textBox1.Text, out valor1) && double.TryParse(textBox2.Text, out valor2))
            {
                double resultado = 0;

               
                if (radioButtonAdicao.Checked)
                    resultado = valor1 + valor2;
                else if (radioButtonSubtracao.Checked)
                    resultado = valor1 - valor2;
                else if (radioButtonMultiplicacao.Checked)
                    resultado = valor1 * valor2;
                else if (radioButtonDivisao.Checked)
                {
                    if (valor2 != 0)
                        resultado = valor1 / valor2;
                    else
                        MessageBox.Show("Não é possível dividir por zero.");
                }

                
                labelResultado.Text = $"Resultado: {resultado}";
            }
            else
            {
                MessageBox.Show("Insira valores numéricos válidos.");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
