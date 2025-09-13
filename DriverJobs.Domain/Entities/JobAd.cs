using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverJobs.Domain.Entities
{
    public class JobAd
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime PostedDate { get; set; } = DateTime.Now;

        public bool IsActive { get; set; } = false;

        public string ApplicationUserId { get; set; }
    }
}