using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeProject.Models
{
    public class WorkExperience
    {
        public int ID { get; set; }
        public string Employer { get; set; }
        public DateTime EmploymentDates { get; set;  }
        public string JobTitle { get; set; }
        public string JobDuties { get; set; }

    }
}
