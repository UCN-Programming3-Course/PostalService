using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZipCityApi.Models
{
    public class ZipCity
    {
        [JsonProperty("nr")]
        public string Zip { get; set; }

        [JsonProperty("navn")]
        public string City { get; set; }
    }
}