using System.Collections.Generic;
using System.Windows.Forms;

namespace Toegangscontrole
{
    public partial class Gebruikerslijst : Form
    {
        private readonly EventClasses.Toegangscontrole _tc = new EventClasses.Toegangscontrole();

        public Gebruikerslijst(int evt)
        {
            InitializeComponent();
            List<string> aanwezig = _tc.GetAanwezigheid(evt);
            lbAanwezigheid.DataSource = aanwezig;
        }
    }
}
