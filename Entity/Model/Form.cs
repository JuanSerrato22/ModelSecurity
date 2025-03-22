using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model
{
    class Form
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public required string Name { get; set; }
        public bool Active { get; set; }
    }
}
