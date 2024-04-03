using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MugiwaraGram
{
    public partial class Post : UserControl
    {
        private string _PostID;
        private string _Username;
        private string _Time;
        private string _Cap_Username;
        private string _caption;
        private Image _post;
        private Image _pfp;
        private MainPage mainPage;
        public Post(MainPage mainPage)
        {
            InitializeComponent();
            this.mainPage = mainPage;   
        }

        public string Username 
        {
            get { return _Username; }
            set { _Username = value; lbl_username.Text = value; }
        }
        public string ID
        {
            get { return _PostID; }
            set { _PostID = value; }
        }

        public string Time
        {
            get { return _Time; }
            set { _Time = value; lbl_time.Text = value; }
        }

        public string Cap_Username 
        {
            get { return _Cap_Username; }
            set { _Cap_Username = value; lbl_usercap.Text = value; }
        }
        public string Caption 
        {
            get { return _caption; }
            set { _caption = value; lbl_caption.Text = value; }
        }
        public Image Pfp 
        {
            get { return _pfp; }
            set { _pfp = value; pic_user.Image = value; }
        }
        public Image post
        {
            get { return _post; }
            set { _post = value; pic_post.Image = value; }
        }

        private void lbl_comments_Click(object sender, EventArgs e)
        {
            mainPage.PostID = _PostID;
            mainPage.GenerateComments();
        }
        #region Hover
        private void lbl_comments_MouseEnter(object sender, EventArgs e)
        {
            lbl_comments.ForeColor = Color.White;
            pic_comments.Image = pic_comm2.Image;
        }

        private void lbl_comments_MouseLeave(object sender, EventArgs e)
        {
            lbl_comments.ForeColor = Color.Gray;
            pic_comments.Image = pic_original.Image;
        }
        #endregion
    }
}
