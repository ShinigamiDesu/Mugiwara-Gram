namespace MugiwaraGram
{
    partial class Comments
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
            this.flow_main = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_send = new MugiwaraGram.PictureFormat();
            this.txt_comment = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_send)).BeginInit();
            this.SuspendLayout();
            // 
            // flow_main
            // 
            this.flow_main.BackColor = System.Drawing.Color.Black;
            this.flow_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flow_main.Location = new System.Drawing.Point(0, 0);
            this.flow_main.Margin = new System.Windows.Forms.Padding(0);
            this.flow_main.Name = "flow_main";
            this.flow_main.Size = new System.Drawing.Size(366, 375);
            this.flow_main.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pic_send);
            this.panel1.Controls.Add(this.txt_comment);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 375);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 50);
            this.panel1.TabIndex = 1;
            // 
            // pic_send
            // 
            this.pic_send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_send.Image = global::MugiwaraGram.Properties.Resources.icons8_send_50;
            this.pic_send.Location = new System.Drawing.Point(322, 0);
            this.pic_send.Margin = new System.Windows.Forms.Padding(0);
            this.pic_send.Name = "pic_send";
            this.pic_send.Size = new System.Drawing.Size(44, 50);
            this.pic_send.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_send.TabIndex = 1;
            this.pic_send.TabStop = false;
            this.pic_send.Click += new System.EventHandler(this.pic_send_Click);
            // 
            // txt_comment
            // 
            this.txt_comment.BackColor = System.Drawing.Color.Black;
            this.txt_comment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_comment.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_comment.ForeColor = System.Drawing.Color.White;
            this.txt_comment.Location = new System.Drawing.Point(1, 0);
            this.txt_comment.Margin = new System.Windows.Forms.Padding(0);
            this.txt_comment.Multiline = true;
            this.txt_comment.Name = "txt_comment";
            this.txt_comment.Size = new System.Drawing.Size(321, 50);
            this.txt_comment.TabIndex = 0;
            this.txt_comment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_comment.TextChanged += new System.EventHandler(this.txt_comment_TextChanged);
            // 
            // Comments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flow_main);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Comments";
            this.Size = new System.Drawing.Size(366, 425);
            this.Load += new System.EventHandler(this.Comments_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_send)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flow_main;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_comment;
        private PictureFormat pic_send;
    }
}
