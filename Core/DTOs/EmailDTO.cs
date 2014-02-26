using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs
{
    public class EmailDTO
    {
        public int EmailId { get; set; }
        public Nullable<int> PersonId { get; set; }
        public string Address { get; set; }
        public string EmailType { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    }
}
