using Core.Models.Task;
using Microsoft.Extensions.DependencyInjection;
using TaskManagement.Core.Models.User;

namespace Frontend
{
    public partial class MainForm : Form
    {
        private readonly ApiService _apiService;
        private readonly IServiceProvider _serviceProvider;
        private UserResponse _currentUser;
        private List<TaskResponse> _tasks;
        private List<TaskResponse> _sharedTasks;

        public MainForm(ApiService apiService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _apiService = apiService;   
            _serviceProvider = serviceProvider;
        }


        private async void MainForm_Load(object sender, EventArgs e)
        {
            using (var AuthForm  = _serviceProvider.GetRequiredService<LoginRegisterForm>())
            {
                if (AuthForm.ShowDialog() == DialogResult.Cancel) 
                    this.Close();

                _currentUser = await _apiService.GetCurrentUser();

                lbUsername.Text = _currentUser.Username;

                if (_currentUser == null)
                {
                    MessageBox.Show($"Cannot download user");
                    this.Close();
                }

                if (!_currentUser.IsManager)
                {
                    cbIsManager.Checked = false;
                    tabControl1.TabPages.Remove(tabPage3);
                }


            }
        }

        private async Task GetTasks()
        {
           
        }
    }
}
