using System.Linq;
using System.Collections.Generic;
using System;
using System.Text;
namespace OnlineLineExam.Repository
 
{
    public interface IUnitOfWork
    {
        IGenericRepository<T> GenericRepository<T>() where T : class;
        void Save();
    }
}
