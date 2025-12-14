using Entities;
using Repositories.Contracts;

namespace AirportApp.Services
{
    /// <summary>
    /// Хранилище рейсов в оперативной памяти
    /// </summary>
    public class InMemoryFlightStorage : IFlightStorage
    {
        private readonly List<FlightModel> flights = new();

        /// <inheritdoc/>
        public Task Add(FlightModel flight, CancellationToken cancellationToken = default)
        {
            flights.Add(flight);
            return Task.CompletedTask;
        }

        /// <inheritdoc/>
        public Task Remove(FlightModel flight, CancellationToken cancellationToken = default)
        {   
            flights.Remove(flight);
            return Task.CompletedTask;
        }

        /// <inheritdoc/>
        public Task Update(FlightModel flight, CancellationToken cancellationToken = default)
        {
            var index = flights.FindIndex(f => f.Id == flight.Id);
            if (index >= 0)
            {
                flights[index] = flight;
            }
            return Task.CompletedTask;
        }

        /// <inheritdoc/>
        public Task<ICollection<FlightModel>> GetAll(CancellationToken cancellationToken = default)
        {
            return Task.FromResult<ICollection<FlightModel>>(flights);
        }

        /// <inheritdoc/>
        public Task<FlightStatistics> GetStatistics(CancellationToken cancellationToken = default)
        {
            var totalFlights = flights.Count;
            var totalPassengers = flights.Sum(f => f.NumberOfPassengers);
            var totalCrew = flights.Sum(f => f.CrewNumber);

            decimal totalRevenue = 0m;
            foreach (var flight in flights)
            {
                var baseRevenue = flight.NumberOfPassengers * flight.PassengerFee
                                + flight.CrewNumber * flight.CrewFee;
                var serviceFee = baseRevenue * (flight.ServicePercentage / Constants.Constants.MaxPercent);
                totalRevenue += baseRevenue + serviceFee;
            }

            var statistics = new FlightStatistics(totalFlights, totalPassengers, totalCrew, totalRevenue);
            return Task.FromResult(statistics);
        }
    }
}