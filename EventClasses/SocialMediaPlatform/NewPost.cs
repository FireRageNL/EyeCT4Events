using System;
using System.IO;
using System.Windows.Forms;
using EventClasses;

namespace SocialMediaPlatform
{
    public partial class NewPost : Form
    {
        private readonly EventClasses.Login _val;
        private readonly SocialControl _sc = new SocialControl();

        public NewPost(EventClasses.Login val)
        {
            _val = val;
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //Get the data out of the input fields
            string message = richTextBox1.Text;
            string url = null;
            string title = "untitled";
            if (!string.IsNullOrWhiteSpace(textBox2.Text))
            {
                title = textBox2.Text;
            }
            string mtype = comboBox1.Text;
            //If the URL isnt empty, insert an URL into the field else keep the value null
            if (textBox1.Text != "")
            {
                url = textBox1.Text;
            }
            //Check if at least the body of the post has been filled in
            if (richTextBox1.Text != "")
            {
                //Send the post data to the controller
                _sc.NewPost(message, url, mtype, _val, title);
            }
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() != DialogResult.OK) return;
            string sourcefile = ofd.FileName;
            string fileName = ofd.FileName.Substring(ofd.FileName.LastIndexOf(("\\")) + 1);
            string destinationfile = @"S:\" + fileName;
            try
            {
                File.Copy(sourcefile, destinationfile);
                textBox1.Text = destinationfile;
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

