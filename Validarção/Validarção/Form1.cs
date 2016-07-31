using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Validarção
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Boolean checkCPF(String text)
        {
            Boolean res = false;
            try
            {
                
                int length = text.Length;
                int soma1 = 0;
                int soma2 = 0;
                int[] valores_cpf1 = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                int[] valores_cpf2 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                if (length > 11)
                {
                    res = false;
                }
                else
                {
                    int i = 0;
                    int sub = (length - 2);
                    while (i < sub)
                    {
                        try
                        {
                            int num = int.Parse("" + text[i]);
                            soma1 += num * valores_cpf2[i];
                            soma2 += num * valores_cpf1[i];
                        }
                        catch (Exception ex)
                        {

                        }
                        i++;
                    }
                    int resto1 = soma1 % 11;
                    int resto2 = soma2 % 11;
                    int verificador1 = 0;
                    int verificador2 = 0;
                    if (resto1 >= 2)
                    {
                        verificador1 = 11 - resto1;

                    }
                    else
                    {
                        verificador1 = 2;
                    }

                    if (resto2 >= 2)
                    {
                        verificador2 = 11 - resto2;

                    }
                    else
                    {
                        verificador2 = 2;
                    }

                    if (int.Parse("" + text[9]) == verificador1 && int.Parse("" + text[10]) == verificador2)
                    {
                        res = true;
                    }
                    else
                    {
                        res = false;
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return res;
        }
        public Boolean checkCNPJ(String text)
        {
            Boolean res = false;
            try
            {

                int length = text.Length;
                int soma1 = 0;
                int soma2 = 0;
                int[] valores_cnpj1 = { 6,5,4,3,2,9,8,7,6,5,4,3,2};
                int[] valores_cnpj2 = { 5,4,3,2,9,8,7,6,5,4,3,2 };
                if (length > 14)
                {
                    res = false;
                }
                else
                {
                    int i = 0;
                    int num = 0;
                    int sub = (length - 2);
                    while (i < sub)
                    {
                        try
                        {
                            num = int.Parse("" + text[i]);
                            soma1 += num * valores_cnpj2[i];
                            soma2 += num * valores_cnpj1[i];
                        }
                        catch (Exception ex)
                        {

                        }
                        i++;
                    }
                    num = int.Parse("" + text[12]);
                    soma2 += num * 2;
                    int resto1 = soma1 % 11;
                    int resto2 = soma2 % 11;
                    int verificador1 = 0;
                    int verificador2 = 0;
                    if (resto1 >= 2)
                    {
                        verificador1 = 11 - resto1;

                    }
                    else
                    {
                        verificador1 = 0;
                    }

                    if (resto2 >= 2)
                    {
                        verificador2 = 11 - resto2;

                    }
                    else
                    {
                        verificador2 = 0;
                    }
                    if (int.Parse("" + text[12]) == verificador1 && int.Parse("" + text[13]) == verificador2)
                    {
                        res = true;
                    }
                    else
                    {
                        res = false;
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return res;
        }
        public Boolean checkPIS(String text)
        {
            Boolean res = false;
            try
            {
                int length = text.Length;
                int[] valores = {3,2,9,8,7,6,5,4,3,2};
                int soma = 0;
                int i = 0;
                while(i < (length - 1))
                {
                    int num = int.Parse("" + text[i]);
                    soma += num * valores[i];
                    i++;
                }
                int resto = soma % 11;
                int sub = 11 - resto;
                if (sub >= 10)
                {
                    sub = 0;
                }
                else
                {

                }
                if (int.Parse(""+text[length - 1]) == sub)
                {
                    res = true;
                }
                else
                {
                    res = false;
                }
            }
            catch (Exception ex)
            {
                res = false;
            }

            return res;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            
            if (radioButton1.Checked == true)
            {
                if (checkCNPJ(textBox1.Text) == true)
                {
                    MessageBox.Show("CNPJ VALIDO");
                }
                else
                {
                    MessageBox.Show("CNPJ INVALIDO");
                }
            }
            else if (radioButton2.Checked == true)
            {
                if (checkCPF(textBox1.Text) == true)
                {
                    MessageBox.Show("CPF VALIDO");
                }
                else
                {
                    MessageBox.Show("CPF INVALIDO");
                }
            }
            else if (radioButton3.Checked == true)
            {
                if (checkPIS(textBox1.Text) == true)
                {
                    MessageBox.Show("PIS VALIDO");
                }
                else
                {
                    MessageBox.Show("PIS INVALIDO");
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "47567512882";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "02228667000171";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "22641698284";
        }
        
    }
}
