


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
            splitContainer2 = new SplitContainer();
            btnRefresh = new Button();
            button2 = new Button();
            btnUsun = new Button();
            btnEdit = new Button();
            btnDodaj = new Button();
            lvTasks = new ListView();
            Id = new ColumnHeader();
            ColName = new ColumnHeader();
            Description = new ColumnHeader();
            CreatedAt = new ColumnHeader();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
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
            button1.Text = "Report";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnWyloguj
            // 
            btnWyloguj.Location = new Point(1028, 8);
            btnWyloguj.Name = "btnWyloguj";
            btnWyloguj.Size = new Size(114, 31);
            btnWyloguj.TabIndex = 2;
            btnWyloguj.Text = "Log out";
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
            tabPage1.Controls.Add(splitContainer2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1140, 518);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Tasks";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.IsSplitterFixed = true;
            splitContainer2.Location = new Point(3, 3);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(btnRefresh);
            splitContainer2.Panel1.Controls.Add(button2);
            splitContainer2.Panel1.Controls.Add(btnUsun);
            splitContainer2.Panel1.Controls.Add(btnEdit);
            splitContainer2.Panel1.Controls.Add(btnDodaj);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(lvTasks);
            splitContainer2.Size = new Size(1134, 512);
            splitContainer2.SplitterDistance = 150;
            splitContainer2.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(17, 467);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(114, 31);
            btnRefresh.TabIndex = 9;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // button2
            // 
            button2.Location = new Point(17, 129);
            button2.Name = "button2";
            button2.Size = new Size(114, 31);
            button2.TabIndex = 8;
            button2.Text = "Share";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnShare_Click;
            // 
            // btnUsun
            // 
            btnUsun.Location = new Point(17, 92);
            btnUsun.Name = "btnUsun";
            btnUsun.Size = new Size(114, 31);
            btnUsun.TabIndex = 7;
            btnUsun.Text = "Delete";
            btnUsun.UseVisualStyleBackColor = true;
            btnUsun.Click += btnUsun_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(17, 55);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(114, 31);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(17, 18);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(114, 31);
            btnDodaj.TabIndex = 5;
            btnDodaj.Text = "Add";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // lvTasks
            // 
            lvTasks.CheckBoxes = true;
            lvTasks.Columns.AddRange(new ColumnHeader[] { Id, ColName, Description, CreatedAt });
            lvTasks.Dock = DockStyle.Fill;
            lvTasks.Location = new Point(0, 0);
            lvTasks.Name = "lvTasks";
            lvTasks.Size = new Size(980, 512);
            lvTasks.TabIndex = 0;
            lvTasks.UseCompatibleStateImageBehavior = false;
            lvTasks.View = View.Details;
            // 
            // Id
            // 
            Id.Text = "Id";
            // 
            // ColName
            // 
            ColName.Text = "Name";
            ColName.Width = 300;
            // 
            // Description
            // 
            Description.Text = "Description";
            Description.Width = 400;
            // 
            // CreatedAt
            // 
            CreatedAt.Text = "CreatedAt";
            CreatedAt.Width = 120;
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
            tabPage1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
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
        private SplitContainer splitContainer2;
        private Button btnEdit;
        private Button btnDodaj;
        private Button btnUsun;
        private Button button2;
        private ListView lvTasks;
        private Button btnRefresh;
        private ColumnHeader Id;
        private ColumnHeader ColName;
        private ColumnHeader Description;
        private ColumnHeader CreatedAt;
    }
}
