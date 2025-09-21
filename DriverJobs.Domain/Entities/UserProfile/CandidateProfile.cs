using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverJobs.Domain.Entities.UserProfile
{
    public class CandidateProfile : UserProfile
    {
        public string AccountType { get; set; } = "Candidate";
    }
}