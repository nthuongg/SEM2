using SupperMarketManagement.Data;
using SupperMarketManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupperMarketManagement.Controllers
{
    public class ProductController
    {
        private DataContext _context = new DataContext();
        public void Add(Product p)
        {
            _context.Products.Add(p);
            _context.SaveChanges();
            Console.WriteLine("Create success !");
        }

        public Product GetById(int id)
        {
            var product = _context.Products.Find(id);
            return product;
        }

        public List<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public void Delete(int id)
        {
            var product = GetById(id);
            try
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
                Console.WriteLine("Delete success !");
            }
            catch (Exception)
            {
                Console.WriteLine("This product does not exist");
            }
        }

        public void Update(int id, Product p)
        {
            var product = GetById(id);
            if(product != null)
            {
                product.Name = p.Name;
                product.Barcode = p.Barcode;
                product.Price = p.Price;
                _context.SaveChanges();
                Console.WriteLine("Update success");
            }
            else
            {
                Console.WriteLine("This product does not exist");
            }
            
        }
    }
}
