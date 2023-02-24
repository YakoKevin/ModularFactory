using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace SharedModels.SvgModels
{
    [XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2000/svg")]
    [XmlRoot(ElementName = "svg", Namespace = "http://www.w3.org/2000/svg", IsNullable = false)]
    [Serializable()]
    public class Svg
    {
        [XmlAttribute(AttributeName = "viewBox")]
        public string viewBox { get; set; }

        [XmlAttribute(AttributeName = "width")]
        public string width { get; set; }

        [XmlAttribute(AttributeName = "height")]
        public string height { get; set; }

        [XmlAttribute(AttributeName = "xlmns")]
        public string xlmns { get; set; }

        [XmlElement(ElementName = "rect")]
        public List<Rect> rect { get; set; } = new List<Rect>();
    }
}
