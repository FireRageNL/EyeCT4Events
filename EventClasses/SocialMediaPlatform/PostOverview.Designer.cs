namespace SocialMediaPlatform
{
    partial class PostOverview
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
            this.LbOverview = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LbOverview
            // 
            this.LbOverview.FormattingEnabled = true;
            this.LbOverview.Location = new System.Drawing.Point(244, 128);
            this.LbOverview.Name = "LbOverview";
            this.LbOverview.Size = new System.Drawing.Size(279, 251);
            this.LbOverview.TabIndex = 0;
            this.LbOverview.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LbOverview_MouseDoubleClick);
            // 
            // PostOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 549);
            this.Controls.Add(this.LbOverview);
            this.Name = "PostOverview";
            this.Text = "PostOverview";
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LbOverview_MouseDoubleClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LbOverview;
    }
}