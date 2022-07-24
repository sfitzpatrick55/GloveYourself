using GloveYourself.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GloveYourself.WebMVC.Data;

public class ApplicationDbContext : IdentityDbContext
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

