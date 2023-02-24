using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModularFactoryAPI.IServices.ISvgAndXmlServices;
using ModularFactoryAPI.Services.SvgAndXmlServices;

namespace ModularFactoryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SvgAndXmlController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetXMLInfo()
        {
            try
            {
                IBuildXmlService buildXMLFile = new BuildXmlService();
                var xmlObject = buildXMLFile.CreateObject("ModularFactorySVG");
                string xmlString = buildXMLFile.xmlAsString();

                return Ok(xmlObject);
            }
            catch (Exception e)
            {
                return Ok("Exception " + e);
            }

        }
    }
}
