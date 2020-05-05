using CustomerInformation.Applications.CustomerOption.Commands.CreateCustomer;
using CustomerInformation.Applications.CustomerOption.Queries;
using CustomerInformation.Domains.ResponseModels;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CustomerInformation.Api.Controllers
{
    [Route("api/customer")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private IMediator _mediator;
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateCustomerCommand command) => await Mediator.Send(command);

        [HttpGet]
        public async Task<IList<CustomerResponseModel>> Get() => await Mediator.Send(new GetCustomerQuery());
    }
}