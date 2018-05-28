using GiphyAPIDemo.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GiphyAPIDemo.Giphy
{
    public class GetRandomGif: IGetRandomGif
    {

        public async Task<GiphyModel> ReturnRandomGifBasedOnTag(string searchCritera)
        {
            const string giphyKey = "OJagN8A3J39Sdh5Le9vrra1lTTcQofsa"; //get one from their website here: https://developers.giphy.com/docs/

            using (var client = new HttpClient())
            {
                var url = new Uri($"http://api.giphy.com/v1/gifs/search?api_key={giphyKey}&q={searchCritera}&limit=1");
                var response = await client.GetAsync(url);

                string json;

                using(var content = response.Content)
                {
                    json = await content.ReadAsStringAsync();
                }

                return JsonConvert.DeserializeObject<GiphyModel>(json);//deserialise response from json format to Giphy format
            }

        }
    }
}
