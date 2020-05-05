using CustomerInformation.Applications.Common.Interfaces;
using CustomerInformation.Data.Configurations;
using CustomerInformation.Domains.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CustomerInformation.Data
{
    public class CustomerInformationContext : DbContext, ICustomerInformationContext
    {
        public CustomerInformationContext()
        {
        }

        public CustomerInformationContext(DbContextOptions<CustomerInformationContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CustomerBankDetail> BankDetails { get; set; }
        public virtual DbSet<CustomerContactDetail> ContactDetails { get; set; }
        public virtual DbSet<CustomerFamilyDetail> FamilyDetails { get; set; }
        public virtual DbSet<CustomerPersonalDetail> PersonalDetails { get; set; }
        public virtual DbSet<CustomerPhoto> Photos { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerBankDetailConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerContactDetailConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerFamilyDetailConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerPersonalDetailConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerPhotoConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
        }
    }
}