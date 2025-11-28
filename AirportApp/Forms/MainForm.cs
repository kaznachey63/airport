using AirportApp.Entities;
using AirportApp.Services;
using AirportApp.Services.Contracts;
using System.ComponentModel;

namespace AirportApp.Forms
{
    /// <summary>
    /// Главаная форма
    /// </summary>
    public partial class MainForm : Form
    {
        private FlightModel? selectedFlight;
        private readonly IFlightService flightService;
        private readonly BindingSource bindingSource = new();
        private BindingList<FlightModel> flights = new();

        public MainForm()
        {
            InitializeComponent();
            Table.AutoGenerateColumns = false;
            flightService = new FlightService(new InMemoryFlightStorage());
            Table.DataSource = LoadData();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            using var addForm = new FlightForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                flightService.Add(addForm.CurrentFlight).Wait();
                LoadData();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (selectedFlight == null)
                return;

            using var editForm = new FlightForm(selectedFlight.Clone());
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                flightService.Update(editForm.CurrentFlight).Wait();
                LoadData();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (selectedFlight == null)
                return;

            var confirm = MessageBox.Show(
                $"Точно удалить рейс №{selectedFlight.FlightNumber}?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                flightService.Remove(selectedFlight).Wait();
                LoadData();
            }
        }

        private void Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedFlight = (FlightModel)Table.Rows[e.RowIndex].DataBoundItem;
            }
        }

        private void Table_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (Table.Columns[e.ColumnIndex].Name == "RevenueColumn")
            {
                if (Table.Rows[e.RowIndex].DataBoundItem is FlightModel flightModel)
                {
                    var revenue = (flightModel.NumberOfPassengers * flightModel.PassengerFee + flightModel.CrewNumber * flightModel.CrewFee) * (Constants.Constants.BaseSum + flightModel.ServicePercentage / Constants.Constants.MaxPercent);

                    e.Value = revenue.ToString("C");
                    e.FormattingApplied = true;
                }
            }
        }

        private BindingSource LoadData()
        {
            var flights = flightService.GetAll().Result;
            flights = new BindingList<FlightModel>(flights.ToList());
            bindingSource.DataSource = flights;
            SetStatistics();
            return bindingSource;
        }

        private void SetStatistics()
        {
            var statistics = flightService.GetStatistics().Result;

            NumberOfFlights.Text = $"Количество рейсов: {statistics.Flights}";
            NumberOfPassengers.Text = $"Количество пассажиров: {statistics.Passengers}";
            CrewNumber.Text = $"Количество экипажа: {statistics.Crew}";
            TotalRevenue.Text = $"Общая выручка: {statistics.Revenue:C}";
        }
    }
}