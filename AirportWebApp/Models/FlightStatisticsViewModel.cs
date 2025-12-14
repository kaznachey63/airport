namespace AirportWebApp.Models
{
    /// <summary>
    /// Статистика по рейсам для отображения в представлении
    /// </summary>
    public class FlightStatisticsViewModel
    {
        public int TotalFlights { get; set; }
        public int TotalPassengers { get; set; }
        public int TotalCrew { get; set; }
        public decimal TotalRevenue { get; set; }

        // Конструктор для маппинга из Entities.FlightStatistics
        public FlightStatisticsViewModel(Entities.FlightStatistics stats)
        {
            TotalFlights = stats.Flights;
            TotalPassengers = stats.Passengers;
            TotalCrew = stats.Crew;
            TotalRevenue = stats.Revenue;
        }
    }
}