using System;
using System.Collections.Generic;
using CustomerInformation.Domains.RequestModels;
using MediatR;

namespace CustomerInformation.Applications.CustomerOption.Commands.CreateCustomer
{
    public class CreateCustomerCommand : IRequest<int>
    {
        public CreateCustomerCommand()
        {
            CustomerBankDetailRequestModels = new List<CustomerBankDetailRequestModel>();
            CustomerContactDetailRequestModels = new List<CustomerContactDetailRequestModel>();
            CustomerFamilyDetailRequestModels = new List<CustomerFamilyDetailRequestModel>();
            CustomerPersonalDetailRequestModels = new List<CustomerPersonalDetailRequestModel>();
            CustomerPhotoRequestModels = new List<CustomerPhotoRequestModel>();
        }
        public string CustomerName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Nationality { get; set; }
        public List<CustomerBankDetailRequestModel> CustomerBankDetailRequestModels { get; set; }
        public List<CustomerContactDetailRequestModel> CustomerContactDetailRequestModels { get; set; }
        public List<CustomerFamilyDetailRequestModel> CustomerFamilyDetailRequestModels { get; set; }
        public List<CustomerPersonalDetailRequestModel> CustomerPersonalDetailRequestModels { get; set; }
        public List<CustomerPhotoRequestModel> CustomerPhotoRequestModels { get; set; }
    }
}