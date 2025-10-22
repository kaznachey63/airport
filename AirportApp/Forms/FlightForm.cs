using AirportApp.Models;

namespace AirportApp.Forms
{
    public partial class FlightForm : Form
    {
        private readonly FlightModel targetFlight;
        public FlightForm(FlightModel? sourceFLight = null)
        {
            InitializeComponent();

            if (sourceFLight != null)
            {
                targetFlight = new FlightModel
                {
                    Id = sourceFLight.Id,
                    FlightNumber = sourceFLight.FlightNumber,
                    TypeOFAircraft = sourceFLight.TypeOFAircraft,
                    ArrivalTime = sourceFLight.ArrivalTime,
                    NumberOFPassengers = sourceFLight.NumberOFPassengers,
                    PassengerFee = sourceFLight.PassengerFee,
                    CrewNumber = sourceFLight.CrewNumber,
                    CrewFee = sourceFLight.CrewFee,
                    ServicePercentage = sourceFLight.ServicePercentage,
                };
            }
            else
            {
                targetFlight = new FlightModel
                {
                    Id = Guid.NewGuid(),
                    FlightNumber = 0,
                    TypeOFAircraft = TypeOFAircraft.None,
                    ArrivalTime = DateTime.Now,
                    NumberOFPassengers = 0,
                    PassengerFee = 0,
                    CrewNumber = 0,
                    CrewFee = 0,
                    ServicePercentage = 0,
                };
            }
        }

        public FlightModel CurrentFlight => targetFlight;

        private void FlightForm_Load(object sender, EventArgs e)
        {
            InitializeDataBindings();
        }

        private void InitializeDataBindings()
        {
            // Привязка NumericUpDown к свойствам
            NumericUpDownFlightNumber.DataBindings.Add("Value", targetFlight, "FlightNumber");
            NumericUpDownNumberPassenger.DataBindings.Add("Value", targetFlight, "NumberOFPassengers");
            NumericUpDownPassengerFee.DataBindings.Add("Value", targetFlight, "PassengerFee");
            NumericUpDownCrewNumber.DataBindings.Add("Value", targetFlight, "CrewNumber");
            NumericUpDownCrewFee.DataBindings.Add("Value", targetFlight, "CrewFee");
            NumericUpDownPercentage.DataBindings.Add("Value", targetFlight, "ServicePercentage");

            // Привязка DateTimePicker
            TimePicker.DataBindings.Add("Value", targetFlight, "ArrivalTime");

            // Привязка ComboBox
            ComboBox.DataSource = Enum.GetValues(typeof(TypeOFAircraft));
            ComboBox.DataBindings.Add("SelectedItem", targetFlight, "TypeOFAircraft");
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
