using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelAgencyDemo.Hotelsbed.Hotels
{
    public class Search
    {

        public class Rootobject
        {
            public string operationId { get; set; }
            public Pagination pagination { get; set; }
            public Auditdata auditData { get; set; }
            public Activity[] activities { get; set; }
        }

        public class Pagination
        {
            public int itemsPerPage { get; set; }
            public int page { get; set; }
            public int totalItems { get; set; }
        }

        public class Auditdata
        {
            public string serverId { get; set; }
            public string environment { get; set; }
            public int processTime { get; set; }
            public DateTime time { get; set; }
        }

        public class Activity
        {
            public int order { get; set; }
            public string type { get; set; }
            public string code { get; set; }
            public string name { get; set; }
            public string currency { get; set; }
            public string currencyName { get; set; }
            public Amountsfrom[] amountsFrom { get; set; }
            public Modality[] modalities { get; set; }
            public Country country { get; set; }
            public Content content { get; set; }
        }

        public class Country
        {
            public string code { get; set; }
            public string name { get; set; }
            public Destination[] destinations { get; set; }
        }

        public class Destination
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public class Content
        {
            public string contentId { get; set; }
            public string name { get; set; }
            public Geolocation geolocation { get; set; }
            public Location location { get; set; }
            public Media media { get; set; }
            public string description { get; set; }
            public Featuregroup[] featureGroups { get; set; }
            public Segmentationgroup[] segmentationGroups { get; set; }
        }

        public class Geolocation
        {
            public float latitude { get; set; }
            public float longitude { get; set; }
        }

        public class Location
        {
            public Startingpoint[] startingPoints { get; set; }
        }

        public class Startingpoint
        {
            public string type { get; set; }
            public Meetingpoint meetingPoint { get; set; }
        }

        public class Meetingpoint
        {
            public string type { get; set; }
            public Geolocation1 geolocation { get; set; }
            public string address { get; set; }
            public Country1 country { get; set; }
            public string city { get; set; }
            public string zip { get; set; }
            public string description { get; set; }
        }

        public class Geolocation1
        {
            public float latitude { get; set; }
            public float longitude { get; set; }
        }

        public class Country1
        {
            public string code { get; set; }
            public string name { get; set; }
            public Destination1[] destinations { get; set; }
        }

        public class Destination1
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public class Media
        {
            public Image[] images { get; set; }
        }

        public class Image
        {
            public int visualizationOrder { get; set; }
            public string mimeType { get; set; }
            public Url[] urls { get; set; }
        }

        public class Url
        {
            public int dpi { get; set; }
            public int height { get; set; }
            public int width { get; set; }
            public string resource { get; set; }
            public string sizeType { get; set; }
        }

        public class Featuregroup
        {
            public string groupCode { get; set; }
            public Included[] included { get; set; }
            public Excluded[] excluded { get; set; }
        }

        public class Included
        {
            public string featureType { get; set; }
            public string description { get; set; }
        }

        public class Excluded
        {
            public string featureType { get; set; }
            public string description { get; set; }
        }

        public class Segmentationgroup
        {
            public int code { get; set; }
            public string name { get; set; }
            public Segment[] segments { get; set; }
        }

        public class Segment
        {
            public int code { get; set; }
            public string name { get; set; }
        }

        public class Amountsfrom
        {
            public string paxType { get; set; }
            public int ageFrom { get; set; }
            public int ageTo { get; set; }
            public float amount { get; set; }
            public float boxOfficeAmount { get; set; }
        }

        public class Modality
        {
            public string code { get; set; }
            public string name { get; set; }
            public Duration duration { get; set; }
            public Amountsfrom1[] amountsFrom { get; set; }
            public Cancellationpolicy[] cancellationPolicies { get; set; }
        }

        public class Duration
        {
            public int value { get; set; }
            public string metric { get; set; }
        }

        public class Amountsfrom1
        {
            public string paxType { get; set; }
            public int ageFrom { get; set; }
            public int ageTo { get; set; }
            public float amount { get; set; }
            public float boxOfficeAmount { get; set; }
        }

        public class Cancellationpolicy
        {
            public DateTime dateFrom { get; set; }
            public float amount { get; set; }
        }

    }
}