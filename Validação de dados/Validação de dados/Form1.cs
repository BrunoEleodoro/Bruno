using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Validação_de_dados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                CNPJ(textBox1.Text);
            }
            else if(radioButton2.Checked == true)
            {

            }
            else if (radioButton3.Checked == true)
            {

            }
        }
        public string CNPJ(string cnpj)
        {
            string res = "";
            return res;
        }
        public string CPF(string cpf)
        {
            string res = "";
            return res;
        }
        public string PIS(string pis)
        {
            string res = "";
            return res;
        }

    }
}
