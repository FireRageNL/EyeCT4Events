using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using EventClasses;
using Message = EventClasses.Message;

namespace SocialMediaPlatform
{
    public partial class Form1 : Form
    {
        private readonly EventClasses.Login _val;
        private readonly SocialControl _sc = new SocialControl();
        private readonly Media _parent;

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(EventClasses.Login val, int postid)
        {
            InitializeComponent();
            _val = val;
            List<Message> list = _sc.GetContents(postid);
            _parent = (Media)list[0];
            LblNaam.Text = _parent.UserMessage.Name;
            LblDatum.Text = "Vandaag";
            List<string> cont = (from msg in list where msg.ParentMessage != null select msg.UserMessage.Name + ": " + msg.Content).ToList();
            listBox1.DataSource = cont;
            LblPost.Text = _parent.Content;
            int reacties = cont.Count;
            LblReacties.Text = reacties.ToString();
            PbMedia.SizeMode = PictureBoxSizeMode.StretchImage;
            PbMedia.ImageLocation = _parent.Location;
        }

        private void BtnPlaats_Click(object sender, EventArgs e)
        {
            string message = RtbReactie.Text;
            _sc.PostReply(message, _parent,_val.User.UserId);
            List<Message> list = _sc.GetContents(_parent.MessageId);
            List<string> cont = (from msg in list where msg.ParentMessage != null select msg.UserMessage.Name + ": " + msg.Content).ToList();
            listBox1.DataSource = cont;
            int reacties = cont.Count;
            RtbReactie.Clear();
            LblReacties.Text = reacties.ToString();
        }

        private void BtnDownload_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                Filter = "Jpeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif",
                Title = "Save an Image File"
            };
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                PbMedia.Image.Save(saveFileDialog1.FileName);
            }
        }
    }
}
