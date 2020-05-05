using System;

namespace CustomerInformation.Domains.Models.Entities
{
    public class CustomerPersonalDetail
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime? TradeLicenseDate { get; set; }
        public string TradeLicenseNo { get; set; }
        public string TradeLicAuthority { get; set; }
        public string RegistrationAuthority { get; set; }
        public string RegistrationNo { get; set; }
        public string BirthCertificateNo { get; set; }
        public string NationalId { get; set; }
        public string OccupationAndPosition { get; set; }
        public string Position { get; set; }
        public string PassportNo { get; set; }
        public DateTime? PassportExpireDate { get; set; }
        public string TINNo { get; set; }
        public string DrivingLicenseNo { get; set; }
        public string CustomerIncomeSource { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
