using AirportApp.Entities;
using AirportApp.Services.Contracts;
using AirportApp.Repositories.Contracts;

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
        public FlightService(IFlightStorage flightStorage)
        {
            storage = flightStorage;
        }

        /// <inheritdoc/>
        public async Task Add(FlightModel flight, CancellationToken cancellationToken = default)
        {
            await storage.Add(flight, cancellationToken);
        }

        /// <inheritdoc/>
        public async Task Remove(FlightModel flight, CancellationToken cancellationToken = default)
        {
            await storage.Remove(flight, cancellationToken);
        }

        /// <inheritdoc/>
        public async Task Update(FlightModel flight, CancellationToken cancellationToken = default)
        {
            await storage.Update(flight, cancellationToken);
        }

        /// <inheritdoc/>
        public async Task<ICollection<FlightModel>> GetAll(CancellationToken cancellationToken = default)
        {
            return await storage.GetAll(cancellationToken);
        }

        /// <inheritdoc/>
        public async Task<FlightStatistics> GetStatistics(CancellationToken cancellationToken = default)
        {
            return await storage.GetStatistics(cancellationToken);
        }
    }
}