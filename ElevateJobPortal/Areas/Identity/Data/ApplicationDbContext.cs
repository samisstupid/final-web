using ElevateJobPortal.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ElevateJobPortal.Areas.Identity.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationIdentityUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<Organization> Organization { get; set; }
    public DbSet<Vendor> Vendor { get; set; }
    public DbSet<Category> Category { get; set; }
    public DbSet<JobDescription> JobDescription { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
