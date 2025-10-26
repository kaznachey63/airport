using AirportApp.Infostructure;
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
        [Display(Name = "Количество пассажиров")]
        [Required(ErrorMessage = "{0} обязательно для заполнения")]
        [Range(Constants.MinPassengerNumber, Constants.MaxPassengerNumber, ErrorMessage = "{0} - {1}")]
        public int NumberOfPassengers { get; set; }

        /// <summary>
        /// Сбор на пассажира
        /// </summary>
        [Required(ErrorMessage = "Сбор на пассажира обязателен для заполнения")]
        public decimal PassengerFee { get; set; }

        /// <summary>
        /// Количество экипажа
        /// </summary>
        [Display(Name = "Количество экипажа")]
        [Required(ErrorMessage = "{0} обязательно для заполнения")]
        [Range(Constants.MinCrewNumber, Constants.MaxCrewNumber, ErrorMessage = "{0} - {1}")]
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
        public decimal Revenue => (NumberOfPassengers * PassengerFee + CrewNumber * CrewFee) * (Constants.BaseSum + ServicePercentage / Constants.Percent);

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