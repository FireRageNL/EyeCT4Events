using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EventClasses;

namespace SocialMediaPlatform
{
    public partial class PostOverview : Form
    {
        private readonly EventClasses.Login _val;
        private readonly SocialControl _sc = new SocialControl();

        public PostOverview()
        {
            InitializeComponent();
        }

        public PostOverview(EventClasses.Login val)
        {
            InitializeComponent();
            _val = val;
            List<string> list = _sc.GetPosts();
            LbOverview.DataSource = list;
        }

        private void LbOverview_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int postid = Convert.ToInt32(LbOverview.SelectedItem.ToString());
            Form1 form = new Form1(_val,postid);
            form.Show();
        }

        private void BtnAddPost_Click(object sender, EventArgs e)
        {
            NewPost post = new NewPost(_val);
            post.ShowDialog();
            List<string> list = _sc.GetPosts();
            LbOverview.DataSource = list;
        }
    }
}
