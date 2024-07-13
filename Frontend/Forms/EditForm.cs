using Core.Models.Priority;
using Core.Models.Task;

namespace Frontend.Forms
{
    public partial class EditForm : Form
    {
        public TaskResponse Task;

        public EditForm()
        {
            InitializeComponent();
        }

        public void Initialize(TaskResponse taskResponse, List<PriorityResponse> priorities, bool edit)
        {
            cbPriority.DataSource = priorities;
            cbPriority.DisplayMember = "Name";
            cbPriority.ValueMember = "Id";

            if (edit)
            {
                teName.Text = taskResponse.Name;
                teDescription.Text = taskResponse.Description;
                this.Text = "Edit Task";
                cbPriority.SelectedValue = taskResponse.PriorityId;
                btnAdd.Text = "Edit";
            }
            else
            {
                this.Text = "Create Task";
                btnAdd.Text = "Add";
            }

        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(teName.Text) && string.IsNullOrEmpty(teDescription.Text))
            {
                MessageBox.Show("Name and description must not be empty!");
                return;
            }

            int selectedId = 0;

            if (cbPriority.SelectedItem is PriorityResponse selectedPriority)
            {
                selectedId = selectedPriority.Id;
            }

            Task = new TaskResponse()
            {
                CreatedAt = DateTime.Now,
                Description = teDescription.Text,
                Name = teName.Text,
                PriorityId = selectedId,
            };

            this.DialogResult = DialogResult.OK;
        }
    }
}
