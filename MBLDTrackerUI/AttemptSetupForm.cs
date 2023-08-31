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
    public partial class AttemptSetupForm : Form
    {
        private AttemptModel attempt;
        private int index;
        INewAttemptRequester callingForm;
        public AttemptSetupForm(AttemptModel newAttempt, INewAttemptRequester frm)
        {
            InitializeComponent();
            callingForm = frm;
            attempt = newAttempt;
            RemoveLastScrambleButton();
            index = 1;
            NoImageRadioButton.Checked = true;
            RefreshItems();

        }
        private void RemoveLastScrambleButton()
        {
            LastScrambleButton.Visible = false;
            
        }
        private void AddLastScrambleButton()
        {
            LastScrambleButton.Visible = true;
            
        }
        private void RefreshItems()
        {
            ScrambleValueLabel.Text = null;
            ScrambleValueLabel.Text = $"{index.ToString()}.{attempt.Scrambles[index - 1].Scramble}";
            GenerateColors();
        }

        private void NewScrambleButton_Click(object sender, EventArgs e)
        {
            AddLastScrambleButton();
            if (index < attempt.Scrambles.Count)
            {
                index++;
                if (index == attempt.Scrambles.Count)
                {
                    NewScrambleButton.Text = "Finish";
                }
                RefreshItems();
            }

            else
            {
                MessageBox.Show("GOOD LUCK!");
                //SqlConnector.CreateAttempt(attempt);
                SQLiteConnector.CreateAttempt(attempt);
                callingForm.NewAttemptCreated(attempt);
                this.Close();
            }
        }
        private void GenerateColors()
        {
            if (NoImageRadioButton.Checked)
            {
                foreach (Control control in ScrambleImagePanel.Controls)
                {
                    control.BackColor = Color.Black;
                }
            }
            else if (PartialImageRadioButton.Checked)
            {
                foreach (Control control in ScrambleImagePanel.Controls)
                {
                    control.BackColor = Color.Black;
                }
                UBLColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[0]);
                UBColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[1]);
                UBRColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[2]);
                ULColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[3]);
                UCenterColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[4]);
                URColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[5]);
                UFLColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[6]);
                UFColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[7]);
                UFRColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[8]);
                FCenterColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[22]);
                DFLColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[27]);
                DFRColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[29]);
                DBLColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[33]);
                DBRColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[35]);

            }
            else
            {
                UBLColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[0]);
                UBColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[1]);
                UBRColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[2]);
                ULColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[3]);
                UCenterColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[4]);
                URColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[5]);
                UFLColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[6]);
                UFColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[7]);
                UFRColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[8]);
                RUFColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[9]);
                RUColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[10]);
                RUBColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[11]);
                RFColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[12]);
                RCenterColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[13]);
                RBColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[14]);
                RDFColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[15]);
                RDColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[16]);
                RDBColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[17]);
                FULColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[18]);
                FUColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[19]);
                FURColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[20]);
                FLColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[21]);
                FCenterColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[22]);
                FRColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[23]);
                FDLColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[24]);
                FDColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[25]);
                FDRColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[26]);
                DFLColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[27]);
                DFColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[28]);
                DFRColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[29]);
                DLColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[30]);
                DCenterColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[31]);
                DRColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[32]);
                DBLColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[33]);
                DBColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[34]);
                DBRColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[35]);
                LUBColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[36]);
                LUColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[37]);
                LUFColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[38]);
                LBColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[39]);
                LCenterColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[40]);
                LFColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[41]);
                LDBColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[42]);
                LDColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[43]);
                LDFColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[44]);
                BURColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[45]);
                BUColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[46]);
                BULColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[47]);
                BRColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[48]);
                BCenterColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[49]);
                BLColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[50]);
                BDRColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[51]);
                BDColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[52]);
                BDLColorBox.BackColor = GetColor(attempt.Scrambles[index - 1].ColorString[53]);
            }

        }

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

        private void NoImageRadioButton_CheckChanged(object sender, EventArgs e)
        {
            GenerateColors();
        }

        private void FullImageRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            GenerateColors();
        }

        private void PartialImageRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            GenerateColors();
        }

        private void LastScrambleButton_Click(object sender, EventArgs e)
        {
            if (index == 2)
            {
                RemoveLastScrambleButton();
            }
            if (index > 1)
            {
                index--;
                if (index < attempt.Scrambles.Count)
                {
                    NewScrambleButton.Text = "Next Scramble";
                }

                RefreshItems();
            }
        }
    }
}
