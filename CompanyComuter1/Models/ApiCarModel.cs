using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CompanyComuter1.Models
{
    public class ApiCarModel
    {
        [JsonProperty("model")]
        public string model { get; set; }

        public  string engine { get; set; }
        public string offical_euro_class { get; set; }
        
        public int WTW_CO2 { get; set; }
       
        public string TTW_CO2 { get; set; }
        public string testprog { get; set; }
    }
}