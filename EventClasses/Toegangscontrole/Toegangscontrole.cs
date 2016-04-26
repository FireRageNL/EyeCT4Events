using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EventClasses;
using Phidgets;
using Phidgets.Events;

namespace Toegangscontrole
{
    public partial class Toegangscontrole : Form
    {
        private readonly EventClasses.Toegangscontrole _tc = new EventClasses.Toegangscontrole();
        readonly RFID _rfid = new RFID();    
        public Toegangscontrole()
        {
            InitializeComponent();
            _rfid.Attach += rfid_Attach;
            _rfid.Detach += rfid_Detach;
            _rfid.Error += rfid_Error;

            _rfid.Tag += rfid_Tag;
            _rfid.TagLost += rfid_TagLost;
            _rfid.open();
            Console.WriteLine("waiting for attachment...");
            _rfid.waitForAttachment();
            _rfid.Antenna = true;
            _rfid.LED = true;
            List<string> eventnaam = _tc.GetEvents();
            CbEvent.DataSource = eventnaam;
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            string rfid = TbRFID.Text;
            CheckIn check= _tc.CheckIn(rfid,(CbEvent.SelectedIndex+1));
            LblNaam.Text = check.Naam;
            ChkBetaald.Checked = check.Betaald;

            if (check.Betaald == false)
            {
                MessageBox.Show("Bezoeker heeft nog niet betaald");
            }
        }

        private void BtnBetaald_Click(object sender, EventArgs e)
        {
            string rfid = TbRFID.Text;
            bool check = _tc.Betaald(rfid , CbEvent.SelectedIndex + 1);
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
                                    e.Device.SerialNumber);
        }
        static void rfid_Detach(object sender, DetachEventArgs e)
        {
            Console.WriteLine("RFID reader {0} detached!",
                                    e.Device.SerialNumber);
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