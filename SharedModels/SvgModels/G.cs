using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace SharedModels.SvgModels
{
    public class G
    {
        [XmlAttribute(AttributeName = "title")]
        public string title { get; set; } = "";

        [XmlElement(ElementName = "rect")]
        public List<Rect> rect { get; set; } = new List<Rect>();

        [XmlElement(ElementName = "line")]
        public List<Line> line { get; set; } = new List<Line>();
    }
}
