using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core.Entities
{
    class courses
    {
        public int id { get; set; }
        public TimeOnly duration { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int top_id { get; set; }


    }
}
