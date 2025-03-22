using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model
{
    internal class ChangeLog
    {
        public int Id { get; set; }
        public DateTime DeleteAt { get; set; }
        public DateTime CreateAt { get; set; }
        public int IdTable { get; set; }
        public int IdUser { get; set; }
        public int IdPermission { get; set; }
        public bool Action { get; set; }
    }
}
