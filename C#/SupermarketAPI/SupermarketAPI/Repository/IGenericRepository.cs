using System.Linq.Expressions;

namespace SupermarketAPI.Repository
{
    //T co the la Customer, Membership, Product.....
    public interface IGenericRepository<T> where T : class
    {
        //Task nghia la ham bat dong bo
        Task<List<T>> GetAll(Expression<Func<T, bool>> expression = null, List<string> includes = null); //Khong bat buoc truyen tham so, mac dinh la null

        Task<T> GetSingle(Expression<Func<T, bool>> expression = null, List<string> includes = null);

        Task Add(T entity);
        Task Delete(int id);
        void Update(T entity);  
    }
}
