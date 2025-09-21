using DriverJobs.Domain.Entities.JobAd;
using DriverJobs.Domain.Entities.UserProfile;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace DriverJobs.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<JobAd> JobAds { get; set; }

    public DbSet<UserProfile> UserProfiles { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<UserProfile>()
            .HasOne<ApplicationUser>()
            .WithOne(a => a.UserProfile)
            .HasForeignKey<UserProfile>(u => u.ApplicationUserId);

        builder.Entity<UserProfile>()
            .HasMany(u => u.JobAds)
            .WithOne(j => j.UserProfile)
            .HasForeignKey(j => j.UserProfileId);




    }
}