using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DriverJobs.Domain.Entities.UserProfile
{
    public class UserProfile
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string ApplicationUserId { get; set; }

        public string AccountType { get; set; }

        public ICollection<JobAd.JobAd> JobAds { get; set; }
    }
}