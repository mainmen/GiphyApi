using System.Threading.Tasks;
using GiphyAPIDemo.GiphyRepo;
using Microsoft.AspNetCore.Mvc;

namespace GiphyAPIDemo.Controllers
{
    [Produces("application/json")]
    [Route("api/Giphy")]
    public class GiphyController : Controller
    {
        private readonly IGiphyService _giphyRepo;
        public GiphyController(IGiphyService giphyRepo)
        {
            _giphyRepo = giphyRepo;
        }
        [HttpGet]
        [Route("v1/giphy/random/{searchCritera}")]
        public async Task<IActionResult> GetRandomGif(string searchCritera){
            var result = await _giphyRepo.GetRandomGifBasedOnSerachCritera(searchCritera);
            return Ok(result);
        }
    }
}