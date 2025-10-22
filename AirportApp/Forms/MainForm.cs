using AirportApp.Forms;
using AirportApp.Models;

namespace AirportApp
{
    public partial class MainForm : Form
    {
        private int selectedRowIndex = 0;
        private readonly Core core;

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
            if (selectedRowIndex < 0)
            {
                return;
            }

            var flight = (FlightModel)Table.Rows[selectedRowIndex].DataBoundItem;
            core.EditButtonHandler(flight);
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
