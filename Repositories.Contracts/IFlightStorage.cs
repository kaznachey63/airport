using AirportApp.Entities;

namespace AirportApp.Repositories.Contracts
{
    /// <summary>
    /// Хранилище рейсов для операций CRUD
    /// </summary>
    public interface IFlightStorage
    {
        /// <summary>
        /// Добавить новый рейс
        /// </summary>
        Task Add(FlightModel flight, CancellationToken cancellationToken = default);

        /// <summary>
        /// Удалить существующий рейс
        /// </summary>
        Task Remove(FlightModel flight, CancellationToken cancellationToken = default);

        /// <summary>
        /// Обновить данные рейса
        /// </summary>
        Task Update(FlightModel flight, CancellationToken cancellationToken = default);

        /// <summary>
        /// Получить все рейсы
        /// </summary>
        Task<ICollection<FlightModel>> GetAll(CancellationToken cancellationToken = default);
    }
}