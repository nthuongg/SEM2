using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class ProductController
    {
        private List<Product> _products = new List<Product> (); 
        
        public void AddNewProduct(Product p)
        {
			try
			{
                            
                 _products.Add(p);
                 Console.WriteLine("Add product success !");
                
            }
			catch (Exception ex)
			{
				Console.WriteLine("Add product failed !" + ex.Message);

			}
        }


        public void DisplayProducts()
        {
            Console.WriteLine(string.Format("{0,-20}{1,-20}{2,-20}", "Product ID", "Product Name", "Price"));
            foreach (Product p in _products)
            {
                Console.WriteLine(string.Format("{0,-20}{1,-20}{2,-20}", p.Id, p.Name, p.Price));
            }
            
        }

        public Product GetById (string id)
        {
            var product = _products.FirstOrDefault(product => product.Id == id);
            return product;

        }

        public void DeleteProduct(string id)
        {
            var product = GetById(id);  
            try
            {
                _products.Remove(product);
                Console.WriteLine("Delete success !");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Datete failed !" + ex.Message);
            }
        }
    }
}
