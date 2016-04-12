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
    public partial class NewPost : Form
    {
        private EventClasses.Login val;
        private EventClasses.SocialControl sc = new SocialControl();
        public NewPost(EventClasses.Login val)
        {
            this.val = val;
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string message = richTextBox1.Text;
            string url = null;
            string mtype = comboBox1.Text;
            if (textBox1.Text != "")
            {
                url = textBox1.Text;
            }
            if (richTextBox1.Text != "")
            {
                sc.NewPost(message, url, mtype, val);
            }
            this.Dispose();
        }
    }
}
