using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace SharedModels.SvgModels
{
    public class Line
    {
        [XmlAttribute(AttributeName = "stroke-width")]
        public string strokeWidth { get; set; } = "";

        [XmlAttribute(AttributeName = "id")]
        public string id { get; set; } = "";

        [XmlAttribute(AttributeName = "y2")]
        public string y2 { get; set; } = "";

        [XmlAttribute(AttributeName = "x2")]
        public string x2 { get; set; } = "";

        [XmlAttribute(AttributeName = "y1")]
        public string y1 { get; set; } = "";

        [XmlAttribute(AttributeName = "x1")]
        public string x1 { get; set; } = "";

        [XmlAttribute(AttributeName = "stroke")]
        public string stroke { get; set; } = "";

        [XmlAttribute(AttributeName = "fill")]
        public string fill { get; set; } = "";
    }
}
