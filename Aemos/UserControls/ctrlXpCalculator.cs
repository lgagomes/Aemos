using Aemos.Forms;
using Aemos.Helpers;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Aemos.UserControls
{
    public partial class ctrlXpCalculator : UserControl
    {
        private XPCalculator _xpCalculator;

        public ctrlXpCalculator()
        {
            InitializeComponent();
            _xpCalculator = new XPCalculator();
        }

        private void UpdateLevelAfterXPGain()
        {
            textBoxLevelAfterXP.Text = (
                _xpCalculator.CalculateLevelBySumXP(
                    Convert.ToInt64(textBoxActualXP.Text),
                    Convert.ToInt64(textBoxReceivedXP.Text))).ToString();
        }

        private void CheckEpicLevel()
        {
            textBoxLevelAfterXP.ReadOnly = false;
            textBoxLevelAfterXP.ForeColor = (Convert.ToInt64(textBoxLevelAfterXP.Text) > 20) ? Color.Blue : Color.Black;
            textBoxLevelAfterXP.ReadOnly = true;
            textBoxLevelAfterXP.BackColor = textBoxLevelAfterXP.BackColor;
        }

        private void UpdateTotalXP()
        {
            textBoxTotalXP.Text = (Convert.ToInt64(textBoxActualXP.Text) + Convert.ToInt64(textBoxReceivedXP.Text)).ToString();
        }

        private void UpdateXpTextBoxes(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxActualXP.Text) && !string.IsNullOrEmpty(textBoxReceivedXP.Text))
            {
                UpdateLevelAfterXPGain();
                UpdateTotalXP();
                CheckEpicLevel();
            }
            else
            {
                WarningMessage.ShowWarningMessage("Please inform a valid value greater than 0");
            }
        }

        private void KeyPressValidation(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void buttonXPProgression_Click(object sender, EventArgs e)
        {
            using (frmXpProgression frmXpProgression = new frmXpProgression())
            {
                frmXpProgression.ShowDialog();
            }            
        }
    }
}
