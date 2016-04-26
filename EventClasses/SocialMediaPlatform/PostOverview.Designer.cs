using System.ComponentModel;
using System.Windows.Forms;

namespace SocialMediaPlatform
{
    partial class PostOverview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.LbOverview = new System.Windows.Forms.ListBox();
            this.BtnAddPost = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbOverview
            // 
            this.LbOverview.FormattingEnabled = true;
            this.LbOverview.Location = new System.Drawing.Point(12, 12);
            this.LbOverview.Name = "LbOverview";
            this.LbOverview.Size = new System.Drawing.Size(279, 524);
            this.LbOverview.TabIndex = 0;
            this.LbOverview.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LbOverview_MouseDoubleClick);
            // 
            // BtnAddPost
            // 
            this.BtnAddPost.Location = new System.Drawing.Point(297, 12);
            this.BtnAddPost.Name = "BtnAddPost";
            this.BtnAddPost.Size = new System.Drawing.Size(86, 57);
            this.BtnAddPost.TabIndex = 1;
            this.BtnAddPost.Text = "Nieuwe post maken";
            this.BtnAddPost.UseVisualStyleBackColor = true;
            this.BtnAddPost.Click += new System.EventHandler(this.BtnAddPost_Click);
            // 
            // PostOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 549);
            this.Controls.Add(this.BtnAddPost);
            this.Controls.Add(this.LbOverview);
            this.Name = "PostOverview";
            this.Text = "PostOverview";
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LbOverview_MouseDoubleClick);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox LbOverview;
        private Button BtnAddPost;
    }
}