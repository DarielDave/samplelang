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
using System.Data.OleDb;

namespace Financial_Processing
{
    public partial class salary : Form
    {
        MySqlConnection conn;
        MySqlCommand cn;
        MySqlDataReader GetReader;
        MySqlDataAdapter getadapter;
        global frmcon = new global();

        
        public salary()
        {
            InitializeComponent();
            textBox3.Enabled = true;
            conn = new MySqlConnection(frmcon.dbconnect());


        }
        private void viewdata()
        {
            conn.Open();
            cn = new MySqlCommand("SELECT `AID`, `fname`, `lname`, `date`, `hours`, `days`, `total_sal` FROM `salary`", conn);
            GetReader = cn.ExecuteReader();
            listView1.Items.Clear();
            while (GetReader.Read())
            {
                ListViewItem view = new ListViewItem(Convert.ToString(GetReader["fname"]));
                view.SubItems.Add(Convert.ToString(GetReader["lname"]));
                view.SubItems.Add(Convert.ToString(GetReader["date"]));
                view.SubItems.Add(Convert.ToString(GetReader["total_sal"]));
                view.SubItems.Add(Convert.ToString(GetReader["AID"]));
                listView1.Items.Add(view);
            }
            conn.Close();
            GetReader.Close();
        }
        private void salary_Load(object sender, EventArgs e)
        {
            viewdata();
            revenue();
            loadDatatoCombobox();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Value.ToString("MM-dd-yyyy");
            if (string.IsNullOrEmpty(comboBox1.Text)|| string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrEmpty(textBox6.Text)|| string.IsNullOrEmpty(date)|| string.IsNullOrEmpty(textBox2.Text)|| string.IsNullOrEmpty(textBox4.Text)|| string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("please insert values");
            }
            else
            {
                conn.Open();
                cn = new MySqlCommand("INSERT INTO `salary`(`AID`, `fname`,mname,lname,date, `hours`, `days`, `total_sal`) VALUES ('" + global.a_name + "','" + comboBox1.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + date + "','" + textBox2.Text + "','" + textBox4.Text + "','" + textBox3.Text + "')", conn);
                cn.ExecuteNonQuery();
                MessageBox.Show("successful");
                conn.Close();
                viewdata();
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void revenue()
        {
            conn.Open();
            cn = new MySqlCommand("SELECT SUM(amount) FROM `payment`", conn);
            GetReader = cn.ExecuteReader();
            while (GetReader.Read())
            {
                string revenue = GetReader["SUM(amount)"].ToString();
                label13.Text = revenue;
            }
            conn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void loadDatatoCombobox()
        {
            conn.Open();
            getadapter = new MySqlDataAdapter("SELECT `fname`, `mname`, `lname` FROM `personnel`", conn);
            DataTable table = new DataTable();
            getadapter.Fill(table);
            table.Rows.Add("name");
            comboBox1.DataSource = table;
            comboBox1.DisplayMember = "fname";
            comboBox1.ValueMember = "fname";
            comboBox1.SelectedValue = "select fname";
            conn.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
