using AirportApp.Forms;

namespace AirportApp
{
    public partial class MainForm : Form
    {
        private readonly Core core = new();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            core.ShowDate(DataGrid);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            using var addForm = new AddForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            using var editForm = new AddForm();
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
        }
    }
}
