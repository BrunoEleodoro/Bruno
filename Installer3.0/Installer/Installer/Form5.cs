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

    public partial class Form5 : Form
    {
        public String caminho = "";
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                System.Diagnostics.Process.Start(caminho);
                Application.Exit();
            }
            else
            {
                Application.Exit();

            }
        }

    }
}
