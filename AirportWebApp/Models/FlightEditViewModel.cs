using System.ComponentModel.DataAnnotations;
using AirportApp.Entities;
using AirportApp.Constants;

namespace AirportWebApp.Models
{
    /// <summary>
    /// Модель представления для добавления и редактирования рейса
    /// </summary>
    public class FlightEditViewModel
    {
        /// <summary>
        /// Идентификатор рейса
        /// Используется при редактировании существующей записи
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// Номер рейса
        /// </summary>
        [Display(Name = "Номер рейса")]
        [Required(ErrorMessage = "{0} обязательно для заполнения")]
        [Range(Constants.MinNumberFlight, Constants.MaxNumberFlight)]
        public int FlightNumber { get; set; }

        /// <summary>
        /// Тип самолёта
        /// </summary>
        [Display(Name = "Тип самолёта")]
        [Required(ErrorMessage = "{0} обязательно для выбора")]
        public TypeOfAircraft TypeOfAircraft { get; set; }

        /// <summary>
        /// Время прибытия рейса
        /// </summary>
        [Display(Name = "Время прибытия")]
        [Required(ErrorMessage = "{0} обязательно для заполнения")]
        public DateTime ArrivalTime { get; set; }

        /// <summary>
        /// Количество пассажиров на рейсе
        /// </summary>
        [Display(Name = "Количество пассажиров")]
        [Required(ErrorMessage = "{0} обязательно для заполнения")]
        [Range(Constants.MinPassengerNumber, Constants.MaxPassengerNumber)]
        public int NumberOfPassengers { get; set; }

        /// <summary>
        /// Сбор на одного пассажира
        /// </summary>
        [Display(Name = "Сбор на пассажира")]
        [Required(ErrorMessage = "{0} обязательно для заполнения")]
        [Range(Constants.MinPassengerFee, Constants.MaxPassengerFee)]
        public decimal PassengerFee { get; set; }

        /// <summary>
        /// Количество членов экипажа
        /// </summary>
        [Display(Name = "Количество экипажа")]
        [Required(ErrorMessage = "{0} обязательно для заполнения")]
        [Range(Constants.MinCrewNumber, Constants.MaxCrewNumber)]
        public int CrewNumber { get; set; }

        /// <summary>
        /// Сбор на одного члена экипажа
        /// </summary>
        [Display(Name = "Сбор на экипаж")]
        [Required(ErrorMessage = "{0} обязательно для заполнения")]
        [Range(Constants.MinCrewFee, Constants.MaxCrewFee)]
        public decimal CrewFee { get; set; }

        /// <summary>
        /// Процент надбавки за обслуживание рейса
        /// </summary>
        [Display(Name = "Процент обслуживания")]
        [Required(ErrorMessage = "{0} обязательно для заполнения")]
        [Range(Constants.MinPercent, Constants.MaxPercent)]
        public int ServicePercentage { get; set; }
    }
}