using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OnlineRadioTunner
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
           
            notIcon.Visible = true;

            notIcon.ContextMenu = ctxMenu;
        }

        private void wMediaPlayer_StatusChange(object sender, EventArgs e)
        {
            AxWMPLib.AxWindowsMediaPlayer wmp = (AxWMPLib.AxWindowsMediaPlayer)sender;
            notIcon.ShowBalloonTip(30000000, "Emisora", wmp.status, ToolTipIcon.Info);
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            wMediaPlayer.URL = "mms://reflector.marca.com:9054";
        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            wMediaPlayer.URL = "mms://ondacerolivewm.fplive.net/ondacerowmlive-live/oc_sevilla";
        }
    }
}
