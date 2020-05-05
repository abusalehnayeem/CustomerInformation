using System;

namespace CustomerInformation.Domains.ResponseModels
{
    public class CustomerResponseModel
    {
        public int Id { get; set; }
        public string CustomerNo { get; set; }
        public string CustomerName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Nationality { get; set; }
    }
}
