using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MugiwaraGram
{
    public partial class SearchProfile : UserControl
    {
        public SearchProfile(MainPage mainPage)
        {
            InitializeComponent();
            this.mainPage = mainPage;
        }

        private MainPage mainPage;
        DataIO dataIO = new DataIO();
        public string UserID { get; set; }
        public string PostID { get; set; }
        public string UsernameLogged { get; set; }

        string friendID;
        public string SearchedUsername { get; set; }
        private Image _pfp;
        private string _Username;
        private string _Following;
        private string _Followers;

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

        public void FollowButtonValidation() 
        {
            bool following = dataIO.CheckFollowing(UserID, friendID);
            if (following || SearchedUsername == UsernameLogged)
            {
                btn_follow.Visible = false;
            }
            else
            {
                btn_follow.Visible = true;
            }
        }

        public void Profile_Load(string ID)
        {
            dataIO.UserID = UserID;
            DataTable dt = dataIO.getOwnPosts(ID);
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
                            Searchprofile_panel.Controls.Add(listItems[i]);
                        }
                    }
                }
                else
                {
                    Searchprofile_panel.Controls.Clear();
                }
            }
            else
            {
                Searchprofile_panel.Controls.Clear();
            }
            friendID = ID;
            FollowButtonValidation();
        }

        private void btn_follow_Click(object sender, EventArgs e)
        {
            dataIO.UserID = UserID;
            dataIO.FollowUser(SearchedUsername);
            FollowButtonValidation();
        }
    }
}
