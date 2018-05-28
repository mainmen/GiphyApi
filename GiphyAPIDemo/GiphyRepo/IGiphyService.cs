using GiphyAPIDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GiphyAPIDemo.GiphyRepo
{
    public interface IGiphyService
    {
        Task<GiphyModel> GetRandomGifBasedOnSerachCritera(string searchCrit);
    }
}
