using AirportApp.Forms;
using AirportApp.Models;

namespace AirportApp
{
    public partial class MainForm : Form
    {
        private readonly Core core = new();

        public MainForm()
        {   
            InitializeComponent();
            Table.AutoGenerateColumns = false;
            Table.DataSource = core.LoadData();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            core.ShowData(Table);
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
