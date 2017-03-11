using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectResume.Models
{
    public class Certifications
    {
        public int ID { get; set; }
        [Display(Name = "Certification")]
        public string CertificationReceived { get; set; }
        [Display(Name = "Received From")]
        public string From { get; set; }
        [Display(Name = "Date Received")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateReceived { get; set; }



    }
}
