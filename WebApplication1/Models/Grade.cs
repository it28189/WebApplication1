using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Grade
    {
        public int GradeId { get; set; }
        public int GradeName { get; set; }
        public string Section { get; set; }
        ICollection<Student> Student { get; set; }
    }
}
