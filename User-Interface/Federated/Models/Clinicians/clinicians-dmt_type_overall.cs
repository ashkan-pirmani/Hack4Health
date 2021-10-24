using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Federated.Models.Clinicians
{
   public class clinicians_dmt_type_overall
    {
        [JsonProperty("No Information on DMT use")]
        public int currently_no_information_DMT_use { get; set; }
        [JsonProperty("currently not using any DMT")]
        public int currently_not_using_DMT { get; set; }
        [JsonProperty("currently on interferon")]
        public int currently_on_interferon { get; set; }
        [JsonProperty("currently on glatiramer")]
        public int currently_on_glatiramer { get; set; }
        [JsonProperty("currently on natalizumab")]
        public int currently_on_natalizumab { get; set; }
        [JsonProperty("currently on fingolimod")]
        public int currently_on_fingolimod { get; set; }
        [JsonProperty("currently on dimethyl fumarate")]
        public int currently_on_fumarate { get; set; }
        [JsonProperty("currently on teriflunomide")]
        public int currently_on_teriflunomide { get; set; }
        [JsonProperty("currently on alemtuzumab")]
        public int currently_on_alemtuzumab { get; set; }
        [JsonProperty("currently on cladribine")]
        public int currently_on_cladribine { get; set; }
        [JsonProperty("currently on siponimod")]
        public int currently_on_siponimod { get; set; }
        [JsonProperty("currently on rituximab")]
        public int currently_on_rituximab { get; set; }
        [JsonProperty("currently on ocrelizumab")]
        public int currently_on_ocrelizumab { get; set; }
        [JsonProperty("currently on another drug not listed")]
        public int currently_on_another_drug_not_listed { get; set; }
        public int missing { get; set; }

    }
}
