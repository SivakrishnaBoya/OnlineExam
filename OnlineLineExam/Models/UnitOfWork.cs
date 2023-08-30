using Microsoft.EntityFrameworkCore;
using OnlineLineExam.Repository;

namespace OnlineLineExam.Models
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        public readonly OnlineDbContext _context;
        public UnitOfWork( OnlineDbContext _dbContext)
        {
            _context = _dbContext;
        }
       

        public IGenericRepository<T> GenericRepository<T>() where T : class
        {
            IGenericRepository<T> repository = (IGenericRepository<T>)_context.Set<T>();
            return repository;
        }

        public void Save()
        {
            _context.SaveChanges();
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
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

    }
}
