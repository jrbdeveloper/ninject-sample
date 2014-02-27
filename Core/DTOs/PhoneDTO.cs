using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs
{
    public class PhoneDTO
    {
        public int PhoneId { get; set; }
        public int? AreaCode { get; set; }
        public int? Prefix { get; set; }
        public int? Sufix { get; set; }
    }
}
