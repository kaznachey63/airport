using AirportApp.Entities;

namespace AirportApp.Services.Contracts
{

    /// <summary>
    /// Хранилище рейсов для операций CRUD
    /// </summary>
    public interface IFlightStorage
    {
        /// <summary>
        /// Добавить новый рейс
        /// </summary>
        Task Add(FlightModel flight);

        /// <summary>
        /// Удалить существующий рейс
        /// </summary>
        Task Remove(FlightModel flight);

        /// <summary>
        /// Обновить данные рейса
        /// </summary>
        Task Update(FlightModel flight);

        /// <summary>
        /// Получить все рейсы
        /// </summary>
        Task<ICollection<FlightModel>> GetAll();
    }
}