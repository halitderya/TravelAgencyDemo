using System.Web.Mvc;
using System.Net;
using System.Net.Http;
using TravelAgencyDemo.Hotelsbed.Authentication;
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using TravelAgencyDemo.Hotelsbed.Hotels;

namespace TravelAgencyDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            using (WebClient client = new WebClient())
            {
                const string endpoint = "api.test.hotelbeds.com";

                UriBuilder uriBuilder = new UriBuilder();
                uriBuilder.Host = endpoint;
                uriBuilder.Path = "activity-content-api/3.0/hotels/en/PMI";


                uriBuilder.Scheme = "https";
                string finalpath = uriBuilder.ToString();
                HotelObject _model = GetJson(finalpath);
                List<Hotel> model = _model.hotels;

                




                return View("Index",model);
            }
        
    }



    private HotelObject GetJson(string url)
        {
            using (var w = new WebClient())
            {
                w.Headers.Add("X-Signature", GetAuthenticed.Signature());
                w.Headers.Add("secret", "hC4G64FvN9");
                w.Headers.Add("Api-Key", "9g9e3fpc5ea8e692pdznrk52");
                w.Headers.Add("Accept", "application/json");
                HotelObject rootObject = new HotelObject();
                var json_data = string.Empty;
                try
                {
                    json_data = w.DownloadString(url);
                }
                catch
                {

                }
                return JsonConvert.DeserializeObject<HotelObject>(json_data); 
               




            }
        }
    }
}
