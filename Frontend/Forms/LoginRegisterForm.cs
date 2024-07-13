namespace Frontend
{
    public partial class LoginRegisterForm : Form
    {
        private bool _isLoginMode = true;
        private readonly ApiService _apiService;
        public string Token;

        public LoginRegisterForm(ApiService apiService)
        {
            InitializeComponent();
            _apiService = apiService;
            Token = string.Empty;
        }

        private void cbChangeAuth_CheckedChanged_1(object sender, EventArgs e)
        {
            _isLoginMode = cbChangeAuth.Checked;

            if (_isLoginMode)
            {
                btnLoginRegister.Text = "Logowanie";
                cbManager.Visible = false;
                return;
            }

            btnLoginRegister.Text = "Rejestracja";
            cbManager.Visible = true;
        }

        private async void btnLoginRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbUsername.Text) || string.IsNullOrEmpty(tbPassword.Text))
            {
                MessageBox.Show("Username or password is empty.");
                return;
            }

            if (_isLoginMode)
            {
                var isLoggedCorrect = await _apiService.Login(tbUsername.Text, tbPassword.Text);

                if (!isLoggedCorrect)
                {
                    MessageBox.Show("Wrong password or login");
                    return;
                }
                this.DialogResult = DialogResult.OK;
                return;
            }

            var isRegisterCorrect = await _apiService.Register(tbUsername.Text, tbPassword.Text, cbChangeAuth.Checked);

            if (!isRegisterCorrect)
            {
                MessageBox.Show("Username already exists!");
                return;
            }
            

            this.DialogResult = DialogResult.OK;
        }
    }
}
