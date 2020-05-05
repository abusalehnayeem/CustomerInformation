using CustomerInformation.Domains.ResponseModels;
using MediatR;
using System.Collections.Generic;

namespace CustomerInformation.Applications.CustomerOption.Queries
{
    public class GetCustomerQuery: IRequest<List<CustomerResponseModel>>
    {
    }
}
