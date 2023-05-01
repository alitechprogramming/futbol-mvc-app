using AplicacionMVC.Models;
using AplicacionMVC.Models.Entities;
using AplicacionMVC.Models.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AplicacionMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepository<Notice> _noticeRepository;

        public HomeController(ILogger<HomeController> logger, IRepository<Notice> noticeRepository)
        {
            _logger = logger;
            _noticeRepository = noticeRepository;
        }

        public IActionResult Index()
        {
            var allNotices = _noticeRepository.Get();
            return View();
        }
        
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}