namespace MugiwaraGram
{
    partial class Post
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pic_comments = new System.Windows.Forms.PictureBox();
            this.lbl_comments = new System.Windows.Forms.Label();
            this.pic_original = new System.Windows.Forms.PictureBox();
            this.pic_comm2 = new System.Windows.Forms.PictureBox();
            this.lbl_usercap = new System.Windows.Forms.Label();
            this.lbl_caption = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pic_user = new MugiwaraGram.PictureFormat();
            this.lbl_username = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_post = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_comments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_comm2)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_user)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_post)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanel1.Controls.Add(this.pic_comments);
            this.flowLayoutPanel1.Controls.Add(this.lbl_comments);
            this.flowLayoutPanel1.Controls.Add(this.pic_original);
            this.flowLayoutPanel1.Controls.Add(this.pic_comm2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 400);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(366, 32);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // pic_comments
            // 
            this.pic_comments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_comments.Image = global::MugiwaraGram.Properties.Resources.icons8_comment_50;
            this.pic_comments.Location = new System.Drawing.Point(3, 3);
            this.pic_comments.Name = "pic_comments";
            this.pic_comments.Size = new System.Drawing.Size(24, 26);
            this.pic_comments.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_comments.TabIndex = 0;
            this.pic_comments.TabStop = false;
            // 
            // lbl_comments
            // 
            this.lbl_comments.AutoSize = true;
            this.lbl_comments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_comments.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_comments.ForeColor = System.Drawing.Color.Gray;
            this.lbl_comments.Location = new System.Drawing.Point(30, 5);
            this.lbl_comments.Margin = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.lbl_comments.Name = "lbl_comments";
            this.lbl_comments.Size = new System.Drawing.Size(138, 21);
            this.lbl_comments.TabIndex = 2;
            this.lbl_comments.Text = "View Comments";
            this.lbl_comments.Click += new System.EventHandler(this.lbl_comments_Click);
            this.lbl_comments.MouseEnter += new System.EventHandler(this.lbl_comments_MouseEnter);
            this.lbl_comments.MouseLeave += new System.EventHandler(this.lbl_comments_MouseLeave);
            // 
            // pic_original
            // 
            this.pic_original.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_original.Image = global::MugiwaraGram.Properties.Resources.icons8_comment_50;
            this.pic_original.Location = new System.Drawing.Point(176, 3);
            this.pic_original.Name = "pic_original";
            this.pic_original.Size = new System.Drawing.Size(24, 26);
            this.pic_original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_original.TabIndex = 3;
            this.pic_original.TabStop = false;
            this.pic_original.Visible = false;
            // 
            // pic_comm2
            // 
            this.pic_comm2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_comm2.Image = global::MugiwaraGram.Properties.Resources._2;
            this.pic_comm2.Location = new System.Drawing.Point(206, 3);
            this.pic_comm2.Name = "pic_comm2";
            this.pic_comm2.Size = new System.Drawing.Size(24, 26);
            this.pic_comm2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_comm2.TabIndex = 4;
            this.pic_comm2.TabStop = false;
            this.pic_comm2.Visible = false;
            // 
            // lbl_usercap
            // 
            this.lbl_usercap.AutoSize = true;
            this.lbl_usercap.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usercap.ForeColor = System.Drawing.Color.White;
            this.lbl_usercap.Location = new System.Drawing.Point(0, 10);
            this.lbl_usercap.Margin = new System.Windows.Forms.Padding(0, 10, 3, 0);
            this.lbl_usercap.Name = "lbl_usercap";
            this.lbl_usercap.Size = new System.Drawing.Size(58, 19);
            this.lbl_usercap.TabIndex = 0;
            this.lbl_usercap.Text = "label1";
            // 
            // lbl_caption
            // 
            this.lbl_caption.AutoSize = true;
            this.lbl_caption.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_caption.ForeColor = System.Drawing.Color.White;
            this.lbl_caption.Location = new System.Drawing.Point(61, 9);
            this.lbl_caption.Margin = new System.Windows.Forms.Padding(0, 9, 5, 0);
            this.lbl_caption.Name = "lbl_caption";
            this.lbl_caption.Size = new System.Drawing.Size(57, 21);
            this.lbl_caption.TabIndex = 1;
            this.lbl_caption.Text = "label2";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanel2.Controls.Add(this.pic_user);
            this.flowLayoutPanel2.Controls.Add(this.lbl_username);
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.lbl_time);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(366, 59);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // pic_user
            // 
            this.pic_user.Image = global::MugiwaraGram.Properties.Resources.wounded_Son_Goku_ultra_instinct;
            this.pic_user.Location = new System.Drawing.Point(5, 5);
            this.pic_user.Margin = new System.Windows.Forms.Padding(5, 5, 3, 3);
            this.pic_user.Name = "pic_user";
            this.pic_user.Size = new System.Drawing.Size(50, 47);
            this.pic_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_user.TabIndex = 4;
            this.pic_user.TabStop = false;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.White;
            this.lbl_username.Location = new System.Drawing.Point(61, 20);
            this.lbl_username.Margin = new System.Windows.Forms.Padding(3, 20, 0, 0);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(99, 22);
            this.lbl_username.TabIndex = 1;
            this.lbl_username.Text = "Son Goku";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(160, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "•";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.ForeColor = System.Drawing.Color.White;
            this.lbl_time.Location = new System.Drawing.Point(182, 23);
            this.lbl_time.Margin = new System.Windows.Forms.Padding(0, 23, 3, 0);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(37, 17);
            this.lbl_time.TabIndex = 3;
            this.lbl_time.Text = "Time";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pic_post);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 311);
            this.panel1.TabIndex = 6;
            // 
            // pic_post
            // 
            this.pic_post.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_post.Image = global::MugiwaraGram.Properties.Resources._0fa066b399c13ddc47bdacc39f911436fe7230a4_00;
            this.pic_post.Location = new System.Drawing.Point(0, 0);
            this.pic_post.Name = "pic_post";
            this.pic_post.Size = new System.Drawing.Size(366, 311);
            this.pic_post.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_post.TabIndex = 0;
            this.pic_post.TabStop = false;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanel3.Controls.Add(this.lbl_usercap);
            this.flowLayoutPanel3.Controls.Add(this.lbl_caption);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 370);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(366, 30);
            this.flowLayoutPanel3.TabIndex = 7;
            // 
            // Post
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Post";
            this.Size = new System.Drawing.Size(366, 432);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_comments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_comm2)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_user)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_post)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lbl_usercap;
        private System.Windows.Forms.Label lbl_caption;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_time;
        private PictureFormat pic_user;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic_post;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.PictureBox pic_comments;
        private System.Windows.Forms.Label lbl_comments;
        private System.Windows.Forms.PictureBox pic_original;
        private System.Windows.Forms.PictureBox pic_comm2;
    }
}
