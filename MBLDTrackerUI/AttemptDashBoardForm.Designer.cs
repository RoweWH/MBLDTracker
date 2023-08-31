namespace MBLDTrackerUI
{
    partial class AttemptDashBoardForm
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
            MBLDTrackerTitleLabel = new Label();
            PendingAttemptsLabel = new Label();
            CompletedAttemptsLabel = new Label();
            CompletedAttemptsListBox = new ListBox();
            PendingAttemptsListBox = new ListBox();
            DeletePendingButton = new Button();
            EnterResultsPendingButton = new Button();
            DeleteCompletedAttemptButton = new Button();
            ViewAttemptButton = new Button();
            OrderByResultRadioButton = new RadioButton();
            OrderByDateRadioButton = new RadioButton();
            CreateNewButton = new Button();
            SuspendLayout();
            // 
            // MBLDTrackerTitleLabel
            // 
            MBLDTrackerTitleLabel.AutoSize = true;
            MBLDTrackerTitleLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            MBLDTrackerTitleLabel.Location = new Point(427, 35);
            MBLDTrackerTitleLabel.Name = "MBLDTrackerTitleLabel";
            MBLDTrackerTitleLabel.Size = new Size(284, 54);
            MBLDTrackerTitleLabel.TabIndex = 0;
            MBLDTrackerTitleLabel.Text = "MBLD Tracker";
            // 
            // PendingAttemptsLabel
            // 
            PendingAttemptsLabel.AutoSize = true;
            PendingAttemptsLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            PendingAttemptsLabel.Location = new Point(106, 106);
            PendingAttemptsLabel.Name = "PendingAttemptsLabel";
            PendingAttemptsLabel.Size = new Size(178, 54);
            PendingAttemptsLabel.TabIndex = 1;
            PendingAttemptsLabel.Text = "Pending";
            // 
            // CompletedAttemptsLabel
            // 
            CompletedAttemptsLabel.AutoSize = true;
            CompletedAttemptsLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            CompletedAttemptsLabel.Location = new Point(642, 106);
            CompletedAttemptsLabel.Name = "CompletedAttemptsLabel";
            CompletedAttemptsLabel.Size = new Size(230, 54);
            CompletedAttemptsLabel.TabIndex = 2;
            CompletedAttemptsLabel.Text = "Completed";
            // 
            // CompletedAttemptsListBox
            // 
            CompletedAttemptsListBox.FormattingEnabled = true;
            CompletedAttemptsListBox.ItemHeight = 20;
            CompletedAttemptsListBox.Location = new Point(621, 186);
            CompletedAttemptsListBox.Name = "CompletedAttemptsListBox";
            CompletedAttemptsListBox.Size = new Size(276, 424);
            CompletedAttemptsListBox.TabIndex = 3;
            // 
            // PendingAttemptsListBox
            // 
            PendingAttemptsListBox.FormattingEnabled = true;
            PendingAttemptsListBox.ItemHeight = 20;
            PendingAttemptsListBox.Location = new Point(60, 186);
            PendingAttemptsListBox.Name = "PendingAttemptsListBox";
            PendingAttemptsListBox.Size = new Size(276, 424);
            PendingAttemptsListBox.TabIndex = 4;
            // 
            // DeletePendingButton
            // 
            DeletePendingButton.BackColor = SystemColors.Highlight;
            DeletePendingButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DeletePendingButton.ForeColor = SystemColors.ControlText;
            DeletePendingButton.Location = new Point(370, 474);
            DeletePendingButton.Name = "DeletePendingButton";
            DeletePendingButton.Size = new Size(175, 45);
            DeletePendingButton.TabIndex = 213;
            DeletePendingButton.Text = "Delete";
            DeletePendingButton.UseVisualStyleBackColor = false;
            DeletePendingButton.Click += DeletePendingButton_Click;
            // 
            // EnterResultsPendingButton
            // 
            EnterResultsPendingButton.BackColor = SystemColors.Highlight;
            EnterResultsPendingButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            EnterResultsPendingButton.ForeColor = SystemColors.ControlText;
            EnterResultsPendingButton.Location = new Point(370, 366);
            EnterResultsPendingButton.Name = "EnterResultsPendingButton";
            EnterResultsPendingButton.Size = new Size(175, 45);
            EnterResultsPendingButton.TabIndex = 214;
            EnterResultsPendingButton.Text = "Enter Results";
            EnterResultsPendingButton.UseVisualStyleBackColor = false;
            EnterResultsPendingButton.Click += EnterResultsPendingButton_Click;
            // 
            // DeleteCompletedAttemptButton
            // 
            DeleteCompletedAttemptButton.BackColor = SystemColors.Highlight;
            DeleteCompletedAttemptButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteCompletedAttemptButton.ForeColor = SystemColors.ControlText;
            DeleteCompletedAttemptButton.Location = new Point(932, 482);
            DeleteCompletedAttemptButton.Name = "DeleteCompletedAttemptButton";
            DeleteCompletedAttemptButton.Size = new Size(175, 45);
            DeleteCompletedAttemptButton.TabIndex = 215;
            DeleteCompletedAttemptButton.Text = "Delete";
            DeleteCompletedAttemptButton.UseVisualStyleBackColor = false;
            DeleteCompletedAttemptButton.Click += DeleteCompletedAttemptButton_Click;
            // 
            // ViewAttemptButton
            // 
            ViewAttemptButton.BackColor = SystemColors.Highlight;
            ViewAttemptButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ViewAttemptButton.ForeColor = SystemColors.ControlText;
            ViewAttemptButton.Location = new Point(932, 366);
            ViewAttemptButton.Name = "ViewAttemptButton";
            ViewAttemptButton.Size = new Size(175, 45);
            ViewAttemptButton.TabIndex = 216;
            ViewAttemptButton.Text = "View Attempt";
            ViewAttemptButton.UseVisualStyleBackColor = false;
            ViewAttemptButton.Click += ViewAttemptButton_Click;
            // 
            // OrderByResultRadioButton
            // 
            OrderByResultRadioButton.AutoSize = true;
            OrderByResultRadioButton.Location = new Point(932, 287);
            OrderByResultRadioButton.Name = "OrderByResultRadioButton";
            OrderByResultRadioButton.Size = new Size(132, 24);
            OrderByResultRadioButton.TabIndex = 217;
            OrderByResultRadioButton.TabStop = true;
            OrderByResultRadioButton.Text = "Order By Result";
            OrderByResultRadioButton.UseVisualStyleBackColor = true;
            OrderByResultRadioButton.CheckedChanged += OrderByResultRadioButton_CheckedChanged;
            // 
            // OrderByDateRadioButton
            // 
            OrderByDateRadioButton.AutoSize = true;
            OrderByDateRadioButton.Location = new Point(932, 236);
            OrderByDateRadioButton.Name = "OrderByDateRadioButton";
            OrderByDateRadioButton.Size = new Size(124, 24);
            OrderByDateRadioButton.TabIndex = 218;
            OrderByDateRadioButton.TabStop = true;
            OrderByDateRadioButton.Text = "Order By Date";
            OrderByDateRadioButton.UseVisualStyleBackColor = true;
            OrderByDateRadioButton.CheckedChanged += OrderByDateRadioButton_CheckedChanged;
            // 
            // CreateNewButton
            // 
            CreateNewButton.BackColor = SystemColors.Highlight;
            CreateNewButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CreateNewButton.ForeColor = SystemColors.ControlText;
            CreateNewButton.Location = new Point(370, 258);
            CreateNewButton.Name = "CreateNewButton";
            CreateNewButton.Size = new Size(175, 45);
            CreateNewButton.TabIndex = 219;
            CreateNewButton.Text = "Create New";
            CreateNewButton.UseVisualStyleBackColor = false;
            CreateNewButton.Click += CreateNewButton_Click;
            // 
            // AttemptDashBoardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1139, 654);
            Controls.Add(CreateNewButton);
            Controls.Add(OrderByDateRadioButton);
            Controls.Add(OrderByResultRadioButton);
            Controls.Add(ViewAttemptButton);
            Controls.Add(DeleteCompletedAttemptButton);
            Controls.Add(EnterResultsPendingButton);
            Controls.Add(DeletePendingButton);
            Controls.Add(PendingAttemptsListBox);
            Controls.Add(CompletedAttemptsListBox);
            Controls.Add(CompletedAttemptsLabel);
            Controls.Add(PendingAttemptsLabel);
            Controls.Add(MBLDTrackerTitleLabel);
            ForeColor = SystemColors.Highlight;
            Name = "AttemptDashBoardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Attempt Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MBLDTrackerTitleLabel;
        private Label PendingAttemptsLabel;
        private Label CompletedAttemptsLabel;
        private ListBox CompletedAttemptsListBox;
        private ListBox PendingAttemptsListBox;
        private Button DeletePendingButton;
        private Button EnterResultsPendingButton;
        private Button DeleteCompletedAttemptButton;
        private Button ViewAttemptButton;
        private RadioButton OrderByResultRadioButton;
        private RadioButton OrderByDateRadioButton;
        private Button CreateNewButton;
    }
}