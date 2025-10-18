namespace AirportApp
{
    /// <summary>
    /// Данные о рейсе
    /// </summary>
    internal class FlightData
    {
        public FlightData()
        {

        }

        /// <summary>
        /// Номер рейса
        /// </summary>
        public int FlightNumber { get; set; }

        /// <summary>
        /// Тип самолета
        /// </summary>
        public string TypeOfAircraft { get; set; }

        /// <summary>
        /// Время прибытия
        /// </summary>
        public DateTime ArrivalTime { get; set; }

        /// <summary>
        /// Количество пассажаиров
        /// </summary>
        public int NumberOfPassengers { get; set; }

        /// <summary>
        /// Сбор на пассажира
        /// </summary>
        public int PassengerFee { get; set; }

        /// <summary>
        /// Количество экипажа
        /// </summary>
        public int CrewNumber { get; set; }

        /// <summary>
        /// Сбор на экипаж
        /// </summary>
        public int CrewFee { get; set; }

        /// <summary>
        /// Процент надбавки за обслуживание
        /// </summary>
        public double ServiceSurchagePercentage { get; set; }

        /// <summary>
        /// Выручка
        /// </summary>
        public double Revenue { get; set; }
    }
}
