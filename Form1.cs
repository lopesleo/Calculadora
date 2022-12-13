using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora2
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            txtRes.Text += "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtRes.Text += "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtRes.Text += "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtRes.Text += "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtRes.Text += "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtRes.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtRes.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtRes.Text += "7";
        }


        private void button2_Click(object sender, EventArgs e)
        {
            txtRes.Text += "8";
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            txtRes.Text += "9";
        }

        private void txtRes_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (txtRes.Text != "")
            {
                valor2 = decimal.Parse(txtRes.Text, CultureInfo.InvariantCulture);

                if (operacao == "soma")
                {
                    txtRes.Text = Convert.ToString(valor1 + valor2);
                }
                else if (operacao == "sub")
                {
                    txtRes.Text = Convert.ToString(valor1 - valor2);
                }
                else if (operacao == "mult")
                {
                    txtRes.Text = Convert.ToString(valor1 * valor2);
                }
                else
                {
                    txtRes.Text = Convert.ToString(valor1 / valor2);
                }
            }
            else
                MessageBox.Show("digite um valor válido");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txtRes.Text != "")
            {
                valor1 = decimal.Parse(txtRes.Text, CultureInfo.InvariantCulture);

            txtRes.Text = "";
            operacao = "sub";
            label1.Text = "-";
            }

            else
                MessageBox.Show("informe um valor");
        }
    

        private void button12_Click(object sender, EventArgs e)
          
        {
        if (txtRes.Text != "")
            {
                valor1 = decimal.Parse(txtRes.Text, CultureInfo.InvariantCulture);

            txtRes.Text = "";
            operacao = "mult";
            label1.Text = "X";

            }

                else
                    MessageBox.Show("informe um valor");
        }
        

        private void button17_Click(object sender, EventArgs e)
        {
            if (txtRes.Text != "")
            {
                valor1 = decimal.Parse(txtRes.Text, CultureInfo.InvariantCulture);

            txtRes.Text = "";
            operacao = "div";
            label1.Text = "÷";

                }

                else
        MessageBox.Show("informe um valor");
}
             


                

        private void button5_Click(object sender, EventArgs e)
        {
            txtRes.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtRes.Text += ".";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtRes.Text = "";
            valor1 = 0;
            valor2 = 0;
            label1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtRes.Text != "")
            {
                valor1 = decimal.Parse(txtRes.Text, CultureInfo.InvariantCulture);

                txtRes.Text = "";
                operacao = "soma";
                label1.Text = "+";
            }

            else
                MessageBox.Show("informe um valor");
        }
    }
}
