using System.ComponentModel.DataAnnotations;

namespace AirportApp.Models
{
    /// <summary>
    /// Данные о рейсе
    /// </summary>
    public class FlightModel
    {
        public FlightModel()
        {
            Id = Guid.NewGuid();
            ArrivalTime = DateTime.Now;
        }

        /// <summary>
        /// Идентификатор рейса
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Номер рейса
        /// </summary>
        [Required(ErrorMessage = "Номер рейса обязателен для заполнения")]
        public int FlightNumber { get; set; }

        /// <inheritdoc cref="Models.TypeOfAircraft" />
        [Required(ErrorMessage = "Тип не должен быть None")]
        public TypeOfAircraft TypeOfAircraft { get; set; }

        /// <summary>
        /// Время прибытия
        /// </summary>
        public DateTime ArrivalTime { get; set; }

        /// <summary>
        /// Количество пассажаиров
        /// </summary>
        [Required(ErrorMessage = "Количество пассажиров обязательно для заполнения")]
        [Range(1, int.MaxValue, ErrorMessage = "Минимальное количество пассажиров - 1")]
        public int NumberOfPassengers { get; set; }

        /// <summary>
        /// Сбор на пассажира
        /// </summary>
        [Required(ErrorMessage = "Сбор на пассажира обязателен для заполнения")]
        public decimal PassengerFee { get; set; }

        /// <summary>
        /// Количество экипажа
        /// </summary>
        [Required(ErrorMessage = "Количество экипажа обязательно для заполнения")]
        [Range(1, int.MaxValue, ErrorMessage = "Минимальное количество экипажа - 1")]
        public int CrewNumber { get; set; }

        /// <summary>
        /// Сбор на экипаж
        /// </summary>
        [Required(ErrorMessage = "Сбор на экипаж обязателен для заполнения")]
        public decimal CrewFee { get; set; }

        /// <summary>
        /// Процент надбавки за обслуживание
        /// </summary>
        [Required(ErrorMessage = "Процент обслуживания обязателен для заполнения")]
        public decimal ServicePercentage { get; set; }

        /// <summary>
        /// Выручка
        /// </summary>
        public decimal Revenue => (NumberOfPassengers * PassengerFee + CrewNumber * CrewFee) * (1 + ServicePercentage / 100);

        /// <summary>
        /// Клон модели
        /// </summary>
        /// <returns></returns>
        public FlightModel Clone()
        {
            return (FlightModel)this.MemberwiseClone();
        }

    }
}