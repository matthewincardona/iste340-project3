namespace iSchoolWebApp.Models
{
    public class EmploymentModel
    {
        public string? PageTitle { get; set; }
        public CoopTable? CoopTable { get; set; }
        public Introduction? Introduction { get; set; }
        public DegreeStatistics? DegreeStatistics { get; set; }
        public Employers? Employers { get; set; }
        public Careers? Careers { get; set; }
    }

    public class CoopTable
    {
        public string? Title { get; set; }
        public List<CoopInformation>? CoopInformation { get; set; }
    }

    public class CoopInformation
    {
        public string? Employer { get; set; }
        public string? Degree { get; set; }
        public string? City { get; set; }
        public string? Term { get; set; }
    }

    public class Introduction
    {
        public string? Title { get; set; }
        public List<IntroductionContent>? Content { get; set; }
    }

    public class IntroductionContent
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
    }

    public class DegreeStatistics
    {
        public string? Title { get; set; }
        public List<DegreeStatistic>? Statistics { get; set; }
    }

    public class DegreeStatistic
    {
        public string? Value { get; set; }
        public string? Description { get; set; }
    }

    public class Employers
    {
        public string? Title { get; set; }
        public List<string>? EmployerNames { get; set; }
    }

    public class Careers
    {
        public string? Title { get; set; }
        public List<string>? CareerNames { get; set; }
    }
}
