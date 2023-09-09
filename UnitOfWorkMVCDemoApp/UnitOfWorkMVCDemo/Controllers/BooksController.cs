using Microsoft.AspNetCore.Mvc;
using UnitOfWorkMVCDemo.Repository;
using UnitOfWorkMVCDemo.UnitOfWork;

namespace UnitOfWorkMVCDemo.Controllers
{
    public class BooksController : Controller
    {
        //This Controller is having unit of work implementation
        private readonly IUnitOfWork _unitOfWork;

        //private readonly IBookRepository _bookrepository;
        public BooksController(IBookRepository bookRepository,IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            //_bookrepository = bookRepository;   
        }
        public IActionResult Index()
        {
            var data = _unitOfWork.BookRepository.GetAll();
            //var data = _bookrepository.GetAll();
            return View(data);
        }
    }
}
    