using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace MugiwaraGram
{
    public partial class CommentDesign : UserControl
    {
        private string _Username;
        private string _Comment;
        private Image _pfp;
        public string UserID { get; set; }
        public string PostID { get; set; }
        public CommentDesign()
        {
            InitializeComponent();
        }

        public string Username
        {
            get { return _Username; }
            set { _Username = value; lbl_username.Text = value; }
        }
        public string Comment
        {
            get { return _Comment; }
            set { _Comment = value; lbl_comment.Text = value; }
        }
        public Image Pfp
        {
            get { return _pfp; }
            set { _pfp = value; pic_pfp.Image = value; }
        }
    }
}
