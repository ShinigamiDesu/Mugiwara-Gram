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
    public partial class AddPost : Form
    {
        DataIO dataIO = new DataIO();
        public string UserID { get; set; }
        byte[] value;
        string path;
        public AddPost()
        {
            InitializeComponent();
        }

        private void AddPost_Load(object sender, EventArgs e)
        {
            pic_post.Image = null;
            txt_caption.Text = "";

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            string ImagePath = "";

            OpenFileDialog Dialog = new OpenFileDialog();
            Dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All Files(*.*)|*.*";
            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                ImagePath = Dialog.FileName.ToString();
                pic_post.ImageLocation = ImagePath;
                path = ImagePath;
            }
            byte[] imagebyte = null;
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            imagebyte = br.ReadBytes((int)fs.Length);
            value = imagebyte;
        }

        private void btn_Post_Click(object sender, EventArgs e)
        {
            if (txt_caption.Text == "" || pic_post.Image == null)
            {
                MessageBox.Show("Fill All Fields");
            }
            else 
            {
                dataIO.AddPost(UserID, txt_caption.Text, path, value);
                this.Hide();
            }
            
        }
    }
}
