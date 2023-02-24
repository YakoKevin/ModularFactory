using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace SharedModels.SvgModels
{
    public class Rect
    {
        [XmlAttribute(AttributeName = "id")]
        public string id { get; set; } = "";
        [XmlAttribute(AttributeName = "x")]
        public string x { get; set; }
        [XmlAttribute(AttributeName = "y")]
        public string y { get; set; }
        [XmlAttribute(AttributeName = "height")]
        public string height { get; set; }
        [XmlAttribute(AttributeName = "width")]
        public string width { get; set; }
        [XmlAttribute(AttributeName = "stroke")]
        public string stroke { get; set; }
        [XmlAttribute(AttributeName = "fill")]
        public string fill { get; set; }
        [XmlAttribute(AttributeName = "style")]
        public string style { get; set; }
    }
}
