using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectResume.Models
{
    public class VolunteerExperience
    {
        public int ID { get; set; }
        public string VolunteerOrganization { get; set; }
        public DateTime VolunteerDate { get; set; }
        public string VolunteerDuties { get; set; }

    }
}
