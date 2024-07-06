using Microsoft.AspNetCore.Mvc;

namespace Mammoth.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MammothController : ControllerBase
    {
        [HttpGet]
        public dynamic ConvertWordToHtml(string word)
        {
            var converter = new DocumentConverter();
            var result = converter.ConvertToHtml(word);
            return result.Value;

        }
    }
}
