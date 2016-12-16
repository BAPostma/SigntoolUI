using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SignToolUI.Timestamping
{
    [Serializable]
    public class CA
    {
        [XmlElement("name")]
        public string Name { get; set; }
        [XmlElement("timestampurl")]
        public string TimestampServerUri { get; set; }
        [XmlElement("rfc3161")]
        public bool RFC3161Compliant { get; set; }
    }
}
