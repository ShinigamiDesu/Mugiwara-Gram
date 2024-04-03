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
    public partial class EditProfile : UserControl
    {
        public EditProfile()
        {
            InitializeComponent();
        }

        public string UserID {  get; set; } 
        private Image _pfp;
        private string _Username;
        private string _Password;

        public string Username
        {
            get { return _Username; }
            set { _Username = value; txt_username.Text = value; }
        }

        public string Password
        {
            get { return _Password; }
            set { _Password = value; txt_password.Text = value; }
        }

        public Image Pfp
        {
            get { return _pfp; }
            set { _pfp = value; pic_pfp.Image = value; }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {

        }
    }
}
