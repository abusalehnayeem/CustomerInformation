using System;
using CustomerInformation.Applications.CustomerOption.Commands.CreateCustomer;
using FluentValidation;

namespace CustomerInformation.Applications.CustomerOption.Validators
{
    public class CreateCustomerCommandValidator: AbstractValidator<CreateCustomerCommand>
    {
        public CreateCustomerCommandValidator()
        {
            RuleFor(v => v.CustomerName).NotEmpty().NotNull().MinimumLength(3);
            RuleFor(v => v.DateOfBirth).NotEmpty().NotNull().LessThan(DateTime.Today);
            RuleFor(v => v.Gender).NotEmpty().NotNull();
            RuleFor(v => v.Nationality).NotEmpty().NotNull();
            //RuleFor(v => v.CustomerPersonalDetailRequestModels)
            //    .SetValidator(new MustHaveInvoiceItemPropertyValidator<CustomerPersonalDetailRequestModel>());
            //RuleFor(v => v.CustomerPersonalDetailRequestModels)
            //    .SetValidator(new MustHaveInvoiceItemPropertyValidator<CustomerPersonalDetailRequestModel>());
        }
    }
}
