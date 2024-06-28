using Microsoft.EntityFrameworkCore;
using si730pc2u202119447.API.profile.Domain.Model.Aggregates;

namespace si730pc2u202119447.API.Shared.Infrastructure.Persistence.EFC;

public class AppDbContext : DbContext
{
    public DbSet<Profile> Profiles { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Profile>().ToTable("profiles");
        builder.Entity<Profile>().HasKey(p => p.Id);
        builder.Entity<Profile>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<Profile>().Property(p => p.Name).IsRequired().HasMaxLength(100);
        builder.Entity<Profile>().Property(p => p.Email).IsRequired().HasMaxLength(100);
        builder.Entity<Profile>().Property(p => p.Password).IsRequired();
        builder.Entity<Profile>().Property(p => p.Role).IsRequired();
        builder.Entity<Profile>().Property(p => p.CreatedAt).IsRequired();
        builder.Entity<Profile>().Property(p => p.UpdatedAt).IsRequired();
    }
}