using System.ComponentModel.DataAnnotations;

namespace AirportApp.Entities
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
            FlightNumber = 1;
            NumberOfPassengers = 1;
            PassengerFee = 1;
            CrewNumber = 1;
            CrewFee = 1;
            ServicePercentage = 1;
        }

        /// <summary>
        /// Идентификатор рейса
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Номер рейса
        /// </summary>
        [Display(Name = "Номер рейса")]
        [Required(ErrorMessage = "{0} обязательно для заполнения")]
        [Range(Constants.Constants.MinNumberFlight, Constants.Constants.MaxNumberFlight, ErrorMessage = "{0} - должно быть больше {1}")]
        public int FlightNumber { get; set; }

        /// <summary>
        /// Тип самолета
        /// </summary>
        public TypeOfAircraft TypeOfAircraft { get; set; }

        /// <summary>
        /// Время прибытия
        /// </summary>
        [Display(Name = "Время прибытия")]
        public DateTime ArrivalTime { get; set; }

        /// <summary>
        /// Количество пассажиров
        /// </summary>
        [Display(Name = "Количество пассажиров")]
        [Required(ErrorMessage = "{0} обязательно для заполнения")]
        [Range(Constants.Constants.MinPassengerNumber, Constants.Constants.MaxPassengerNumber, ErrorMessage = "{0} - {1}")]
        public int NumberOfPassengers { get; set; }

        /// <summary>
        /// Сбор на пассажира
        /// </summary>
        [Display(Name = "Сбор на пассажира")]
        [Required(ErrorMessage = "{0} обязательно для заполнения")]
        [Range(Constants.Constants.MinPassengerFee, Constants.Constants.MaxPassengerFee, ErrorMessage = "{0} - должно быть больше {1}")]
        public decimal PassengerFee { get; set; }

        /// <summary>
        /// Количество экипажа
        /// </summary>
        [Display(Name = "Количество экипажа")]
        [Required(ErrorMessage = "{0} обязательно для заполнения")]
        [Range(Constants.Constants.MinCrewNumber, Constants.Constants.MaxCrewNumber, ErrorMessage = "{0} - {1}")]
        public int CrewNumber { get; set; }

        /// <summary>
        /// Сбор на экипаж
        /// </summary>
        [Display(Name = "Сбор на экипаж")]
        [Required(ErrorMessage = "{0} обязательно для заполнения")]
        [Range(Constants.Constants.MinCrewFee, Constants.Constants.MaxCrewFee, ErrorMessage = "{0} - должно быть больше {1}")]
        public decimal CrewFee { get; set; }

        /// <summary>
        /// Процент надбавки за обслуживание
        /// </summary>
        [Display(Name = "Процент обслуживания")]
        [Required(ErrorMessage = "{0} обязательно для заполнения")]
        [Range(Constants.Constants.MinPercent, Constants.Constants.MaxPercent, ErrorMessage = "{0} - должно быть от {1} до {2}")]
        public decimal ServicePercentage { get; set; }

        /// <summary>
        /// Клон модели
        /// </summary>
        public FlightModel Clone()
        {
            return (FlightModel)MemberwiseClone();
        }
    }
}
