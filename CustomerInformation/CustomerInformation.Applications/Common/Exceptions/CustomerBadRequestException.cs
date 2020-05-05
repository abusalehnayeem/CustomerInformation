using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerInformation.Applications.Common.Exceptions
{
    public class CustomerBadRequestException : Exception
    {
        public CustomerBadRequestException(string message)
            : base(message)
        {
        }
    }
}
