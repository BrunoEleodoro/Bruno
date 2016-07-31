using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace Installer
{
    public partial class Form1 : Form
    {
        String versao = "1.2.1";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            String v = wc.DownloadString("http://fotoperfil.pe.hu/tcc/checkVersao.php?versao="+versao);
            MessageBox.Show(v);
        }
    }
}
