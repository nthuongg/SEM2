using SupperMarketManagement.Data;
using SupperMarketManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupperMarketManagement.Controllers
{
    public class OrderController
    {
        private DataContext _context = new DataContext();   
        public void Add(Order o)
        {
            _context.Orders.Add(o);
            _context.SaveChanges();
            Console.WriteLine("Create success !");

        }

        public Order GetById(int id)
        {
            var order = _context.Orders.Find(id);
            return order; 
        }

        public List<Order> GetAll() 
        {
            return _context.Orders.ToList();    
        }

        public void Delete(int id)
        {
            var order = GetById(id);
            try
            {
                _context.Orders.Remove(order);
                _context.SaveChanges();
                Console.WriteLine("Delete success !");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Delete failed " + ex.Message);
            }
        }

        public void Update(int id, Order o)
        {
            var order = GetById(id);
            if(order != null)
            {
                order.DateCreate = o.DateCreate;
                order.TotalAmount = o.TotalAmount;
                _context.SaveChanges();
                Console.WriteLine("Update success !");
            }
            Console.WriteLine("This order does not exist !");
        }
    }
}
