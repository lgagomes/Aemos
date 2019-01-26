using Aemos.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aemos.UserControls
{
    public partial class ctrlDiceRoller : UserControl
    {
        private DiceRollerManager _diceRollerManager;

        public ctrlDiceRoller()
        {
            InitializeComponent();
        }

        private void ctrlDiceRoller_Load(object sender, EventArgs e)
        {
            _diceRollerManager = new DiceRollerManager();
            comboBoxModifierSignal.SelectedIndex = 0;
        }

        private void ExtractNumberOfDiceFaces(string diceInfo)
        {
            StringBuilder digits = new StringBuilder();

            /* d4, d6, d8 => gets the last character
             * d10, d12, d20 => gets the last 2 characters
             * d100 => gets the last 3 characters */
            
            switch (diceInfo.Length)
            {
                case 9:
                    digits.Append(diceInfo[diceInfo.Length - 2]);
                    break;

                case 10:
                    digits.Append(diceInfo[diceInfo.Length - 3]);
                    digits.Append(diceInfo[diceInfo.Length - 2]);
                    break;
            }
            digits.Append(diceInfo[diceInfo.Length - 1]);
            int.TryParse(digits.ToString(), out int result);
            _diceRollerManager.NumberOfDiceFaces = result;
        }

        private void UpdateDiceType(object sender, EventArgs e)
        {
            labelCustomDice.Visible = false;
            textBoxCustomDice.Visible = false;
            textBoxDiceRollModifier.ReadOnly = false;

            Button buttonSender = sender as Button;
            labelDiceType.Text = buttonSender.Text;

            ExtractNumberOfDiceFaces(buttonSender.Name);
        }

        private void ShowRollResults()
        {
            PrintRollHeader();
            PrintRolls();
        }

        private void PrintRollHeader()
        {
            StringBuilder rollSummary = new StringBuilder();

            rollSummary.AppendFormat("Rolling {0}", textBoxNumberOfDices.Text);

            if (string.Equals(labelDiceType.Text, "Custom Dice"))
                rollSummary.AppendFormat("d{0}", textBoxCustomDice.Text);
            else
                rollSummary.Append(labelDiceType.Text);

            rollSummary.AppendFormat("{0}{1}", comboBoxModifierSignal.Text, textBoxDiceRollModifier.Text);
            rollSummary.AppendFormat(" at {0}... {1}" , DateTime.Now.ToString("HH:mm:ss"), Environment.NewLine);

            textBoxRollResults.Text += rollSummary;
        }

        private void PrintRolls()
        {
            StringBuilder rollsResult = new StringBuilder();
            if (radioButtonAfterRolls.Checked)
            {
                int i = 0;
                rollsResult.Append("(");
                foreach (var roll in _diceRollerManager.Rolls)
                {
                    rollsResult.Append(roll);
                    if (i < _diceRollerManager.Rolls.Count - 1)
                    {
                        rollsResult.Append(" + ");
                    }
                    else
                    {
                        rollsResult.AppendFormat(") {0} ", comboBoxModifierSignal.Text);
                    }
                    i++;
                }
                rollsResult.AppendFormat("{0} = {1}{2}", Math.Abs(_diceRollerManager.Modifier), _diceRollerManager.TotalRolledValues, Environment.NewLine);
            }
            else if (radioButtonEachRoll.Checked)
            {
                int j = 0;
                foreach (var roll in _diceRollerManager.Rolls)
                {
                    rollsResult.Append("(");
                    rollsResult.Append(roll);
                    if (j < _diceRollerManager.Rolls.Count - 1)
                    {
                        rollsResult.AppendFormat(" {0} {1} ", comboBoxModifierSignal.Text, Math.Abs(_diceRollerManager.Modifier));
                        rollsResult.Append(") + ");
                    }
                    else
                    {
                        rollsResult.AppendFormat(" {0} {1}) ", comboBoxModifierSignal.Text, Math.Abs(_diceRollerManager.Modifier));
                    }
                    j++;                    
                }
                rollsResult.AppendFormat("= {0}", _diceRollerManager.TotalRolledValues);
            }
            rollsResult.AppendFormat("{0}{0}", Environment.NewLine);
            textBoxRollResults.Text += rollsResult;
        }

        private List<string> CheckMissingInfo()
        {
            List<string> missingInformation = new List<string>();

            if (string.Equals(labelDiceType.Text, "__"))
                missingInformation.Add(" - DICE TYPE");

            if (string.IsNullOrWhiteSpace(textBoxNumberOfDices.Text))
                missingInformation.Add(" - NUMBER OF DICES TO ROLL");

            return missingInformation;
        }

        private void buttonCustomDice_Click(object sender, EventArgs e)
        {
            labelDiceType.Text = "Custom Dice";
            labelCustomDice.Visible = true;
            textBoxCustomDice.Visible = true;
        }

        private void textBoxNumberOfDices_TextChanged(object sender, EventArgs e)
        {
            if (string.Equals(textBoxNumberOfDices.Text, ""))
            {
                WarningMessage.ShowWarningMessage("Please insert a positive value");
            }
            else
            {
                _diceRollerManager.NumberOfRolls = Convert.ToInt32(textBoxNumberOfDices.Text);
            }
        }

        private void textBoxCustomDice_TextChanged(object sender, EventArgs e)
        {
            if (string.Equals(textBoxCustomDice.Text, ""))
            {
                WarningMessage.ShowWarningMessage("Please insert a positive value");
            }
            else
            {
                _diceRollerManager.NumberOfDiceFaces = Convert.ToInt32(textBoxCustomDice.Text);
            }
        }

        private void radioButtonAfterRolls_CheckedChanged(object sender, EventArgs e)
        {
            _diceRollerManager.AddEachRoll = false;
        }

        private void radioButtonEachRoll_CheckedChanged(object sender, EventArgs e)
        {
            _diceRollerManager.AddEachRoll = true;
        }

        private void buttonRoll_Click(object sender, EventArgs e)
        {
            /* If we do consective rolls with a negative modifier, each time we enter here
            * the modifier will be multiplied by -1, becoming positive, so we need to get it 
            * again */

            List<string> missingFields = CheckMissingInfo();

            if (!missingFields.Any())
            {
                _diceRollerManager.Modifier = Convert.ToInt32(textBoxDiceRollModifier.Text);
                if (string.Equals(comboBoxModifierSignal.Text, "-"))
                {
                    _diceRollerManager.Modifier *= -1;
                }

                _diceRollerManager.AccumulateValues();
                ShowRollResults();
            }
            else
            {
                StringBuilder warnings = new StringBuilder();
                warnings.AppendFormat("The missing required infos are missing: {0}", Environment.NewLine);

                foreach (var message in missingFields)
                {
                    warnings.AppendFormat("{0} {1}",message,Environment.NewLine);
                }
                WarningMessage.ShowWarningMessage(warnings.ToString());
            }
        }

        private void buttonClearRollResults_Click(object sender, EventArgs e)
        {
            textBoxRollResults.Text = "";
        }

        private void textBoxRollResults_TextChanged(object sender, EventArgs e)
        {
            textBoxRollResults.SelectionStart = textBoxRollResults.Text.Length;
            textBoxRollResults.ScrollToCaret();
            textBoxRollResults.Refresh();
        }
        
        private void TextBoxKeyPressCommon(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
