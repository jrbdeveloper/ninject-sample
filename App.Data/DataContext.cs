using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
using System.Linq;
using Core.DTOs;

namespace App.Data
{
    public class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //throw new UnintentionalCodeFirstException();
            
            modelBuilder.Entity<AddressDTO>();
            modelBuilder.Entity<BiometricsDTO>();
            modelBuilder.Entity<CompanyDTO>();
            modelBuilder.Entity<EmailDTO>();
            modelBuilder.Entity<PersonDTO>();
            modelBuilder.Entity<PhoneDTO>();
        }
    
        public virtual DbSet<AddressDTO> Addresses { get; set; }
        public virtual DbSet<BiometricsDTO> Biometrics { get; set; }
        public virtual DbSet<CompanyDTO> Companies { get; set; }
        public virtual DbSet<EmailDTO> Emails { get; set; }
        public DbSet<PersonDTO> People { get; set; }
        public virtual DbSet<PhoneDTO> Phones { get; set; }
    }
}
