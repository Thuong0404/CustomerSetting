using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSettingBlazor.Models
{
    public class CustomerSettingDataModel
    {
        public int Id { get; set; }
        public string AttributeID { get; set; }

        public string AttributeName { get; set; }
        public string Description { get; set; }
        public bool IsDistributorAttribute { get; set; }
        public bool IsCustomerAttribute { get; set; }
        public bool Used { get; set; }
    }
}
