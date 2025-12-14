namespace Constants
{
    /// <summary>
    /// Константы, используемые для валидации и расчетов в приложении
    /// </summary>
    public class Constants
    {
        /// <summary>
        /// Минимальное количество пассажиров в рейсе
        /// </summary>
        public const int MinPassengerNumber = 1;

        /// <summary>
        /// Максимальное количество пассажиров в рейсе
        /// </summary>
        public const int MaxPassengerNumber = 100;

        /// <summary>
        /// Минимальное количество членов экипажа
        /// </summary>
        public const int MinCrewNumber = 1;

        /// <summary>
        /// Максимальное количество членов экипажа
        /// </summary>
        public const int MaxCrewNumber = 7;

        /// <summary>
        /// Базовая сумма для расчетов выручки
        /// </summary>
        public const int BaseSum = 1;

        /// <summary>
        /// Максимальный процент надбавки за обслуживание
        /// </summary>
        public const int MaxPercent = 100;

        /// <summary>
        /// Минимальный процент надбавки за обслуживание
        /// </summary>
        public const int MinPercent = 1;

        /// <summary>
        /// Минимальный номер рейса
        /// </summary>
        public const int MinNumberFlight = 1;

        /// <summary>
        /// Максимальный номер рейса
        /// </summary>
        public const int MaxNumberFlight = 999;

        /// <summary>
        /// Минимальная плата за пассажира
        /// </summary>
        public const double MinPassengerFee = 1;

        /// <summary>
        /// Максимальная плата за пассажира
        /// </summary>
        public const double MaxPassengerFee = 20000.0; // исправил, чтобы имело смысл

        /// <summary>
        /// Минимальная плата за члена экипажа
        /// </summary>
        public const double MinCrewFee = 1;

        /// <summary>
        /// Максимальная плата за члена экипажа
        /// </summary>
        public const double MaxCrewFee = 20000.0; // исправил, чтобы имело смысл

        /// <summary>
        /// Минмальный элемент для комбобокса
        /// </summary>
        public const int MinCombobx = 0;

        /// <summary>
        /// Макс. эл. для комбобоксав
        /// </summary>
        public const int MaxCombobx = 3;
    }
}