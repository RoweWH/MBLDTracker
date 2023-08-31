using MBLDTracker.DataAccess;
using MBLDTracker.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MBLDTracker.FormattingTools;

namespace MBLDTrackerUI
{
    public partial class ViewAttemptForm : Form, IResultRequester
    {
        private AttemptModel attempt;
        IResultViewRequester callingForm;

        public ViewAttemptForm(AttemptModel selectedAttempt, IResultViewRequester frm)
        {
            callingForm = frm;
            InitializeComponent();
            attempt = selectedAttempt;
            WireUpLists();
            LoadScrambleImage();

        }
        private void LoadScrambleImage()
        {
            ScrambleModel scramble = (ScrambleModel)ScramblesListBox.SelectedItem;
            if (scramble != null)
            {
                GenerateColors(scramble.ColorString);
            }
        }
        private void GenerateColors(string colorString)
        {
            UBLColorBox.BackColor = GetColor(colorString[0]);
            UBColorBox.BackColor = GetColor(colorString[1]);
            UBRColorBox.BackColor = GetColor(colorString[2]);
            ULColorBox.BackColor = GetColor(colorString[3]);
            UCenterColorBox.BackColor = GetColor(colorString[4]);
            URColorBox.BackColor = GetColor(colorString[5]);
            UFLColorBox.BackColor = GetColor(colorString[6]);
            UFColorBox.BackColor = GetColor(colorString[7]);
            UFRColorBox.BackColor = GetColor(colorString[8]);
            RUFColorBox.BackColor = GetColor(colorString[9]);
            RUColorBox.BackColor = GetColor(colorString[10]);
            RUBColorBox.BackColor = GetColor(colorString[11]);
            RFColorBox.BackColor = GetColor(colorString[12]);
            RCenterColorBox.BackColor = GetColor(colorString[13]);
            RBColorBox.BackColor = GetColor(colorString[14]);
            RDFColorBox.BackColor = GetColor(colorString[15]);
            RDColorBox.BackColor = GetColor(colorString[16]);
            RDBColorBox.BackColor = GetColor(colorString[17]);
            FULColorBox.BackColor = GetColor(colorString[18]);
            FUColorBox.BackColor = GetColor(colorString[19]);
            FURColorBox.BackColor = GetColor(colorString[20]);
            FLColorBox.BackColor = GetColor(colorString[21]);
            FCenterColorBox.BackColor = GetColor(colorString[22]);
            FRColorBox.BackColor = GetColor(colorString[23]);
            FDLColorBox.BackColor = GetColor(colorString[24]);
            FDColorBox.BackColor = GetColor(colorString[25]);
            FDRColorBox.BackColor = GetColor(colorString[26]);
            DFLColorBox.BackColor = GetColor(colorString[27]);
            DFColorBox.BackColor = GetColor(colorString[28]);
            DFRColorBox.BackColor = GetColor(colorString[29]);
            DLColorBox.BackColor = GetColor(colorString[30]);
            DCenterColorBox.BackColor = GetColor(colorString[31]);
            DRColorBox.BackColor = GetColor(colorString[32]);
            DBLColorBox.BackColor = GetColor(colorString[33]);
            DBColorBox.BackColor = GetColor(colorString[34]);
            DBRColorBox.BackColor = GetColor(colorString[35]);
            LUBColorBox.BackColor = GetColor(colorString[36]);
            LUColorBox.BackColor = GetColor(colorString[37]);
            LUFColorBox.BackColor = GetColor(colorString[38]);
            LBColorBox.BackColor = GetColor(colorString[39]);
            LCenterColorBox.BackColor = GetColor(colorString[40]);
            LFColorBox.BackColor = GetColor(colorString[41]);
            LDBColorBox.BackColor = GetColor(colorString[42]);
            LDColorBox.BackColor = GetColor(colorString[43]);
            LDFColorBox.BackColor = GetColor(colorString[44]);
            BURColorBox.BackColor = GetColor(colorString[45]);
            BUColorBox.BackColor = GetColor(colorString[46]);
            BULColorBox.BackColor = GetColor(colorString[47]);
            BRColorBox.BackColor = GetColor(colorString[48]);
            BCenterColorBox.BackColor = GetColor(colorString[49]);
            BLColorBox.BackColor = GetColor(colorString[50]);
            BDRColorBox.BackColor = GetColor(colorString[51]);
            BDColorBox.BackColor = GetColor(colorString[52]);
            BDLColorBox.BackColor = GetColor(colorString[53]);
        }
        /// <summary>
        /// returns correct color based on given char c
        /// </summary>
        /// <param name="c">always either U, F, R, B, L or D</param>
        /// <returns></returns>
        private Color GetColor(char c)
        {
            if (c == 'U')
            {
                return Color.White;
            }
            else if (c == 'F')
            {
                return Color.Lime;
            }
            else if (c == 'R')
            {
                return Color.Red;
            }
            else if (c == 'B')
            {
                return Color.Blue;
            }
            else if (c == 'L')
            {
                return Color.Orange;
            }
            else
            {
                return Color.Yellow;
            }
        }
        private void WireUpLists()
        {
            ScramblesListBox.DataSource = null;
            ScramblesListBox.DataSource = attempt.Scrambles;
            ScramblesListBox.DisplayMember = "Scramble";

            ResultHeaderLabel.Text = attempt.CompletedDisplayValue;
            FullResultValueLabel.Text = attempt.CompletedDisplayValue;

            if (TimeSpan.Parse(attempt.TotalTime) > new TimeSpan(1, 0, 0))
            {
                HourResultValueLabel.Text = attempt.HourDisplayValue;
            }
            else HourResultValueLabel.Text = attempt.CompletedDisplayValue;

            int wcaPoints = (attempt.SolvedAtHour - (attempt.Attempted - attempt.SolvedAtHour));
            if (wcaPoints >= 0) WCAPointsValueLabel.Text = wcaPoints.ToString();
            else WCAPointsValueLabel.Text = "DNF";

            MemoTimeValueLabel.Text = attempt.MemoTimeDisplayValue;

            TimeSpan exec = TimeSpan.Parse(attempt.TotalTime) - TimeSpan.Parse(attempt.MemoTime);
            ExecTimeValueLabel.Text = FormatTime(exec.ToString());


            double execPerCube = Math.Round((exec.TotalSeconds / attempt.Attempted), 2);
            if (execPerCube > 60)
            {
                ExecPerCubeValueLabel.Text = FormatTime(TimeSpan.FromSeconds(Math.Truncate(execPerCube)).ToString());
            }
            else
            {
                ExecPerCubeValueLabel.Text = execPerCube.ToString();
            }
            double memoPerCube = Math.Round((TimeSpan.Parse(attempt.MemoTime).TotalSeconds / attempt.Attempted), 2);
            if (memoPerCube > 60)
            {
                MemoPerCubeValueLabel.Text = FormatTime(TimeSpan.FromSeconds(Math.Truncate(memoPerCube)).ToString());
            }
            else
            {
                MemoPerCubeValueLabel.Text = memoPerCube.ToString();
            }

            double totalPerCube = Math.Round((TimeSpan.Parse(attempt.TotalTime).TotalSeconds / attempt.Attempted), 2);
            if (totalPerCube > 60)
            {
                TotalPerCubeValueLabel.Text = FormatTime(TimeSpan.FromSeconds(Math.Truncate(totalPerCube)).ToString());
            }
            else
            {
                TotalPerCubeValueLabel.Text = totalPerCube.ToString();
            }


            CPHValueLabel.Text = Math.Round((new TimeSpan(1, 0, 0).TotalSeconds / (TimeSpan.Parse(attempt.TotalTime).TotalSeconds / attempt.Attempted)), 2).ToString();

            AccuracyValueLabel.Text = $"{Math.Round(((double)(100 * attempt.Solved) / attempt.Attempted), 2)}%";

            NotesTextBox.Text = attempt.Notes;
        }






        private void ScramblesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadScrambleImage();
        }



        public void ResultsComplete(AttemptModel completedAttempt)
        {
            attempt = completedAttempt;
            SQLiteConnector.UpdateAttempt(completedAttempt);
            callingForm.UpdateAttempts();
            WireUpLists();
            LoadScrambleImage();
        }

        private void EditResultButton_Click(object sender, EventArgs e)
        {
            EnterResultsForm frm = new EnterResultsForm(attempt, this);
            frm.Show();
        }

        private void ViewAttemptForm_Load(object sender, EventArgs e)
        {

        }
    }
}
