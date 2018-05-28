using GiphyAPIDemo.Giphy;
using GiphyAPIDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GiphyAPIDemo.GiphyRepo
{
    public class GiphyService: IGiphyService
    {
        private readonly IGetRandomGif _getRandomGif;

        public GiphyService(IGetRandomGif getRandomGif)
        {
            _getRandomGif = getRandomGif;
        }

        public async Task<GiphyModel> GetRandomGifBasedOnSerachCritera(string searchCrit)
        {
            return await _getRandomGif.ReturnRandomGifBasedOnTag(searchCrit);
        }
    }
}
