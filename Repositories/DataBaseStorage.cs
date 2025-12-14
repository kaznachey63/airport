using Microsoft.EntityFrameworkCore;
using Entities;
using Repositories.Contracts;
using DataBase;

namespace Repositories
{
    /// <summary>
    /// Хранилище рейсов в БД
    /// </summary>
    public class DataBaseStorage(DataBaseContext ctx) : IFlightStorage
    {
        /// <inheritdoc/>
        public async Task Add(FlightModel flight, CancellationToken cancellationToken = default)
        {
            ctx.Add(flight);
            await ctx.SaveChangesAsync(cancellationToken);
        }

        /// <inheritdoc/>
        public async Task Remove(FlightModel flight, CancellationToken cancellationToken = default)
        {
            ctx.Remove(flight);
            await ctx.SaveChangesAsync(cancellationToken);
        }

        /// <inheritdoc/>
        public async Task Update(FlightModel flight, CancellationToken cancellationToken = default)
        {
            ctx.Update(flight);
            await ctx.SaveChangesAsync(cancellationToken);
        }

        /// <inheritdoc/>
        public async Task<ICollection<FlightModel>> GetAll(CancellationToken cancellationToken = default)
        {
            return await ctx.Set<FlightModel>().ToListAsync(cancellationToken);
        }

        /// <inheritdoc/>
        public async Task<FlightModel?> GetById(Guid id, CancellationToken cancellationToken = default)
        {
            return await ctx.Set<FlightModel>()
                .FirstOrDefaultAsync(f => f.Id == id, cancellationToken);
        }

        /// <inheritdoc/>
        public async Task<FlightStatistics> GetStatistics(CancellationToken cancellationToken = default)
        {
            var flights = await ctx.Set<FlightModel>().ToListAsync(cancellationToken);

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

            var statistics = new FlightStatistics(totalFlights, totalPassengers, totalCrew, totalRevenue);
            return statistics;
        }
    }
}