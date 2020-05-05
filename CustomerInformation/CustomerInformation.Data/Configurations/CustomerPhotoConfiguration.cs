using CustomerInformation.Domains.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CustomerInformation.Data.Configurations
{
    public class CustomerPhotoConfiguration : IEntityTypeConfiguration<CustomerPhoto>
    {
        public void Configure(EntityTypeBuilder<CustomerPhoto> entity)
        {
            entity.ToTable("CustomerPhotos")
                .HasKey(e => e.Id);


            entity.Property(e => e.Id)
                .HasColumnName("Id")
                .HasColumnType("int");


            entity.Property(e => e.CustomerId)
                .HasColumnName("CustomerId")
                .HasColumnType("int");

            entity.HasOne(d => d.Customer)
                .WithMany(p => p.CustomerPhotos)
                .HasForeignKey(d => d.CustomerId);

            entity.Property(e => e.CustomerImage)
                .HasColumnName("CustomerImage")
                .HasColumnType("System.Byte[]");


            entity.Property(e => e.ImageExtention)
                .HasColumnName("ImageExtention")
                .HasColumnType("string")
                .HasMaxLength(4);


            entity.Property(e => e.EntryDate)
                .HasColumnName("EntryDate")
                .HasColumnType("DateTime");


            entity.Property(e => e.IsDefault)
                .HasColumnName("IsDefault")
                .HasColumnType("bool");
        }
    }
}