using App.DataAccess.Repository.IRepository;
using App.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GamsStation.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;
        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            IEnumerable<Game> gameList = _unitOfWork.Game.GetAll(includeProperties: "Category");
            return View(gameList);
        }

        public IActionResult Details(int gameId)
        {
            Game game = _unitOfWork.Game.Get(u => u.Id == gameId, includeProperties: "Category");
            return View(game);
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
