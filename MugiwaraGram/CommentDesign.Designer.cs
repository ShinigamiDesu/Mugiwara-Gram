namespace MugiwaraGram
{
    partial class CommentDesign
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
            this.flow_commentDesign = new System.Windows.Forms.FlowLayoutPanel();
            this.pic_pfp = new MugiwaraGram.PictureFormat();
            this.lbl_username = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_comment = new System.Windows.Forms.Label();
            this.flow_commentDesign.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pfp)).BeginInit();
            this.SuspendLayout();
            // 
            // flow_commentDesign
            // 
            this.flow_commentDesign.Controls.Add(this.pic_pfp);
            this.flow_commentDesign.Controls.Add(this.lbl_username);
            this.flow_commentDesign.Controls.Add(this.label1);
            this.flow_commentDesign.Controls.Add(this.lbl_comment);
            this.flow_commentDesign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flow_commentDesign.Location = new System.Drawing.Point(0, 0);
            this.flow_commentDesign.Margin = new System.Windows.Forms.Padding(0);
            this.flow_commentDesign.Name = "flow_commentDesign";
            this.flow_commentDesign.Size = new System.Drawing.Size(366, 38);
            this.flow_commentDesign.TabIndex = 0;
            // 
            // pic_pfp
            // 
            this.pic_pfp.Image = global::MugiwaraGram.Properties.Resources.wounded_Son_Goku_ultra_instinct;
            this.pic_pfp.Location = new System.Drawing.Point(3, 3);
            this.pic_pfp.Name = "pic_pfp";
            this.pic_pfp.Size = new System.Drawing.Size(34, 32);
            this.pic_pfp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_pfp.TabIndex = 0;
            this.pic_pfp.TabStop = false;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.White;
            this.lbl_username.Location = new System.Drawing.Point(40, 11);
            this.lbl_username.Margin = new System.Windows.Forms.Padding(0, 11, 0, 0);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(64, 17);
            this.lbl_username.TabIndex = 1;
            this.lbl_username.Text = "Son Goku";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(104, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 11, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = ":";
            // 
            // lbl_comment
            // 
            this.lbl_comment.AutoSize = true;
            this.lbl_comment.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_comment.ForeColor = System.Drawing.Color.White;
            this.lbl_comment.Location = new System.Drawing.Point(115, 11);
            this.lbl_comment.Margin = new System.Windows.Forms.Padding(0, 11, 0, 0);
            this.lbl_comment.Name = "lbl_comment";
            this.lbl_comment.Size = new System.Drawing.Size(71, 17);
            this.lbl_comment.TabIndex = 3;
            this.lbl_comment.Text = "Das Crazy!!";
            // 
            // CommentDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.flow_commentDesign);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CommentDesign";
            this.Size = new System.Drawing.Size(366, 38);
            this.flow_commentDesign.ResumeLayout(false);
            this.flow_commentDesign.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pfp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flow_commentDesign;
        private PictureFormat pic_pfp;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_comment;
    }
}
