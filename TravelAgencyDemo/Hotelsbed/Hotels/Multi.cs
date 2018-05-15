using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelAgencyDemo.Hotelsbed.Hotels
{
    public class Multi
    {

        public class Rootobject
        {
            public Auditdata auditData { get; set; }
            public Activitiescontent[] activitiesContent { get; set; }
        }

        public class Auditdata
        {
            public string serverId { get; set; }
            public string environment { get; set; }
            public int processTime { get; set; }
            public DateTime time { get; set; }
        }

        public class Activitiescontent
        {
            public string contentId { get; set; }
            public string activityFactsheetType { get; set; }
            public string activityCode { get; set; }
            public string name { get; set; }
            public string modalityCode { get; set; }
            public Geolocation geolocation { get; set; }
            public Location location { get; set; }
            public Media media { get; set; }
            public string description { get; set; }
            public string[] detailedInfo { get; set; }
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
            public Country country { get; set; }
            public string city { get; set; }
            public string zip { get; set; }
            public string description { get; set; }
        }

        public class Geolocation1
        {
            public float latitude { get; set; }
            public float longitude { get; set; }
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
        }

        public class Included
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

    }
}