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
            {
                return StatusCode(500, "Не удалось загрузить статистику рейсов.");
            }

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
            {
                return View(model);
            }

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

        /// <summary>
        /// Редактирование рейса
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> Update(Guid id)
        {
            var flights = await flightService.GetAll();
            var flight = flights.FirstOrDefault(f => f.Id == id);

            if (flight == null)
            {
                return NotFound();
            }

            var model = new FlightEditViewModel
            {
                Id = flight.Id,
                FlightNumber = flight.FlightNumber,
                TypeOfAircraft = flight.TypeOfAircraft,
                ArrivalTime = flight.ArrivalTime,
                NumberOfPassengers = flight.NumberOfPassengers,
                PassengerFee = flight.PassengerFee,
                CrewNumber = flight.CrewNumber,
                CrewFee = flight.CrewFee,
                ServicePercentage = (int)flight.ServicePercentage
            };

            return View(model);
        }

        /// <summary>
        /// Обновление рейса
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> Update(FlightEditViewModel model, CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
                return View(model);

            var flights = await flightService.GetAll();
            var flight = flights.FirstOrDefault(f => f.Id == model.Id);

            if (flight == null)
            {
                return NotFound();
            }

            // Обновляем поля
            flight.FlightNumber = model.FlightNumber;
            flight.TypeOfAircraft = model.TypeOfAircraft!.Value;
            flight.ArrivalTime = model.ArrivalTime;
            flight.NumberOfPassengers = model.NumberOfPassengers;
            flight.PassengerFee = model.PassengerFee;
            flight.CrewNumber = model.CrewNumber;
            flight.CrewFee = model.CrewFee;
            flight.ServicePercentage = model.ServicePercentage;

            await flightService.Update(flight, cancellationToken);

            return RedirectToAction(nameof(Index));
        }

        /// <summary>
        /// Страница подтверждения удаления рейса
        /// </summary>
        /// <param name="id">ID рейса</param>
        public async Task<IActionResult> Remove(Guid id)
        {
            var flight = await flightService.GetById(id);
            if (flight == null)
            {
                return NotFound();
            }

            var model = new FlightEditViewModel
            {
                Id = flight.Id,
                FlightNumber = flight.FlightNumber,
                TypeOfAircraft = flight.TypeOfAircraft,
                ArrivalTime = flight.ArrivalTime,
                NumberOfPassengers = flight.NumberOfPassengers,
                PassengerFee = flight.PassengerFee,
                CrewNumber = flight.CrewNumber,
                CrewFee = flight.CrewFee,
                ServicePercentage = (int)flight.ServicePercentage
            };

            return View(model);
        }

        /// <summary>
        /// Подтверждение удаления рейса
        /// </summary>
        /// <param name="id">ID рейса</param>
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id, CancellationToken cancellationToken)
        {
            var flight = await flightService.GetById(id, cancellationToken);

            if (flight == null)
            {
                return NotFound();
            }

            await flightService.Remove(flight, cancellationToken);

            return RedirectToAction(nameof(Index));
        }

        /// <summary>
        /// Страница конфиденциальности
        /// </summary>
        [HttpGet]
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
