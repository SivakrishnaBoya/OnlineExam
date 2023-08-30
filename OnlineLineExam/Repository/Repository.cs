using Microsoft.EntityFrameworkCore;
using OnlineLineExam.Models;
using System.Linq.Expressions;

namespace OnlineLineExam.Repository
{
    public class Repository<T> : IDisposable, IGenericRepository<T> where T : class
    {
        internal DbSet<T> DbSet;
        private readonly OnlineDbContext _Context = null;
        public Repository(DbSet<T> Dbset,OnlineDbContext dbContext)
        {
           
            _Context = dbContext;
            this.DbSet = DbSet;
        }
      public T GetById(object Id)
        {
           return DbSet.Find(Id);

            throw new NotImplementedException();
        }
        public void Add(T entity)
        {
            DbSet.Add(entity);
        }

        public void Delete(T entityToDelete)
        {

            if (_Context.Entry(entityToDelete).State == EntityState.Detached)
            {
                DbSet.Attach(entityToDelete);
            }
            DbSet.Remove(entityToDelete);
            
        }

        public async Task<T> DeleteAsync(T entityToDelete)
        {
            if (_Context.Entry(entityToDelete).State == EntityState.Detached)
            {
                DbSet.Attach(entityToDelete);
            }
            DbSet.Remove(entityToDelete);
            return entityToDelete;
        }

        public void DeleteById(object Id)
        {
          var i=  DbSet.Find(Id);
            Delete(i);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private bool disposed = false;
        public void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if(disposing)
                {
                    _Context.Dispose();
                }
            }
            this.disposed=true;
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "")
        {
            IQueryable<T> query = DbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            foreach(var includeproperty in includeProperties.Split( new char [] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeproperty);
            }
            if(orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
            throw new NotImplementedException();
        }

        public async Task<T> GetByIdAsync(object id)
        {
            return await DbSet.FindAsync(id);

            throw new NotImplementedException();
        }

        public async Task<T> AddAsync(T entityToInsert)
        {
            DbSet.Add(entityToInsert);
            return entityToInsert;
        }

        public void Update(T entityToUpdate)
        {
            DbSet.Attach(entityToUpdate);
            _Context.Entry(entityToUpdate).State = EntityState.Modified;
        }

        public async Task<T> UpdateAsync(T entityToUpdate)
        {
            DbSet.Attach(entityToUpdate);
            _Context.Entry(entityToUpdate).State = EntityState.Modified;
            return entityToUpdate;
        }
    }
}
