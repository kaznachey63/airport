namespace AirportApp.Models
{
    /// <summary>
    /// Данные о рейсе
    /// </summary>
    internal class Flight
    {
        /// <summary>
        /// Идентификатор рейса
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Номер рейса
        /// </summary>
        public int FlightNumber { get; set; }

        /// <inheritdoc cref="Models.TypeOFAircraft" />
        public TypeOFAircraft TypeOFAircraft { get; set; }

        /// <summary>
        /// Время прибытия
        /// </summary>
        public DateTime ArrivalTime { get; set; }

        /// <summary>
        /// Количество пассажаиров
        /// </summary>
        public int NumberOFPassengers { get; set; }

        /// <summary>
        /// Сбор на пассажира
        /// </summary>
        public decimal PassengerFee { get; set; }

        /// <summary>
        /// Количество экипажа
        /// </summary>
        public int CrewNumber { get; set; }

        /// <summary>
        /// Сбор на экипаж
        /// </summary>
        public decimal CrewFee { get; set; }

        /// <summary>
        /// Процент надбавки за обслуживание
        /// </summary>
        public decimal ServicePercentage { get; set; }

        /// <summary>
        /// Выручка
        /// </summary>
        public decimal Revenue => (NumberOFPassengers * PassengerFee + CrewNumber * CrewFee) * (1 + ServicePercentage / 100);
    }
}