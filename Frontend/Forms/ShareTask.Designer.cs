namespace Frontend.Forms
{
    partial class ShareTaskForm
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
            cbUsers = new ComboBox();
            lbUsers = new Label();
            btnShare = new Button();
            SuspendLayout();
            // 
            // cbUsers
            // 
            cbUsers.FormattingEnabled = true;
            cbUsers.Location = new Point(12, 23);
            cbUsers.Name = "cbUsers";
            cbUsers.Size = new Size(176, 23);
            cbUsers.TabIndex = 0;
            // 
            // lbUsers
            // 
            lbUsers.AutoSize = true;
            lbUsers.Location = new Point(194, 26);
            lbUsers.Name = "lbUsers";
            lbUsers.Size = new Size(35, 15);
            lbUsers.TabIndex = 1;
            lbUsers.Text = "Users";
            // 
            // btnShare
            // 
            btnShare.Location = new Point(12, 228);
            btnShare.Name = "btnShare";
            btnShare.Size = new Size(140, 34);
            btnShare.TabIndex = 2;
            btnShare.Text = "Share";
            btnShare.UseVisualStyleBackColor = true;
            btnShare.Click += btnShare_Click;
            // 
            // ShareTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(265, 274);
            Controls.Add(btnShare);
            Controls.Add(lbUsers);
            Controls.Add(cbUsers);
            MaximumSize = new Size(281, 313);
            MinimumSize = new Size(281, 313);
            Name = "ShareTask";
            ShowIcon = false;
            Text = "Share Task";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbUsers;
        private Label lbUsers;
        private Button btnShare;
    }
}