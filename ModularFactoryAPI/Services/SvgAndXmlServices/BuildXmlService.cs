using ModularFactoryAPI.IServices.ISvgAndXmlServices;
using SharedModels.SvgModels;
using System.Xml.Serialization;

namespace ModularFactoryAPI.Services.SvgAndXmlServices
{
    public class BuildXmlService : IBuildXmlService
    {
        private string SvgDirectory => System.IO.Path.Combine(".", "SvgFiles");

        public string SvgPath(string productionChannel)
        {
            return System.IO.Path.Combine(SvgDirectory, $"{productionChannel}.svg");
        }

        public Svg CreateObject(string productionChannel)
        {
            Svg svg = new Svg();
            // save document in XLS format
            XmlSerializer xs = new XmlSerializer(typeof(Svg));

            using (FileStream stream = File.Open(SvgPath(productionChannel), FileMode.Open))
            {
                svg = (Svg)xs.Deserialize(stream);
            }

            return svg;
        }

        public string xmlAsString()
        {
            string path = @"SvgFiles\ModularFactorySVG.svg";
            string xmlString = File.ReadAllText(path);

            return xmlString;
        }
    }
}
