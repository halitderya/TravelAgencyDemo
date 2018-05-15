using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelAgencyDemo.Hotelsbed.Hotels
{
    public class SearchFilter
    {
        public class SearchFilterItem
        {
            public string type { get; set; }
            public string value { get; set; }
        }

        public class Filter
        {
            public List<SearchFilterItem> searchFilterItems { get; set; }
        }

        public class Pagination
        {
            public int itemsPerPage { get; set; }
            public int page { get; set; }
        }

        public class RootObject
        {
            public List<Filter> filters { get; set; }
            public string from { get; set; }
            public string to { get; set; }
            public string language { get; set; }
            public Pagination pagination { get; set; }
            public string order { get; set; }
        }
    }
}