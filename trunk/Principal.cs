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
        private Dictionary<IntPtr, String> map_id_url = new Dictionary<IntPtr, string>();
        
        public Principal(OnlineRadioTunnerSystem system)
        {
            InitializeComponent();
           
            
            //notIcon.ContextMenu = ctxMenu;

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
                    map_id_url[itm.Handle] = grp.Stations[0].Url;
                }
                else
                {
                    MenuItem[] itm_arr = new MenuItem[grp.Stations.Count];
                    int i = 0;
                    foreach (RadioStation rstn in grp.Stations)
                    {
                        itm_arr[i] = new MenuItem(rstn.Name);
                        itm_arr[i].Click += new EventHandler(change_radio_station);
                        map_id_url[itm_arr[i].Handle] = rstn.Url; 
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
            notIcon.ShowBalloonTip(30000000, "Emisora", wmp.status, ToolTipIcon.Info);
        }

        private void change_radio_station(object sender, EventArgs e)
        {
            MenuItem itm = (MenuItem) sender;
            String url;
            if(map_id_url.TryGetValue(itm.Handle, out url))
            {
                wMediaPlayer.URL = url;
            }
            else
            {
                MessageBox.Show("No se encontro la dirección de la emisora "+ itm.Name, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void salir_click(object sender, EventArgs e)
        {
            if (notIcon != null)
            {
                notIcon.Dispose();
            }
            
            Application.Exit();
        }
    }
}
