namespace CustomerInformation.Domains.Models.Entities
{
    public class CustomerFamilyDetail
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string SpouseName { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
