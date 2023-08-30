using System.Linq.Expressions;
using System.Linq;
using System.Collections.Generic;
using System.Text;


namespace OnlineLineExam.Repository

{
    public interface IGenericRepository<T>:IDisposable where T :class
    {
        IEnumerable<T> GetAll(
        Expression<Func<T, bool>> filter = null,
        Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
        string includeProperties = "");
        Task<T> GetByIdAsync(object id);
        Task<T> AddAsync(T entityToInsert);
        Task<T> UpdateAsync(T entityToUpdate);
        Task<T> DeleteAsync(T entityToDelete);
        void Add(T entity);
        void DeleteById(object Id);
        void Update(T entityToUpdate);
        void Delete(T entityToDelete);
        T GetById(object Id);

    }
}
