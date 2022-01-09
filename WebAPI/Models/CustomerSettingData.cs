using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    [Table("CustomerSetting")]
    public class CustomerSettingData
    {
        [Key]
        [DatabaseGenerated (DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        public string AttributeID { get; set; }

        public string AttributeName { get; set; }
        public string Description { get; set; }
        public bool IsDistributorAttribute { get; set; }
        public bool IsCustomerAttribute { get; set; }
        public bool Used { get; set; }
    }
}
