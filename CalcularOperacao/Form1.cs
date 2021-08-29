using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularOperacao
{
    public partial class Form1 : Form
    {
        public void calcular(double v1, double v2)
        {
            try
            {
                v1 = Convert.ToDouble(txtValor1.Text);
                v2 = Convert.ToDouble(txtValor2.Text);
                

                //Soma
                if (rbSomar.Checked == true)
                {
                    lblResultado.Text = (v1 + v2).ToString();
                }

                //Subtração
                else if (rbSubtrair.Checked == true)
                {
                    lblResultado.Text = (v1 - v2).ToString();
                }

                //Multiplicação
                else if (rbMultiplicar.Checked == true)
                {
                    lblResultado.Text = (v1 * v2).ToString();
                }

                //Divisão
                else if (rbDividir.Checked == true)
                {
                    lblResultado.Text = (v1 / v2).ToString();
                }

                //Média
                else if (rbMedia.Checked == true)
                {
                    lblResultado.Text = ((v1 + v2) / 2).ToString();
                }

                //Quadrado
                else if (rbQuadrado.Checked == true)
                {
                    if (txtValor2.Text == "")
                    {
                        txtValor2.Text = "0";
                    }
                    lblResultado.Text = Math.Pow(v1, 2).ToString();
                }


            }
            catch (Exception)
            {

                MessageBox.Show("Verifique os valores digitados!");
            }


        }

        public Form1()
        {
            InitializeComponent();

            
        }


        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void testeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSplitButton1_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtValor2.Text == "")
                {
                    txtValor2.Text = "0";
                }
                calcular(Convert.ToDouble(txtValor1.Text), Convert.ToDouble(txtValor2.Text));
            }
            catch (Exception)
            {

               MessageBox.Show("Verifique os valores digitados!");
            }

            
        }

        private void teste2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void calcularToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtValor2.Text == "")
                {
                    txtValor2.Text = "0";
                }
                calcular(Convert.ToDouble(txtValor1.Text), Convert.ToDouble(txtValor2.Text));


            }
            catch (Exception)
            {

                MessageBox.Show("Verifique os valores digitados!"); ;
            }
           
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmSobre janela = new frmSobre();
            janela.ShowDialog();

        }
    }
}
