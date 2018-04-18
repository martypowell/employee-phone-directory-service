using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeePhoneDirectoryService.Models;
using EmployeePhoneDirectoryService.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeePhoneDirectoryService.Controllers
{
    [Produces("application/json")]
    [Route("api/Listings")]
    public class ListingsController : Controller
    {
        private readonly IPhoneDirectoryService phoneDirectoryService;
        public ListingsController(IPhoneDirectoryService _phoneDirectoryService)
        {
            phoneDirectoryService = _phoneDirectoryService;
        }
        // GET: api/Listings
        [HttpGet]
        public IEnumerable<PhoneDirectoryEmployeeEntry> Get()
        {
            return phoneDirectoryService.Get();
        }

        // GET: api/Listings/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Listings
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Listings/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
