using DriverJobs.Domain.Entities.UserProfile;
using Microsoft.AspNetCore.Identity;

namespace DriverJobs.Data;

public class ApplicationUser : IdentityUser
{
    public UserProfile UserProfile { get; set; }

    public string UserProfileId { get; set; }
}