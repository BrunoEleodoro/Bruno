using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Installer
{
    public partial class Form2 : Form
    {
        String raiz = "";
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false)
            {
                button3.Enabled = false;
            }
            else
            {
                button3.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false)
            {
                button3.Enabled = false;
            }
            else
            {
                button3.Enabled = true;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Pegando diretorio do programa
            raiz = System.Environment.CurrentDirectory.ToString();
            //Criando o arquivo com a liçença
            StreamWriter printer = new StreamWriter(""+raiz+"\\licença.rtf");
            //escrevendo em uma linha 
            printer.WriteLine("                LICENÇA DO PROGRAMA");
            printer.WriteLine("Termos de Serviço do Google");

            printer.WriteLine("Última modificação: 14 de abril de 2014 (visualizar versões arquivadas)");

            printer.WriteLine("Bem-vindo ao Google!");
            printer.WriteLine("Agradecemos por usar nossos produtos e serviços (“Serviços”). Os Serviços serão fornecidos pelo Google Inc. (“Google”), localizado em 1600 Amphitheatre Parkway, Mountain View, CA 94043, Estados Unidos.");

            printer.WriteLine("Ao usar nossos Serviços, você está concordando com estes termos. Leia-os com atenção.");

            printer.WriteLine("Nossos Serviços são muito diversos, portanto, às vezes, podem aplicar-se termos adicionais ou exigências de produtos (inclusive exigências de idade). Os termos adicionais estarão disponíveis com os Serviços relevantes e esses termos adicionais se tornarão parte de nosso contrato com você, caso você use esses Serviços.");
            //Esvaziando o objeto escritor
            printer.Flush();
            //fechando o arquivo
            printer.Close();
            //mostrando mensagem
            MessageBox.Show("Relatorio gerado em "+raiz);
        }
    
    }
}
