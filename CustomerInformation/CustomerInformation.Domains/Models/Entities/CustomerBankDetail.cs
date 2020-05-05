namespace CustomerInformation.Domains.Models.Entities
{
    public class CustomerBankDetail
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string BankName { get; set; }
        public string BranchName { get; set; }
        public string AccountType { get; set; }

        public virtual Customer Customer { get; set; }
    }


}
