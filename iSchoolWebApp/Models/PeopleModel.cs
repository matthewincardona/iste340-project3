namespace iSchoolWebApp.Models
{
    public class PeopleModel
    {
        public string? PageTitle { get; set; }
        public string? Title { get; set; }
        public string? SubTitle { get; set; }
        public List<Faculty>? Faculty { get; set; }
    }

    public class Faculty
    {
        public string? Username { get; set; }
        public string? Name { get; set; }
        public string? Tagline { get; set; }
        public string? ImagePath { get; set; }
        public string? Title { get; set; }
        public string? InterestArea { get; set; }
        public string? Office { get; set; }
        public string? Website { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Twitter { get; set; }
        public string? Facebook { get; set; }
    }
}