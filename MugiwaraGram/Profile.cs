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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace MugiwaraGram
{
    public partial class Profile : UserControl
    {
        private MainPage mainPage;
        DataIO dataIO = new DataIO();
        public string UserID { get; set; }
        public string PostID { get; set; }
        private Image _pfp;
        private string _Username;
        private string _Following;
        private string _Followers;

        public Profile(MainPage mainPage)
        {
            InitializeComponent();
            this.mainPage = mainPage;

        }

        public FlowLayoutPanel getPanel() 
        {
            return profile_panel;
        }

        public string Username
        {
            get { return _Username; }
            set { _Username = value; lbl_username.Text = value; }
        }
        public string Following
        {
            get { return _Following; }
            set { _Following = value; lbl_following.Text = value; }
        }
        public string Followers
        {
            get { return _Followers; }
            set { _Followers = value; lbl_followers.Text = value; }
        }
        public Image Pfp
        {
            get { return _pfp; }
            set { _pfp = value; pic_pfp.Image = value; }
        }

        public void Profile_Load()
        {
            dataIO.UserID = UserID;
            
            DataTable dt = dataIO.getOwnPosts(UserID);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    Post[] listItems = new Post[dt.Rows.Count];
                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            listItems[i] = new Post(mainPage);
                            // Add ID
                            listItems[i].ID = row["PostID"].ToString();
                            // Add Profile Picture
                            MemoryStream ms = new MemoryStream((byte[])row["ImgPFPValue"]);
                            listItems[i].Pfp = new Bitmap(ms);
                            // Add Username
                            listItems[i].Username = row["username"].ToString();
                            listItems[i].Cap_Username = row["username"].ToString();
                            // Add Caption
                            listItems[i].Caption = row["caption"].ToString();
                            // Add Post Image
                            MemoryStream ms1 = new MemoryStream((byte[])row["ImgValue"]);
                            listItems[i].post = new Bitmap(ms1);
                            // Add Time
                            listItems[i].Time = row["date_posted"].ToString();
                            profile_panel.Controls.Add(listItems[i]);
                        }
                    }
                }
                else
                {
                    profile_panel.Controls.Clear();
                }
            }
            else
            {
                profile_panel.Controls.Clear();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            mainPage.UserID = UserID;
            dataIO.UserID = UserID;
            mainPage.GenerateEditProfile();
        }

        private void lbl_followers_Click(object sender, EventArgs e)
        {
            mainPage.UserID = UserID;
            mainPage.choice = 1;
            mainPage.DisplayFollowData();
        }

        private void lbl_following_Click(object sender, EventArgs e)
        {
            mainPage.UserID = UserID;
            mainPage.choice = 2;    
            mainPage.DisplayFollowData();
        }

        #region Hover Effects
        private void lbl_followers_MouseEnter(object sender, EventArgs e)
        {
            lbl_followers.ForeColor = Color.Gray;
            label1.ForeColor = Color.Gray;
        }

        private void lbl_followers_MouseLeave(object sender, EventArgs e)
        {
            lbl_followers.ForeColor = Color.White;
            label1.ForeColor = Color.White;
        }

        private void lbl_following_MouseEnter(object sender, EventArgs e)
        {
            lbl_following.ForeColor = Color.Gray;
            label2.ForeColor = Color.Gray;
        }

        private void lbl_following_MouseLeave(object sender, EventArgs e)
        {
            lbl_following.ForeColor = Color.White;
            label2.ForeColor = Color.White;
        }
        #endregion
    }
}
