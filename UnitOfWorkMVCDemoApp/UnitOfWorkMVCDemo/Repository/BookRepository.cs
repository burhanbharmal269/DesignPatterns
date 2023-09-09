using Microsoft.EntityFrameworkCore;
using UnitOfWorkMVCDemo.Models;

namespace UnitOfWorkMVCDemo.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly AppDbContext _context;
        public BookRepository(AppDbContext context)
        {
            _context = context;
        }
        public Book GetById(int id)
        {
            return _context.BooksTable.Find(id);
        }

        public IEnumerable<Book> GetAll()
        {
            return _context.BooksTable.ToList();
        }
    }
}
