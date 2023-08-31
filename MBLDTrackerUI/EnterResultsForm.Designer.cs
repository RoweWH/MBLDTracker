namespace MBLDTrackerUI
{
    partial class EnterResultsForm
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
            AttemptNameLabel = new Label();
            CubesAttemptedLabel = new Label();
            CubesAttemptedValueLabel = new Label();
            NotesLabel = new Label();
            TotalTimeLabel = new Label();
            MemoTimeLabel = new Label();
            CubesSolvedAtHourLabel = new Label();
            CubesSolvedLabel = new Label();
            CubesSolvedAtHourTextBox = new TextBox();
            CubesSolvedTextBox = new TextBox();
            NotesTextBox = new TextBox();
            SubmitButton = new Button();
            TotalTimeMinutesTextBox = new TextBox();
            TotalTimeHourTextBox = new TextBox();
            TotalTimeSecondsTextBox = new TextBox();
            ColonLabel = new Label();
            ColonLabel2 = new Label();
            ColonLabel4 = new Label();
            ColonLabel3 = new Label();
            MemoTimeSecondsTextBox = new TextBox();
            MemoTimeHourTextBox = new TextBox();
            MemoTimeMinutesTextBox = new TextBox();
            SuspendLayout();
            // 
            // AttemptNameLabel
            // 
            AttemptNameLabel.AutoSize = true;
            AttemptNameLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            AttemptNameLabel.ForeColor = SystemColors.Highlight;
            AttemptNameLabel.Location = new Point(139, 29);
            AttemptNameLabel.Name = "AttemptNameLabel";
            AttemptNameLabel.Size = new Size(152, 31);
            AttemptNameLabel.TabIndex = 0;
            AttemptNameLabel.Text = "Enter Results";
            // 
            // CubesAttemptedLabel
            // 
            CubesAttemptedLabel.AutoSize = true;
            CubesAttemptedLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CubesAttemptedLabel.ForeColor = SystemColors.Highlight;
            CubesAttemptedLabel.Location = new Point(35, 98);
            CubesAttemptedLabel.Name = "CubesAttemptedLabel";
            CubesAttemptedLabel.Size = new Size(176, 28);
            CubesAttemptedLabel.TabIndex = 3;
            CubesAttemptedLabel.Text = "Cubes Attempted";

            // 
            // CubesAttemptedValueLabel
            // 
            CubesAttemptedValueLabel.AutoSize = true;
            CubesAttemptedValueLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CubesAttemptedValueLabel.ForeColor = SystemColors.Highlight;
            CubesAttemptedValueLabel.Location = new Point(268, 98);
            CubesAttemptedValueLabel.Name = "CubesAttemptedValueLabel";
            CubesAttemptedValueLabel.Size = new Size(128, 28);
            CubesAttemptedValueLabel.TabIndex = 4;
            CubesAttemptedValueLabel.Text = "<#ofCubes>";
            // 
            // NotesLabel
            // 
            NotesLabel.AutoSize = true;
            NotesLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            NotesLabel.ForeColor = SystemColors.Highlight;
            NotesLabel.Location = new Point(35, 388);
            NotesLabel.Name = "NotesLabel";
            NotesLabel.Size = new Size(68, 28);
            NotesLabel.TabIndex = 5;
            NotesLabel.Text = "Notes";
            // 
            // TotalTimeLabel
            // 
            TotalTimeLabel.AutoSize = true;
            TotalTimeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TotalTimeLabel.ForeColor = SystemColors.Highlight;
            TotalTimeLabel.Location = new Point(35, 212);
            TotalTimeLabel.Name = "TotalTimeLabel";
            TotalTimeLabel.Size = new Size(112, 28);
            TotalTimeLabel.TabIndex = 6;
            TotalTimeLabel.Text = "Total Time";
            // 
            // MemoTimeLabel
            // 
            MemoTimeLabel.AutoSize = true;
            MemoTimeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            MemoTimeLabel.ForeColor = SystemColors.Highlight;
            MemoTimeLabel.Location = new Point(35, 162);
            MemoTimeLabel.Name = "MemoTimeLabel";
            MemoTimeLabel.Size = new Size(125, 28);
            MemoTimeLabel.TabIndex = 7;
            MemoTimeLabel.Text = "Memo Time";
            // 
            // CubesSolvedAtHourLabel
            // 
            CubesSolvedAtHourLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CubesSolvedAtHourLabel.ForeColor = SystemColors.Highlight;
            CubesSolvedAtHourLabel.Location = new Point(35, 312);
            CubesSolvedAtHourLabel.Name = "CubesSolvedAtHourLabel";
            CubesSolvedAtHourLabel.Size = new Size(145, 67);
            CubesSolvedAtHourLabel.TabIndex = 8;
            CubesSolvedAtHourLabel.Text = "Cubes Solved At Hour";
            // 
            // CubesSolvedLabel
            // 
            CubesSolvedLabel.AutoSize = true;
            CubesSolvedLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CubesSolvedLabel.ForeColor = SystemColors.Highlight;
            CubesSolvedLabel.Location = new Point(35, 262);
            CubesSolvedLabel.Name = "CubesSolvedLabel";
            CubesSolvedLabel.Size = new Size(137, 28);
            CubesSolvedLabel.TabIndex = 9;
            CubesSolvedLabel.Text = "Cubes Solved";
            // 
            // CubesSolvedAtHourTextBox
            // 
            CubesSolvedAtHourTextBox.Location = new Point(268, 312);
            CubesSolvedAtHourTextBox.Name = "CubesSolvedAtHourTextBox";
            CubesSolvedAtHourTextBox.Size = new Size(125, 27);
            CubesSolvedAtHourTextBox.TabIndex = 7;
            CubesSolvedAtHourTextBox.Text = "0";
            // 
            // CubesSolvedTextBox
            // 
            CubesSolvedTextBox.Location = new Point(268, 262);
            CubesSolvedTextBox.Name = "CubesSolvedTextBox";
            CubesSolvedTextBox.Size = new Size(125, 27);
            CubesSolvedTextBox.TabIndex = 6;
            CubesSolvedTextBox.Text = "0";

            // 
            // NotesTextBox
            // 
            NotesTextBox.Location = new Point(35, 430);
            NotesTextBox.Multiline = true;
            NotesTextBox.Name = "NotesTextBox";
            NotesTextBox.Size = new Size(361, 152);
            NotesTextBox.TabIndex = 8;
            // 
            // SubmitButton
            // 
            SubmitButton.BackColor = SystemColors.Highlight;
            SubmitButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            SubmitButton.Location = new Point(139, 602);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(145, 42);
            SubmitButton.TabIndex = 9;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = false;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // TotalTimeMinutesTextBox
            // 
            TotalTimeMinutesTextBox.Location = new Point(314, 212);
            TotalTimeMinutesTextBox.Name = "TotalTimeMinutesTextBox";
            TotalTimeMinutesTextBox.Size = new Size(32, 27);
            TotalTimeMinutesTextBox.TabIndex = 4;
            TotalTimeMinutesTextBox.Text = "00";
            TotalTimeMinutesTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // TotalTimeHourTextBox
            // 
            TotalTimeHourTextBox.Location = new Point(268, 212);
            TotalTimeHourTextBox.Name = "TotalTimeHourTextBox";
            TotalTimeHourTextBox.Size = new Size(32, 27);
            TotalTimeHourTextBox.TabIndex = 3;
            TotalTimeHourTextBox.Text = "00";
            TotalTimeHourTextBox.TextAlign = HorizontalAlignment.Center;
            TotalTimeHourTextBox.TextChanged += TotalTimeHourTextBox_TextChanged;
            // 
            // TotalTimeSecondsTextBox
            // 
            TotalTimeSecondsTextBox.Location = new Point(360, 212);
            TotalTimeSecondsTextBox.Name = "TotalTimeSecondsTextBox";
            TotalTimeSecondsTextBox.Size = new Size(32, 27);
            TotalTimeSecondsTextBox.TabIndex = 5;
            TotalTimeSecondsTextBox.Text = "00";
            TotalTimeSecondsTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // ColonLabel
            // 
            ColonLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ColonLabel.ForeColor = SystemColors.Highlight;
            ColonLabel.Location = new Point(300, 208);
            ColonLabel.Name = "ColonLabel";
            ColonLabel.Size = new Size(14, 35);
            ColonLabel.TabIndex = 19;
            ColonLabel.Text = ":";
            // 
            // ColonLabel2
            // 
            ColonLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ColonLabel2.ForeColor = SystemColors.Highlight;
            ColonLabel2.Location = new Point(346, 208);
            ColonLabel2.Name = "ColonLabel2";
            ColonLabel2.Size = new Size(14, 35);
            ColonLabel2.TabIndex = 20;
            ColonLabel2.Text = ":";
            // 
            // ColonLabel4
            // 
            ColonLabel4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ColonLabel4.ForeColor = SystemColors.Highlight;
            ColonLabel4.Location = new Point(346, 162);
            ColonLabel4.Name = "ColonLabel4";
            ColonLabel4.Size = new Size(14, 35);
            ColonLabel4.TabIndex = 25;
            ColonLabel4.Text = ":";
            // 
            // ColonLabel3
            // 
            ColonLabel3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ColonLabel3.ForeColor = SystemColors.Highlight;
            ColonLabel3.Location = new Point(300, 162);
            ColonLabel3.Name = "ColonLabel3";
            ColonLabel3.Size = new Size(14, 35);
            ColonLabel3.TabIndex = 24;
            ColonLabel3.Text = ":";
            // 
            // MemoTimeSecondsTextBox
            // 
            MemoTimeSecondsTextBox.Location = new Point(360, 166);
            MemoTimeSecondsTextBox.Name = "MemoTimeSecondsTextBox";
            MemoTimeSecondsTextBox.Size = new Size(32, 27);
            MemoTimeSecondsTextBox.TabIndex = 2;
            MemoTimeSecondsTextBox.Text = "00";
            MemoTimeSecondsTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // MemoTimeHourTextBox
            // 
            MemoTimeHourTextBox.Location = new Point(268, 166);
            MemoTimeHourTextBox.Name = "MemoTimeHourTextBox";
            MemoTimeHourTextBox.Size = new Size(32, 27);
            MemoTimeHourTextBox.TabIndex = 0;
            MemoTimeHourTextBox.Text = "00";
            MemoTimeHourTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // MemoTimeMinutesTextBox
            // 
            MemoTimeMinutesTextBox.Location = new Point(314, 166);
            MemoTimeMinutesTextBox.Name = "MemoTimeMinutesTextBox";
            MemoTimeMinutesTextBox.Size = new Size(32, 27);
            MemoTimeMinutesTextBox.TabIndex = 1;
            MemoTimeMinutesTextBox.Text = "00";
            MemoTimeMinutesTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // EnterResultsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(430, 665);
            Controls.Add(ColonLabel4);
            Controls.Add(ColonLabel3);
            Controls.Add(MemoTimeSecondsTextBox);
            Controls.Add(MemoTimeHourTextBox);
            Controls.Add(MemoTimeMinutesTextBox);
            Controls.Add(ColonLabel2);
            Controls.Add(ColonLabel);
            Controls.Add(TotalTimeSecondsTextBox);
            Controls.Add(TotalTimeHourTextBox);
            Controls.Add(TotalTimeMinutesTextBox);
            Controls.Add(SubmitButton);
            Controls.Add(NotesTextBox);
            Controls.Add(CubesSolvedTextBox);
            Controls.Add(CubesSolvedAtHourTextBox);
            Controls.Add(CubesSolvedLabel);
            Controls.Add(CubesSolvedAtHourLabel);
            Controls.Add(MemoTimeLabel);
            Controls.Add(TotalTimeLabel);
            Controls.Add(NotesLabel);
            Controls.Add(CubesAttemptedValueLabel);
            Controls.Add(CubesAttemptedLabel);
            Controls.Add(AttemptNameLabel);
            Name = "EnterResultsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Enter Results";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AttemptNameLabel;
        private TextBox MemoTimeTextBox;
        private Label CubesAttemptedLabel;
        private Label CubesAttemptedValueLabel;
        private Label NotesLabel;
        private Label TotalTimeLabel;
        private Label MemoTimeLabel;
        private Label CubesSolvedAtHourLabel;
        private Label CubesSolvedLabel;
        private TextBox TotalTimeTextBox;





        private Label ColonLabel;
        private Label ColonLabel2;
        private Label ColonLabel4;
        private Label ColonLabel3;
        private TextBox MemoTimeHourTextBox;
        private TextBox MemoTimeMinutesTextBox;
        private TextBox MemoTimeSecondsTextBox;
        private TextBox TotalTimeHourTextBox;
        private TextBox TotalTimeMinutesTextBox;
        private TextBox TotalTimeSecondsTextBox;
        private TextBox CubesSolvedTextBox;
        private TextBox CubesSolvedAtHourTextBox;
        private TextBox NotesTextBox;
        private Button SubmitButton;
    }
}