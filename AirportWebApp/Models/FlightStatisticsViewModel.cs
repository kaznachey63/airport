namespace AirportWebApp.Models
{
    /// <summary>
    /// Агрегированная статистика по рейсам
    /// </summary>
    public class FlightStatisticsViewModel
    {
        /// <summary>
        /// Общее количество рейсов
        /// </summary>
        public int TotalFlights { get; set; }

        /// <summary>
        /// Общее количество пассажиров
        /// </summary>
        public int TotalPassengers { get; set; }

        /// <summary>
        /// Общее количество членов экипажа
        /// </summary>
        public int TotalCrew { get; set; }

        /// <summary>
        /// Общая сумма сборов по всем рейсам
        /// </summary>
        public decimal TotalRevenue { get; set; }
    }
}