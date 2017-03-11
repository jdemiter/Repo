using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public class StudentViewModel
    {
        public Student Student { get; set; }
        public ICollection <Enrollment> enrollments { get; set; }
    }
}
