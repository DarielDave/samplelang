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
    public partial class paymentfrm : Form
    {
        MySqlConnection conn;
        MySqlCommand cn;
        MySqlDataReader GetReader;
        global frmcon = new global();
        
        public paymentfrm()
        {
            InitializeComponent();
            conn = new MySqlConnection(frmcon.dbconnect());
            
        }

        private void viewdata()
        {
            conn.Open();
            cn = new MySqlCommand("SELECT  `fname`, `lname`, `amount`, `a_name` FROM `payment`", conn);
            GetReader = cn.ExecuteReader();
            listView1.Items.Clear();
            while (GetReader.Read())
            {
                ListViewItem view = new ListViewItem(Convert.ToString(GetReader["fname"]));
                view.SubItems.Add(Convert.ToString(GetReader["lname"]));
                view.SubItems.Add(Convert.ToString(GetReader["amount"]));
                view.SubItems.Add(Convert.ToString(GetReader["a_name"]));
                listView1.Items.Add(view);
            }
            conn.Close();
            GetReader.Close();
        }
        private void paymentfrm_Load(object sender, EventArgs e)
        {
            viewdata();
            panel5.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Value.ToString("MM-dd-yyyy");
            if (string.IsNullOrEmpty(fbox.Text)|| string.IsNullOrEmpty(mbox.Text)|| string.IsNullOrEmpty(lbox.Text)|| string.IsNullOrEmpty(blkbox.Text)|| string.IsNullOrEmpty(lotbox.Text)|| string.IsNullOrEmpty(streetbox.Text)|| string.IsNullOrEmpty(date)|| string.IsNullOrEmpty(amountbox.Text))
            {
                MessageBox.Show("Fill Missing Input");
            }
            else
            {
                conn.Open();
                cn = new MySqlCommand("INSERT INTO payment(fname,mname,lname,blk,lot,street,date,amount,a_name) VALUES ('" + fbox.Text + "','" + mbox.Text + "','" + lbox.Text + "','" + blkbox.Text + "','" + lotbox.Text + "','" + streetbox.Text + "','" + date + "','" + amountbox.Text + "','" + global.a_name + "')", conn);
                cn.ExecuteNonQuery();
                MessageBox.Show("successful");
                conn.Close();
                viewdata();
            }
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
            
        }

        private void label10_Click(object sender, EventArgs e)
        {
            
            
        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            panel6.Size = new Size(325, 469);
            pictureBox1.Visible = false;
            panel5.Visible = true;
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void panel5_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click_2(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_3(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void panel6_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel6.Size = new Size(20, 469);
            pictureBox1.Visible = true;
            panel5.Visible = false;
        }

        

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            cn = new MySqlCommand("INSERT INTO `resident`(`fname`, `mname`, `lname`, `blk`, `lot`, `street`, `contnum`) VALUES ('"+ fname + "','" + mname + "','" + lname + "','" + block + "','" + lot + "','" + street + "','" + contnum + "')",conn);
            cn.ExecuteNonQuery();
            conn.Close();
        }
    }
}
