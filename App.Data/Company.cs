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
    
    public partial class Company
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
