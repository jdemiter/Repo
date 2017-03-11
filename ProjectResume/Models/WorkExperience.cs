using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectResume.Models
{
    public class WorkExperience
    {
        public int ID { get; set; }
        public string Employer { get; set; }
        public string JobTitle { get; set; }
        public DateTime EmploymentStartDate { get; set; }
    }
}
