using CustomerInformation.Domains.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CustomerInformation.Data.Configurations
{
    public class CustomerPersonalDetailConfiguration : IEntityTypeConfiguration<CustomerPersonalDetail>
    {
        public void Configure(EntityTypeBuilder<CustomerPersonalDetail> entity)
        {
            entity.ToTable("CustomerPersonalDetails")
                .HasKey(e => e.Id);


            entity.Property(e => e.Id)
                .HasColumnName("Id")
                .HasColumnType("int");


            entity.Property(e => e.CustomerId)
                .HasColumnName("CustomerId")
                .HasColumnType("int");

            entity.HasOne(d => d.Customer)
                .WithMany(p => p.CustomerPersonalDetails)
                .HasForeignKey(d => d.CustomerId);

            entity.Property(e => e.TradeLicenseDate)
                .HasColumnName("TradeLicenseDate")
                .HasColumnType("DateTime");


            entity.Property(e => e.TradeLicenseNo)
                .HasColumnName("TradeLicenseNo")
                .HasColumnType("string")
                .HasMaxLength(50);


            entity.Property(e => e.TradeLicAuthority)
                .HasColumnName("TradeLicAuthority")
                .HasColumnType("string")
                .HasMaxLength(50);


            entity.Property(e => e.RegistrationAuthority)
                .HasColumnName("RegistrationAuthority")
                .HasColumnType("string")
                .HasMaxLength(50);


            entity.Property(e => e.RegistrationNo)
                .HasColumnName("RegistrationNo")
                .HasColumnType("string")
                .HasMaxLength(50);


            entity.Property(e => e.BirthCertificateNo)
                .HasColumnName("BirthCertificateNo")
                .HasColumnType("string")
                .HasMaxLength(25);


            entity.Property(e => e.NationalId)
                .HasColumnName("NationalId")
                .HasColumnType("string")
                .HasMaxLength(25);


            entity.Property(e => e.OccupationAndPosition)
                .HasColumnName("OccupationAndPosition")
                .HasColumnType("string")
                .HasMaxLength(100);


            entity.Property(e => e.Position)
                .HasColumnName("Position")
                .HasColumnType("string")
                .HasMaxLength(100);


            entity.Property(e => e.PassportNo)
                .HasColumnName("PassportNo")
                .HasColumnType("string")
                .HasMaxLength(50);


            entity.Property(e => e.PassportExpireDate)
                .HasColumnName("PassportExpireDate")
                .HasColumnType("DateTime");


            entity.Property(e => e.TINNo)
                .HasColumnName("TINNo")
                .HasColumnType("string")
                .HasMaxLength(50);


            entity.Property(e => e.DrivingLicenseNo)
                .HasColumnName("DrivingLicenseNo")
                .HasColumnType("string")
                .HasMaxLength(50);


            entity.Property(e => e.CustomerIncomeSource)
                .HasColumnName("CustomerIncomeSource")
                .HasColumnType("string")
                .HasMaxLength(50);
        }
    }
}