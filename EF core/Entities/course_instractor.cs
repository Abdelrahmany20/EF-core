using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core.Entities
{
    class course_instractor
    {
        [Key]
        public int course_id { get; set; }
        public int instractor_id { get; set; }
        public int evaluate { get; set; }
    }
}
