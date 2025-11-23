using AirportApp.Entities;
using AirportApp.Services.Contracts;

namespace AirportApp.Services
{
    /// <summary>
    /// Хранилище рейсов в оперативной памяти
    /// </summary>
    public class InMemoryFlightStorage : IFlightStorage
    {
        private readonly List<FlightModel> flights;

        public InMemoryFlightStorage()
        {
            flights = new List<FlightModel>
            {
                new FlightModel
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
                }
            };
        }

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
    }
}