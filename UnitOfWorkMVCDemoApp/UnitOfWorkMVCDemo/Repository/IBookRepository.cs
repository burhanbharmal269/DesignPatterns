using UnitOfWorkMVCDemo.Models;

namespace UnitOfWorkMVCDemo.Repository
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAll();
        Book GetById(int id);
    }
}