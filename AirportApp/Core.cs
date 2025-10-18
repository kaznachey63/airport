using AirportApp.Models;

namespace AirportApp
{
    /// <summary>
    /// Ядро приложения
    /// </summary>
    internal class Core
    {
        private readonly List<Flight> flights = new();
        private readonly BindingSource bindingSource = new();

        public Core()
        {
            LoadData();
        }

        /// <summary>
        /// Загрузка данных
        /// </summary>
        public BindingSource LoadData()
        {
            flights.Clear(); // очищаем список перед новой загрузкой
            flights.Add(new Flight
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
        /// Отображение данных
        /// </summary>
        public void ShowData(DataGridView table)
        {
            // table.Rows[0].Cells[0].Value = "привет";
        }
    }
}
