using AirportApp.Forms;
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
        private readonly MainForm mainForm;

        public Core(MainForm MF)
        {
            mainForm = MF;
        }

        // -------------- MainForm ---------------------------------------------
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
                AddData(addForm.CurrentFlight);
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
                RefreshData(editForm.CurrentFlight);
            }
        }

        /// <summary>
        /// Обработчик кнопки удалить
        /// </summary>
        /// <param name="flight">Выбранный рейс</param>
        public void DeleteButtonHandler(FlightModel flight)
        {
            var target = flights.FirstOrDefault(x => x.Id == flight.Id);
            var rightTODelete = MessageBox.Show("Точно удалить рейс №" + target!.FlightNumber + "?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rightTODelete == DialogResult.Yes)
            {
                flights.Remove(target);
                SetTable();
            }
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
                SetTable();
            }
        }

        /// <summary>
        /// Добавление данных (строки \ рейса)
        /// </summary>
        /// <param name="currentFlight">Выбранный рейс</param>
        public void AddData(FlightModel currentFlight)
        {
            flights.Add(currentFlight);
            SetTable();
        }
        // -------------------------------------------------s

        // -------------- private ----------------------------
        private void SetStatistics()
        {
            mainForm.NumberOFFlights.Text = $"Количество рейсов: {flights.Count}";
            mainForm.NumberOFPassengers.Text = $"Количество пассажиров: {flights.Sum(f => f.NumberOFPassengers)}";
            mainForm.CrewNumber.Text = $"Количество экипажа: {flights.Sum(c => c.CrewNumber)}";
            mainForm.TotalRevenue.Text = $"Общая выручка: {flights.Sum(r => r.Revenue)}";
        }

        private void SetTable()
        {
            bindingSource.ResetBindings(false);
            SetStatistics();
        }
        // ----------------------------------------------------
    }
}
