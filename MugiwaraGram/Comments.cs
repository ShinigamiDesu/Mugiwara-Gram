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
    public partial class Comments : UserControl
    {
        public Comments(MainPage mainPage)
        {
            InitializeComponent();
            this.mainPage = mainPage;
        }

        DataIO dataIO = new DataIO();
        private MainPage mainPage;
        public string UserID { get; set; }
        public string PostID { get; set; }
        private void Comments_Load(object sender, EventArgs e)
        {
            if (txt_comment.Text == "")
            {
                txt_comment.Width = 366;
                pic_send.Visible = false;
            }
            else
            {
                txt_comment.Width = 321;
                pic_send.Visible = true;
            }
        }

        private void txt_comment_TextChanged(object sender, EventArgs e)
        {
            if(txt_comment.Text == "") 
            {
                txt_comment.Width = 366;
                pic_send.Visible = false;
            }
            else 
            {
                txt_comment.Width = 321;
                pic_send.Visible = true;
            }
        }

        public void LoadComments()
        {
            dataIO.UserID = UserID;
            dataIO.PostID = PostID;
            DataTable dt = dataIO.getComments();
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    flow_main.Controls.Clear();
                    CommentDesign[] listItems = new CommentDesign[dt.Rows.Count];
                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            listItems[i] = new CommentDesign();
                            // Add Profile Picture
                            MemoryStream ms = new MemoryStream((byte[])row["ImgPFPValue"]);
                            listItems[i].Pfp = new Bitmap(ms);
                            // Add Username
                            listItems[i].Username = row["username"].ToString();
                            // Add Comment
                            listItems[i].Comment = row["comment"].ToString();
                            flow_main.Controls.Add(listItems[i]);
                        }
                    }
                }
                else
                {
                    flow_main.Controls.Clear();
                }
            }
        }

        private void pic_send_Click(object sender, EventArgs e)
        {
            dataIO.UserID = UserID;
            string Comment = txt_comment.Text;
            int ID = int.Parse(PostID);
            int userID = int.Parse(UserID);
            dataIO.AddComment(userID, ID, Comment);
            txt_comment.Text = "";
            
        }
    }
}
