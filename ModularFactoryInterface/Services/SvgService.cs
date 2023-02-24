using ModularFactoryInterface.IServices;

namespace ModularFactoryInterface.Services
{
    public class SvgService : ISvgService
    {
        private readonly HttpClient _httpClient;

        public SvgService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetSvgAsObject()
        {
            var responseMessage = await _httpClient.GetAsync($"/api/SvgAndXml");

            if (responseMessage.IsSuccessStatusCode)
            {
                return await responseMessage.Content.ReadAsStringAsync();
            }

            return "failed";
        }
    }
}
