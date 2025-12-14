using AirportWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AirportWebApp.Controllers
{
    /// <summary>
    /// Контроллер главной страницы и операций с рейсами
    /// </summary>
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        /// <summary>
        /// Конструктор с логгером
        /// </summary>
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Главная страница со списком рейсов
        /// </summary>
        public IActionResult Index()
        {
            return View(new FlightIndexViewModel());
        }

        /// <summary>
        /// Страница добавления рейса
        /// </summary>
        public IActionResult Add()
        {
            return View("Add", new FlightEditViewModel());
        }

        /// <summary>
        /// Страница редактирования рейса
        /// </summary>
        public IActionResult Update()
        {
            return View();
        }

        /// <summary>
        /// Страница удаления рейса
        /// </summary>
        public IActionResult Remove()
        {
            return View();
        }

        /// <summary>
        /// Страница конфиденциальности
        /// </summary>
        public IActionResult Privacy()
        {
            return View();
        }

        /// <summary>
        /// Страница ошибки
        /// </summary>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}