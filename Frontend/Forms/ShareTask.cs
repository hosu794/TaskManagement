using TaskManagement.Core.Models.User;

namespace Frontend.Forms
{
    public partial class ShareTaskForm : Form
    {
        private List<UserResponse> _users;
        public int ShareUserId { get; set; }

        public ShareTaskForm()
        {
            InitializeComponent();
        }

        public void Initialize(List<UserResponse> users)
        {
            _users = users;

            cbUsers.DataSource = _users;
            cbUsers.DisplayMember = "Username";
            cbUsers.ValueMember = "Id";
        }

        private void btnShare_Click(object sender, EventArgs e)
        {

            int selectedId = 0;

            if (cbUsers.SelectedItem is UserResponse selectedUser)
            {
                selectedId = selectedUser.Id;
            }

            ShareUserId = selectedId;

            this.DialogResult = DialogResult.OK;
        }
    }
}
