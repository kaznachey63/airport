using AirportApp.Models;

namespace AirportApp
{
    /// <summary>
    /// Ядро приложения
    /// </summary>
    internal class Core
    {
        private readonly List<FlightModel> flights = new();
        private readonly BindingSource bindingSource = new();

        public Core()
        {
        }

        /// <summary>
        /// Загрузка данных
        /// </summary>
        public BindingSource LoadData()
        {
            flights.Clear(); // очищаем список перед новой загрузкой
            flights.Add(new FlightModel
            {
                Id = Guid.NewGuid(),
                FlightNumber = 504,
                TypeOFAircraft = TypeOFAircraft.Boieng,
                ArrivalTime = DateTime.Now,
                NumberOFPassengers = 100,
                PassengerFee = 12000m,
                CrewNumber = 5,
                CrewFee = 2000m,
                ServicePercentage = 5m
            });

            bindingSource!.DataSource = flights;
            return bindingSource;
        }

        /// <summary>
        /// Обновление данных
        /// </summary>
        /// <param name="currentFlight">Измененный рейс (строка)</param>
        public void RefreshData(FlightModel currentFlight)
        {
            var target = flights.FirstOrDefault(x => x.Id == currentFlight.Id);
            if (target != null)
            {
                target.FlightNumber = currentFlight.FlightNumber;
                target.TypeOFAircraft = currentFlight.TypeOFAircraft;
                target.ArrivalTime = currentFlight.ArrivalTime;
                target.NumberOFPassengers = currentFlight.NumberOFPassengers;
                target.PassengerFee = currentFlight.PassengerFee;
                target.CrewNumber = currentFlight.CrewNumber;
                target.CrewFee = currentFlight.CrewFee;
                target.ServicePercentage = currentFlight.ServicePercentage;

                bindingSource.ResetBindings(false);
            }
        }

        /// <summary>
        /// Добавление данных (строки \ рейса)
        /// </summary>
        /// <param name="currentFlight">Выбранный рейс</param>
        public void AddData(FlightModel currentFlight)
        {
            flights.Add(currentFlight);
            bindingSource.ResetBindings(false);
        }
    }
}
