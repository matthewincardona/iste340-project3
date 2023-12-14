namespace iSchoolWebApp.Models
{
    public class MinorsModel
    {
        public List<Minor>? UgMinors { get; set; } 
        public string? PageTitle { get; set; }
    }

    public class Minor
    {
        public string? Name { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public List<string>? Courses { get; set; }
        public string? Note { get; set; }
    }
}
