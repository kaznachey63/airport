using AirportWebApp.Models;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using System.Diagnostics;

namespace AirportWebApp.Controllers
{
    /// <summary>
    /// Контроллер главной страницы и операций с рейсами
    /// </summary>
    public class HomeController : Controller
    {
        private readonly IFlightService flightService = default!;

        /// <summary>
        /// Конструктор с логгером
        /// </summary>
        public HomeController(IFlightService FlightService)
        {
            flightService = FlightService;
        }

        /// <summary>
        /// Главная страница со списком рейсов
        /// </summary>
        public async Task<IActionResult> Index()
        {
            var flights = await flightService.GetAll();
            var statistics = await flightService.GetStatistics();

            if (statistics == null)
                return StatusCode(500, "Не удалось загрузить статистику рейсов.");

            var statisticsVm = new FlightStatisticsViewModel(statistics);

            var vm = new FlightIndexViewModel
            {
                Flights = flights,
                Statistics = statisticsVm
            };

            return View(vm);
        }

        /// <summary>
        /// Страница добавления рейса
        /// </summary>
        [HttpGet]
        public IActionResult Add()
        {
            return View(new FlightEditViewModel());
        }

        /// <summary>
        /// Добавление рейса
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> Add(FlightEditViewModel model, CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
                return View(model);

            var flight = new FlightModel
            {
                Id = Guid.NewGuid(),
                FlightNumber = model.FlightNumber,
                TypeOfAircraft = model.TypeOfAircraft!.Value,
                ArrivalTime = model.ArrivalTime,
                NumberOfPassengers = model.NumberOfPassengers,
                PassengerFee = model.PassengerFee,
                CrewNumber = model.CrewNumber,
                CrewFee = model.CrewFee,
                ServicePercentage = model.ServicePercentage
            };

            await flightService.Add(flight, cancellationToken);

            return RedirectToAction(nameof(Index));
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
