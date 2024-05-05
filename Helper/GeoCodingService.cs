
using GeoMapping.DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GeoMapping.Helper
{
    class Response
    {
        public List<GeoCode> features { get; set; }
    }

    public static class GeoCodingService
    {
        public static int index = 0;



        public static List<GeoCode> AddComponent()
        {
            string URL = "https://api.mapbox.com/geocoding/" +
                "v5/mapbox.places/Bogor%20Tengah%2C%20Bogor%2C%20West%20Java%2C%20Indonesia.json?proximity=ip&access_token=pk.eyJ1IjoibWFkZWwtOTc5NyIsImEiOiJjbHZxZnJpdW4wZXEwMmxtaHFvdXJsNGNiIn0.4rf_FlySdUEG3NMti8NuUQ";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();

            client.BaseAddress = new Uri(URL);
            byte[] cred = UTF8Encoding.UTF8.GetBytes("username:password");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpContent content = new StringContent("", UTF8Encoding.UTF8, "application/json");
            HttpResponseMessage messge = client.GetAsync(URL).Result;
            string description = string.Empty;
            if (messge.IsSuccessStatusCode)
            {
                string result = messge.Content.ReadAsStringAsync().Result;

                var jsonp = JsonConvert.DeserializeObject<Response>(result).features;
               // var geometryjson= JsonConvert.DeserializeObject<List<GeoCode>>(jsonp);

                return jsonp.ToList();
            }

            return null;
        }
    }
}
