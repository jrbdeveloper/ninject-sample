namespace App.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<int> BiometricId { get; set; }
        public Nullable<int> AddressId { get; set; }
        public Nullable<int> PhoneId { get; set; }
        public Nullable<int> EmailId { get; set; }
        public Nullable<int> CompanyId { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    }
}
