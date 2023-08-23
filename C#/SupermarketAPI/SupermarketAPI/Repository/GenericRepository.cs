using Microsoft.EntityFrameworkCore;
using SupermarketAPI.Data;
using System.Linq.Expressions;

namespace SupermarketAPI.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DataContext _context;
        private readonly DbSet<T> _table;

        public GenericRepository(DataContext context)
        {
            _context = context;
            _table = _context.Set<T>();
        }
        public async Task Add(T entity)
        {
            await _table.AddAsync(entity);
     
        }

        public async Task Delete(int id)
        {
            // Tim ham de xoa theo id
            var result = await _table.FindAsync(id);
            _table.Remove(result);
        }

        public async Task<List<T>> GetAll(Expression<Func<T, bool>> expression = null, List<string> includes = null)
        {
            // Luu bang vao bien query
            IQueryable<T> query = _table;

            //expression: c => c.MembershipId = 2: xuat ra tat ca khach hang co MembershipId = 2
            if (expression != null)
            {
                query = query.Where(expression);
            }

            // includes: "membership" bao gom ca thong tin ve hang thaanh vien cua khach hang
            if (includes != null)
            {
                foreach (var include in includes)
                {
                    query = query.Include(include);
                }
            }

            return query.AsNoTracking().ToList(); //AsNotracking: chir duoc doc, khong dc thay doi thong tin
            
        }

        public async Task<T> GetSingle(Expression<Func<T, bool>> expression = null, List<string> includes = null)
        {
            IQueryable<T> query = _table;

            if(includes != null)
            {
                foreach(var include in includes)
                {
                    query = query.Include(include);
                }
            }

            return await query.AsNoTracking().FirstOrDefaultAsync(expression);
        }

        public void Update(T entity)
        {
            // Danh dau doi tuong can updete
            _table.Attach(entity);

            // tien hanh update
            _context.Entry(entity).State = EntityState.Modified;    
        }
    }
}
