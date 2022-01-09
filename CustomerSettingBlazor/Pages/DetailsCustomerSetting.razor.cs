using CustomerSettingBlazor.Models;
using CustomerSettingBlazor.Service;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSettingBlazor.Pages
{
    public partial class DetailsCustomerSetting
    {
        [Inject] 
        private ICustomerSettingServices services {get; set;}
        private CustomerSettingDataModel DataModel;
        [Parameter]
        public int customerid { get; set; }
        protected override async Task OnInitializedAsync()
        {
            DataModel = await services.Getitem(1);
        }

    }
}
