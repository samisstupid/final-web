using System.ComponentModel.DataAnnotations;

namespace ElevateJobPortal.Entity
{
    public class Vendor: Common
    {
        [Key]
        public int VendorID { get; set; }
        public string VendorName { get; set; }
        public string VendorAddress { get; set; }
        public int VendorPhone_no { get; set; }
    }
}
