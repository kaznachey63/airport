using AirportApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportApp.Services
{
    public class InMemoryStorage
    {
        private readonly List<FlightModel> flights = new();

        public InMemoryStorage()
        {
            LoadData();
        }

        private Task LoadData()
        {
            flights.Clear(); // очищаем список перед новой загрузкой
            flights.Add(new FlightModel
            {
                Id = Guid.NewGuid(),
                FlightNumber = 504,
                TypeOfAircraft = TypeOfAircraft.Boieng,
                ArrivalTime = DateTime.Now,
                NumberOfPassengers = 100,
                PassengerFee = 12000m,
                CrewNumber = 5,
                CrewFee = 2000m,
                ServicePercentage = 5m
            });

            return Task.CompletedTask;
        }

        public Task AddData(FlightModel currentFlight)
        {
            flights.Add(currentFlight);
            // SetTable();
            return Task.CompletedTask;
        }

        public Task EditData(FlightModel currentFlight) 
        {
            // RefreshData(editForm.CurrentFlight);
            return Task.CompletedTask;
        }

        public Task RemoveData(FlightModel currentFlight)
        {
            //var target = flights.FirstOrDefault(x => x.Id == flight.Id);
            //var rightToDelete = MessageBox.Show("Точно удалить рейс №" + target!.FlightNumber + "?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (rightToDelete == DialogResult.Yes)
            //{
            //    flights.Remove(target);
            //    SetTable();
            //}
            return Task.CompletedTask;
        }

        public Task RefreshData(FlightModel currentFlight)
        {
            var target = flights.FirstOrDefault(x => x.Id == currentFlight.Id);
            if (target != null)
            {
                target.FlightNumber = currentFlight.FlightNumber;
                target.TypeOfAircraft = currentFlight.TypeOfAircraft;
                target.ArrivalTime = currentFlight.ArrivalTime;
                target.NumberOfPassengers = currentFlight.NumberOfPassengers;
                target.PassengerFee = currentFlight.PassengerFee;
                target.CrewNumber = currentFlight.CrewNumber;
                target.CrewFee = currentFlight.CrewFee;
                target.ServicePercentage = currentFlight.ServicePercentage;
                // SetTable();
                return Task.CompletedTask;
            }
            else
            {
                return Task.CompletedTask;
            }
        }

        private Task SetStatistics()
        {
            //mainForm.NumberOfFlights.Text = $"Количество рейсов: {flights.Count}";
            //mainForm.NumberOfPassengers.Text = $"Количество пассажиров: {flights.Sum(f => f.NumberOfPassengers)}";
            //mainForm.CrewNumber.Text = $"Количество экипажа: {flights.Sum(c => c.CrewNumber)}";

            //var totalRevenue = 0m;
            //foreach (var flight in flights)
            //{
            //    var revenue = (flight.NumberOfPassengers * flight.PassengerFee + flight.CrewNumber * flight.CrewFee) * (Constants.BaseSum + flight.ServicePercentage / Constants.MaxPercent);
            //    totalRevenue += revenue;
            //}
            //mainForm.TotalRevenue.Text = $"Общая выручка: {totalRevenue}";
            return Task.CompletedTask;
        }

        private Task SetTable()
        {
            // bindingSource.ResetBindings(false);
            SetStatistics();
            return Task.CompletedTask;
        }
    }
}
