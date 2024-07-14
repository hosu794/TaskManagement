namespace Frontend.Forms
{
    partial class ChooseManagerForm
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
            cbChooseManager = new ComboBox();
            lbChooseManager = new Label();
            btnSave = new Button();
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
            splitContainer1.Panel1.Controls.Add(lbChooseManager);
            splitContainer1.Panel1.Controls.Add(cbChooseManager);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(btnClose);
            splitContainer1.Panel2.Controls.Add(btnSave);
            splitContainer1.Size = new Size(241, 313);
            splitContainer1.SplitterDistance = 247;
            splitContainer1.TabIndex = 0;
            // 
            // cbChooseManager
            // 
            cbChooseManager.FormattingEnabled = true;
            cbChooseManager.Location = new Point(12, 38);
            cbChooseManager.Name = "cbChooseManager";
            cbChooseManager.Size = new Size(203, 23);
            cbChooseManager.TabIndex = 0;
            // 
            // lbChooseManager
            // 
            lbChooseManager.AutoSize = true;
            lbChooseManager.Location = new Point(12, 20);
            lbChooseManager.Name = "lbChooseManager";
            lbChooseManager.Size = new Size(97, 15);
            lbChooseManager.TabIndex = 1;
            lbChooseManager.Text = "Choose manager";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 27);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(154, 27);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // ChooseManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(241, 313);
            Controls.Add(splitContainer1);
            MaximumSize = new Size(257, 352);
            MinimumSize = new Size(257, 352);
            Name = "ChooseManagerForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Choose manager";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private ComboBox cbChooseManager;
        private Label lbChooseManager;
        private Button btnClose;
        private Button btnSave;
    }
}