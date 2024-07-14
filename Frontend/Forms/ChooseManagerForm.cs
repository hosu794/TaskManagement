using TaskManagement.Core.Models.User;

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
    }
}
