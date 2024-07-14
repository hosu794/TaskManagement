


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
            btnChooseManager = new Button();
            cbIsManager = new CheckBox();
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
            PriorityName = new ColumnHeader();
            CreatedAt = new ColumnHeader();
            tabPage2 = new TabPage();
            splitContainer3 = new SplitContainer();
            splitContainer4 = new SplitContainer();
            label1 = new Label();
            lvSharedTaskByUser = new ListView();
            clId = new ColumnHeader();
            clName = new ColumnHeader();
            clDescription = new ColumnHeader();
            clPriorityName = new ColumnHeader();
            clCreatedAt = new ColumnHeader();
            btnShareEdit = new Button();
            splitContainer5 = new SplitContainer();
            label2 = new Label();
            lvSharedTaskForUser = new ListView();
            colId = new ColumnHeader();
            chName = new ColumnHeader();
            chDescription = new ColumnHeader();
            chPriority = new ColumnHeader();
            chCreatedAt = new ColumnHeader();
            tabPage3 = new TabPage();
            splitContainer6 = new SplitContainer();
            lvUserManagerTasks = new ListView();
            cId = new ColumnHeader();
            cName = new ColumnHeader();
            cDescription = new ColumnHeader();
            cCreatedAt = new ColumnHeader();
            cPriority = new ColumnHeader();
            cUsername = new ColumnHeader();
            button3 = new Button();
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
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).BeginInit();
            splitContainer4.Panel1.SuspendLayout();
            splitContainer4.Panel2.SuspendLayout();
            splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer5).BeginInit();
            splitContainer5.Panel1.SuspendLayout();
            splitContainer5.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer6).BeginInit();
            splitContainer6.Panel1.SuspendLayout();
            splitContainer6.Panel2.SuspendLayout();
            splitContainer6.SuspendLayout();
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
            splitContainer1.Panel1.Controls.Add(btnChooseManager);
            splitContainer1.Panel1.Controls.Add(cbIsManager);
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
            // btnChooseManager
            // 
            btnChooseManager.Location = new Point(732, 8);
            btnChooseManager.Name = "btnChooseManager";
            btnChooseManager.Size = new Size(114, 31);
            btnChooseManager.TabIndex = 5;
            btnChooseManager.Text = "Choose manager";
            btnChooseManager.UseVisualStyleBackColor = true;
            btnChooseManager.Visible = false;
            btnChooseManager.Click += btnChooseManager_Click;
            // 
            // cbIsManager
            // 
            cbIsManager.AutoCheck = false;
            cbIsManager.AutoSize = true;
            cbIsManager.Checked = true;
            cbIsManager.CheckState = CheckState.Checked;
            cbIsManager.Location = new Point(864, 15);
            cbIsManager.Name = "cbIsManager";
            cbIsManager.Size = new Size(73, 19);
            cbIsManager.TabIndex = 4;
            cbIsManager.Text = "Manager";
            cbIsManager.UseVisualStyleBackColor = true;
            // 
            // btnWyloguj
            // 
            btnWyloguj.Location = new Point(1028, 8);
            btnWyloguj.Name = "btnWyloguj";
            btnWyloguj.Size = new Size(114, 31);
            btnWyloguj.TabIndex = 2;
            btnWyloguj.Text = "Log out";
            btnWyloguj.UseVisualStyleBackColor = true;
            btnWyloguj.Click += btnWyloguj_Click;
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
            btnDodaj.Click += btnAdd_Click;
            // 
            // lvTasks
            // 
            lvTasks.CheckBoxes = true;
            lvTasks.Columns.AddRange(new ColumnHeader[] { Id, ColName, Description, PriorityName, CreatedAt });
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
            // PriorityName
            // 
            PriorityName.DisplayIndex = 4;
            PriorityName.Text = "Priority";
            // 
            // CreatedAt
            // 
            CreatedAt.DisplayIndex = 3;
            CreatedAt.Text = "CreatedAt";
            CreatedAt.Width = 120;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(splitContainer3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1140, 518);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "SharedTasks";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(3, 3);
            splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(splitContainer4);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(splitContainer5);
            splitContainer3.Size = new Size(1134, 512);
            splitContainer3.SplitterDistance = 533;
            splitContainer3.TabIndex = 0;
            // 
            // splitContainer4
            // 
            splitContainer4.Dock = DockStyle.Fill;
            splitContainer4.Location = new Point(0, 0);
            splitContainer4.Name = "splitContainer4";
            splitContainer4.Orientation = Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            splitContainer4.Panel1.Controls.Add(label1);
            splitContainer4.Panel1.Controls.Add(lvSharedTaskByUser);
            // 
            // splitContainer4.Panel2
            // 
            splitContainer4.Panel2.Controls.Add(btnShareEdit);
            splitContainer4.Size = new Size(533, 512);
            splitContainer4.SplitterDistance = 426;
            splitContainer4.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(223, 17);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 1;
            label1.Text = "Shared by you";
            // 
            // lvSharedTaskByUser
            // 
            lvSharedTaskByUser.CheckBoxes = true;
            lvSharedTaskByUser.Columns.AddRange(new ColumnHeader[] { clId, clName, clDescription, clPriorityName, clCreatedAt });
            lvSharedTaskByUser.Location = new Point(0, 44);
            lvSharedTaskByUser.Name = "lvSharedTaskByUser";
            lvSharedTaskByUser.Size = new Size(533, 379);
            lvSharedTaskByUser.TabIndex = 0;
            lvSharedTaskByUser.UseCompatibleStateImageBehavior = false;
            lvSharedTaskByUser.View = View.Details;
            // 
            // clId
            // 
            clId.Text = "Id";
            // 
            // clName
            // 
            clName.Text = "Name";
            // 
            // clDescription
            // 
            clDescription.Text = "Description";
            // 
            // clPriorityName
            // 
            clPriorityName.DisplayIndex = 4;
            clPriorityName.Text = "Priority";
            // 
            // clCreatedAt
            // 
            clCreatedAt.DisplayIndex = 3;
            clCreatedAt.Text = "CreatedAt";
            // 
            // btnShareEdit
            // 
            btnShareEdit.Location = new Point(20, 26);
            btnShareEdit.Name = "btnShareEdit";
            btnShareEdit.Size = new Size(109, 34);
            btnShareEdit.TabIndex = 0;
            btnShareEdit.Text = "Unshare";
            btnShareEdit.UseVisualStyleBackColor = true;
            btnShareEdit.Click += btnUnshare_Click;
            // 
            // splitContainer5
            // 
            splitContainer5.Dock = DockStyle.Fill;
            splitContainer5.Location = new Point(0, 0);
            splitContainer5.Name = "splitContainer5";
            splitContainer5.Orientation = Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            splitContainer5.Panel1.Controls.Add(label2);
            splitContainer5.Panel1.Controls.Add(lvSharedTaskForUser);
            splitContainer5.Size = new Size(597, 512);
            splitContainer5.SplitterDistance = 427;
            splitContainer5.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(266, 17);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 1;
            label2.Text = "Shared to you";
            // 
            // lvSharedTaskForUser
            // 
            lvSharedTaskForUser.Columns.AddRange(new ColumnHeader[] { colId, chName, chDescription, chPriority, chCreatedAt });
            lvSharedTaskForUser.Location = new Point(3, 44);
            lvSharedTaskForUser.Name = "lvSharedTaskForUser";
            lvSharedTaskForUser.Size = new Size(591, 379);
            lvSharedTaskForUser.TabIndex = 0;
            lvSharedTaskForUser.UseCompatibleStateImageBehavior = false;
            lvSharedTaskForUser.View = View.Details;
            // 
            // colId
            // 
            colId.Text = "Id";
            // 
            // chDescription
            // 
            chDescription.Text = "Description";
            // 
            // chPriority
            // 
            chPriority.DisplayIndex = 4;
            chPriority.Text = "Priority";
            // 
            // chCreatedAt
            // 
            chCreatedAt.DisplayIndex = 3;
            chCreatedAt.Text = "CreatedAt";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(splitContainer6);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1140, 518);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "User tasks";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer6
            // 
            splitContainer6.Dock = DockStyle.Fill;
            splitContainer6.Location = new Point(3, 3);
            splitContainer6.Name = "splitContainer6";
            splitContainer6.Orientation = Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            splitContainer6.Panel1.Controls.Add(lvUserManagerTasks);
            // 
            // splitContainer6.Panel2
            // 
            splitContainer6.Panel2.Controls.Add(button3);
            splitContainer6.Size = new Size(1134, 512);
            splitContainer6.SplitterDistance = 446;
            splitContainer6.TabIndex = 0;
            // 
            // lvUserManagerTasks
            // 
            lvUserManagerTasks.Columns.AddRange(new ColumnHeader[] { cId, cName, cDescription, cCreatedAt, cPriority, cUsername });
            lvUserManagerTasks.Dock = DockStyle.Fill;
            lvUserManagerTasks.Location = new Point(0, 0);
            lvUserManagerTasks.Name = "lvUserManagerTasks";
            lvUserManagerTasks.Size = new Size(1134, 446);
            lvUserManagerTasks.TabIndex = 0;
            lvUserManagerTasks.UseCompatibleStateImageBehavior = false;
            lvUserManagerTasks.View = View.Details;
            // 
            // cId
            // 
            cId.Text = "Task id";
            // 
            // cDescription
            // 
            cDescription.Text = "Description";
            // 
            // cCreatedAt
            // 
            cCreatedAt.Text = "Created at";
            // 
            // cPriority
            // 
            cPriority.Text = "Priority";
            // 
            // cUsername
            // 
            cUsername.Text = "Username";
            // 
            // button3
            // 
            button3.Location = new Point(13, 13);
            button3.Name = "button3";
            button3.Size = new Size(172, 37);
            button3.TabIndex = 0;
            button3.Text = "Genererate report";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnGenerateReport_Click;
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
            tabPage2.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            splitContainer4.Panel1.ResumeLayout(false);
            splitContainer4.Panel1.PerformLayout();
            splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer4).EndInit();
            splitContainer4.ResumeLayout(false);
            splitContainer5.Panel1.ResumeLayout(false);
            splitContainer5.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer5).EndInit();
            splitContainer5.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            splitContainer6.Panel1.ResumeLayout(false);
            splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer6).EndInit();
            splitContainer6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private CheckBox cbIsManager;
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
        private Button btnChooseManager;
        private SplitContainer splitContainer3;
        private SplitContainer splitContainer4;
        private SplitContainer splitContainer5;
        private Label label1;
        private ListView lvSharedTaskByUser;
        private Label label2;
        private ListView lvSharedTaskForUser;
        private Button btnShareEdit;
        private SplitContainer splitContainer6;
        private ListView lvUserManagerTasks;
        private Button button3;
        private ColumnHeader clId;
        private ColumnHeader clName;
        private ColumnHeader clDescription;
        private ColumnHeader clCreatedAt;
        private ColumnHeader colId;
        private ColumnHeader chName;
        private ColumnHeader chDescription;
        private ColumnHeader chCreatedAt;
        private ColumnHeader PriorityName;
        private ColumnHeader clPriorityName;
        private ColumnHeader chPriority;
        private ColumnHeader cId;
        private ColumnHeader cName;
        private ColumnHeader cDescription;
        private ColumnHeader cPriority;
        private ColumnHeader cUsername;
        private ColumnHeader cCreatedAt;
    }
}
