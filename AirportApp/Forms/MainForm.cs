using AirportApp.Models;

namespace AirportApp
{
    public partial class MainForm : Form
    {
        private readonly Core core;
        private FlightModel? selectedFlight;

        public MainForm()
        {
            InitializeComponent();
            core = new(this);
            Table.AutoGenerateColumns = false;
            Table.DataSource = core.LoadData();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            core.AddButtonHandler();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (selectedFlight == null)
                return;

            core.EditButtonHandler(selectedFlight);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (selectedFlight == null)
                return;

            core.DeleteButtonHandler(selectedFlight);
        }

        private void Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedFlight = (FlightModel)Table.Rows[e.RowIndex].DataBoundItem;
            }
        }
    }
}
