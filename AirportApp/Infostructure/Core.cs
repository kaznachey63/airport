using AirportApp.Entities;
using AirportApp.Services;
using AirportApp.Services.Contracts;

namespace AirportApp
{
    /// <summary>
    /// Ядро приложения
    /// </summary>
    internal class Core
    {
        private readonly IFlightService flightService;
        private readonly BindingSource bindingSource = new();
        private readonly MainForm mainForm;

        public Core(MainForm MainForm)
        {
            mainForm = MainForm;
            flightService = new FlightService(new InMemoryFlightStorage());
        }

        // -------------- MainForm ---------------------------------------------
        /// <summary>
        /// Загрузка данных
        /// </summary>
        public BindingSource LoadData()
        {
            var flights = flightService.GetAll().Result; 
            bindingSource.DataSource = flights.ToList();
            SetStatistics();
            return bindingSource;
        }

        /// <summary>
        /// Обработчик кнопки добавить
        /// </summary>
        public void AddButtonHandler()
        {
            using var addForm = new FlightForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                flightService.Add(addForm.CurrentFlight).Wait();
                SetTable();
            }
        }

        /// <summary>
        /// Обработчик кнопки изменить
        /// </summary>
        /// <param name="flight">Выбранный рейс</param>
        public void EditButtonHandler(FlightModel flight)
        {
            using var editForm = new FlightForm(flight);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                flightService.Update(editForm.CurrentFlight).Wait();
                SetTable();
            }
        }

        /// <summary>
        /// Обработчик кнопки удалить
        /// </summary>
        /// <param name="flight">Выбранный рейс</param>
        public void DeleteButtonHandler(FlightModel flight)
        {
            var confirm = MessageBox.Show(
                $"Точно удалить рейс №{flight.FlightNumber}?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                flightService.Remove(flight).Wait();
                SetTable();
            }
        }

        // -------------- private ----------------------------
        private void SetStatistics()
        {
            var statistics = flightService.GetStatistics().Result;

            mainForm.NumberOfFlights.Text = $"Количество рейсов: {statistics.Flights}";
            mainForm.NumberOfPassengers.Text = $"Количество пассажиров: {statistics.Passengers}";
            mainForm.CrewNumber.Text = $"Количество экипажа: {statistics.Crew}";
            mainForm.TotalRevenue.Text = $"Общая выручка: {statistics.Revenue:C}";
        }

        private void SetTable()
        {
            bindingSource.ResetBindings(false);
            SetStatistics();
        }
    }
}