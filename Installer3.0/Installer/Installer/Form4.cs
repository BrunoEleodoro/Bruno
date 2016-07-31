using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Installer
{
    public partial class Form4 : Form
    {
        String file = "\\cl.exe";
        String raiz = "";
        
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            String caminho = folderBrowserDialog1.SelectedPath;
            textBox1.Text = caminho + "" + file;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            raiz = System.Environment.CurrentDirectory.ToString() + file;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Selecione uma pasta!");
            }
            else
            {
                try
                {
                    File.Copy(raiz, textBox1.Text);
                }
                catch (Exception)
                {

                }
                progressBar1.Value = 100;
                Thread.Sleep(500);
                MessageBox.Show("'Cidadão Ligado!' instalado com sucesso!");

                Form5 f5 = new Form5();
                f5.caminho = textBox1.Text;
                f5.Show();
                this.Hide();
            }
            

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
