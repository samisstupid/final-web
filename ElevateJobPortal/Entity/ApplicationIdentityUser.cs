using Microsoft.AspNetCore.Identity;

namespace ElevateJobPortal.Entity
{
    public class ApplicationIdentityUser: IdentityUser
    {
        public int? VendorOrgId { get; set; }
    }
}
