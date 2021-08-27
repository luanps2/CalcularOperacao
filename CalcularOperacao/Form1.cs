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

        private void button1_Click(object sender, EventArgs e)
        {
           double v1 = Convert.ToDouble(txtValor1.Text);
            double v2 = Convert.ToDouble(txtValor2.Text);
            string resultado = lblResultado.Text;

            //MessageBox.Show(groupBox1.Checked);

            //switch (rbSomar.Checked)
            //{
            //    resultado = (v1 + v2).ToString():
            //        break;
            //}

            //if (rbSomar.Checked)
            //{
            //    lblResultado.Text = (v1 + v2).ToString();
            //}else if
        }
    }
}
