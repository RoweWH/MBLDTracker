using MBLDTracker.DataAccess.Models;
using MBLDTracker.DataAccess;
using System.Security.Cryptography;

namespace MBLDTrackerUI
{
    public partial class EnterResultsForm : Form
    {
        AttemptModel attempt;
        IResultRequester callingForm;

        public EnterResultsForm(AttemptModel currentAttempt, IResultRequester frm)
        {
            InitializeComponent();
            attempt = currentAttempt;
            callingForm = frm;
            CubesAttemptedValueLabel.Text = attempt.Attempted.ToString();
            CubesSolvedAtHourLabel.Visible = false;
            CubesSolvedAtHourTextBox.Visible = false;
            LoadDefaultValues();
        }
        private void LoadDefaultValues()
        {
            if (attempt.Solved != null)
            {
                CubesSolvedTextBox.Text = attempt.Solved.ToString();
            }
            if (attempt.SolvedAtHour != null)
            {
                CubesSolvedAtHourTextBox.Text = attempt.SolvedAtHour.ToString();
            }
            if (attempt.MemoTime != null)
            {
                TimeSpan memoTime = TimeSpan.Parse(attempt.MemoTime);
                if (memoTime.Hours != 0)
                {
                    if (memoTime.Hours < 10)
                    {
                        MemoTimeHourTextBox.Text = $"0{memoTime.Hours}";
                    }
                    else MemoTimeHourTextBox.Text = memoTime.Hours.ToString();
                }
                if (memoTime.Minutes != 0)
                {
                    if (memoTime.Minutes < 10)
                    {
                        MemoTimeMinutesTextBox.Text = $"0{memoTime.Minutes}";
                    }
                    else MemoTimeMinutesTextBox.Text = memoTime.Minutes.ToString();
                }
                if (memoTime.Seconds != 0)
                {
                    if (memoTime.Seconds < 10)
                    {
                        MemoTimeSecondsTextBox.Text = $"0{memoTime.Seconds}";
                    }
                    else MemoTimeSecondsTextBox.Text = memoTime.Seconds.ToString();
                }

            }
            if (attempt.TotalTime != null)
            {
                TimeSpan totalTime = TimeSpan.Parse(attempt.TotalTime);
                if (totalTime.Hours != 0)
                {
                    if (totalTime.Hours < 10)
                    {
                        TotalTimeHourTextBox.Text = $"0{totalTime.Hours}";
                    }
                    else TotalTimeHourTextBox.Text = totalTime.Hours.ToString();
                }
                if (totalTime.Minutes != 0)
                {
                    if (totalTime.Minutes < 10)
                    {
                        TotalTimeMinutesTextBox.Text = $"0{totalTime.Minutes}";
                    }
                    else TotalTimeMinutesTextBox.Text = totalTime.Minutes.ToString();
                }
                if (totalTime.Seconds != 0)
                {
                    if (totalTime.Seconds < 10)
                    {
                        TotalTimeSecondsTextBox.Text = $"0{totalTime.Seconds}";
                    }
                    else TotalTimeSecondsTextBox.Text = totalTime.Seconds.ToString();
                }

            }
            if (attempt.Notes != null)
            {
                NotesTextBox.Text = attempt.Notes;
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {

            bool dataValid = ValidateData();
            if (dataValid)
            {
                TimeSpan memoTime = new TimeSpan(int.Parse(MemoTimeHourTextBox.Text), int.Parse(MemoTimeMinutesTextBox.Text), int.Parse(MemoTimeSecondsTextBox.Text));
                TimeSpan totalTime = new TimeSpan(int.Parse(TotalTimeHourTextBox.Text), int.Parse(TotalTimeMinutesTextBox.Text), int.Parse(TotalTimeSecondsTextBox.Text));
                attempt.MemoTime = memoTime.ToString();
                attempt.TotalTime = totalTime.ToString();
                attempt.Solved = int.Parse(CubesSolvedTextBox.Text);
                attempt.SolvedAtHour = int.Parse(CubesSolvedAtHourTextBox.Text);
                attempt.Notes = NotesTextBox.Text;
                SQLiteConnector.SaveResults(attempt);
                callingForm.ResultsComplete(attempt);
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
        }
        private bool ValidateData()
        {
            int solved;
            int solvedAtHour;
            int memoTimeHours;
            int memoTimeMinutes;
            int memoTimeSeconds;
            int totalTimeHours;
            int totalTimeMinutes;
            int totalTimeSeconds;
            int cubesSolved;
            int cubesSolvedAtHour;
            bool memoTimeHoursValid = int.TryParse(MemoTimeHourTextBox.Text, out memoTimeHours);
            bool memoTimeMinutesValid = int.TryParse(MemoTimeMinutesTextBox.Text, out memoTimeMinutes);
            bool memoTimeSecondsValid = int.TryParse(MemoTimeSecondsTextBox.Text, out memoTimeSeconds);
            bool totalTimeHoursValid = int.TryParse(TotalTimeHourTextBox.Text, out totalTimeHours);
            bool totalTimeMinutesValid = int.TryParse(TotalTimeMinutesTextBox.Text, out totalTimeMinutes);
            bool totalTimeSecondsValid = int.TryParse(TotalTimeSecondsTextBox.Text, out totalTimeSeconds);
            bool cubesSolvedValid = int.TryParse(CubesSolvedTextBox.Text, out cubesSolved);
            bool cubesSolvedAtHourValid = int.TryParse(CubesSolvedAtHourTextBox.Text, out cubesSolvedAtHour);
            if(CubesSolvedAtHourTextBox.Visible == false)
            {
                CubesSolvedAtHourTextBox.Text = CubesSolvedTextBox.Text;
            }
            
            bool valid = true;
            if (!memoTimeHoursValid || memoTimeHours < 0)
            {
                if (!String.IsNullOrWhiteSpace(MemoTimeHourTextBox.Text))
                {
                    return false;
                }
                else
                {
                    MemoTimeHourTextBox.Text = "0";
                }
            }
            if (!memoTimeMinutesValid || memoTimeMinutes >= 60 || memoTimeMinutes < 0)
            {
                if (!String.IsNullOrWhiteSpace(MemoTimeMinutesTextBox.Text))
                {
                    return false;
                }
                else
                {
                    MemoTimeMinutesTextBox.Text = "0";
                }
            }
            if (!memoTimeSecondsValid || memoTimeSeconds >= 60 || memoTimeSeconds < 0)
            {
                if (!String.IsNullOrWhiteSpace(MemoTimeSecondsTextBox.Text))
                {
                    return false;
                }
                else
                {
                    MemoTimeSecondsTextBox.Text = "0";
                }
            }
            if (!totalTimeHoursValid || totalTimeHours < 0)
            {
                if (!String.IsNullOrWhiteSpace(TotalTimeHourTextBox.Text))
                {
                    return false;
                }
                else
                {
                    TotalTimeHourTextBox.Text = "0";
                }
            }
            if (!totalTimeMinutesValid || totalTimeMinutes >= 60 || totalTimeMinutes < 0)
            {
                if (!String.IsNullOrWhiteSpace(TotalTimeMinutesTextBox.Text))
                {
                    return false;
                }
                else
                {
                    TotalTimeMinutesTextBox.Text = "0";
                }
            }
            if (!totalTimeSecondsValid || totalTimeSeconds >= 60 || totalTimeSeconds < 0)
            {
                if (!String.IsNullOrWhiteSpace(TotalTimeSecondsTextBox.Text))
                {
                    return false;
                }
                else
                {
                    TotalTimeSecondsTextBox.Text = "0";
                }
            }
            if (!cubesSolvedValid || cubesSolved > attempt.Attempted)
            {
                return false;
            }
            if (!cubesSolvedAtHourValid || cubesSolvedAtHour > cubesSolved)
            {
                return false;
            }
            if (NotesTextBox.Text.Length > 5000)
            {
                return false;
            }
            TimeSpan memoTimeSpan = new TimeSpan(memoTimeHours, memoTimeMinutes, memoTimeSeconds);
            TimeSpan totalTimeSpan = new TimeSpan(totalTimeHours, totalTimeMinutes, totalTimeSeconds);
            if (memoTimeSpan > totalTimeSpan) return false;
            
            return valid;
        }

        private void TotalTimeHourTextBox_TextChanged(object sender, EventArgs e)
        {
            int intValid = 0;
            if (int.TryParse(TotalTimeHourTextBox.Text, out intValid))
            {
                if (intValid > 0)
                {
                    CubesSolvedAtHourTextBox.Visible = true;
                    CubesSolvedAtHourLabel.Visible = true;
                }
                else
                {
                    CubesSolvedAtHourTextBox.Visible = false;
                    CubesSolvedAtHourLabel.Visible = false;
                }
            }
            else
            {
                CubesSolvedAtHourTextBox.Visible = false;
                CubesSolvedAtHourLabel.Visible = false;
            }

        }
    }
}