using UnitOfWorkMVCDemo.Models;
using UnitOfWorkMVCDemo.Repository;

namespace UnitOfWorkMVCDemo.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Book> BookRepository { get; }
        void SaveChanges();
    }
}
