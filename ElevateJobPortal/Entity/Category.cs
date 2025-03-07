using System.ComponentModel.DataAnnotations;

namespace ElevateJobPortal.Entity
{
    public class Category:Common
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryAddress { get; set; }
        public int CategoryPhone_no { get; set; }
    }
}
