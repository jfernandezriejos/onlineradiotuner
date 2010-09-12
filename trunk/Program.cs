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



            /* // PEQUEÑO TROZO DE CODIGO PARA SERIALIZAR LAS EMISORAS
			OnlineRadioTunnerSystem system = new OnlineRadioTunnerSystem();
            RadioStationGroup group = new RadioStationGroup("Onda Cero");
            group.Stations.Add(new RadioStation("OC - Sevilla", "mms://ondacerolivewm.fplive.net/ondacerowmlive-live/oc_sevilla"));
            group.Stations.Add(new RadioStation("OC - Almeria", "mms://ondacerolivewm.fplive.net/ondacerowmlive-live/oc_almeria"));
			system.Groups.Add(group);
            
            RadioStationGroup group2 = new RadioStationGroup("Marca");
            group2.Stations.Add(new RadioStation("M - Sevilla", "mms://reflector.marca.com:9054"));

			system.Groups.Add(group2);
			
			RadioStationGroup group3 = new RadioStationGroup("Canal Sur Radio");
            group3.Stations.Add(new RadioStation("CSR", "http://canalsurradio.rtva.stream.flumotion.com/rtva/canalsurradio_master.mp3.m3u"));
			system.Groups.Add(group3);
			
			RadioStationGroup group4 = new RadioStationGroup("Rock and Gol");
            group4.Stations.Add(new RadioStation("R&G", "http://rockandgol.cope.stream.flumotion.com/cope/rockandgol.asf.asx"));
			system.Groups.Add(group4);
            

            XmlSerializer serializer = new XmlSerializer(typeof(OnlineRadioTunnerSystem));

           
            StreamWriter w = new System.IO.StreamWriter("rstation.xml");
            serializer.Serialize(w, system);
            w.Close();*/

            XmlSerializer serializer = new XmlSerializer(typeof(OnlineRadioTunnerSystem));
            StreamReader r = new StreamReader("rstation.xml");
            OnlineRadioTunnerSystem system = (OnlineRadioTunnerSystem)serializer.Deserialize(r); 

            Principal pfrm = new Principal(system);
            Application.Run(/*pfrm*/);
        }
    }
}
