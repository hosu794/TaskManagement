namespace TaskManagement.Frontend.Forms
{
    partial class ManagerStatsForm
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
            lvStats = new ListView();
            cUserId = new ColumnHeader();
            cUsername = new ColumnHeader();
            cYear = new ColumnHeader();
            cMonth = new ColumnHeader();
            cTaskCount = new ColumnHeader();
            btnClose = new Button();
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
            splitContainer1.Panel1.Controls.Add(lvStats);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(btnClose);
            splitContainer1.Size = new Size(920, 515);
            splitContainer1.SplitterDistance = 444;
            splitContainer1.TabIndex = 0;
            // 
            // lvStats
            // 
            lvStats.Columns.AddRange(new ColumnHeader[] { cUserId, cUsername, cYear, cMonth, cTaskCount });
            lvStats.Dock = DockStyle.Fill;
            lvStats.Location = new Point(0, 0);
            lvStats.Name = "lvStats";
            lvStats.Size = new Size(920, 444);
            lvStats.TabIndex = 0;
            lvStats.UseCompatibleStateImageBehavior = false;
            lvStats.View = View.Details;
            // 
            // cUserId
            // 
            cUserId.Text = "User id";
            cUserId.Width = 100;
            // 
            // cUsername
            // 
            cUsername.Text = "Username";
            cUsername.Width = 200;
            // 
            // cYear
            // 
            cYear.Text = "Year";
            cYear.Width = 200;
            // 
            // cMonth
            // 
            cMonth.Text = "Month";
            cMonth.Width = 200;
            // 
            // cTaskCount
            // 
            cTaskCount.Text = "Count";
            cTaskCount.Width = 200;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(807, 18);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(92, 27);
            btnClose.TabIndex = 0;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // ManagerStatsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 515);
            Controls.Add(splitContainer1);
            MaximumSize = new Size(936, 554);
            MinimumSize = new Size(936, 554);
            Name = "ManagerStatsForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "ManagerStatsForm";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btnClose;
        private ListView lvStats;
        private ColumnHeader cUserId;
        private ColumnHeader cUsername;
        private ColumnHeader cYear;
        private ColumnHeader cMonth;
        private ColumnHeader cTaskCount;
    }
}