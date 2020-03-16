using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.Test_ElasticSearch.Models
{
    public class Recipe
    {
        public string id { get; set; }
        public string name { get; set; }
        public string cookTime { get; set; }
        public string creator { get; set; }
        public string datePublished { get; set; }
        public string description { get; set; }
    }
}
