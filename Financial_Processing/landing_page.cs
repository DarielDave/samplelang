using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace Financial_Processing
{
    public partial class landing_page : Form
    {
        MySqlConnection conn;
        MySqlCommand cn;
        MySqlDataReader GetReader;
        global frmcon = new global();
        public landing_page()
        {
            InitializeComponent();
            conn = new MySqlConnection(frmcon.dbconnect());
            this.panel10.Controls.Clear();
            Dashboard dashboard_form = new Dashboard()
            {
                Dock = DockStyle.Bottom,
                TopLevel = false
            };
            dashboard_form.FormBorderStyle = FormBorderStyle.None;
            this.panel10.Controls.Add(dashboard_form);
            dashboard_form.Show();
            
        }
        private void landing_page_Load(object sender, EventArgs e)
        {
            viewdata();
        }
        private void viewdata()
        {
            conn.Open();
            cn = new MySqlCommand("SELECT `fname`, `lname`, `contnum` FROM `resident`", conn);
            GetReader = cn.ExecuteReader();
            listView1.Items.Clear();
            while (GetReader.Read())
            {

                ListViewItem view = new ListViewItem(Convert.ToString(GetReader["fname"]));
                view.SubItems.Add(Convert.ToString(GetReader["lname"]));
                view.SubItems.Add(Convert.ToString(GetReader["contnum"]));
                
                listView1.Items.Add(view);
            }
            conn.Close();
            GetReader.Close();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);
        private void panel9_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            add_admin nf = new add_admin();
            nf.Show();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Login nf = new Login();
            nf.Show();
            Visible = false;
        }

        

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void panel5_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.panel10.Controls.Clear();
            Dashboard dashboard_form = new Dashboard()
            {
                Dock = DockStyle.Bottom,TopLevel=false
            };
            dashboard_form.FormBorderStyle = FormBorderStyle.None;
            this.panel10.Controls.Add(dashboard_form);
            dashboard_form.Show();
        }

        private void pictureBox3_click(object sender, EventArgs e)
        {
            this.panel10.Controls.Clear();
            paymentfrm payment_form = new paymentfrm()
            {
                Dock = DockStyle.Bottom,
                TopLevel = false
            };
            payment_form.FormBorderStyle = FormBorderStyle.None;
            this.panel10.Controls.Add(payment_form);
            payment_form.Show();
        }
        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.FromArgb(255, 128, 0);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Transparent;

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.panel10.Controls.Clear();
            salary salary_form = new salary()
            {
                Dock = DockStyle.Bottom,
                TopLevel = false
            };
            salary_form.FormBorderStyle = FormBorderStyle.None;
            this.panel10.Controls.Add(salary_form);
            salary_form.Show();
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.FromArgb(255, 128, 0);
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.Transparent;
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint_2(object sender, PaintEventArgs e)
        {

        }
    }
}
