namespace AirportApp.Entities
{
    /// <summary>
    /// Статистика по рейсам
    /// </summary>
    public class FlightStatistics
    {
        public int Flights { get; set; }
        public int Passengers { get; set; }
        public int Crew { get; set; }
        public decimal Revenue { get; set; }

        public FlightStatistics(int flights, int passengers, int crew, decimal revenue)
        {
            Flights = flights;
            Passengers = passengers;
            Crew = crew;
            Revenue = revenue;
        }
    }
}