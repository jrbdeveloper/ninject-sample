using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs
{
    public class AddressDTO
    {
        public int AddressId { get; set; }
        public Nullable<int> PersonId { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string AddressType { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    }
}
