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
using Message = EventClasses.Message;

namespace SocialMediaPlatform
{
    public partial class Form1 : Form
    {
        private EventClasses.Login val;
        private EventClasses.SocialControl sc = new SocialControl();

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(EventClasses.Login val, int postid)
        {
            InitializeComponent();
            this.val = val;
            List<Message> list = sc.GetContents(postid);
            Message parent = list[0];
            LblNaam.Text = parent.UserMessage.Name;
            LblDatum.Text = "Vandaag";
            List<string> cont = new List<string>();
            foreach (Message msg in list)
            {
                cont.Add(msg.Content);
            }
            listBox1.DataSource = cont;
        }
    }
}
