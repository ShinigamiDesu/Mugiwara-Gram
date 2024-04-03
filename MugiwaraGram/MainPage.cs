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
    public partial class MainPage : Form
    {
        public int choice {  get; set; } 
        DataIO dataIO = new DataIO();
        public string UserID { get; set; }
        public string Username { get; set; }
        public string PostID { get; set; }
        public string SearchedUsername { get; set; }

        public MainPage()
        {
            InitializeComponent();
        }
        private void MainPage_Load(object sender, EventArgs e)
        {
            GenerateExplore();
        }

        private void pic_logout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void DisplayFollowData() {
            // Display the current Followers
            FollowData follow = new FollowData();
            follow.UserID = UserID;
            if(choice == 1) 
            { 
                follow.choice = choice;
                follow.GenerateFollowersGrid(); 
            }
            else 
            {
                follow.choice = choice;
                follow.GenerateFollowingGrid(); 
            }
            flowPanel_main.Controls.Clear();
            flowPanel_main.Controls.Add(follow);
        }

        public void GenerateExplore() 
        {
            //// This Function will Generate The Posts of all Users
            dataIO.UserID = UserID;
            /////////////////////////
            /// Get The Current User Profile Data
            DataTable dt1 = dataIO.getProfileData(UserID);
            MemoryStream pfp = new MemoryStream((byte[])dt1.Rows[0]["ImgPFPValue"]);
            pic_profile.Image = new Bitmap(pfp);
            ///////////////////////////////////////////////////////////////////////
            flowPanel_main.Controls.Clear();
            DataTable dt = dataIO.getPostsExplore();
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    Post[] listItems = new Post[dt.Rows.Count];
                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            listItems[i] = new Post(this);
                            // Get Post ID
                            listItems[i].ID = row["PostID"].ToString();
                            // Add Profile Picture OF the Poster
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
                            // Add Time Posted
                            listItems[i].Time = row["date_posted"].ToString();
                            flowPanel_main.Controls.Add(listItems[i]);
                        }
                    }
                }
                else
                {
                    flowPanel_main.Controls.Clear();
                }
            }
            else
            {
                flowPanel_main.Controls.Clear();
            }
        }

        private void pic_addPost_Click(object sender, EventArgs e)
        {
            AddPost add = new AddPost();    
            add.UserID = UserID;
            add.ShowDialog();
        }

        private void pic_profile_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(this);
            dataIO.UserID = UserID;
            profile.UserID = UserID;
            // Getting Follower and Following Data
            DataTable followers = dataIO.GetFollowers(UserID);
            DataTable following = dataIO.GetFollowing(UserID);
            profile.Followers = followers.Rows.Count.ToString();
            profile.Following = following.Rows.Count.ToString();
            // Getting Profile Data
            DataTable dt = dataIO.getProfileData(UserID);
            // Loading User Posts
            profile.Profile_Load();
            // Adding PFP
            MemoryStream ms = new MemoryStream((byte[])dt.Rows[0]["ImgPFPValue"]);
            profile.Pfp = new Bitmap(ms);
            // Adding Username
            profile.Username = dt.Rows[0]["username"].ToString();
            flowPanel_main.Controls.Clear();
            flowPanel_main.Controls.Add(profile);
        }

        private void pic_Explore_Click(object sender, EventArgs e)
        {
            GenerateExplore();
        }

        private void pic_search_Click(object sender, EventArgs e)
        {
            SearchUser Search = new SearchUser(this);
            Search.UserID = UserID;
            flowPanel_main.Controls.Clear();
            flowPanel_main.Controls.Add(Search);
        }

        public void GenerateEditProfile()
        {
            flowPanel_main.Controls.Clear();
            EditProfile edit = new EditProfile();
            edit.UserID = UserID;
            dataIO.UserID = UserID;
            //Retrieving Profile DataTable
            DataTable dt = dataIO.getProfileData(UserID);
            //Adding PFP
            MemoryStream ms = new MemoryStream((byte[])dt.Rows[0]["ImgPFPValue"]);
            edit.Pfp = new Bitmap(ms);
            //Adding Username
            edit.Username = dt.Rows[0]["username"].ToString();
            //Adding Password
            edit.Password = dt.Rows[0]["password"].ToString();
            flowPanel_main.Controls.Add(edit);
        }

        public void GenerateComments() 
        {
            Comments comment = new Comments(this);
            comment.UserID = UserID;
            dataIO.UserID = UserID;
            dataIO.PostID = PostID;
            comment.PostID = PostID;
            comment.LoadComments();
            flowPanel_main.Controls.Clear();
            flowPanel_main.Controls.Add(comment);
        }

        public void ViewProfile(String ID) 
        {
            SearchProfile SearchProfile = new SearchProfile(this);
            dataIO.UserID = UserID;
            SearchProfile.UserID = UserID;
            SearchProfile.UsernameLogged = Username;
            SearchProfile.SearchedUsername = SearchedUsername;
            // Getting Follower and Following Data
            DataTable followers = dataIO.GetFollowers(ID);
            DataTable following = dataIO.GetFollowing(ID);
            SearchProfile.Followers = followers.Rows.Count.ToString();
            SearchProfile.Following = following.Rows.Count.ToString();
            // Getting Profile Data
            DataTable dt = dataIO.getProfileData(ID);
            // Loading User Posts
            SearchProfile.Profile_Load(ID);
            // Adding PFP
            MemoryStream ms = new MemoryStream((byte[])dt.Rows[0]["ImgPFPValue"]);
            SearchProfile.Pfp = new Bitmap(ms);
            // Adding Username
            SearchProfile.Username = dt.Rows[0]["username"].ToString();
            flowPanel_main.Controls.Clear();
            flowPanel_main.Controls.Add(SearchProfile);
        }
    }
}
