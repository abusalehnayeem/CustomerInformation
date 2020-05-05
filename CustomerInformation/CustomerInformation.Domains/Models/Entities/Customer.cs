using System;
using System.Collections.Generic;

namespace CustomerInformation.Domains.Models.Entities
{
    public class Customer
    {
        public Customer()
        {
            CustomerBankDetails = new List<CustomerBankDetail>();
            CustomerContactDetails = new List<CustomerContactDetail>();
            CustomerFamilyDetails = new List<CustomerFamilyDetail>();
            CustomerPersonalDetails = new List<CustomerPersonalDetail>();
            CustomerPhotos = new List<CustomerPhoto>();
        }
        public int Id { get; set; }
        public string CustomerNo { get; set; }
        public string CustomerName { get; set; }
        public string Gender { get; set; }
        public DateTime? CustomerEntryDate { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Nationality { get; set; }
        public bool? IsApproved { get; set; }
        public bool IsActive { get; set; }
        public bool? IsDeleted { get; set; }
        public byte? SortedBy { get; set; }
        public string Remarks { get; set; }
        public virtual List<CustomerBankDetail> CustomerBankDetails { get; set; }
        public virtual List<CustomerContactDetail> CustomerContactDetails { get; set; }
        public virtual List<CustomerFamilyDetail> CustomerFamilyDetails { get; set; }
        public virtual List<CustomerPersonalDetail> CustomerPersonalDetails { get; set; }
        public virtual List<CustomerPhoto> CustomerPhotos { get; set; }
    }

}
