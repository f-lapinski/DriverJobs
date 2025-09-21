using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverJobs.Domain.Entities.JobAd
{
    public class JobAd
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime PostedDate { get; set; } = DateTime.Now;

        public bool IsActive { get; set; } = false;

        public string UserProfileId { get; set; }

        public UserProfile.UserProfile UserProfile { get; set; }
    }
}