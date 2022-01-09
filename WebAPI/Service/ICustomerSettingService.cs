using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Service
{
    public interface  ICustomerSettingService
    {
        Task<List<CustomerSettingData>> GetAll();
        Task<CustomerSettingData> Getitem(int id);
        Task<CustomerSettingData> CreateCustomer(CustomerSettingData  newcustomer);
        Task<CustomerSettingData> EditCustomer(CustomerSettingData editcustomer);
        Task<CustomerSettingData> DeleteCustomer(int id);
       

    }
}
