using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerInformation.Applications.Common.Exceptions
{
    public class CustomerDeleteFailureException : Exception
    {
        public CustomerDeleteFailureException(string name, object key, string message)
            : base($"Deletion of entity \"{name}\" ({key}) failed. {message}")
        {
        }
    }
}
