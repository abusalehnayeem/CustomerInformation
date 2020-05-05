using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using CustomerInformation.Applications.Common.Interfaces;
using CustomerInformation.Applications.CustomerOption.Commands.CreateCustomer;
using CustomerInformation.Domains.Models.Entities;
using MediatR;

namespace CustomerInformation.Applications.CustomerOption.Handlers
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, int>
    {
        private readonly ICustomerInformationContext _context;
        private readonly IMapper _mapper;

        public CreateCustomerCommandHandler(ICustomerInformationContext context, IMapper mapper) =>
            (_context, _mapper) = (context, mapper);
        
        public async Task<int> Handle(CreateCustomerCommand request, CancellationToken cancellationToken= default)
        {
            var entity = _mapper.Map<Customer>(request);
            _context.Customers.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return entity.Id;
        }
    }
}
