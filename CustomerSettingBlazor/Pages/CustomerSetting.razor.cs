using CustomerSettingBlazor.Models;
using CustomerSettingBlazor.Service;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSettingBlazor.Pages
{
    public partial class CustomerSetting
    {
        [Inject] public ICustomerSettingServices service { get; set; }
        public List<CustomerSettingDataModel> CustomerSettingDatas;
        protected override async Task OnInitializedAsync() {
            CustomerSettingDatas = await service.GetAllItem();
        }
        [Inject] NavigationManager navigation{get; set;}
        public async Task EditClick(int id)
        {
            navigation.NavigateTo("/detailscustomer/" + id);
        }
    }
}
