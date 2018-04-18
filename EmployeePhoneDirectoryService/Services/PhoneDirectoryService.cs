using EmployeePhoneDirectoryService.Models;
using EmployeePhoneDirectoryService.Providers;
using System.Collections.Generic;


namespace EmployeePhoneDirectoryService.Services
{
    public class PhoneDirectoryService : IPhoneDirectoryService
    {
        private readonly IEmployeeInformationProvider employeeInformationProvider;

        public PhoneDirectoryService(IEmployeeInformationProvider _employeeInformationProvider)
        {
            employeeInformationProvider = _employeeInformationProvider;
        }

        public IEnumerable<PhoneDirectoryEmployeeEntry> Get()
        {
            return employeeInformationProvider.GetBasicInformation();
        }
    }
}
