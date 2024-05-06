
using GeoMapping.DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
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



        public static List<double> AddComponent(AddressDTO addressDTO)
        {
            string siteName = addressDTO.SiteName;
            string city = "%20" + addressDTO.City;
            string country = "%20" + addressDTO.Country + ".json?";
            string encodedUrl = Uri.EscapeDataString(siteName)+city+country;


            
            string URL = "https://api.mapbox.com/geocoding/" +
                "v5/mapbox.places/"+encodedUrl+ "proximity=ip&access_token=pk.eyJ1IjoibWFkZWwtOTc5NyIsImEiOiJjbHZxZnJpdW4wZXEwMmxtaHFvdXJsNGNiIn0.4rf_FlySdUEG3NMti8NuUQ";
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
                var items= jsonp.ToList();
                var coordinates = items[0].geometry.coordinates;
                return coordinates;
            }

            return null;
        }
    }
}
