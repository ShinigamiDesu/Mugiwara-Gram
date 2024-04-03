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
    public partial class FollowData : UserControl
    {
       
        public int choice {  get; set; }
        public string UserID { get; set; }
        DataIO dataIO = new DataIO();
        public FollowData()
        {
            InitializeComponent();
        }

        public void GenerateFollowersGrid() 
        { 
            dataIO.UserID = UserID;
            DataTable dt = dataIO.GetFollowers(UserID);
            
            if (dt != null)
            {
                grid_Data.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {

                    int n = grid_Data.Rows.Add();
                    grid_Data.Rows[n].Cells[0].Value = row["userID"].ToString();
                    MemoryStream ms = new MemoryStream((byte[])row["ImgPFPValue"]);
                    grid_Data.Rows[n].Cells[1].Value = new Bitmap(ms);
                    grid_Data.Rows[n].Cells[2].Value = row["username"].ToString();
                }
            }
        }

        public void GenerateFollowingGrid()
        {
            dataIO.UserID = UserID;
            DataTable dt = dataIO.GetFollowing(UserID);

            if (dt != null)
            {
                grid_Data.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {

                    int n = grid_Data.Rows.Add();
                    grid_Data.Rows[n].Cells[0].Value = row["friendID"].ToString();
                    MemoryStream ms = new MemoryStream((byte[])row["ImgPFPValue"]);
                    grid_Data.Rows[n].Cells[1].Value = new Bitmap(ms);
                    grid_Data.Rows[n].Cells[2].Value = row["username"].ToString();
                }
            }
        }
        private void Followers_Load(object sender, EventArgs e)
        {
            if (choice == 1) 
            {
                GenerateFollowersGrid();
            }
            else 
            {
                GenerateFollowingGrid();
            }
            
        }

        private void grid_Data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataIO.UserID = UserID;
            if (grid_Data.Columns[e.ColumnIndex].Name == "Remove") 
            {
                if (choice == 1)
                {
                    string ID = grid_Data.SelectedCells[0].Value.ToString();
                    dataIO.DeleteFollowData(ID, choice);
                    GenerateFollowersGrid();
                }
                else
                {
                    string ID = grid_Data.SelectedCells[0].Value.ToString();
                    dataIO.DeleteFollowData(ID, choice);
                    GenerateFollowingGrid();
                }

            }
        }
    }
}
