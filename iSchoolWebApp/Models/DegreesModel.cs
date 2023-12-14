namespace iSchoolWebApp.Models
{
    public class DegreesModel
    {
        public string? PageTitle { get; set; }
        public List<Degree>? Undergraduate { get; set; }
        public List<Degree>? Graduate { get; set; }
        public List<string>? GraduateAdvancedCertificates { get; set; }
    }

    public class Degree
    {
        public string? DegreeName { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public List<string>? Concentrations { get; set; }
        public List<string>? AvailableCertificates { get; set; }
    }
}
