using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace GiphyAPIDemo.Models
{
    [DataContract] //we need this for deserialisation to work
    public class Data
    {
        [DataMember(Name = "bitly_gif_url")]
        public string Bitly_Gif_Url { get; set; }
    }
}
