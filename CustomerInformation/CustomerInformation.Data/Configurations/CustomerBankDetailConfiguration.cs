using CustomerInformation.Domains.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CustomerInformation.Data.Configurations
{
    public class CustomerBankDetailConfiguration: IEntityTypeConfiguration<CustomerBankDetail>
    {
        public void Configure(EntityTypeBuilder<CustomerBankDetail> builder)
        {
            builder.ToTable("CustomerBankDetails")
                .HasKey(e => e.Id);


            builder.Property(e => e.Id)
                .HasColumnName("Id")
                .HasColumnType("int");


            builder.Property(e => e.CustomerId)
                .HasColumnName("CustomerId")
                .HasColumnType("int");

            builder.HasOne(d => d.Customer)
                .WithMany(p => p.CustomerBankDetails)
                .HasForeignKey(d => d.CustomerId);

            builder.Property(e => e.BankName)
                .HasColumnName("BankName")
                .HasColumnType("string")
                .HasMaxLength(100);


            builder.Property(e => e.BranchName)
                .HasColumnName("BranchName")
                .HasColumnType("string")
                .HasMaxLength(100);


            builder.Property(e => e.AccountType)
                .HasColumnName("AccountType")
                .HasColumnType("string")
                .HasMaxLength(10);
        }
    }
}