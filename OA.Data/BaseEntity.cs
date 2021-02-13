using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Data
{
    public class BaseEntity
    {
        public int ID { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public string IPAddress { get; set; }
        public bool IsDeleted { get; set; }
    }
}
