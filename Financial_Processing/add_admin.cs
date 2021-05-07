using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace Financial_Processing
{
    public partial class add_admin : Form
    {
        MySqlConnection conn;
        MySqlCommand cn;
        global frmconn = new global();
        public add_admin()
        {
            InitializeComponent();
            conn = new MySqlConnection(frmconn.dbconnect());

        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void add_admin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();

            if (string.IsNullOrEmpty(textBox1.Text)|| string.IsNullOrEmpty(textBox2.Text)|| string.IsNullOrEmpty(textBox3.Text)|| string.IsNullOrEmpty(comboBox1.Text)|| string.IsNullOrEmpty(textBox5.Text)|| string.IsNullOrEmpty(textBox6.Text)|| string.IsNullOrEmpty(textBox7.Text))
            {
                MessageBox.Show("please inpute required data");
            }
            else if (textBox6.TextLength <=8)
            {
                MessageBox.Show("please input 8 character");
            }
            else if(textBox6.Text== textBox7.Text)
            {
                MessageBox.Show("mismatch password");
            }
            else
            {
                cn = new MySqlCommand("INSERT INTO admin (uname,pass,Fname,mname,lname,posi) VALUES('" + textBox5.Text + "','" + textBox6.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "')", conn);
                cn.ExecuteNonQuery();
                MessageBox.Show("Successful");
                conn.Close();
            }
            
        }
    }
}
