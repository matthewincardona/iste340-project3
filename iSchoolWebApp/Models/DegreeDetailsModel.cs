using Newtonsoft.Json;
using System.Collections.Generic;

namespace iSchoolWebApp.Models
{
    public class DegreeDetailsModel
    {
        [JsonProperty("degreeName")]
        public string? DegreeName { get; set; }

        [JsonProperty("title")]
        public string? DegreeTitle { get; set; }

        [JsonProperty("description")]
        public string? DegreeDescription { get; set; }

        [JsonProperty("concentrations")]
        public List<string>? Concentrations { get; set; }
    }
}
