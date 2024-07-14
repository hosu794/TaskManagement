using Core.Models.Priority;
using Core.Models.Task;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using TaskManagement.Core.Models.User;

namespace Frontend
{
    public partial class MainForm : Form
    {
        private readonly ApiService _apiService;
        private readonly IServiceProvider _serviceProvider;
        private UserResponse _currentUser;
        private List<TaskResponse> _tasks;
        private List<TaskResponse> _sharedTasksByUser;
        private List<TaskResponse> _sharedTaskForUser;
        private List<PriorityResponse> _priorities;
        private List<UserResponse> _users;

        public MainForm(ApiService apiService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _apiService = apiService;
            _serviceProvider = serviceProvider;
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            using (var AuthForm = _serviceProvider.GetRequiredService<LoginRegisterForm>())
            {
                if (AuthForm.ShowDialog() == DialogResult.Cancel)
                    this.Close();

                _currentUser = await _apiService.GetCurrentUser();

                if (_currentUser == null)
                {
                    MessageBox.Show($"Cannot download user");
                    this.Close();
                }

                lbUsername.Text = _currentUser.Username;

                if (!_currentUser.IsManager)
                {
                    cbIsManager.Checked = false;
                    tabControl1.TabPages.Remove(tabPage3);
                    btnChooseManager.Visible = true;
                }

                await Task.WhenAll(
                    LoadTasks(),
                    LoadPriorities(),
                    LoadAllUsers(), 
                    LoadSharedTasksByUser(),
                    LoadShareTasksForUser()
                    );
            }
        }

        private async Task LoadTasks()
        {
            try
            {
                _tasks = await _apiService.GetAllTasks();


                lvTasks.Items.Clear();
                foreach (var task in _tasks)
                {

                    var item = new ListViewItem(task.Id.ToString());
                    item.SubItems.Add(task.Name);
                    item.SubItems.Add(task.Description);
                    item.SubItems.Add(task.CreatedAt.ToString());

                    lvTasks.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading tasks: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadSharedTasksByUser()
        {
            try
            {
                _sharedTasksByUser = await _apiService.GetSharedTaskByUser();

                lvSharedTaskByUser.Items.Clear();
                foreach (var task in _sharedTasksByUser)
                {

                    var item = new ListViewItem(task.Id.ToString());
                    item.SubItems.Add(task.Name);
                    item.SubItems.Add(task.Description);
                    item.SubItems.Add(task.CreatedAt.ToString());

                    lvSharedTaskByUser.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading shared tasks by user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadShareTasksForUser()
        {
            try
            {
                _sharedTaskForUser = await _apiService.GetSharedTaskForUser();

                lvSharedTaskForUser.Items.Clear();
                foreach (var task in _sharedTaskForUser)
                {

                    var item = new ListViewItem(task.Id.ToString());
                    item.SubItems.Add(task.Name);
                    item.SubItems.Add(task.Description);
                    item.SubItems.Add(task.CreatedAt.ToString());

                    lvSharedTaskForUser.Items.Add(item);
                }
            } catch (Exception ex)
            {
                MessageBox.Show($"Error loading shared tasks by user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadPriorities()
        {
            try
            {

                _priorities = await _apiService.GetAllPriorities();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading priorities: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadAllUsers()
        {
            try
            {
                _users = await _apiService.GetAllUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading users: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            using (var AddForm = _serviceProvider.GetRequiredService<Forms.EditForm>())
            {
                AddForm.Initialize(null, _priorities, false);

                if (AddForm.ShowDialog() == DialogResult.OK)
                {
                    var taskRequest = AddForm.Task;

                    var taskResponse = await _apiService.CreateTask(new TaskRequest()
                    {
                        Description = taskRequest.Description,
                        Name = taskRequest.Name,
                        PriorityId = taskRequest.PriorityId,
                    });

                    var item = new ListViewItem(taskResponse.Id.ToString());
                    item.SubItems.Add(taskResponse.Name);
                    item.SubItems.Add(taskResponse.Description);
                    item.SubItems.Add(taskResponse.CreatedAt.ToString());

                    lvTasks.Items.Add(item);
                    _tasks.Add(taskResponse);

                    MessageBox.Show($"Add new task with id: {taskResponse.Id}");
                }

            }
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvTasks.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select a task to edit.", "No task selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (lvTasks.CheckedItems.Count > 1)
            {
                MessageBox.Show("Please select single task", "Too many task selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedItem = lvTasks.CheckedItems[0];
            int taskId = int.Parse(selectedItem.SubItems[0].Text);

            TaskResponse selectedTask = _tasks.FirstOrDefault(t => t.Id == taskId);
            if (selectedTask == null)
            {
                MessageBox.Show("Selected task not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var AddForm = _serviceProvider.GetRequiredService<Forms.EditForm>())
            {
                AddForm.Initialize(selectedTask, _priorities, true);

                if (AddForm.ShowDialog() == DialogResult.OK)
                {
                    var taskRequest = AddForm.Task;

                    var updatedTask = await _apiService.UpdateTask(new TaskRequest()
                    {
                        Description = taskRequest.Description,
                        Name = taskRequest.Name,
                        PriorityId = taskRequest.PriorityId,
                    }, selectedTask.Id);

                    var taskIndex = _tasks.FindIndex(t => t.Id == updatedTask.Id);
                    if (taskIndex >= 0)
                    {
                        _tasks[taskIndex] = updatedTask;
                    }


                    selectedItem.SubItems[1].Text = updatedTask.Name;
                    selectedItem.SubItems[2].Text = updatedTask.Description;
                    selectedItem.SubItems[3].Text = updatedTask.CreatedAt.ToString();


                    MessageBox.Show("Selected task updated.", "Update");
                }
            }

        }

        private async void btnUsun_Click(object sender, EventArgs e)
        {
            if (lvTasks.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select a task to delete.", "No task selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (lvTasks.CheckedItems.Count > 1)
            {
                MessageBox.Show("Please select single task", "Too many task selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedItem = lvTasks.CheckedItems[0];
            int taskId = int.Parse(selectedItem.SubItems[0].Text);

            TaskResponse selectedTask = _tasks.FirstOrDefault(t => t.Id == taskId);

            if (selectedTask == null)
            {
                MessageBox.Show("Selected task not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var deleteResponse = await _apiService.DeleteTask(selectedTask.Id);

            if (!deleteResponse)
            {
                MessageBox.Show("Delete error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var taskIndex = _tasks.FindIndex(t => t.Id == selectedTask.Id);
            if (taskIndex >= 0)
            {
                _tasks.Remove(selectedTask);
            }

            lvTasks.Items.Remove(selectedItem);

            MessageBox.Show($"Deleted successfull task with id {selectedTask.Id}", "Delete");


        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private async void btnShare_Click(object sender, EventArgs e)
        {
            if (lvTasks.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select a task to share.", "No task selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (lvTasks.CheckedItems.Count > 1)
            {
                MessageBox.Show("Please select single task", "Too many task selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedItem = lvTasks.CheckedItems[0];
            int taskId = int.Parse(selectedItem.SubItems[0].Text);

            TaskResponse selectedTask = _tasks.FirstOrDefault(t => t.Id == taskId);

            if (selectedTask == null)
            {
                MessageBox.Show("Selected task not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var ShareForm = _serviceProvider.GetRequiredService<Forms.ShareTaskForm>())
            {
                ShareForm.Initialize(_users);

                if (ShareForm.ShowDialog() == DialogResult.OK)
                {
                    var shareUserId = ShareForm.ShareUserId;

                    var response = await _apiService.ShareTask(taskId, shareUserId);

                    if (response is null) MessageBox.Show($"Error during sharing task");

                    var item = new ListViewItem(response.Id.ToString());
                    item.SubItems.Add(response.Name);
                    item.SubItems.Add(response.Description);
                    item.SubItems.Add(response.CreatedAt.ToString());

                    lvSharedTaskByUser.Items.Add(item);
                    _sharedTasksByUser.Add(response);

                    MessageBox.Show("Selected task shared.", "Share");
                }
            }
        }

        private void btnWyloguj_Click(object sender, EventArgs e)
        {

        }

        private void btnChooseManager_Click(object sender, EventArgs e)
        {
            using (var ChooseManagerForm = _serviceProvider.GetRequiredService<Forms.ChooseManagerForm>())
            {
                ChooseManagerForm.Initialize(_users);

                if (ChooseManagerForm.ShowDialog() == DialogResult.OK)
                {
                    var shareUserId = ChooseManagerForm.ChoosenManagerId;


                    MessageBox.Show("Selected manager aproved.", "Choosen manager.");
                }
            }
        }
    }
}
