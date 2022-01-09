using CustomerSettingBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSettingBlazor.Service
{
    public interface ICustomerSettingServices
    {
        Task<List<CustomerSettingDataModel>> GetAllItem();
        Task<CustomerSettingDataModel> Getitem(int id);
        
    }
}
