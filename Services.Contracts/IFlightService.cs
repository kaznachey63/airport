using AirportApp.Entities;

namespace AirportApp.Services.Contracts
{

    /// <summary>
    /// Сервис управления рейсами с бизнес-логикой
    /// </summary>
    public interface IFlightService
    {
        /// <inheritdoc cref="IFlightStorage.Add"/>
        Task Add(FlightModel flight);

        /// <inheritdoc cref="IFlightStorage.Remove"/>
        Task Remove(FlightModel flight);

        /// <inheritdoc cref="IFlightStorage.Update"/>
        Task Update(FlightModel flight);

        /// <inheritdoc cref="IFlightStorage.GetAll"/>
        Task<ICollection<FlightModel>> GetAll();

        /// <summary>
        /// Рассчитать статистику по рейсам
        /// </summary>
        Task<(int Flights, int Passengers, int Crew, decimal Revenue)> GetStatistics();
    }
}