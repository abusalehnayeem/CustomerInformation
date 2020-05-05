using CustomerInformation.Domains.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CustomerInformation.Data.Configurations
{
    public class CustomerContactDetailConfiguration : IEntityTypeConfiguration<CustomerContactDetail>
    {
        public void Configure(EntityTypeBuilder<CustomerContactDetail> builder)
        {
            builder.ToTable("CustomerContactDetails")
                .HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .HasColumnName("Id")
                .HasColumnType("int");

            builder.Property(e => e.CustomerId)
                .HasColumnName("CustomerId")
                .HasColumnType("int");

            builder.HasOne(d => d.Customer)
                .WithMany(p => p.CustomerContactDetails)
                .HasForeignKey(d => d.CustomerId);

            builder.Property(e => e.PresentAddress)
                .HasColumnName("PresentAddress")
                .HasColumnType("string")
                .HasMaxLength(300);


            builder.Property(e => e.PermanentAddress)
                .HasColumnName("PermanentAddress")
                .HasColumnType("string")
                .HasMaxLength(300);


            builder.Property(e => e.OfficeAddress)
                .HasColumnName("OfficeAddress")
                .HasColumnType("string")
                .HasMaxLength(300);


            builder.Property(e => e.Mobile)
                .HasColumnName("Mobile")
                .HasColumnType("string")
                .HasMaxLength(15);


            builder.Property(e => e.AnotherCellNo)
                .HasColumnName("AnotherCellNo")
                .HasColumnType("string")
                .HasMaxLength(15);


            builder.Property(e => e.Home)
                .HasColumnName("Home")
                .HasColumnType("string")
                .HasMaxLength(15);


            builder.Property(e => e.Office)
                .HasColumnName("Office")
                .HasColumnType("string")
                .HasMaxLength(15);


            builder.Property(e => e.Email)
                .HasColumnName("Email")
                .HasColumnType("string")
                .HasMaxLength(50);
        }
    }
}