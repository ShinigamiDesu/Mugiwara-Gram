namespace MugiwaraGram
{
    partial class Profile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_pfp = new MugiwaraGram.PictureFormat();
            this.btn_edit = new System.Windows.Forms.Button();
            this.lbl_following = new System.Windows.Forms.Label();
            this.lbl_followers = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.profile_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pfp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pic_pfp);
            this.panel1.Controls.Add(this.btn_edit);
            this.panel1.Controls.Add(this.lbl_following);
            this.panel1.Controls.Add(this.lbl_followers);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_username);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 86);
            this.panel1.TabIndex = 0;
            // 
            // pic_pfp
            // 
            this.pic_pfp.Image = global::MugiwaraGram.Properties.Resources.wounded_Son_Goku_ultra_instinct;
            this.pic_pfp.Location = new System.Drawing.Point(6, 7);
            this.pic_pfp.Name = "pic_pfp";
            this.pic_pfp.Size = new System.Drawing.Size(53, 52);
            this.pic_pfp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_pfp.TabIndex = 13;
            this.pic_pfp.TabStop = false;
            // 
            // btn_edit
            // 
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(159, 56);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(105, 22);
            this.btn_edit.TabIndex = 12;
            this.btn_edit.Text = "Edit Profile";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // lbl_following
            // 
            this.lbl_following.AutoSize = true;
            this.lbl_following.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_following.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_following.ForeColor = System.Drawing.Color.White;
            this.lbl_following.Location = new System.Drawing.Point(253, 26);
            this.lbl_following.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_following.Name = "lbl_following";
            this.lbl_following.Size = new System.Drawing.Size(18, 19);
            this.lbl_following.TabIndex = 6;
            this.lbl_following.Text = "5";
            this.lbl_following.Click += new System.EventHandler(this.lbl_following_Click);
            this.lbl_following.MouseEnter += new System.EventHandler(this.lbl_following_MouseEnter);
            this.lbl_following.MouseLeave += new System.EventHandler(this.lbl_following_MouseLeave);
            // 
            // lbl_followers
            // 
            this.lbl_followers.AutoSize = true;
            this.lbl_followers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_followers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_followers.ForeColor = System.Drawing.Color.White;
            this.lbl_followers.Location = new System.Drawing.Point(155, 26);
            this.lbl_followers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_followers.Name = "lbl_followers";
            this.lbl_followers.Size = new System.Drawing.Size(27, 19);
            this.lbl_followers.TabIndex = 5;
            this.lbl_followers.Text = "32";
            this.lbl_followers.Click += new System.EventHandler(this.lbl_followers_Click);
            this.lbl_followers.MouseEnter += new System.EventHandler(this.lbl_followers_MouseEnter);
            this.lbl_followers.MouseLeave += new System.EventHandler(this.lbl_followers_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(223, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Following";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(127, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Followers";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.White;
            this.lbl_username.Location = new System.Drawing.Point(2, 60);
            this.lbl_username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(84, 21);
            this.lbl_username.TabIndex = 2;
            this.lbl_username.Text = "Son Goku";
            // 
            // profile_panel
            // 
            this.profile_panel.AutoScroll = true;
            this.profile_panel.BackColor = System.Drawing.Color.Black;
            this.profile_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profile_panel.Location = new System.Drawing.Point(0, 86);
            this.profile_panel.Margin = new System.Windows.Forms.Padding(0);
            this.profile_panel.Name = "profile_panel";
            this.profile_panel.Size = new System.Drawing.Size(383, 346);
            this.profile_panel.TabIndex = 1;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.profile_panel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Profile";
            this.Size = new System.Drawing.Size(383, 432);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pfp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_followers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_following;
        private System.Windows.Forms.FlowLayoutPanel profile_panel;
        private System.Windows.Forms.Button btn_edit;
        private PictureFormat pic_pfp;
    }
}
