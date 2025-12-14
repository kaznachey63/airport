using Entities;

namespace Services.Contracts
{
    /// <summary>
    /// Сервис управления рейсами с бизнес-логикой
    /// </summary>
    public interface IFlightService
    {
        /// <inheritdoc cref="IFlightStorage.Add"/>
        Task Add(FlightModel flight, CancellationToken cancellationToken = default);

        /// <inheritdoc cref="IFlightStorage.Remove"/>
        Task Remove(FlightModel flight, CancellationToken cancellationToken = default);

        /// <inheritdoc cref="IFlightStorage.Update"/>
        Task Update(FlightModel flight, CancellationToken cancellationToken = default);

        /// <inheritdoc cref="IFlightStorage.GetAll"/>
        Task<ICollection<FlightModel>> GetAll(CancellationToken cancellationToken = default);

        /// <summary>
        /// Рассчитать статистику по рейсам
        /// </summary>
        Task<FlightStatistics> GetStatistics(CancellationToken cancellationToken = default);
    }
}