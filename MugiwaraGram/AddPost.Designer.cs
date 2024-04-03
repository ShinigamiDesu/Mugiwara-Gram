namespace MugiwaraGram
{
    partial class AddPost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPost));
            this.pic_post = new System.Windows.Forms.PictureBox();
            this.btn_upload = new System.Windows.Forms.Button();
            this.btn_Post = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_caption = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_post)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_post
            // 
            this.pic_post.BackColor = System.Drawing.Color.White;
            this.pic_post.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_post.Location = new System.Drawing.Point(51, 10);
            this.pic_post.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pic_post.Name = "pic_post";
            this.pic_post.Size = new System.Drawing.Size(210, 203);
            this.pic_post.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_post.TabIndex = 0;
            this.pic_post.TabStop = false;
            // 
            // btn_upload
            // 
            this.btn_upload.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_upload.ForeColor = System.Drawing.Color.White;
            this.btn_upload.Location = new System.Drawing.Point(51, 217);
            this.btn_upload.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(209, 27);
            this.btn_upload.TabIndex = 8;
            this.btn_upload.Text = "Upload";
            this.btn_upload.UseVisualStyleBackColor = true;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // btn_Post
            // 
            this.btn_Post.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Post.ForeColor = System.Drawing.Color.Black;
            this.btn_Post.Location = new System.Drawing.Point(67, 300);
            this.btn_Post.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Post.Name = "btn_Post";
            this.btn_Post.Size = new System.Drawing.Size(148, 27);
            this.btn_Post.TabIndex = 9;
            this.btn_Post.Text = "Post";
            this.btn_Post.UseVisualStyleBackColor = true;
            this.btn_Post.Click += new System.EventHandler(this.btn_Post_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 264);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Caption:";
            // 
            // txt_caption
            // 
            this.txt_caption.Location = new System.Drawing.Point(67, 264);
            this.txt_caption.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_caption.MaxLength = 50;
            this.txt_caption.Multiline = true;
            this.txt_caption.Name = "txt_caption";
            this.txt_caption.Size = new System.Drawing.Size(240, 32);
            this.txt_caption.TabIndex = 11;
            // 
            // btn_back
            // 
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(241, 337);
            this.btn_back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(64, 19);
            this.btn_back.TabIndex = 12;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // AddPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 366);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.txt_caption);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Post);
            this.Controls.Add(this.btn_upload);
            this.Controls.Add(this.pic_post);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddPost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPost";
            this.Load += new System.EventHandler(this.AddPost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_post)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_post;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.Button btn_Post;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_caption;
        private System.Windows.Forms.Button btn_back;
    }
}