using CustomerInformation.Domains.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CustomerInformation.Data.Configurations
{
    public class CustomerFamilyDetailConfiguration : IEntityTypeConfiguration<CustomerFamilyDetail>
    {
        public void Configure(EntityTypeBuilder<CustomerFamilyDetail> builder)
        {
            builder.ToTable("CustomerFamilyDetails")
                .HasKey(e => e.Id);


            builder.Property(e => e.Id)
                .HasColumnName("Id")
                .HasColumnType("int");


            builder.Property(e => e.CustomerId)
                .HasColumnName("CustomerId")
                .HasColumnType("int");

            builder.HasOne(d => d.Customer)
                .WithMany(p => p.CustomerFamilyDetails)
                .HasForeignKey(d => d.CustomerId);

            builder.Property(e => e.FatherName)
                .HasColumnName("FatherName")
                .HasColumnType("string")
                .HasMaxLength(100);


            builder.Property(e => e.MotherName)
                .HasColumnName("MotherName")
                .HasColumnType("string")
                .HasMaxLength(100);


            builder.Property(e => e.SpouseName)
                .HasColumnName("SpouseName")
                .HasColumnType("string")
                .HasMaxLength(100);
        }
    }
}