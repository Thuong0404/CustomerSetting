#pragma checksum "D:\Thuctap_Solution\Demo\WebAPI\CustomerSettingBlazor\Pages\DetailsCustomerSetting.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a2d589d83411e24c29efdffef9a861042e76aa2"
// <auto-generated/>
#pragma warning disable 1591
namespace CustomerSettingBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Thuctap_Solution\Demo\WebAPI\CustomerSettingBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Thuctap_Solution\Demo\WebAPI\CustomerSettingBlazor\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Thuctap_Solution\Demo\WebAPI\CustomerSettingBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Thuctap_Solution\Demo\WebAPI\CustomerSettingBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Thuctap_Solution\Demo\WebAPI\CustomerSettingBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Thuctap_Solution\Demo\WebAPI\CustomerSettingBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Thuctap_Solution\Demo\WebAPI\CustomerSettingBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Thuctap_Solution\Demo\WebAPI\CustomerSettingBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Thuctap_Solution\Demo\WebAPI\CustomerSettingBlazor\_Imports.razor"
using CustomerSettingBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Thuctap_Solution\Demo\WebAPI\CustomerSettingBlazor\_Imports.razor"
using CustomerSettingBlazor.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/detailscustomer/{customerid:int}")]
    public partial class DetailsCustomerSetting : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 b-hgrugcjl5u>EditCustomerSetting</h3>\r\n\r\n    ");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "b-hgrugcjl5u");
            __builder.OpenElement(3, "tr");
            __builder.AddAttribute(4, "b-hgrugcjl5u");
            __builder.AddMarkupContent(5, "<td b-hgrugcjl5u>AttributeID</td>\r\n            ");
            __builder.OpenElement(6, "td");
            __builder.AddAttribute(7, "b-hgrugcjl5u");
#nullable restore
#line 7 "D:\Thuctap_Solution\Demo\WebAPI\CustomerSettingBlazor\Pages\DetailsCustomerSetting.razor"
__builder.AddContent(8, DataModel.AttributeID);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "tr");
            __builder.AddAttribute(11, "b-hgrugcjl5u");
            __builder.AddMarkupContent(12, "<td b-hgrugcjl5u>AttributeName</td>\r\n            ");
            __builder.OpenElement(13, "td");
            __builder.AddAttribute(14, "b-hgrugcjl5u");
#nullable restore
#line 11 "D:\Thuctap_Solution\Demo\WebAPI\CustomerSettingBlazor\Pages\DetailsCustomerSetting.razor"
__builder.AddContent(15, DataModel.AttributeName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "tr");
            __builder.AddAttribute(18, "b-hgrugcjl5u");
            __builder.AddMarkupContent(19, "<td b-hgrugcjl5u>Description</td>\r\n            ");
            __builder.OpenElement(20, "td");
            __builder.AddAttribute(21, "b-hgrugcjl5u");
#nullable restore
#line 15 "D:\Thuctap_Solution\Demo\WebAPI\CustomerSettingBlazor\Pages\DetailsCustomerSetting.razor"
__builder.AddContent(22, DataModel.Description);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "tr");
            __builder.AddAttribute(25, "b-hgrugcjl5u");
            __builder.AddMarkupContent(26, "<td b-hgrugcjl5u>IsDistributorAttribute</td>\r\n            ");
            __builder.OpenElement(27, "td");
            __builder.AddAttribute(28, "b-hgrugcjl5u");
#nullable restore
#line 19 "D:\Thuctap_Solution\Demo\WebAPI\CustomerSettingBlazor\Pages\DetailsCustomerSetting.razor"
__builder.AddContent(29, DataModel.IsDistributorAttribute);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.OpenElement(31, "tr");
            __builder.AddAttribute(32, "b-hgrugcjl5u");
            __builder.AddMarkupContent(33, "<td b-hgrugcjl5u>IsCustomerAttribute</td>\r\n            ");
            __builder.OpenElement(34, "td");
            __builder.AddAttribute(35, "b-hgrugcjl5u");
#nullable restore
#line 23 "D:\Thuctap_Solution\Demo\WebAPI\CustomerSettingBlazor\Pages\DetailsCustomerSetting.razor"
__builder.AddContent(36, DataModel.IsCustomerAttribute);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.OpenElement(38, "tr");
            __builder.AddAttribute(39, "b-hgrugcjl5u");
            __builder.AddMarkupContent(40, "<td b-hgrugcjl5u>Used</td>\r\n            ");
            __builder.OpenElement(41, "td");
            __builder.AddAttribute(42, "b-hgrugcjl5u");
#nullable restore
#line 27 "D:\Thuctap_Solution\Demo\WebAPI\CustomerSettingBlazor\Pages\DetailsCustomerSetting.razor"
__builder.AddContent(43, DataModel.Used);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
