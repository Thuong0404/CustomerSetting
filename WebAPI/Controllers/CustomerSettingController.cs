using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;
using WebAPI.Service;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerSettingController :ControllerBase
    {
        private readonly ICustomerSettingService _service;
        public CustomerSettingController(ICustomerSettingService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<List<CustomerSettingData>> getAll()
        {
            return await _service.GetAll();
        }
        [HttpGet("/id")]
        public async Task<CustomerSettingData> getitem(int id)
        {
            return await _service.Getitem(id);
        }
        [HttpPost]
        public async Task<CustomerSettingData> creatCustomer(CustomerSettingData newcustomer)
        {
            return await _service.CreateCustomer(newcustomer);
        }
        [HttpPut]
        public async Task<CustomerSettingData> editCustomer(CustomerSettingData editcustomer)
        {
            return await _service.EditCustomer(editcustomer);

        }
        [HttpDelete("/id")]
        public async Task<CustomerSettingData> deleteCustomer(int id)
        {
            return await _service.DeleteCustomer(id);
        }
    }
}
