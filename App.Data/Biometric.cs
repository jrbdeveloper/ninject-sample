//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Biometric
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
