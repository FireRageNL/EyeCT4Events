using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventClasses;

namespace SocialMediaPlatform
{
    public partial class PostOverview : Form
    {
        private EventClasses.Login val;
        private EventClasses.SocialControl sc = new SocialControl();

        public PostOverview()
        {
            InitializeComponent();
        }

        public PostOverview(EventClasses.Login val)
        {
            InitializeComponent();
            this.val = val;
            List<string> list = new List<string>();
            list = sc.GetPosts();
            LbOverview.DataSource = list;
        }

        private void LbOverview_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int postid = Convert.ToInt32(LbOverview.SelectedItem.ToString());
            Form1 form = new Form1(val,postid);
            form.Show();
        }
    }
}
