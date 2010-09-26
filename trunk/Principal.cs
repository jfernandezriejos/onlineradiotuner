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
        private Dictionary<IntPtr, RadioStation> map_id_station = new Dictionary<IntPtr, RadioStation>();
        
        public Principal(OnlineRadioTunnerSystem system)
        {
            InitializeComponent();

            ContextMenu menu = BuildMenu(system);

            notIcon.ContextMenu = menu;
            notIcon.Visible = true;

        }

        private ContextMenu BuildMenu(OnlineRadioTunnerSystem system)
        {
            ContextMenu menu = new ContextMenu();

            foreach (RadioStationGroup grp in system.Groups)
            {
                // creamos el primer nivel de menu
                MenuItem itm = new MenuItem(grp.Name);
                menu.MenuItems.Add(itm);

                // si solo tiene una estacion
                if (grp.Stations.Count == 1)
                {
                    // añadimos el evento
                    itm.Click += new EventHandler(change_radio_station);
                    map_id_station[itm.Handle] = grp.Stations[0];
                }
                else
                {
                    MenuItem[] itm_arr = new MenuItem[grp.Stations.Count];
                    int i = 0;
                    foreach (RadioStation rstn in grp.Stations)
                    {
                        itm_arr[i] = new MenuItem(rstn.Name);
                        itm_arr[i].Click += new EventHandler(change_radio_station);
                        map_id_station[itm_arr[i].Handle] = rstn; 
                        ++i;
                    }


                    itm.MenuItems.AddRange(itm_arr);
                }
            }

            // añadimos la opcion de salir
            MenuItem salir = new MenuItem("Salir");
            salir.Click += new EventHandler(salir_click);
            menu.MenuItems.Add(salir);
            return menu;
        }

        private void wMediaPlayer_StatusChange(object sender, EventArgs e)
        {
            AxWMPLib.AxWindowsMediaPlayer wmp = (AxWMPLib.AxWindowsMediaPlayer)sender;
            notIcon.ShowBalloonTip(10, "Emisora", wmp.status, ToolTipIcon.Info);
        }

        private void change_radio_station(object sender, EventArgs e)
        {
            MenuItem itm = (MenuItem) sender;
            RadioStation rst;
            if (map_id_station.TryGetValue(itm.Handle, out rst))
            {
                switch (rst.Type)
                {
                    case StationType.WMP:
                        wMediaPlayer.URL = rst.Url;
                        break;
                    case StationType.FLASH:
                        flsh_player.Movie = rst.Url;
                        flsh_player.Play();
                        break;
                }
            }
            else
            {
                MessageBox.Show("No se encontro la dirección de la emisora " + rst.Name, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mute_click(object sender, EventArgs e)
        {
            wMediaPlayer.settings.mute = !wMediaPlayer.settings.mute;
        }



        private void salir_click(object sender, EventArgs e)
        {
            if (notIcon != null)
            {
                notIcon.Dispose();
            }
            
            Application.Exit();
        }

        private void notIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                wMediaPlayer.settings.mute = !wMediaPlayer.settings.mute;

                if (wMediaPlayer.settings.mute)
                {
                    notIcon.Icon = new System.Drawing.Icon("radiomute.ico");
                }
                else 
                {
                    notIcon.Icon = new System.Drawing.Icon("radio.ico");
                }

                

            }
        }

        private void flsh_player_OnReadyStateChange(object sender, AxShockwaveFlashObjects._IShockwaveFlashEvents_OnReadyStateChangeEvent e)
        {
            int i = 0;
            ++i;
        }
    }
}
