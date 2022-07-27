using GloveYourself.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GloveYourself.Data.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Glove> Gloves { get; set; }
    public DbSet<GloveSize> GloveSizes { get; set; }
    public DbSet<UserTask> Tasks { get; set; }
}

