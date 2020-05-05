using System;
using System.Collections.Generic;
using System.Linq;
using FluentValidation.Resources;
using FluentValidation.Validators;

namespace CustomerInformation.Infrastructure
{
/*
    public class MustHaveInvoiceItemPropertyValidator<T> : PropertyValidator where T : class
    {
        public MustHaveInvoiceItemPropertyValidator(IStringSource errorMessageSource) : base(
            "Property {PropertyName} should not be an empty list.")
        {
        }

        public MustHaveInvoiceItemPropertyValidator(string errorMessageResourceName, Type errorMessageResourceType) :
            base(errorMessageResourceName, errorMessageResourceType)
        {
        }

        public MustHaveInvoiceItemPropertyValidator(
            string errorMessage = "Property {PropertyName} should not be an empty list.") : base(errorMessage)
        {
        }

        protected override bool IsValid(PropertyValidatorContext context)
        {
            return context.PropertyValue is IList<T> list && list.Any();
        }
    }
*/
}