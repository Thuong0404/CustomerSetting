using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Repository
{
    public class CustomerSettingContext :DbContext
    {
        public CustomerSettingContext(DbContextOptions options) :base(options){ }
        public DbSet<CustomerSettingData> customer { get; set; }
        
    }
}
