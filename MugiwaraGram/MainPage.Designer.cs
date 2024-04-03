namespace MugiwaraGram
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pic_logout = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.pic_profile = new MugiwaraGram.PictureFormat();
            this.pic_Explore = new System.Windows.Forms.PictureBox();
            this.pic_search = new System.Windows.Forms.PictureBox();
            this.pic_addPost = new System.Windows.Forms.PictureBox();
            this.flowPanel_main = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logout)).BeginInit();
            this.panel_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_profile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Explore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_addPost)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pic_logout);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 44);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MugiwaraGram.Properties.Resources.Straw_Hat_Emblem;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pic_logout
            // 
            this.pic_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_logout.Image = global::MugiwaraGram.Properties.Resources.icons8_logout_48;
            this.pic_logout.Location = new System.Drawing.Point(346, 5);
            this.pic_logout.Margin = new System.Windows.Forms.Padding(2);
            this.pic_logout.Name = "pic_logout";
            this.pic_logout.Size = new System.Drawing.Size(31, 31);
            this.pic_logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_logout.TabIndex = 3;
            this.pic_logout.TabStop = false;
            this.pic_logout.Click += new System.EventHandler(this.pic_logout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Simple Stylist", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(121, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "MugiwaraGram";
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.Black;
            this.panel_menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_menu.Controls.Add(this.pic_profile);
            this.panel_menu.Controls.Add(this.pic_Explore);
            this.panel_menu.Controls.Add(this.pic_search);
            this.panel_menu.Controls.Add(this.pic_addPost);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_menu.Location = new System.Drawing.Point(0, 478);
            this.panel_menu.Margin = new System.Windows.Forms.Padding(2);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(383, 40);
            this.panel_menu.TabIndex = 1;
            // 
            // pic_profile
            // 
            this.pic_profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_profile.Image = global::MugiwaraGram.Properties.Resources.icons8_male_user_50__1_;
            this.pic_profile.Location = new System.Drawing.Point(341, 5);
            this.pic_profile.Name = "pic_profile";
            this.pic_profile.Size = new System.Drawing.Size(31, 31);
            this.pic_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_profile.TabIndex = 5;
            this.pic_profile.TabStop = false;
            this.pic_profile.Click += new System.EventHandler(this.pic_profile_Click);
            // 
            // pic_Explore
            // 
            this.pic_Explore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Explore.Image = global::MugiwaraGram.Properties.Resources.icons8_explore_50;
            this.pic_Explore.Location = new System.Drawing.Point(131, 5);
            this.pic_Explore.Margin = new System.Windows.Forms.Padding(2);
            this.pic_Explore.Name = "pic_Explore";
            this.pic_Explore.Size = new System.Drawing.Size(31, 31);
            this.pic_Explore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Explore.TabIndex = 4;
            this.pic_Explore.TabStop = false;
            this.pic_Explore.Click += new System.EventHandler(this.pic_Explore_Click);
            // 
            // pic_search
            // 
            this.pic_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_search.Image = global::MugiwaraGram.Properties.Resources.icons8_search_50;
            this.pic_search.Location = new System.Drawing.Point(10, 5);
            this.pic_search.Margin = new System.Windows.Forms.Padding(2);
            this.pic_search.Name = "pic_search";
            this.pic_search.Size = new System.Drawing.Size(31, 31);
            this.pic_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_search.TabIndex = 3;
            this.pic_search.TabStop = false;
            this.pic_search.Click += new System.EventHandler(this.pic_search_Click);
            // 
            // pic_addPost
            // 
            this.pic_addPost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_addPost.Image = global::MugiwaraGram.Properties.Resources.icons8_add_48;
            this.pic_addPost.Location = new System.Drawing.Point(216, 5);
            this.pic_addPost.Margin = new System.Windows.Forms.Padding(2);
            this.pic_addPost.Name = "pic_addPost";
            this.pic_addPost.Size = new System.Drawing.Size(31, 31);
            this.pic_addPost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_addPost.TabIndex = 0;
            this.pic_addPost.TabStop = false;
            this.pic_addPost.Click += new System.EventHandler(this.pic_addPost_Click);
            // 
            // flowPanel_main
            // 
            this.flowPanel_main.AutoScroll = true;
            this.flowPanel_main.BackColor = System.Drawing.Color.Black;
            this.flowPanel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanel_main.Location = new System.Drawing.Point(0, 44);
            this.flowPanel_main.Margin = new System.Windows.Forms.Padding(0);
            this.flowPanel_main.Name = "flowPanel_main";
            this.flowPanel_main.Size = new System.Drawing.Size(383, 434);
            this.flowPanel_main.TabIndex = 0;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 518);
            this.Controls.Add(this.flowPanel_main);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Explore";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logout)).EndInit();
            this.panel_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_profile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Explore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_addPost)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic_addPost;
        private System.Windows.Forms.PictureBox pic_logout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pic_search;
        private System.Windows.Forms.FlowLayoutPanel flowPanel_main;
        private System.Windows.Forms.PictureBox pic_Explore;
        private PictureFormat pic_profile;
    }
}

