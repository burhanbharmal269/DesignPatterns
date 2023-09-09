using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UnitOfWorkMVCDemo.Models;
using UnitOfWorkMVCDemo.Repository;

namespace UnitOfWorkMVCDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IGenericRepository<Book> _genericRepository;

        public HomeController(ILogger<HomeController> logger, IGenericRepository<Book> genericRepository)
        {
            _logger = logger;
            _genericRepository = genericRepository;
        }

        public IActionResult Index()
        {
            var data = _genericRepository.GetAll();
            return View(data);
        }

    }
}