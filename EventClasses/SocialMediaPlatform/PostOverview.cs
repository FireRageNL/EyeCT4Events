using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EventClasses;
using Message = EventClasses.Message;

namespace SocialMediaPlatform
{
    public partial class PostOverview : Form
    {
        private readonly EventClasses.Login _val;
        private readonly SocialControl _sc = new SocialControl();

        public PostOverview(EventClasses.Login val)
        {
            InitializeComponent();
            _val = val;
            List<Message> list = _sc.GetPosts();
            LbOverview.DataSource = list;
            LbOverview.DisplayMember = "Title";
        }

        private void LbOverview_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Message fetch = (Message)LbOverview.SelectedItem;
            Form1 form = new Form1(_val,fetch.MessageId);
            form.Show();
        }

        private void BtnAddPost_Click(object sender, EventArgs e)
        {
            NewPost post = new NewPost(_val);
            post.ShowDialog();
            List<Message> list = _sc.GetPosts();
            LbOverview.DataSource = list;
        }
    }
}
