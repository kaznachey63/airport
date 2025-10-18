using AirportApp.Forms;
using AirportApp.Models;

namespace AirportApp
{
    public partial class MainForm : Form
    {
        private readonly Core core = new();
        private readonly List<Flight> flights;
        private readonly BindingSource bindingSource = new();

        public MainForm()
        {
            flights = [];
            flights.Add(new Flight
            {
                Id = Guid.NewGuid(),
                FlightNumber = 504,
                TypeOFAircraft = TypeOFAircraft.Boieng,
                ArrivalTime = DateTime.Now,
                NumberOFPassengers = 100,
                PassengerFee = 12000m,
                CrewNumber = 5,
                CrewFee = 2000m,
                ServicePercentage = 5m
            });

            InitializeComponent();
            Table.AutoGenerateColumns = false;
            bindingSource!.DataSource = flights;
            Table.DataSource = bindingSource;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            core.ShowDate(Table);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            using var addForm = new FlightForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            using var editForm = new FlightForm();
            if (editForm.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var rightTODelete = MessageBox.Show("Точно удалить запись ?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rightTODelete == DialogResult.Yes)
            {

            }
            else
            {
                return;
            }
        }
    }
}
