using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SampleWebCrud.Areas.Identity.Data;
using SampleWebCrud.Models;

namespace SampleWebCrud.Data;

public class SampleWebCrudDbContext : IdentityDbContext<ApplicationUser>
{
    public SampleWebCrudDbContext(DbContextOptions<SampleWebCrudDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

    public DbSet<SampleWebCrud.Models.Registration>? Registration { get; set; }
}
