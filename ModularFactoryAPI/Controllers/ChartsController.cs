using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharedModels.SvgModels;

namespace ModularFactoryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChartsController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult Get()
        {
            List<ChartsData> data = GetChartsData();
            return Ok(data);
        }

        // FAKE DATA FOR NOW
        private List<ChartsData> GetChartsData()
        {
            var myData = new List<ChartsData>();

            for (int i = 0; i < 24; i++)
            {
                var doubleData = new double[]
                {
                    new Random().Next(6590, 6625),
                    new Random().Next(6590, 6625),
                    new Random().Next(6590, 6625),
                    new Random().Next(6590, 6625)
                };

                myData.Add(new ChartsData()
                {
                    X = new DateTimeOffset(DateTime.UtcNow.AddHours(i)).ToUnixTimeMilliseconds(),
                    Y = doubleData
                });
            }

            return myData;
        }
    }
}
