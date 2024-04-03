using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MugiwaraGram
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\amazi\\OneDrive\\Desktop\\C# coding\\Websites, Apps And Databases\\MugiwaraGram\\MugiwaraGram\\MugiwaraGram.mdf\";Integrated Security=True");

        DataIO dataIO = new DataIO();
        public string UserID { get; set; }
        public Login()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string selecting = "SELECT UserID, username, password  FROM tbl_Users WHERE username = '" + txt_username.Text + "' and password = '" + txt_password.Text + "'";
            SqlDataAdapter adapt = new SqlDataAdapter(selecting, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            if (txt_username.Text == "" || txt_password.Text == "") 
            {
                MessageBox.Show("Fill All Fields");
            }
            else if (dt.Rows.Count > 0)
            {
                this.Hide();
                MainPage frm = new MainPage();
                dataIO.UserID = dt.Rows[0]["UserID"].ToString();
                frm.Username = dt.Rows[0]["username"].ToString();
                frm.UserID = dt.Rows[0]["UserID"].ToString();
                frm.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Username or Password Incorrect");
            }
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp sign = new SignUp();
            sign.ShowDialog();
        }

        private void check_pass_CheckedChanged(object sender, EventArgs e)
        {
            if (check_pass.Checked == true)
            {
                txt_password.UseSystemPasswordChar = true;
            }
            else if (check_pass.Checked == false)
            {
                txt_password.UseSystemPasswordChar = false;
            }
        }
    }
}
