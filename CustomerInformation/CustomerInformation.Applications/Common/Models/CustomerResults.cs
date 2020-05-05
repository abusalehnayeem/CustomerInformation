using System.Collections.Generic;
using System.Linq;

namespace CustomerInformation.Applications.Common.Models
{
    public class CustomerResults
    {
        internal CustomerResults(bool succeeded, IEnumerable<string> errors)
        {
            Succeeded = succeeded;
            Errors = errors.ToArray();
        }

        public bool Succeeded { get; set; }

        public string[] Errors { get; set; }

        public static CustomerResults Success()
        {
            return new CustomerResults(true, new string[] { });
        }

        public static CustomerResults Failure(IEnumerable<string> errors)
        {
            return new CustomerResults(false, errors);
        }
    }
}
