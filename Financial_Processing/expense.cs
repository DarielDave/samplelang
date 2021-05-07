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
    public partial class expense : Form
    {
        
        MySqlConnection conn;
        MySqlCommand cn;
        MySqlDataReader GetReader;
        global frmcon = new global();
        
        string id,particular,cost;
        public expense()
        {
            InitializeComponent();
            conn = new MySqlConnection(frmcon.dbconnect());
        }

        private void expense_Load(object sender, EventArgs e)
        {
            viewdata();
            tota_expense();
            listView1.FullRowSelect = true;
            textBox5.Enabled = false;
            
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                id = item.SubItems[0].Text;
                particular = item.SubItems[1].Text;
                cost = item.SubItems[2].Text;
                pictureBox1.Enabled = true;
            }
        }
        private void viewdata()
        {
            conn.Open();
            cn = new MySqlCommand("SELECT `EID`,`event_name`, `date`, `particular`, `cost`, `quantity`,etotal, `a_name` FROM `event`", conn);
            GetReader = cn.ExecuteReader();
            listView1.Items.Clear();
            while (GetReader.Read())
            {
                ListViewItem view = new ListViewItem(Convert.ToString(GetReader["EID"]));
                view.SubItems.Add(Convert.ToString(GetReader["particular"]));
                view.SubItems.Add(Convert.ToString(GetReader["cost"]));
                view.SubItems.Add(Convert.ToString(GetReader["quantity"])); 
                view.SubItems.Add(Convert.ToString(GetReader["etotal"])); 
                view.SubItems.Add(Convert.ToString(GetReader["date"]));
                view.SubItems.Add(Convert.ToString(GetReader["event_name"])); 
                listView1.Items.Add(view);
            }
            conn.Close();
            GetReader.Close();
        }
        private void tota_expense()
        {
            conn.Open();
            cn = new MySqlCommand("SELECT sum(etotal) as etotal FROM event", conn);
            GetReader = cn.ExecuteReader();
            while (GetReader.Read())
            {
                string expense = GetReader["etotal"].ToString();
                label11.Text = expense;
                
            }
            conn.Close();
            GetReader.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrEmpty(textBox1.Text)|| String.IsNullOrEmpty(textBox4.Text)|| String.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("insert value");
            }
            else
            {
                conn.Open();
                string date = dateTimePicker1.Value.ToString("MM-dd-yyyy");
                cn = new MySqlCommand("INSERT INTO `event`(event_name,date,particular,cost,quantity,etotal,a_name) VALUES ('" + textBox3.Text + "','" + date + "','" + textBox2.Text + "','" + textBox1.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + global.a_name + "')",conn);
                cn.ExecuteNonQuery();
                MessageBox.Show("successful");
                conn.Close();
                viewdata();
                tota_expense();
            }
            
        }

        

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            cqtotal();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("are you sure you want to delete "+particular+"cost of "+cost,"confirmation", MessageBoxButtons.YesNo);
            if (Result == DialogResult.Yes)
            {
                conn.Open();
                cn = new MySqlCommand("DELETE FROM event where EID ='" + id + "'",conn);
                GetReader = cn.ExecuteReader();
                conn.Close();
                GetReader.Close();
                MessageBox.Show("Successfully Deleted");
                viewdata();
                
            }
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void cqtotal()
        {
            if (String.IsNullOrEmpty(textBox1.Text)|| String.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("insert value");
            }
            else
            {
                int cost, quantity, total;
                cost = int.Parse(textBox1.Text);
                quantity = int.Parse(textBox4.Text);
                total = cost * quantity;
                textBox5.Text = Convert.ToString(total);
            }
            
        }
    }
}
