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
    }
}
