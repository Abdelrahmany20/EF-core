using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core.Entities
{
    class Instractor
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public decimal bouns { get; set; }
        public decimal salary { get; set; }
        public string Address { get; set; }
        public int hourRate { get; set; }
        public int Dep_ID { get; set; }
    }
}
