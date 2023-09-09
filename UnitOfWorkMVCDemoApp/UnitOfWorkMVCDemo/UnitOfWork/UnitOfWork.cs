using UnitOfWorkMVCDemo.Models;
using UnitOfWorkMVCDemo.Repository;
using UnitOfWorkMVCDemo.UnitOfWork;

namespace UnitOfWorkMVCDemo.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public IGenericRepository<Book> bookRepository;
        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }
        public IGenericRepository<Book> BookRepository
        {
            get
            {
                if(bookRepository == null)
                {
                    bookRepository = new GenericRepository<Book>(_context);
                }
                return bookRepository;
            }
        }

        public void Dispose()
        {
                _context.Dispose(); // Dispose of the DbContext
        }
        public void SaveChanges()
        {
            _context.SaveChanges(); //  Save all the changes
        }
    }

        
    
}
