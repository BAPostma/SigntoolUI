using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace SignToolUI.Timestamping
{
    public sealed class XmlConfigReader
    {
        public XmlConfigReader(string filename = "timestampservers.xml")
        {
            string path = Path.Combine(Environment.CurrentDirectory, filename);

            string xml = @"<?xml version=""1.0"" encoding=""utf-8"" ?>
<timestampservers>
    <server>
        <name>StartSSL</name>
        <timestampurl>http://www.startssl.com/timestamp</timestampurl>
        <rfc3161>True</rfc3161>
    </server>
    <server>
        <name>Verisign</name>
        <timestampurl>http://www.startssl.com/timestamp</timestampurl>
        <rfc3161>False</rfc3161>
    </server>
</timestampservers>";

            XmlSerializer serialiser = new XmlSerializer(typeof(TimestampServers));

            StringReader reader = new StringReader(xml);

            //StreamReader reader = new StreamReader(sr);

            serialiser.UnreferencedObject += serialiser_UnreferencedObject;
            serialiser.UnknownNode += serialiser_UnknownNode;
            serialiser.UnknownElement += serialiser_UnknownElement;
            serialiser.UnknownAttribute += serialiser_UnknownAttribute;

            TimestampServers cas = (TimestampServers)serialiser.Deserialize(reader);

            reader.Close();
        }

        void serialiser_UnknownAttribute(object sender, XmlAttributeEventArgs e)
        {
            throw new NotImplementedException();
        }

        void serialiser_UnknownElement(object sender, XmlElementEventArgs e)
        {
            //throw new NotImplementedException();
        }

        void serialiser_UnknownNode(object sender, XmlNodeEventArgs e)
        {
            //throw new NotImplementedException();
        }

        void serialiser_UnreferencedObject(object sender, UnreferencedObjectEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
