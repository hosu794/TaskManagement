using Core.Models.Priority;
using TaskManagement.Core.Models.User;
using TaskManagement.Data.DbModels;

namespace Frontend.Forms
{
    public partial class ChooseManagerForm : Form
    {

        private List<UserResponse> _managers;
        public int ChoosenManagerId { get; set; }

        public void Initialize(List<UserResponse> managers)
        {
            _managers = managers;

            cbChooseManager.DataSource = _managers;
            cbChooseManager.DisplayMember = "Username";
            cbChooseManager.ValueMember = "Id";

        }

        public ChooseManagerForm()
        {

            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int selectedId = 0;

            if (cbChooseManager.SelectedItem is UserResponse userResponse)
            {
                selectedId = userResponse.Id;
            }

            this.ChoosenManagerId = selectedId;

            this.DialogResult = DialogResult.OK;
        }
    }
}
