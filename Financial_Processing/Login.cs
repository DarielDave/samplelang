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
    public partial class Login : Form
    {
        MySqlConnection conn;
        MySqlDataAdapter dr;
        global frmcon = new global();
        public Login()
        {
            InitializeComponent();
            conn = new MySqlConnection(frmcon.dbconnect());
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
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            conn.Open();
            dr = new MySqlDataAdapter("SELECT * FROM admin WHERE uname='"+textBox1.Text+"' AND pass='"+textBox2.Text+"'",conn);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                global.a_name = dt.Rows[0]["uname"].ToString();
                MessageBox.Show("Welcome "+global.a_name);
                this.Hide();
                landing_page nf = new landing_page();
                nf.Show();
                
            }
            else
            {
                MessageBox.Show("invalid account");
                
            }
            conn.Close();

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
