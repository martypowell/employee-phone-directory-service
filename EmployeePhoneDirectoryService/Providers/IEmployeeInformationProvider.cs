using EmployeePhoneDirectoryService.Models;
using System.Collections.Generic;

namespace EmployeePhoneDirectoryService.Providers
{
    public interface IEmployeeInformationProvider
    {
        IEnumerable<PhoneDirectoryEmployeeEntry> GetBasicInformation();
        IEnumerable<PhoneDirectoryEmployeeEntry> GetInformation(string token);
    }
}
