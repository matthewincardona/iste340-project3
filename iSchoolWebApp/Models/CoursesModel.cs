namespace iSchoolWebApp.Models
{
    public class CoursesModel
    {
        public string? PageTitle { get; set; }
        public List<CourseDegree>? CourseDegrees { get; set; }
    }

    public class CourseDegree
    {
        public string? DegreeName { get; set; }
        public string? Semester { get; set; }
        public List<string>? Courses { get; set; }
    }

    public class Course
    {
        public string? Code { get; set; }
        public string? Title { get; set; }
    }
}
