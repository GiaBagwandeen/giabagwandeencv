using System.Security.Cryptography.Xml;

namespace GBCV.Models
{
    public class CVModels
    {
        public string FullName { get; set; }
        public string ProfessionalTitle { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
        public string LinkedIn { get; set; }
        public string Website { get; set; }
        public string ProfessionalSummary { get; set; }
        public List<Experience> Experiences { get; set; }
        public List<Education> Educations { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Project> Projects { get; set; }
    }


}
