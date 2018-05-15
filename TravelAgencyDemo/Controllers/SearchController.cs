using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Mvc;
using TravelAgencyDemo.Hotelsbed.Authentication;

namespace TravelAgencyDemo.Controllers
{
    public class SearchController : Controller
    {
        // GET: Multi
        public ActionResult Index()
        {

            using (WebClient client = new WebClient())
            {
                const string endpoint = "api.test.hotelbeds.com";

              
                UriBuilder uriBuilder = new UriBuilder();
                uriBuilder.Host = endpoint;
                uriBuilder.Path = "/activity-content-api/3.0/activities";
                uriBuilder.Scheme = "https";
                string finalpath = uriBuilder.ToString();

                GetJson(finalpath);


                




                return View("Index");
            }

        }



        private void GetJson(string url)
        {



            using (var client = new HttpClient(

                new HttpClientHandler()
                {
                    AutomaticDecompression = DecompressionMethods.GZip
                }))

                HttpResponseMessage resp = client.GetAsync(Uri).Result;
            response = resp.Content.ReadAsAsync<T>().Result;
            return response;
            //SearchFilter.RootObject rootObject = new SearchFilter.RootObject();

            //w.Headers.Add("X-Signature", GetAuthenticed.Signature());
            //w.Headers.Add("secret", "hC4G64FvN9");
            //w.Headers.Add("Api-Key", "9g9e3fpc5ea8e692pdznrk52");
            //w.Headers.Add("Accept", "application/json");
            RestClient client = new RestClient("https://api.test.hotelbeds.com");
            var request = new RestRequest(Method.POST);
            request.AddHeader("X-Signature", GetAuthenticed.Signature());
            request.AddHeader("secret", "hC4G64FvN9");
            request.AddHeader("Api-Key", "9g9e3fpc5ea8e692pdznrk52");
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-type", "application/json");

            request.Resource = "/activity-content-api/3.0/activities";
            //request.AddParameter("application/json", "{from:2018-04-28}",ParameterType.RequestBody);
            //request.AddParameter("application/json", "{to:2018-05-10}", ParameterType.RequestBody);
            //request.AddParameter("application/json", "{language:en}", ParameterType.RequestBody);

            request.RequestFormat = DataFormat.Json;
            List<Tuple<string, string>> param;

            param = new List<Tuple<string, string>>
                                    {
                                        new Tuple<string, string>("${from}", "2018-04-28"),
                                        new Tuple<string, string>("${to}", "2018-05-10"),
                                        new Tuple<string, string>("${language}", "en")


                                    };


            request.AddBody(param);



            IRestResponse response = client.Execute(request);















            //rootObject.from = "2018-04-28";
            //rootObject.to = "2018-05-30";
            //rootObject.language = "en";
            //rootObject.order = "DEFAULT";





            //var json = new JavaScriptSerializer().Serialize(rootObject);

            //Newtonsoft.Json.JsonSerializer(rootObject);

            //var response = request.UploadValues(url,"POST", rootObject);

            //var responseString = Encoding.Default.GetString(response);




            ////HotelObject rootObject = new HotelObject();
            //var json_data = string.Empty;
            //try
            //{
            //    json_data = request.DownloadString(url);
            //}
            //catch(Exception ex)
            //{
            //    Debug.WriteLine(ex.Message);
            //}
            //var test = JsonConvert.DeserializeObject<Activitiescontent[]>(json_data);
            //return JsonConvert.DeserializeObject<Activitiescontent[]>(json_data);






        }
    }
}