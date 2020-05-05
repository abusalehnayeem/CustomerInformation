using CustomerInformation.Domains.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CustomerInformation.Data.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers")
                .HasKey(e => e.Id);


            builder.Property(e => e.Id)
                .HasColumnName("Id")
                .HasColumnType("int");


            builder.Property(e => e.CustomerNo)
                .HasColumnName("CustomerNo")
                .HasColumnType("string")
                .HasMaxLength(12);


            builder.Property(e => e.CustomerName)
                .HasColumnName("CustomerName")
                .HasColumnType("string")
                .HasMaxLength(100);


            builder.Property(e => e.Gender)
                .HasColumnName("Gender")
                .HasColumnType("string")
                .HasMaxLength(20);


            builder.Property(e => e.CustomerEntryDate)
                .HasColumnName("CustomerEntryDate")
                .HasColumnType("DateTime");


            builder.Property(e => e.DateOfBirth)
                .HasColumnName("DateOfBirth")
                .HasColumnType("DateTime");


            builder.Property(e => e.Nationality)
                .HasColumnName("Nationality")
                .HasColumnType("string")
                .HasMaxLength(100);


            builder.Property(e => e.IsApproved)
                .HasColumnName("IsApproved")
                .HasColumnType("bool");


            builder.Property(e => e.IsActive)
                .HasColumnName("IsActive")
                .HasColumnType("bool");


            builder.Property(e => e.IsDeleted)
                .HasColumnName("IsDeleted")
                .HasColumnType("bool");


            builder.Property(e => e.SortedBy)
                .HasColumnName("SortedBy")
                .HasColumnType("byte");


            builder.Property(e => e.Remarks)
                .HasColumnName("Remarks")
                .HasColumnType("string")
                .HasMaxLength(500);
        }
    }
}