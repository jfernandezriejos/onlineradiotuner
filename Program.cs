using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace OnlineRadioTunner
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);



            /*
            OnlineRadioTunnerSystem system = new OnlineRadioTunnerSystem();
            RadioStationGroup group = new RadioStationGroup("Onda Cero");
            group.Stations.Add(new RadioStation("OC - Sevilla", "mms://ondacerolivewm.fplive.net/ondacerowmlive-live/oc_sevilla"));
            group.Stations.Add(new RadioStation("OC - Almeria", "mms://ondacerolivewm.fplive.net/ondacerowmlive-live/oc_almeria"));

            system.Groups.Add(group);
            
            RadioStationGroup group2 = new RadioStationGroup("Marca");
            group2.Stations.Add(new RadioStation("M - Sevilla", "mms://reflector.marca.com:9054"));

            system.Groups.Add(group2);


            XmlSerializer serializer = new XmlSerializer(typeof(OnlineRadioTunnerSystem));

           
            StreamWriter w = new System.IO.StreamWriter("rstation.xml");
            serializer.Serialize(w, system);
            w.Close();
            */

            XmlSerializer serializer = new XmlSerializer(typeof(OnlineRadioTunnerSystem));
            StreamReader r = new StreamReader("rstation.xml");
            OnlineRadioTunnerSystem system = (OnlineRadioTunnerSystem)serializer.Deserialize(r);            


            Principal pfrm = new Principal(system);
            Application.Run();
        }
    }
}
