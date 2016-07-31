using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace Consultorio_Medico
{
    public partial class Form1 : Form
    {
        String convenio = "";
        String medico = "";
        String especialidade = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                convenio = listView1.Items[listView1.SelectedIndices[0]].SubItems[0].Text;
                medico = listView1.Items[listView1.SelectedIndices[0]].SubItems[1].Text;
                especialidade = listView1.Items[listView1.SelectedIndices[0]].SubItems[2].Text;
            }
            catch (Exception ex)
            {

            }
            //listView1.Items[i].Text
            //listView1.SelectedIndices[1]
        }
        public void insert(String sql)
        {
            
        }
        public String data_sql(String data)
        {
            String res = "";
            String[] partes = Regex.Split(data, "/");
            res = partes[2] + "-" + partes[1] + "-" + partes[0];
            return res;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            String hoje = monthCalendar1.SelectionRange.Start.ToString();
            
            String[] partes = Regex.Split(hoje, " ");
            String sql = data_sql(partes[0]);

            String sql_final = "INSERT INTO consulta VALUES(null,'" + textBox1.Text + "','" + textBox2.Text + "','" + data_sql(partes[0]) + "','" + textBox3.Text +"','"+convenio+"','"+medico+"','"+especialidade+"');";
            try
            {

                MySqlConnection conexao = new MySqlConnection("server=localhost;database=ds;uid=root;pwd=''");

                MySqlCommand cmd = new MySqlCommand(sql_final, conexao);
                conexao.Open();
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }


            //MessageBox.Show("Convenio="+convenio+" ; Medico = "+medico+"; Especialidade="+especialidade);
        }
    }
}
