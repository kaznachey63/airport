using Entities;

namespace Repositories.Contracts
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

        /// <summary>
        /// Получить рейс по ID
        /// </summary>
        Task<FlightModel?> GetById(Guid id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Получить статистику
        /// </summary>
        Task<FlightStatistics> GetStatistics(CancellationToken cancellationToken = default);
    }
}