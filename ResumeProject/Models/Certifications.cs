using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ResumeProject.Models
{
    public class Certifications
    {
        public string CertficationReceived { get; set; }
        public DateTime DateReceived { get; set; }
    }
}
