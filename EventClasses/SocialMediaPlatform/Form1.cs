using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EventClasses;
using Message = EventClasses.Message;

namespace SocialMediaPlatform
{
    public partial class Form1 : Form
    {
        private EventClasses.Login val;
        private EventClasses.SocialControl sc = new SocialControl();
        private Media parent;

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(EventClasses.Login val, int postid)
        {
            InitializeComponent();
            this.val = val;
            List<Message> list = sc.GetContents(postid);
            parent = (Media)list[0];
            LblNaam.Text = parent.UserMessage.Name;
            LblDatum.Text = "Vandaag";
            List<string> cont = new List<string>();
            foreach (Message msg in list)
            {
                if (msg.ParentMessage != null)
                {
                    string ms = msg.UserMessage.Name + ": " + msg.Content;
                    cont.Add(ms);
                }
            }
            listBox1.DataSource = cont;
            LblPost.Text = parent.Content;
            int reacties = cont.Count;
            LblReacties.Text = reacties.ToString();
            PbMedia.SizeMode = PictureBoxSizeMode.StretchImage;
            PbMedia.ImageLocation = parent.Location;
        }

        private void BtnPlaats_Click(object sender, EventArgs e)
        {
            string message = RtbReactie.Text;
            sc.PostReply(message, parent,val.User.UserID);
            List<Message> list = sc.GetContents(parent.MessageID);
            List<string> cont = new List<string>();
            foreach (Message msg in list)
            {
                if (msg.ParentMessage != null)
                {
                    string ms = msg.UserMessage.Name + ": " + msg.Content;
                    cont.Add(ms);
                }
            }
            listBox1.DataSource = cont;
            int reacties = cont.Count;
            LblReacties.Text = reacties.ToString();
        }

        private void BtnDownload_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                PbMedia.Image.Save(saveFileDialog1.FileName);
            }
        }
    }
}
