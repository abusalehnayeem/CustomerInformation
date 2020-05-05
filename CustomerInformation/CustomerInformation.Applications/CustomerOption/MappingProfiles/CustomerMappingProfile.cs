using AutoMapper;
using CustomerInformation.Applications.CustomerOption.Commands.CreateCustomer;
using CustomerInformation.Applications.CustomerOption.Queries;
using CustomerInformation.Domains.Models.Entities;
using CustomerInformation.Domains.RequestModels;
using CustomerInformation.Domains.ResponseModels;

namespace CustomerInformation.Applications.CustomerOption.MappingProfiles
{
    public class CustomerMappingProfile : Profile
    {
        public CustomerMappingProfile()
        {
            //Request Model Mapping
            CreateMap<Customer, CustomerRequestModel>().ReverseMap();
            CreateMap<CustomerBankDetail, CustomerBankDetailRequestModel>().ReverseMap();
            CreateMap<CustomerContactDetail, CustomerContactDetailRequestModel>().ReverseMap();
            CreateMap<CustomerFamilyDetail, CustomerFamilyDetailRequestModel>().ReverseMap();
            CreateMap<CustomerPersonalDetail, CustomerPersonalDetailRequestModel>().ReverseMap();
            CreateMap<CustomerPhoto, CustomerPhotoRequestModel>().ReverseMap();

            //Create Command Mapping
            CreateMap<Customer, CreateCustomerCommand>();

            //Response Model Mapping
            CreateMap<Customer, CustomerResponseModel>().ReverseMap();

            //Create Query Mapping
            CreateMap<Customer, GetCustomerQuery>();
        }
    }
}
