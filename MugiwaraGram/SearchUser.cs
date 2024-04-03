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

    public partial class SearchUser : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\amazi\\OneDrive\\Desktop\\C# coding\\Websites, Apps And Databases\\MugiwaraGram\\MugiwaraGram\\MugiwaraGram.mdf\";Integrated Security=True");
        private MainPage mainPage;
        public string UserID { get; set; }

        DataIO dataIO = new DataIO();
        public SearchUser(MainPage mainPage)
        {
            InitializeComponent();
            this.mainPage = mainPage;
        }



        private void txt_users_TextChanged(object sender, EventArgs e)
        {
            if (txt_users.Text == "")
            {
                list_users.Items.Clear();
            }
            else 
            {
                DataTable dt = dataIO.getUserList(txt_users.Text);
                list_users.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    list_users.Items.Add(dt.Rows[i]["username"].ToString());
                }
            }

        }

        private void btn_viewprofile_Click(object sender, EventArgs e)
        {
            if (list_users.SelectedIndex == -1)
            {
                MessageBox.Show("Select A User.");
            }
            else 
            {
                string username = list_users.SelectedItem.ToString();
                DataTable dt = dataIO.getSearchedUserData(username);
                string userID = dt.Rows[0]["UserID"].ToString();
                mainPage.UserID = UserID;
                mainPage.SearchedUsername = username;
                mainPage.ViewProfile(userID);
            }

        }
    }
}
