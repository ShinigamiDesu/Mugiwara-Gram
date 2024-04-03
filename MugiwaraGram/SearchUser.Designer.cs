namespace MugiwaraGram
{
    partial class SearchUser
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
            this.txt_users = new System.Windows.Forms.TextBox();
            this.list_users = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_viewprofile = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_users);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 58);
            this.panel1.TabIndex = 0;
            // 
            // txt_users
            // 
            this.txt_users.BackColor = System.Drawing.Color.Black;
            this.txt_users.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_users.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_users.ForeColor = System.Drawing.Color.White;
            this.txt_users.Location = new System.Drawing.Point(0, 0);
            this.txt_users.Margin = new System.Windows.Forms.Padding(0);
            this.txt_users.Multiline = true;
            this.txt_users.Name = "txt_users";
            this.txt_users.Size = new System.Drawing.Size(383, 58);
            this.txt_users.TabIndex = 0;
            this.txt_users.TextChanged += new System.EventHandler(this.txt_users_TextChanged);
            // 
            // list_users
            // 
            this.list_users.BackColor = System.Drawing.Color.Black;
            this.list_users.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.list_users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_users.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_users.ForeColor = System.Drawing.Color.White;
            this.list_users.FormattingEnabled = true;
            this.list_users.ItemHeight = 21;
            this.list_users.Location = new System.Drawing.Point(0, 58);
            this.list_users.Margin = new System.Windows.Forms.Padding(0);
            this.list_users.Name = "list_users";
            this.list_users.Size = new System.Drawing.Size(383, 374);
            this.list_users.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_viewprofile);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 390);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(383, 42);
            this.panel2.TabIndex = 2;
            // 
            // btn_viewprofile
            // 
            this.btn_viewprofile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewprofile.ForeColor = System.Drawing.Color.White;
            this.btn_viewprofile.Location = new System.Drawing.Point(134, 11);
            this.btn_viewprofile.Margin = new System.Windows.Forms.Padding(2);
            this.btn_viewprofile.Name = "btn_viewprofile";
            this.btn_viewprofile.Size = new System.Drawing.Size(103, 22);
            this.btn_viewprofile.TabIndex = 12;
            this.btn_viewprofile.Text = "View Profile";
            this.btn_viewprofile.UseVisualStyleBackColor = true;
            this.btn_viewprofile.Click += new System.EventHandler(this.btn_viewprofile_Click);
            // 
            // Follow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.list_users);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Follow";
            this.Size = new System.Drawing.Size(383, 432);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_users;
        private System.Windows.Forms.ListBox list_users;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_viewprofile;
    }
}
