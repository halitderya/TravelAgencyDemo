using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelAgencyDemo.Hotelsbed.Hotels
{
    public class Countries
    {

        public class Rootobject
        {
            public string operationId { get; set; }
            public Auditdata auditData { get; set; }
            public Country[] countries { get; set; }
        }

        public class Auditdata
        {
            public string serverId { get; set; }
            public string environment { get; set; }
            public int processTime { get; set; }
            public DateTime time { get; set; }
        }

        public class Country
        {
            public string code { get; set; }
            public string name { get; set; }
        }

    }
}