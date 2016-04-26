using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EventClasses;
using Phidgets.Events;


namespace Toegangscontrole
{
    public partial class Toegangscontrole : Form
    {
        private EventClasses.Toegangscontrole tc = new EventClasses.Toegangscontrole();
        private EventClasses.Login val;
        Phidgets.RFID rfid = new Phidgets.RFID();    
        public Toegangscontrole(EventClasses.Login val)
        {
            InitializeComponent();
            rfid.Attach += new AttachEventHandler(rfid_Attach);
            rfid.Detach += new DetachEventHandler(rfid_Detach);
            rfid.Error += new ErrorEventHandler(rfid_Error);

            rfid.Tag += new TagEventHandler(rfid_Tag);
            rfid.TagLost += new TagEventHandler(rfid_TagLost);
            rfid.open();
            Console.WriteLine("waiting for attachment...");
            rfid.waitForAttachment();
            rfid.Antenna = true;
            rfid.LED = true;
            List<string> eventnaam = tc.GetEvents();
            CbEvent.DataSource = eventnaam;
            this.val = val;
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            string RFID = TbRFID.Text;
            CheckIn check= tc.CheckIn(RFID,(CbEvent.SelectedIndex+1));
            LblNaam.Text = check.Naam;
            ChkBetaald.Checked = check.Betaald;

            if (check.Betaald == false)
            {
                MessageBox.Show("Bezoeker heeft nog niet betaald");
            }
        }

        private void BtnBetaald_Click(object sender, EventArgs e)
        {
            string RFID = TbRFID.Text;
            Boolean check = tc.Betaald(RFID , CbEvent.SelectedIndex + 1);
            ChkBetaald.Checked = check;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            TbRFID.Text = "";
            LblNaam.Text = "";
            ChkBetaald.Checked = false;
        }
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            Gebruikerslijst gl = new Gebruikerslijst(CbEvent.SelectedIndex + 1);
            gl.Show();

        }
        static void rfid_Attach(object sender, AttachEventArgs e)
        {
            Console.WriteLine("RFIDReader {0} attached!",
                                    e.Device.SerialNumber.ToString());
        }
        static void rfid_Detach(object sender, DetachEventArgs e)
        {
            Console.WriteLine("RFID reader {0} detached!",
                                    e.Device.SerialNumber.ToString());
        }
        static void rfid_Error(object sender, ErrorEventArgs e)
        {
            Console.WriteLine(e.Description);
        }
        void rfid_Tag(object sender, TagEventArgs e)
        {
            Console.WriteLine("Tag {0} scanned", e.Tag);
            TbRFID.Text = e.Tag;
        }
        static void rfid_TagLost(object sender, TagEventArgs e)
        {
            Console.WriteLine("Tag {0} lost", e.Tag);
        }

    }
}