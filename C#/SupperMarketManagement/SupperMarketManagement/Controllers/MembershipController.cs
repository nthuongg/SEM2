using SupperMarketManagement.Data;
using SupperMarketManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupperMarketManagement.Controllers
{
    public class MembershipController
    {
        private DataContext _context = new DataContext();
        public void Add(Membership mem)
        {
            _context.Memberships.Add(mem);
            _context.SaveChanges();
        }

        public Membership GetById(int id)
        {
            var membership = _context.Memberships.Find(id);
            return membership;
        }

        public List<Membership> GetAll()
        {
            return _context.Memberships.ToList();
        }

        public void Delete(int id)
        {
            var membership = GetById(id);
            try
            {
                _context.Memberships.Remove(membership);
                _context.SaveChanges();
                Console.WriteLine("Xoa thanh cong");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Khong ton tai" + ex.Message);
            }
          
        }
        public void Update(int id, Membership mem)
        {
            var membership = GetById(id);
            if (membership != null)
            {
                membership.Name = mem.Name;
                _context.SaveChanges();
                Console.WriteLine("update thanh conng");
            }
            Console.WriteLine("membership khong ton tai");
        }
    }
}
