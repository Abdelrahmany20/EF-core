using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core.Entities
{
    class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Instractor_ID { get; set; }

        public DateOnly HiringDate { get; set; }
    }
}
