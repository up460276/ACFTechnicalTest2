using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ACFTechTest2.Models
{
    public class testAPI
    {

        public int albumId { get; set; }
        public int id { get; set; }

        public string title { get; set; }

        public string url { get; set; }

        public string thumbnailUrl { get; set; }

    }

    public class testAPICollection : List<testAPI>
    {

    }
        
}
