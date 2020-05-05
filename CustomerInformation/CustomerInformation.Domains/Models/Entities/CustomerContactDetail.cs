namespace CustomerInformation.Domains.Models.Entities
{
    public class CustomerContactDetail
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string PresentAddress { get; set; }
        public string PermanentAddress { get; set; }
        public string OfficeAddress { get; set; }
        public string Mobile { get; set; }
        public string AnotherCellNo { get; set; }
        public string Home { get; set; }
        public string Office { get; set; }
        public string Email { get; set; }

        public virtual Customer Customer { get; set; }
    }


}
