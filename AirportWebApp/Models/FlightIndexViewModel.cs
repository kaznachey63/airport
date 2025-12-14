using Entities;

namespace AirportWebApp.Models
{
    /// <summary>
    /// Модель представления главной страницы рейсов
    /// </summary>
    public class FlightIndexViewModel
    {
        /// <summary>
        /// Коллекция рейсов для отображения в таблице
        /// </summary>
        public IEnumerable<FlightModel> Flights { get; set; } = Enumerable.Empty<FlightModel>();

        /// <summary>
        /// Агрегированная статистика по рейсам
        /// </summary>
        public FlightStatisticsViewModel Statistics { get; set; } = new();
    }
}