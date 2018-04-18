using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeePhoneDirectoryService.Models;

namespace EmployeePhoneDirectoryService.Providers
{
    public class MockEmployeeInformationProvider : IEmployeeInformationProvider
    {
        private IEnumerable<PhoneDirectoryEmployeeEntry> mockData = new List<PhoneDirectoryEmployeeEntry>()
            {
                new PhoneDirectoryEmployeeEntry()
        {
            FirstName = "Marty",
                    LastName = "Powell",
                    PhoneNumbers = new List<Phone>()
                    {
                        new Phone() {
                            Number = "410-887-2222",
                            Type = "Office"
                        }
                    }
                },
                new PhoneDirectoryEmployeeEntry()
        {
            FirstName = "Mike",
                    LastName = "Snyder",
                    PhoneNumbers = new List<Phone>()
                    {
                        new Phone() {
                            Number = "410-887-3333",
                            Type = "Office"
                        },
                        new Phone() {
                            Number = "410-887-3333",
                            Type = "Office"
                        }
                    }
                }
    };

        public IEnumerable<PhoneDirectoryEmployeeEntry> GetBasicInformation() => mockData;

        public IEnumerable<PhoneDirectoryEmployeeEntry> GetInformation(string token)
        {
            throw new NotImplementedException();
        }
    }
}
