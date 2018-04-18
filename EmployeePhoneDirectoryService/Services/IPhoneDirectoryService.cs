using EmployeePhoneDirectoryService.Models;
using System.Collections.Generic;

namespace EmployeePhoneDirectoryService.Services
{
    public interface IPhoneDirectoryService
    {
        IEnumerable<PhoneDirectoryEmployeeEntry> Get();
    }
}
