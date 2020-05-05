using System;

namespace CustomerInformation.Domains.Models.Entities
{
    public class CustomerPhoto
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public byte[] CustomerImage { get; set; }
        public string ImageExtention { get; set; }
        public DateTime? EntryDate { get; set; }
        public bool? IsDefault { get; set; }
        public virtual Customer Customer { get; set; }
    }


}
