using AirportApp.Entities;
using AirportApp.Services.Contracts;

namespace AirportApp.Services
{
    /// <summary>
    /// Сервис по работе с рейсами
    /// </summary>
    public class FlightService : IFlightService
    {
        private readonly IFlightStorage storage;

        /// <summary>
        /// Инициализировать новый экземпляр <see cref="FlightService"/>
        /// </summary>
        public FlightService(IFlightStorage ifstorage)
        {
            storage = ifstorage;
        }

        /// <inheritdoc/>
        public async Task Add(FlightModel flight)
        {
            await storage.Add(flight);
        }

        /// <inheritdoc/>
        public async Task Remove(FlightModel flight)
        {
            await storage.Remove(flight);
        }

        /// <inheritdoc/>
        public async Task Update(FlightModel flight)
        {
            await storage.Update(flight);
        }

        /// <inheritdoc/>
        public async Task<ICollection<FlightModel>> GetAll()
        {
            return await storage.GetAll();
        }
        
        /// <inheritdoc/>
        public async Task<(int Flights, int Passengers, int Crew, decimal Revenue)> GetStatistics()
        {
            var flights = await storage.GetAll();

            var totalFlights = flights.Count;
            var totalPassengers = flights.Sum(f => f.NumberOfPassengers);
            var totalCrew = flights.Sum(f => f.CrewNumber);

            decimal totalRevenue = 0m;
            foreach (var flight in flights)
            {
                var baseRevenue = flight.NumberOfPassengers * flight.PassengerFee + flight.CrewNumber * flight.CrewFee;
                var serviceFee = baseRevenue * (flight.ServicePercentage / Constants.Constants.MaxPercent);
                totalRevenue += baseRevenue + serviceFee;
            }

            return (totalFlights, totalPassengers, totalCrew, totalRevenue);
        }
    }
}