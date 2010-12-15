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

            // PEQUEÑO TROZO DE CODIGO PARA SERIALIZAR LAS EMISORAS
			/*OnlineRadioTunnerSystem system = new OnlineRadioTunnerSystem();
            RadioStationGroup group = new RadioStationGroup("Onda Cero");
            group.Stations.Add(new RadioStation("OC - Sevilla", "mms://ondacerolivewm.fplive.net/ondacerowmlive-live/oc_sevilla", StationType.WMP));
            group.Stations.Add(new RadioStation("OC - Almeria", "mms://ondacerolivewm.fplive.net/ondacerowmlive-live/oc_almeria", StationType.WMP));
			system.Groups.Add(group);
            
            RadioStationGroup group2 = new RadioStationGroup("Marca");
            group2.Stations.Add(new RadioStation("M - Sevilla", "mms://reflector.marca.com:9054", StationType.WMP));

			system.Groups.Add(group2);
			
			RadioStationGroup group3 = new RadioStationGroup("Canal Sur Radio");
            group3.Stations.Add(new RadioStation("CSR", "http://canalsurradio.rtva.stream.flumotion.com/rtva/canalsurradio_master.mp3.m3u", StationType.WMP));
			system.Groups.Add(group3);
			
			RadioStationGroup group4 = new RadioStationGroup("Rock and Gol");
            group4.Stations.Add(new RadioStation("R&G", "http://rockandgol.cope.stream.flumotion.com/cope/rockandgol.asf.asx", StationType.WMP));
			system.Groups.Add(group4);
            
            RadioStationGroup group5 = new RadioStationGroup("RNE");
            group5.Stations.Add(new RadioStation("Radio Nacional", "http://www.rtve.es/swf/3.0.33/RTVEPlayer.swf?assetID=3348_es_audios&location=radio&volume=0.75&autostart=true", StationType.FLASH));
            group5.Stations.Add(new RadioStation("Radio Clásica", "http://www.rtve.es/swf/3.0.33/RTVEPlayer.swf?assetID=3343_es_audios&location=radio&volume=0.75&autostart=true", StationType.FLASH));
            group5.Stations.Add(new RadioStation("Radio 3", "http://www.rtve.es/swf/3.0.33/RTVEPlayer.swf?assetID=3342_es_audios&location=radio&volume=0.75&autostart=true", StationType.FLASH));
            group5.Stations.Add(new RadioStation("Radio 4", "http://www.rtve.es/swf/3.0.33/RTVEPlayer.swf?assetID=3344_es_audios&location=radio&volume=0.75&autostart=true", StationType.FLASH));
            group5.Stations.Add(new RadioStation("Radio 5 Todo Noticias", "http://www.rtve.es/swf/3.0.33/RTVEPlayer.swf?assetID=3345_es_audios&location=radio&volume=0.75&autostart=true", StationType.FLASH));
            group5.Stations.Add(new RadioStation("Radio Exterior", "http://www.rtve.es/swf/3.0.33/RTVEPlayer.swf?assetID=3346_es_audios&location=radio&volume=0.75&autostart=true", StationType.FLASH));
            system.Groups.Add(group5);

            RadioStationGroup group6 = new RadioStationGroup("Cadena Ser");
            group6.Stations.Add(new RadioStation("CS - Sevilla", "http://194.169.201.177:8085/stream/prisacom_Sevilla", StationType.WMP));
			system.Groups.Add(group6);

            RadioStationGroup group7 = new RadioStationGroup("Cadena100");
            group7.Stations.Add(new RadioStation("C100", "http://cadena100.cope.stream.flumotion.com/cope/cadena100.flv.m3u", StationType.WMP));
			system.Groups.Add(group7);

            RadioStationGroup group8 = new RadioStationGroup("Europa FM");
            group8.Stations.Add(new RadioStation("EFM", "http://www.europafm.com/EuropaFM/swf/PlayerEFM-OSMF.swf?var1=http://www.antena3.com/player/europafm_streams.xml", StationType.FLASH));
			system.Groups.Add(group8);

            RadioStationGroup group9 = new RadioStationGroup("Los 40");
            group9.Stations.Add(new RadioStation("40", "http://player.streamtheworld.com/_players/unionradio/UnionRadio.swf?nocache=19%3A47%3A24%20GMT+0200%20%28Hora%20de%20verano%20romance%29&streamid=3993&callsign=LOS40", StationType.FLASH));
            system.Groups.Add(group9);

            RadioStationGroup group10 = new RadioStationGroup("MaximaFM");
            group10.Stations.Add(new RadioStation("MaximaFM", "http://player.streamtheworld.com/_players/unionradio/UnionRadio.swf?nocache=19%3A47%3A24%20GMT+0200%20%28Hora%20de%20verano%20romance%29", StationType.FLASH));
            system.Groups.Add(group10);

            XmlSerializer serializer = new XmlSerializer(typeof(OnlineRadioTunnerSystem));
           
            StreamWriter w = new System.IO.StreamWriter("rstation.xml");
            serializer.Serialize(w, system);
            w.Close();*/

            XmlSerializer serializer = new XmlSerializer(typeof(OnlineRadioTunnerSystem));
            StreamReader r = new StreamReader("rstation.xml");
            OnlineRadioTunnerSystem system = (OnlineRadioTunnerSystem)serializer.Deserialize(r);
            r.Close();

            Principal pfrm = new Principal(system);
            Application.Run();
        }
    }
}
