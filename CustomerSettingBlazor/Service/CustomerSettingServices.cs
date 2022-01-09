using CustomerSettingBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CustomerSettingBlazor.Service
{
    public class CustomerSettingServices : ICustomerSettingServices
    {
        public HttpClient _httpClient;
       public CustomerSettingServices(HttpClient httpclient)
        {
            _httpClient = httpclient;
        }

        public async Task<List<CustomerSettingDataModel>> GetAllItem()
        {
            var listCustomer = _httpClient.GetFromJsonAsync<List<CustomerSettingDataModel>>("/api/CustomerSetting");
            return await listCustomer;
        }
        public async Task<CustomerSettingDataModel> Getitem(int id)
        {
            var listitem=_httpClient.GetFromJsonAsync<CustomerSettingDataModel>("/api/CustomerSetting");
            return await listitem;
        }

       
    }
}
