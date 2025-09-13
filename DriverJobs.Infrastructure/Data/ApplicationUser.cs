using DriverJobs.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace DriverJobs.Data;

public class ApplicationUser : IdentityUser
{
    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public ICollection<JobAd> JobAds { get; set; }
}