namespace Frontend
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            cbIsManager = new CheckBox();
            button1 = new Button();
            btnWyloguj = new Button();
            lbUsername = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tabControl1.SuspendLayout();
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
            splitContainer1.Panel1.Controls.Add(cbIsManager);
            splitContainer1.Panel1.Controls.Add(button1);
            splitContainer1.Panel1.Controls.Add(btnWyloguj);
            splitContainer1.Panel1.Controls.Add(lbUsername);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tabControl1);
            splitContainer1.Size = new Size(1154, 602);
            splitContainer1.SplitterDistance = 46;
            splitContainer1.TabIndex = 0;
            // 
            // cbIsManager
            // 
            cbIsManager.AutoCheck = false;
            cbIsManager.AutoSize = true;
            cbIsManager.Checked = true;
            cbIsManager.CheckState = CheckState.Checked;
            cbIsManager.Location = new Point(864, 15);
            cbIsManager.Name = "cbIsManager";
            cbIsManager.Size = new Size(75, 19);
            cbIsManager.TabIndex = 4;
            cbIsManager.Text = "IsManger";
            cbIsManager.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(12, 8);
            button1.Name = "button1";
            button1.Size = new Size(114, 31);
            button1.TabIndex = 3;
            button1.Text = "Raport";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnWyloguj
            // 
            btnWyloguj.Location = new Point(1028, 8);
            btnWyloguj.Name = "btnWyloguj";
            btnWyloguj.Size = new Size(114, 31);
            btnWyloguj.TabIndex = 2;
            btnWyloguj.Text = "Wyloguj się";
            btnWyloguj.UseVisualStyleBackColor = true;
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Location = new Point(953, 16);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(60, 15);
            lbUsername.TabIndex = 1;
            lbUsername.Text = "Username";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(3, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1148, 546);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1140, 518);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Tasks";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1140, 518);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "SharedTasks";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1140, 518);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "User tasks";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 602);
            Controls.Add(splitContainer1);
            MaximumSize = new Size(1170, 641);
            MinimumSize = new Size(1170, 641);
            Name = "MainForm";
            ShowIcon = false;
            Text = "Task Management App";
            Load += MainForm_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private CheckBox cbIsManager;
        private Button button1;
        private Button btnWyloguj;
        private Label lbUsername;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
    }
}
