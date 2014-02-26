using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs
{
    public class BiometricsDTO
    {
        public int BiometricId { get; set; }
        public Nullable<int> PersonId { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string DOB { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    }
}
