using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerInformation.Applications.Common.Exceptions
{
    public class CustomerNotFoundException : Exception
    {
        public CustomerNotFoundException(string name, object key)
            : base($"Entity \"{name}\" ({key}) was not found.")
        {
        }
    }
}
