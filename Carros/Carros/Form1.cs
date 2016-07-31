using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Carros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string getSelected()
        {
            string coluna = "";
            if (radioButton1.Checked == true)
            {
                coluna = "marca";
            }
            else if (radioButton2.Checked == true)
            {
                coluna = "modelo";
            }
            else if (radioButton3.Checked == true)
            {
                coluna = "combustivel";
            }
            else if (radioButton4.Checked == true)
            {
                coluna = "ano";
            }
            else if (radioButton5.Checked == true)
            {
                coluna = "preco";
            }
            else if (radioButton6.Checked == true)
            {
                coluna = "cor";
            }
            return coluna;
        }
        private void button1_Click(object sender, EventArgs e)
        {


            string res = getSelected();
            //INSERT INTO concessionaria VALUES(null,"FIAT","UNO","GASOLINA",'2016',30.000,"VERMELHO")
            string config = ("server=localhost;database=concessionaria;uid=root;pwd=''");
            MySqlConnection conexao = new MySqlConnection(config);
            MySqlDataAdapter consulta = new MySqlDataAdapter("SELECT * FROM concessionaria WHERE "+res+" LIKE \"%"+textBox1.Text+"%\"", conexao);
            /*
            consulta.SelectCommand.Parameters.AddWithValue("@coluna", res);
            consulta.SelectCommand.Parameters.AddWithValue("@PARAMETRO_NOME", );
            */
            DataTable dt = new DataTable();
            consulta.Fill(dt);
            dataGridView1.DataSource = dt;
            conexao.Close();
        }

    }
}
