using AirportApp.Entities;
using AirportApp.Infostructure;
using System.ComponentModel.DataAnnotations;

namespace AirportApp
{
    /// <summary>
    /// Форма редактирвоания
    /// </summary>
    public partial class FlightForm : Form
    {
        private FlightModel targetFlight = null!;

        /// <summary>
        /// Выбранный рейс
        /// </summary>
        public FlightModel CurrentFlight => targetFlight;

        public FlightForm(FlightModel? sourceFlight = null)
        {
            InitializeComponent();
            DetermineSource(sourceFlight);
            AutoValidate = AutoValidate.EnableAllowFocusChange;
        }

        private void FlightForm_Load(object sender, EventArgs e)
        {
            InitializeDataBindings();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var context = new ValidationContext(CurrentFlight);
            var results = new List<ValidationResult>();
            if (!Validator.TryValidateObject(CurrentFlight, context, results, true))
            {
                MessageBox.Show("У вас ошибки в заполнении данных", "Валидация", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void DetermineSource(FlightModel? sourceFlight)
        {
            if (sourceFlight != null)
            {
                targetFlight = sourceFlight.Clone();
            }
            else
            {
                targetFlight = new FlightModel();
            }
        }

        private void InitializeDataBindings()
        {
            NumericUpDownFlightNumber.AddBinding(x => x.Value, targetFlight, x => x.FlightNumber, errorProvider);
            NumericUpDownNumberPassenger.AddBinding(x => x.Value, targetFlight, x => x.NumberOfPassengers, errorProvider);
            NumericUpDownPassengerFee.AddBinding(x => x.Value, targetFlight, x => x.PassengerFee, errorProvider);
            NumericUpDownCrewNumber.AddBinding(x => x.Value, targetFlight, x => x.CrewNumber, errorProvider);
            NumericUpDownCrewFee.AddBinding(x => x.Value, targetFlight, x => x.CrewFee, errorProvider);
            NumericUpDownPercentage.AddBinding(x => x.Value, targetFlight, x => x.ServicePercentage, errorProvider);
            TimePicker.MinDate = DateTime.Now.Date;
            TimePicker.AddBinding(x => x.Value, targetFlight, x => x.ArrivalTime, errorProvider);
            ComboBox.DataSource = Enum.GetValues(typeof(TypeOfAircraft));
            ComboBox.AddBinding(x => x.SelectedItem, targetFlight, x => x.TypeOfAircraft, errorProvider);
        }
    }
}