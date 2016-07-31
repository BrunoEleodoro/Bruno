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
using System.Data.SqlClient;

namespace Acessando_Mysql
{
    public partial class Form1 : Form
    {
        string config = "server=localhost;database=ds;uid=root;pwd=''";
        //INSERT INTO papelaria VALUES(null,"Caderno",2.45);
        public Form1()
        {
            InitializeComponent();
        }
        public void fill()
        {
            MySqlConnection con = new MySqlConnection(config);
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM papelaria", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        public void insert()
        {
            try
            {
                   
                MySqlConnection conexao = new MySqlConnection("server=localhost;database=ds;uid=root;pwd=''");
               
                MySqlCommand cmd = new MySqlCommand("INSERT INTO papelaria VALUES("+textBox1.Text+",'"+textBox2.Text+"','"+textBox3.Text+"')",conexao);
                conexao.Open();
                cmd.ExecuteNonQuery();
                conexao.Close();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                fill();
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex);
            }
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            fill();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                insert();
                MessageBox.Show("INSERIDO COM SUCESSO");
            }
            catch (Exception)
            {
                MessageBox.Show("ERRO");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("INSIRA UM CODIGO!");
            }
            else
            {
                try
                {
                    MySqlConnection con = new MySqlConnection(config);
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM papelaria WHERE cod=" + textBox1.Text, con);
                    //MySqlDataAdapter adapter = new MySqlDataAdapter(, con);
                    MySqlDataReader rdr = cmd.ExecuteReader();

                    rdr.Read();
                    textBox2.Text = (rdr.GetString(1));
                    textBox3.Text = (rdr.GetString(2));
                    con.Close();
                    button3.Enabled = true;
                    button4.Enabled = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi possivel localizar o codigo");
                }
                

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Insira o codigo");
            }
            else
            {
                try
                {
                    MySqlConnection conexao = new MySqlConnection("server=localhost;database=ds;uid=root;pwd=''");

                    MySqlCommand cmd = new MySqlCommand("DELETE FROM papelaria WHERE cod=" + textBox1.Text, conexao);
                    conexao.Open();
                    cmd.ExecuteNonQuery();
                    conexao.Close();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    fill();
                    button3.Enabled = false;
                    button4.Enabled = false;
                }
                catch (Exception)
                {

                }
            }
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection("server=localhost;database=ds;uid=root;pwd=''");
                //update papelaria set cod=1,nome='teste',preco=1.56 WHERE cod=0
                MySqlCommand cmd = new MySqlCommand("UPDATE papelaria SET cod=" + textBox1.Text + ",nome='"+textBox2.Text+"',preco="+textBox3.Text+" WHERE cod="+textBox1.Text, conexao);
                conexao.Open();
                cmd.ExecuteNonQuery();
                conexao.Close();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                fill();
                button3.Enabled = false;
                button4.Enabled = false;
            }
            catch (Exception)
            {

            }
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
