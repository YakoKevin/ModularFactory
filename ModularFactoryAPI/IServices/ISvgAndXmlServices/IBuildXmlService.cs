using SharedModels.SvgModels;

namespace ModularFactoryAPI.IServices.ISvgAndXmlServices
{
    public interface IBuildXmlService
    {
        string SvgPath(string productionChannel);
        Svg CreateObject(string productionChannel);
        string xmlAsString();
    }
}
