using AirportApp.Models;

namespace AirportApp.Forms
{
    public partial class FlightForm : Form
    {
        private FlightModel? targetFlight;

        public FlightForm(FlightModel? sourceFlight = null)
        {
            InitializeComponent();
            DetermineSource(sourceFlight);
        }

        /// <summary>
        /// Выбранный рейс
        /// </summary>
        public FlightModel CurrentFlight => targetFlight!;

        private void FlightForm_Load(object sender, EventArgs e)
        {
            InitializeDataBindings();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!Validation())
            {
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void DetermineSource(FlightModel? sourceFlight)
        {
            if (sourceFlight != null)
            {
                targetFlight = new FlightModel
                {
                    Id = sourceFlight.Id,
                    FlightNumber = sourceFlight.FlightNumber,
                    TypeOFAircraft = sourceFlight.TypeOFAircraft,
                    ArrivalTime = sourceFlight.ArrivalTime,
                    NumberOFPassengers = sourceFlight.NumberOFPassengers,
                    PassengerFee = sourceFlight.PassengerFee,
                    CrewNumber = sourceFlight.CrewNumber,
                    CrewFee = sourceFlight.CrewFee,
                    ServicePercentage = sourceFlight.ServicePercentage,
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

        private void InitializeDataBindings()
        {
            NumericUpDownFlightNumber.DataBindings.Add("Value", targetFlight, "FlightNumber");
            NumericUpDownNumberPassenger.DataBindings.Add("Value", targetFlight, "NumberOFPassengers");
            NumericUpDownPassengerFee.DataBindings.Add("Value", targetFlight, "PassengerFee");
            NumericUpDownCrewNumber.DataBindings.Add("Value", targetFlight, "CrewNumber");
            NumericUpDownCrewFee.DataBindings.Add("Value", targetFlight, "CrewFee");
            NumericUpDownPercentage.DataBindings.Add("Value", targetFlight, "ServicePercentage");

            TimePicker.DataBindings.Add("Value", targetFlight, "ArrivalTime");

            ComboBox.DataSource = Enum.GetValues(typeof(TypeOFAircraft));
            ComboBox.DataBindings.Add("SelectedItem", targetFlight, "TypeOFAircraft");
        }

        private bool Validation()
        {
            if (NumericUpDownFlightNumber.Value == 0 || ComboBox?.SelectedItem?.ToString() == "None" ||
                NumericUpDownNumberPassenger.Value == 0 || NumericUpDownPassengerFee.Value == 0 ||
                NumericUpDownCrewNumber.Value == 0 || NumericUpDownCrewFee.Value == 0 ||
                NumericUpDownPercentage.Value == 0
                )
            {
                MessageBox.Show("Не все поля заполнены!");
                return false;
            }  
            else
            {
                return true;
            }
        }
    }
}
