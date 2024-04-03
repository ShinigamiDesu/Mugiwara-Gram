using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace MugiwaraGram
{

    internal class DataIO
    {
        public string UserID { get; set; }
        public string PostID { get; set; }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\amazi\\OneDrive\\Desktop\\C# coding\\Websites, Apps And Databases\\MugiwaraGram\\MugiwaraGram\\MugiwaraGram.mdf\";Integrated Security=True");

        public void AddUser(string Username, string Password, string Path, byte[] Value)
        {
            string Insert = "INSERT into tbl_Users(username, password, ImgPath, ImgPFPValue) VALUES(@user, @pass, @path, @value)";
            SqlCommand cmd = new SqlCommand(Insert, con);
            cmd.Parameters.AddWithValue("@user", Username);
            cmd.Parameters.AddWithValue("@pass", Password);
            cmd.Parameters.AddWithValue("@path", Path);
            cmd.Parameters.AddWithValue("@value", Value);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Signed Up!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public bool CheckUsername(string username)
        {
            string selecting = "SELECT username FROM tbl_Users where username = '"+ username +"'";
            SqlDataAdapter adapt = new SqlDataAdapter(selecting, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else 
            { 
                return false;
            }
            
        }

        public DataTable getPostsExplore() 
        {
            string select = "SELECT * FROM tbl_Posts JOIN tbl_Friends ON tbl_Friends.friendID = tbl_Posts.userID JOIN tbl_Users ON tbl_Users.UserID = tbl_Friends.friendID WHERE tbl_Friends.userID = '" + UserID+"' ORDER BY date_posted DESC";
            SqlDataAdapter adapt = new SqlDataAdapter(select, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            return dt;
        }

        public DataTable getOwnPosts(string ID)
        {
            string select = "SELECT * FROM tbl_Posts JOIN tbl_Users ON tbl_Posts.userID = tbl_Users.UserID  WHERE tbl_Posts.userID = '"+ID+"' ORDER BY date_posted DESC";
            SqlDataAdapter adapt = new SqlDataAdapter(select, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            return dt;
        }

        public void AddPost(string userID, string caption, string path, byte[] value) 
        {
            string insert = "INSERT INTO tbl_Posts(userID, caption, ImgPath, ImgValue) VALUES(@user,@cap,@path,@value)";
            SqlCommand cmd = new SqlCommand(insert, con);
            cmd.Parameters.AddWithValue("@user", userID);
            cmd.Parameters.AddWithValue("@cap", caption);
            cmd.Parameters.AddWithValue("@path", path);
            cmd.Parameters.AddWithValue("@value", value);
            try 
            { 
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Post Added.");
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable getProfileData(string ID) 
        {
            string select = "SELECT * FROM tbl_Users WHERE UserID = '" + ID + "'";
            SqlDataAdapter adapt = new SqlDataAdapter(select, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            return dt;
        }

        public DataTable getUserList(string username) {
            string selecting = "SELECT * FROM tbl_Users WHERE username LIKE '%" + username + "%'";
            SqlDataAdapter adapt = new SqlDataAdapter(selecting, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            return dt;
        }

        public void FollowUser(string username) 
        {
            // Get the Friend ID
            string selecting = "SELECT UserID FROM tbl_Users WHERE username = '" + username + "'";
            SqlDataAdapter adapt = new SqlDataAdapter(selecting, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            string FriendID = dt.Rows[0]["UserID"].ToString();
            int userID = int.Parse(UserID);
            int friendID = int.Parse(FriendID);
            ///////////////////////////////////////////////////////////////////////////////
            string inserting = "INSERT INTO tbl_Friends(userID, FriendID) VALUES (@user, @friend)";
            SqlCommand cmd = new SqlCommand(inserting, con);
            cmd.Parameters.AddWithValue("@user", userID);
            cmd.Parameters.AddWithValue("@friend", friendID);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("You Followed: " + username);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public DataTable GetFollowers(String ID) 
        {
            string selecting = "SELECT * FROM tbl_Friends JOIN tbl_Users ON tbl_Users.UserID = tbl_Friends.userID WHERE friendID = '" + ID + "'";
            SqlDataAdapter adapt = new SqlDataAdapter(selecting, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            return dt;
        }

        public DataTable GetFollowing(String ID)
        {
            string selecting = "SELECT * FROM tbl_Friends JOIN tbl_Users ON tbl_Users.UserID = tbl_Friends.friendID WHERE tbl_Friends.userID = '" + ID + "'";
            SqlDataAdapter adapt = new SqlDataAdapter(selecting, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            return dt;
        }

        public void DeleteFollowData(string ID, int choice) 
        {
            if(choice == 1) 
            {

                // Delete Follower
                string delete1 = "DELETE FROM tbl_Friends WHERE userID = '" + ID + "' AND friendID = '"+UserID+"'";
                SqlCommand cmd = new SqlCommand(delete1, con);
                try 
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch(Exception ex) 
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                // Delete Following
                string delete2 = "DELETE FROM tbl_Friends WHERE userID = '" + UserID + "' AND friendID = '" + ID + "'";
                SqlCommand cmd = new SqlCommand(delete2, con);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        public void AddComment(int userID, int postID, string comment)
        {
            string insert = "INSERT INTO tbl_Comments(PostID, UserID, comment) VALUES(@postid, @userid, @comm)";
            SqlCommand cmd = new SqlCommand(insert, con);
            cmd.Parameters.AddWithValue("@postid", postID);
            cmd.Parameters.AddWithValue("@userid", userID);
            cmd.Parameters.AddWithValue("@comm", comment);
            try 
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch(Exception e) 
            {
                MessageBox.Show(e.Message);
            }
        }

        public DataTable getComments() 
        {
            string Selecting = "SELECT * FROM tbl_Comments JOIN tbl_Users ON tbl_Users.UserID = tbl_Comments.UserID WHERE tbl_Comments.PostID = '" + PostID + "'";
            SqlDataAdapter adapt = new SqlDataAdapter(Selecting, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            return dt;
        }

        public DataTable getSearchedUserData(string username)
        {
            string Selecting = "SELECT * FROM tbl_Users WHERE username = '" + username + "'";
            SqlDataAdapter adapt = new SqlDataAdapter(Selecting, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            return dt;
        }

        public bool CheckFollowing(string userID, string friendID) 
        {
            string Selecting = "SELECT * FROM tbl_Friends WHERE userID = '" + UserID + "' AND friendID = '" + friendID + "'";
            SqlDataAdapter adapt = new SqlDataAdapter(Selecting, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            if(dt.Rows.Count > 0) 
            {
                return true;
            }
            else 
            {
                return false; 
            }

        }

    }
}
