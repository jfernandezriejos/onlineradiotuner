﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace OnlineRadioTunner
{
    public enum StationType
    { 
        FLASH, 
        WMP
    }
    
    [XmlRoot(ElementName="RadioStation")]
    public class RadioStation
    {
        public String       Name { get; set; }
        public String       Url { get; set; }
        public StationType  Type { get; set; }

        public RadioStation()
        { }

        public RadioStation(String name, String url, StationType type)
        {
            Name = name;
            Url = url;
            Type = type;
        }
    }

    [XmlRoot(ElementName = "RadioStationGroup")]
    public class RadioStationGroup
    {
        public String Name { get; set; }
        public List<RadioStation> Stations { get; set; }

        public RadioStationGroup()
        {
            Stations = new List<RadioStation>();
        }
        
        public RadioStationGroup(String name)
        {
            Name = name;
            Stations = new List<RadioStation>();
        }
    }

    [XmlRoot(ElementName = "OnlineRadioTunner")]
    public class OnlineRadioTunnerSystem
    {
        public List<RadioStationGroup> Groups { get; set; }

        public OnlineRadioTunnerSystem()
        {
            Groups = new List<RadioStationGroup>();
        }
    }
}
