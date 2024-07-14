
namespace Frontend
{
    partial class LoginRegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            cbManager = new CheckBox();
            lbPassword = new Label();
            tbPassword = new TextBox();
            label1 = new Label();
            tbUsername = new TextBox();
            cbChangeAuth = new CheckBox();
            btnLoginRegister = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(cbManager);
            splitContainer1.Panel1.Controls.Add(lbPassword);
            splitContainer1.Panel1.Controls.Add(tbPassword);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(tbUsername);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(cbChangeAuth);
            splitContainer1.Panel2.Controls.Add(btnLoginRegister);
            splitContainer1.Size = new Size(314, 301);
            splitContainer1.SplitterDistance = 231;
            splitContainer1.TabIndex = 0;
            // 
            // cbManager
            // 
            cbManager.AutoSize = true;
            cbManager.Location = new Point(12, 70);
            cbManager.Name = "cbManager";
            cbManager.Size = new Size(73, 19);
            cbManager.TabIndex = 2;
            cbManager.Text = "Manager";
            cbManager.UseVisualStyleBackColor = true;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(227, 44);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(57, 15);
            lbPassword.TabIndex = 3;
            lbPassword.Text = "Password";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(12, 41);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(209, 23);
            tbPassword.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(227, 20);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(12, 12);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(209, 23);
            tbUsername.TabIndex = 0;
            // 
            // cbChangeAuth
            // 
            cbChangeAuth.AutoSize = true;
            cbChangeAuth.Location = new Point(148, 24);
            cbChangeAuth.Name = "cbChangeAuth";
            cbChangeAuth.Size = new Size(84, 19);
            cbChangeAuth.TabIndex = 1;
            cbChangeAuth.Text = "Logowanie";
            cbChangeAuth.UseVisualStyleBackColor = true;
            cbChangeAuth.CheckedChanged += cbChangeAuth_CheckedChanged_1;
            // 
            // btnLoginRegister
            // 
            btnLoginRegister.Location = new Point(12, 15);
            btnLoginRegister.Name = "btnLoginRegister";
            btnLoginRegister.Size = new Size(119, 35);
            btnLoginRegister.TabIndex = 0;
            btnLoginRegister.Text = "Logowanie";
            btnLoginRegister.UseVisualStyleBackColor = true;
            btnLoginRegister.Click += btnLoginRegister_Click;
            // 
            // LoginRegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 301);
            Controls.Add(splitContainer1);
            MaximumSize = new Size(330, 340);
            MinimumSize = new Size(330, 340);
            Name = "LoginRegisterForm";
            ShowIcon = false;
            Text = "Register or login";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void cbChangeAuth_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private SplitContainer splitContainer1;
        private CheckBox cbChangeAuth;
        private Button btnLoginRegister;
        private CheckBox cbManager;
        private Label lbPassword;
        private TextBox tbPassword;
        private Label label1;
        private TextBox tbUsername;
    }
}