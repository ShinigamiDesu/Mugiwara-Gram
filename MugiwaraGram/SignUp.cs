using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MugiwaraGram
{
    public partial class SignUp : Form
    {
        DataIO dataIO = new DataIO();
        string path; 
        byte[] value;
        public SignUp()
        {
            InitializeComponent();
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            string ImagePath = "";

            OpenFileDialog Dialog = new OpenFileDialog();
            Dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All Files(*.*)|*.*";
            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                ImagePath = Dialog.FileName.ToString();
                pic_pfp.ImageLocation = ImagePath;
                path = ImagePath;
            }
            byte[] imagebyte = null;
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            imagebyte = br.ReadBytes((int)fs.Length);
            value = imagebyte;

        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "" || txt_password.Text == "" || pic_pfp.Image == null) 
            {
                MessageBox.Show("Fill All Fields");
            }
            else if (dataIO.CheckUsername(txt_username.Text))
            {
                MessageBox.Show("Username Already Exists");
            }
            else 
            {
                dataIO.AddUser(txt_username.Text, txt_password.Text, path, value);
                txt_username.Text = "";
                txt_password.Text = "";
                pic_pfp.Image = null;   
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath obj = new System.Drawing.Drawing2D.GraphicsPath();
            obj.AddEllipse(0, 0, pic_pfp.Width, pic_pfp.Height);
            Region rg = new Region(obj);
            pic_pfp.Region = rg;
        }
    }
}
