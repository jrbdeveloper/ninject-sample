using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs
{
    public class CompanyDTO
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public Nullable<int> PersonId { get; set; }
        public Nullable<int> AddressId { get; set; }
        public Nullable<int> PhoneId { get; set; }
        public Nullable<int> EmailId { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    }
}
