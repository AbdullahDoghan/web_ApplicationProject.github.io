using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_ApplicationProject.Models
{
    public class EntityBase
    {
        public int id { get; set; }
        public bool isDeleted { get; set; }
        public DateTime createdDate { get; set; }
        public string createdBy  { get; set; }
        public DateTime lastModfy { get; set; }




    }
}
