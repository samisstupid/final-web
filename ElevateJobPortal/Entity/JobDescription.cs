using System.ComponentModel.DataAnnotations;

namespace ElevateJobPortal.Entity
{
    public class JobDescription: Common 
    {
        [Key]
        public int JobDescriptionId { get; set; }
        public int vendorOrg { get; set; }
        public int CategoryId { get; set; }
        public string JobType { get; set; }
        public string Level { get; set; }
        public int VacancyNo { get; set; }
        public string EmployeeType { get; set; }
        public string JobLoction { get; set; }
        public string OfferedSalary { get; set; }
        public DateTime Deadline { get; set; }
        public string EducationLevel { get; set; }
        public string ExperienceRequired { get; set; }
        public int OtherSpecification { get; set; }
        public string JobWorkDescription { get; set; }
    }
}
