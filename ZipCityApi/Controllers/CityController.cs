using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using ZipCityApi.Models;

namespace ZipCityApi.Controllers
{
    public class CityController : ApiController
    {
        private readonly string _zipService = "https://dawa.aws.dk/";

        [HttpGet]
        [Route("city/{zip}")]
        public async Task<IHttpActionResult> GetCityAsync(string zip)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync($"{_zipService}postnumre/{zip}");
            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsAsync<ZipCity>();
                return Ok(data);
            }
            return StatusCode(HttpStatusCode.ServiceUnavailable);
        }
    }
}
