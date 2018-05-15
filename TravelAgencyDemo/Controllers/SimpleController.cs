using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;
using TravelAgencyDemo.Hotelsbed.Authentication;
using TravelAgencyDemo.Hotelsbed.Hotels;

namespace TravelAgencyDemo.Controllers
{
    public class SimpleController : Controller
    {
        // GET: Simple
        public ActionResult Index()
        {
            using (WebClient client = new WebClient())
            {
                const string endpoint = "api.test.hotelbeds.com";

                // client.Headers.Add("X-Signature", GetAuthenticed.Signature() );
                //client.Headers.Add("secret", "hC4G64FvN9");
                //client.Headers.Add("Api-Key", "9g9e3fpc5ea8e692pdznrk52");
                //client.Headers.Add("Accept", "application/json");
                //string response = client.DownloadString(endpoint);

                UriBuilder uriBuilder = new UriBuilder();
                uriBuilder.Host = endpoint;
                uriBuilder.Path = "activity-content-api/3.0/hotels/en/PMI";


                uriBuilder.Scheme = "https";
                string finalpath = uriBuilder.ToString();
                Activitiescontent[] _model = GetJson(finalpath);
                Rootobject rootobject = new Rootobject();
                






                return View("Index", _model);
            }

        }



        private Activitiescontent[] GetJson(string url)
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

                return JsonConvert.DeserializeObject<Activitiescontent[]>(json_data);





            }
        }
    }



        }
    
