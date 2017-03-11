using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectResume.Models
{
    public class VolunteerExperience
    {
        public int ID { get; set; }
        [Display(Name = "Volunteer Organization")]
        public string VolunteerOrganization { get; set; }
        [Display(Name = "Start Date")]
        public DateTime VolunteerStartDate { get; set; }
        [Display(Name = "End Date")]
        public DateTime VolunteerEndDate { get; set; }
        [Display(Name = "Volunteer Duties")]
        public string VolunteerDuties { get; set; }

    }
}
