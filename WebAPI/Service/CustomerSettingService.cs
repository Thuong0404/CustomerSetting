using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;
using WebAPI.Repository;

namespace WebAPI.Service
{
    public class CustomerSettingService : ICustomerSettingService
    {
        private readonly CustomerSettingContext _context;
        public CustomerSettingService(CustomerSettingContext context)
        {
            _context = context;
        }

        public async Task<CustomerSettingData> CreateCustomer(CustomerSettingData newcustomer)
        {
            var newitem = _context.customer.SingleOrDefault(c => c.Id.Equals(newcustomer.Id));
            if (newitem == null)
            {
                _context.customer.Add(newcustomer);
                _context.SaveChanges();
                return newcustomer;
            }
            else { return null; 
            }
        }

        public async Task<CustomerSettingData> DeleteCustomer(int id)
        {
            var deleteitem = _context.customer.SingleOrDefault(c => c.Id.Equals(id));
            
                _context.Remove(deleteitem);
                _context.SaveChanges();
            return deleteitem;

            
        }

        public async Task<CustomerSettingData> EditCustomer(CustomerSettingData editcustomer)
        {
            var editcustom = _context.customer.SingleOrDefault(c => c.Id.Equals(editcustomer.Id));
            if (editcustom != null)
            {
                editcustom.AttributeID = editcustomer.AttributeID;
                editcustom.AttributeName = editcustomer.AttributeName;
                editcustom.Description = editcustomer.Description;
                editcustom.IsCustomerAttribute = editcustomer.IsCustomerAttribute;
                editcustom.IsDistributorAttribute = editcustomer.IsDistributorAttribute;
                editcustom.Used = editcustomer.Used;
                _context.SaveChanges();
                return editcustomer;
            }
            else { return null; }
        }

        public async Task<List<CustomerSettingData>> GetAll()
        {
            return _context.customer.ToList();
        }

        public async Task<CustomerSettingData> Getitem(int id)
        {
            var itemcustomer = _context.customer.SingleOrDefault(c => c.Id.Equals(id));
            if (itemcustomer != null)
            {
                return itemcustomer;
            }
            else
            {
                return null;
            }
        }

       
    }
}
