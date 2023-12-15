using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace ProxyHTTP.Controllers
{
    [ApiController]
    [Route("[action]")]
    public class ProxyController : ControllerBase
    {
        private HttpClient _httpClient;
        public ProxyController( IHttpClientFactory httpClientFactory ) 
        {
            _httpClient = httpClientFactory.CreateClient();
        }

        [HttpGet]
        public async Task<IActionResult> Authors()
        {
            return await proxyToService("https://localhost:44322/Authors");    
        }
        
        [HttpGet]
        public async Task<IActionResult> Books()
        {
            return await proxyToService("https://localhost:44304/Books");
        }

        private async Task<ContentResult> proxyToService(string url) => Content(await _httpClient.GetStringAsync(url));

        
    }
}
