using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Federated.Models.Clinicians
{



   public class clinicians_age_in_cat
    {

        [JsonProperty("0")]
        public int zero { get; set; }
        [JsonProperty("1")]
        public int one { get; set; }
        [JsonProperty("2")]
        public int two { get; set; }
        [JsonProperty("3")]
        public int three { get; set; }
        public int missing { get; set; }

    }


    

}
