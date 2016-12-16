using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SignToolUI.Timestamping
{
    [XmlRoot("timestampservers")]
    public class TimestampServers
    {
        [XmlElement("server")]
        List<CA> Servers { get; set; }

        public TimestampServers()
        {
            Servers = new List<CA>();
        }
    }
}
