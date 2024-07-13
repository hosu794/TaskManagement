namespace Frontend.Forms
{
    partial class EditForm
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
            lbPriority = new Label();
            cbPriority = new ComboBox();
            label1 = new Label();
            teDescription = new TextBox();
            lbName = new Label();
            teName = new TextBox();
            btnClose = new Button();
            btnAdd = new Button();
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
            splitContainer1.Panel1.Controls.Add(lbPriority);
            splitContainer1.Panel1.Controls.Add(cbPriority);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(teDescription);
            splitContainer1.Panel1.Controls.Add(lbName);
            splitContainer1.Panel1.Controls.Add(teName);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(btnClose);
            splitContainer1.Panel2.Controls.Add(btnAdd);
            splitContainer1.Size = new Size(288, 387);
            splitContainer1.SplitterDistance = 329;
            splitContainer1.TabIndex = 0;
            // 
            // lbPriority
            // 
            lbPriority.AutoSize = true;
            lbPriority.Location = new Point(12, 251);
            lbPriority.Name = "lbPriority";
            lbPriority.Size = new Size(45, 15);
            lbPriority.TabIndex = 6;
            lbPriority.Text = "Priority";
            // 
            // cbPriority
            // 
            cbPriority.FormattingEnabled = true;
            cbPriority.Location = new Point(12, 269);
            cbPriority.Name = "cbPriority";
            cbPriority.Size = new Size(121, 23);
            cbPriority.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 65);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 4;
            label1.Text = "Description";
            // 
            // teDescription
            // 
            teDescription.Location = new Point(12, 83);
            teDescription.Multiline = true;
            teDescription.Name = "teDescription";
            teDescription.Size = new Size(220, 154);
            teDescription.TabIndex = 3;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(12, 9);
            lbName.Name = "lbName";
            lbName.Size = new Size(39, 15);
            lbName.TabIndex = 2;
            lbName.Text = "Name";
            // 
            // teName
            // 
            teName.Location = new Point(12, 30);
            teName.Name = "teName";
            teName.Size = new Size(175, 23);
            teName.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(201, 19);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 19);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 387);
            Controls.Add(splitContainer1);
            Name = "EditForm";
            Text = "Edit Task";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label lbPriority;
        private ComboBox cbPriority;
        private Label label1;
        private TextBox teDescription;
        private Label lbName;
        private TextBox teName;
        private Button btnClose;
        private Button btnAdd;
    }
}