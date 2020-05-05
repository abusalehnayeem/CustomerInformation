using System.Threading;
using System.Threading.Tasks;
using CustomerInformation.Domains.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CustomerInformation.Applications.Common.Interfaces
{
    public interface ICustomerInformationContext
    {
        DbSet<CustomerBankDetail> BankDetails { get; set; }
        DbSet<CustomerContactDetail> ContactDetails { get; set; }
        DbSet<CustomerFamilyDetail> FamilyDetails { get; set; }
        DbSet<CustomerPersonalDetail> PersonalDetails { get; set; }
        DbSet<CustomerPhoto> Photos { get; set; }
        DbSet<Customer> Customers { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken=default);
    }
}