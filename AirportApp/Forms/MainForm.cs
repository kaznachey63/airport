using AirportApp.Forms;
using AirportApp.Models;

namespace AirportApp
{
    public partial class MainForm : Form
    {
        private int selectedRowIndex = 0;
        private readonly Core core = new();

        public MainForm()
        {
            InitializeComponent();
            Table.AutoGenerateColumns = false;
            Table.DataSource = core.LoadData();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            using var addForm = new FlightForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                core.AddData(addForm.CurrentFlight);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex < 0)
            {
                return;
            }

            var flight = (FlightModel)Table.Rows[selectedRowIndex].DataBoundItem;

            using var editForm = new FlightForm(flight);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                core.RefreshData(editForm.CurrentFlight);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex < 0)
            {
                return;
            }
            var flight = (FlightModel)Table.Rows[selectedRowIndex].DataBoundItem;
            core.DeleteButtonHandler(flight);
        }

        private void Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRowIndex = e.RowIndex;
            }
        }
    }
}
