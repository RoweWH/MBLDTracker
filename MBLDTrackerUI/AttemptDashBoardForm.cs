using MBLDTracker.DataAccess;
using MBLDTracker.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MBLDTrackerUI
{
    public partial class AttemptDashBoardForm : Form, IResultRequester, IResultViewRequester, INewAttemptRequester
    {
        private List<AttemptModel> completedAttempts;
        private List<AttemptModel> pendingAttempts;

        public AttemptDashBoardForm()
        {
            InitializeComponent();
            LoadAttempts();
            OrderByResultRadioButton.Checked = true;
            WireUpLists();
        }
        public void LoadAttempts()
        {
            completedAttempts = SQLiteConnector.LoadCompletedAttempts();
            pendingAttempts = SQLiteConnector.LoadUncompletedAttempts();
        }
        private void WireUpLists()
        {
            if (OrderByDateRadioButton.Checked)
            {
                completedAttempts = completedAttempts.OrderByDescending(x => DateTime.Parse(x.DateAttempted)).ToList();
            }
            if (OrderByResultRadioButton.Checked)
            {
                completedAttempts = completedAttempts.OrderByDescending(x => WCAPoints(x)).ThenBy(x => x.TotalTime).ToList();
            }
            CompletedAttemptsListBox.DataSource = null;
            CompletedAttemptsListBox.DataSource = completedAttempts;
            CompletedAttemptsListBox.DisplayMember = "CompletedDisplayValue";
            

            PendingAttemptsListBox.DataSource = null;
            PendingAttemptsListBox.DataSource = pendingAttempts;
            PendingAttemptsListBox.DisplayMember = "PendingDisplayValue";
        }

        private int WCAPoints(AttemptModel attempt)
        {
            return attempt.SolvedAtHour - (attempt.Attempted - attempt.SolvedAtHour);
        }

        private void DeletePendingButton_Click(object sender, EventArgs e)
        {
            AttemptModel attempt = (AttemptModel)PendingAttemptsListBox.SelectedItem;
            if (attempt != null)
            {
                pendingAttempts.Remove(attempt);
                SQLiteConnector.DeleteAttempt(attempt);
                WireUpLists();
            }
        }

        private void ViewAttemptButton_Click(object sender, EventArgs e)
        {
            AttemptModel attempt = (AttemptModel)CompletedAttemptsListBox.SelectedItem;
            attempt.Scrambles = SQLiteConnector.LoadScramblesById(attempt.Id);
            if (attempt != null)
            {
                ViewAttemptForm frm = new ViewAttemptForm(attempt, this);
                frm.Show();
            }
        }

        private void EnterResultsPendingButton_Click(object sender, EventArgs e)
        {
            AttemptModel attempt = (AttemptModel)PendingAttemptsListBox.SelectedItem;
            if (attempt != null)
            {
                EnterResultsForm frm = new EnterResultsForm(attempt, this);
                frm.Show();
            }

        }

        private void DeleteCompletedAttemptButton_Click(object sender, EventArgs e)
        {
            AttemptModel attempt = (AttemptModel)CompletedAttemptsListBox.SelectedItem;
            if (attempt != null)
            {
                completedAttempts.Remove(attempt);
                SQLiteConnector.DeleteAttempt(attempt);
                WireUpLists();
            }
        }

        public void ResultsComplete(AttemptModel completeAttempt)
        {
            completedAttempts.Add(completeAttempt);
            pendingAttempts.Remove(completeAttempt);
            WireUpLists();
        }

        public void UpdateAttempts()
        {
            LoadAttempts();
            WireUpLists();
        }

        private void CreateNewButton_Click(object sender, EventArgs e)
        {
            string value = "0";
            var Result = InputBox("Attempt Size", "How Many Cubes?", ref value);
            if (Result == DialogResult.OK)
            {
                int attemptSize = 0;
                bool validAttemptSize = int.TryParse(value, out attemptSize);
                if (validAttemptSize)
                {
                    AttemptModel newAttempt = new AttemptModel(attemptSize);
                    AttemptSetupForm frm = new AttemptSetupForm(newAttempt, this);
                    frm.Show();
                }
            }


        }
        private static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            int intValue = 0;
            bool validIntValue = Int32.TryParse(value, out intValue);
            if (validIntValue && intValue > 1)
            {
                return dialogResult;
            }
            else
            {
                MessageBox.Show("You Must Enter a Valid Integer Greater Than 1");
                return DialogResult.Cancel;
            }
        }

        public void NewAttemptCreated(AttemptModel newAttempt)
        {
            pendingAttempts.Add(newAttempt);
            WireUpLists();
        }

        private void OrderByDateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            WireUpLists();
        }

        private void OrderByResultRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            WireUpLists();
        }
    }
}
