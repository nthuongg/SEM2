using SupperMarketManagement.Data;
using SupperMarketManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupperMarketManagement.Controllers
{
    public class CustomerController
    {
        // context la database
        private DataContext _context = new DataContext();
        public void Add(Customer c)
        {
            _context.Customers.Add(c);
            _context.SaveChanges();
        }

        public void Delete(int id) 
        {
            var customer = _context.Customers.Find(id);
            try
            {
                _context.Customers.Remove(customer);
                _context.SaveChanges();
                Console.WriteLine("Da xoa khach hang thanh cong");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Xoa khach hang that bai: " + ex.Message);
            }

           
        }

        public Customer GetById(int id) 
        {
            var customer = _context.Customers.Find(id);
            return customer;

        }

        public List<Customer> GetAll() 
        {
            return _context.Customers.ToList();
        }

        public void Update(int id, Customer c)
        { 
            var customer = GetById(id);
            if(customer == null)
            {
                Console.WriteLine("This customer does not exist");
            }
            else
            {
                customer.Name = c.Name;
                customer.Phone = c.Phone;
                customer.Email = c.Email;
                _context.SaveChanges();
                Console.WriteLine("Update success");
            }
        }
    }
}
