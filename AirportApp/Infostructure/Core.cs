using System.ComponentModel;
using AirportApp.Forms;
using AirportApp.Entities;
using AirportApp.Services;
using AirportApp.Services.Contracts;

namespace AirportApp.Infostructure
{
    /// <summary>
    /// Ядро приложения
    /// </summary>
    public class Core
    {
        private readonly IFlightService flightService;
        private readonly BindingSource bindingSource = new();
        private readonly MainForm mainForm;
        private BindingList<FlightModel> flights = new(); // Ключевое изменение!

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
            flights = new BindingList<FlightModel>(flights.ToList());
            bindingSource.DataSource = flights;
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
                LoadData();
            }
        }

        /// <summary>
        /// Обработчик кнопки изменить
        /// </summary>
        public void EditButtonHandler(FlightModel flight)
        {
            using var editForm = new FlightForm(flight.Clone());
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                flightService.Update(editForm.CurrentFlight).Wait();
                LoadData();
            }
        }

        /// <summary>
        /// Обработчик кнопки удалить
        /// </summary>
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
                LoadData();
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
    }
}