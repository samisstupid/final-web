using System.ComponentModel.DataAnnotations;

namespace ElevateJobPortal.Entity
{
    public class Organization:Common
    {
        [Key]
        public int OrgId { get; set; }
        public string OrgName { get; set; }
        public string OrgAddress { get; set; }
        public string OrgContact { get; set; }
        public string OrgEmail { get; set; }
    }
}
