using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OA.Data
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string IPAddress { get; set; }

    }
}
