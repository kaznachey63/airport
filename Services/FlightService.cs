using Entities;
using Services.Contracts;
using Repositories.Contracts;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace Services
{
    /// <summary>
    /// Сервис по работе с рейсами
    /// </summary>
    public class FlightService : IFlightService
    {
        private readonly IFlightStorage storage;
        private readonly ILogger logger;

        /// <summary>
        /// Инициализировать новый экземпляр <see cref="FlightService"/>
        /// </summary>
        public FlightService(IFlightStorage flightStorage, ILoggerFactory loggerFactory)
        {
            storage = flightStorage;
            logger = loggerFactory.CreateLogger(nameof(FlightService));
        }

        /// <inheritdoc/>
        public async Task Add(FlightModel flight, CancellationToken cancellationToken = default)
        {
            var stopwatch = Stopwatch.StartNew();
            try
            {
                await storage.Add(flight, cancellationToken);
            }
            finally
            {
                stopwatch.Stop();
                logger.LogInformation("Метод {MethodName} завершен за {DurationSeconds:F3} с", nameof(Add), stopwatch.Elapsed.TotalSeconds);
            }
        }

        /// <inheritdoc/>
        public async Task Remove(FlightModel flight, CancellationToken cancellationToken = default)
        {
            var stopwatch = Stopwatch.StartNew();
            try
            {
                await storage.Remove(flight, cancellationToken);
            }
            finally
            {
                stopwatch.Stop();
                logger.LogInformation("Метод {MethodName} завершен за {DurationSeconds:F3} с", nameof(Remove), stopwatch.Elapsed.TotalSeconds);
            }
        }

        /// <inheritdoc/>
        public async Task Update(FlightModel flight, CancellationToken cancellationToken = default)
        {
            var stopwatch = Stopwatch.StartNew();
            try
            {
                await storage.Update(flight, cancellationToken);
            }
            finally
            {
                stopwatch.Stop();
                logger.LogInformation("Метод {MethodName} завершен за {DurationSeconds:F3} с", nameof(Update), stopwatch.Elapsed.TotalSeconds);
            }
        }

        /// <inheritdoc/>
        public async Task<ICollection<FlightModel>> GetAll(CancellationToken cancellationToken = default)
        {
            var stopwatch = Stopwatch.StartNew();
            try
            {
                return await storage.GetAll(cancellationToken);
            }
            finally
            {
                stopwatch.Stop();
                logger.LogInformation("Метод {MethodName} завершён за {DurationSeconds:F3} с", nameof(GetAll), stopwatch.ElapsedMilliseconds);
            }
        }
        
        /// <inheritdoc/>
        public async Task<FlightModel?> GetById(Guid id, CancellationToken cancellationToken = default)
        {
            var flights = await storage.GetAll(cancellationToken);
            return flights.FirstOrDefault(f => f.Id == id);
        }

        /// <inheritdoc/>
        public async Task<FlightStatistics> GetStatistics(CancellationToken cancellationToken = default)
        {
            var stopwatch = Stopwatch.StartNew();
            try
            {
                return await storage.GetStatistics(cancellationToken);
            }
            finally
            {
                stopwatch.Stop();
                logger.LogInformation("Метод {MethodName} завершён за {DurationSeconds:F3} с", nameof(GetStatistics), stopwatch.ElapsedMilliseconds);
            }
        }
    }
}