using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePhoneDirectoryService.Models
{
    public class PhoneDirectoryEmployeeEntry
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IEnumerable<Phone> PhoneNumbers { get; set; }
    }
}
