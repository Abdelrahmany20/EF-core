using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core.Entities
{
    class Student_Course
    {
        [Key]
        public int Student_ID { get; set; }
        public int Course_ID { get; set; }
        public int Grade { get; set; }
    }
}
