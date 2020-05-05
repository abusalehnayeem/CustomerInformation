using AutoMapper;
using CustomerInformation.Applications.Common.Interfaces;
using CustomerInformation.Applications.CustomerOption.Queries;
using CustomerInformation.Domains.ResponseModels;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CustomerInformation.Applications.CustomerOption.Handlers
{
    public class GetCustomerQueryHandler : IRequestHandler<GetCustomerQuery, List<CustomerResponseModel>>
    {
        private readonly ICustomerInformationContext _context;
        private readonly IMapper _mapper;

        public GetCustomerQueryHandler(ICustomerInformationContext context, IMapper mapper) =>
            (_context, _mapper) = (context, mapper);
        public async Task<List<CustomerResponseModel>> Handle(GetCustomerQuery request, CancellationToken cancellationToken=default)
        {
            var customerResponseModel = new List<CustomerResponseModel>();
            var customer = await  _context.Customers.ToListAsync(cancellationToken);
            if (customer != null)
                customerResponseModel = _mapper.Map<List<CustomerResponseModel>>(customer);
            return customerResponseModel;
        }
    }
}
