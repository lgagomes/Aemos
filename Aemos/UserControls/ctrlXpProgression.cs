using Aemos.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Aemos.UserControls
{
    public partial class ctrlXpProgression : UserControl
    {
        XpPerLevelHolder _xpPerLevelHolder;
        XPCalculator _xpCalculatorProgression;
        List<XpPerLevelHolder> _levelProgression;

        public ctrlXpProgression()
        {
            InitializeComponent();

            _xpCalculatorProgression = new XPCalculator();

            UpdateLevelProgressionList();
            FillDataGrid();
            VisualFormatDataGrid();
        }

        private void UpdateLevelProgressionList()
        {
            _levelProgression = new List<XpPerLevelHolder>();

            for (int i = 1; i <= 20; i++)
            {
                _xpPerLevelHolder = new XpPerLevelHolder
                {
                    Level = i,
                    XP = _xpCalculatorProgression.CalculateXPByLevel(i)
                };

                _levelProgression.Add(_xpPerLevelHolder);
            }
        }

        private void FillDataGrid()
        {
            dataGridViewXpProgression.DataSource = _levelProgression;
        }

        private void UpdateXpRequired()
        {
            textBoxXpRequired.Text =
                _xpCalculatorProgression.CalculateXPByLevel(Convert.ToInt64(textBoxCharLevel.Text)).ToString();
        }

        private void VisualFormatDataGrid()
        {
            dataGridViewXpProgression.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
            dataGridViewXpProgression.Columns[0].HeaderCell.Style.Font = new Font(DefaultFont, FontStyle.Bold);
            dataGridViewXpProgression.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
            dataGridViewXpProgression.Columns[1].HeaderCell.Style.Font = new Font(DefaultFont, FontStyle.Bold);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            ((Form)TopLevelControl).Close();
        }

        private void textBoxCharLevel_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxCharLevel.Text))
                UpdateXpRequired();
        }

        private void textBoxCharLevel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
