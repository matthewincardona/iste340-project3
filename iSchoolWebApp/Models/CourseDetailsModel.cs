using Newtonsoft.Json;

namespace iSchoolWebApp.Models
{
    public class CourseDetailsModel
    {
        [JsonProperty("courseID")]
        public string? CourseId { get; set; }

        [JsonProperty("title")]
        public string? CourseTitle { get; set; }

        [JsonProperty("description")]
        public string? CourseDescription { get; set; }
    }

}