using System;
using System.Windows.Forms;

namespace Aemos.UserControls
{
    public partial class ctrlCharInputHeader : UserControl
    {
        public event EventHandler ClassChangeEvent;
        public event EventHandler LevelChangeEvent;
        public event EventHandler AttributeScoreEvent;
        private bool _canFireClassChangeEvent;
        private bool _canFireLevelChangeEvent;

        public ctrlCharInputHeader()
        {
            InitializeComponent();
        }

        public string ClassName => comboBoxHeaderClasses.Text;
        public string Level => comboBoxHeaderLevel.Text;
        public string AttributeScore => textBoxHeaderAttributeScore.Text;

        private void ctrlCharInputHeader_Load(object sender, EventArgs e)
        {
            InitializeClasses();
            InitializeLevels();
        }

        private void InitializeClasses()
        {
            comboBoxHeaderClasses.Items.Add("Choose a Class");
            comboBoxHeaderClasses.Items.Add("Barbarian");
            comboBoxHeaderClasses.Items.Add("Bard");
            comboBoxHeaderClasses.Items.Add("Cleric");
            comboBoxHeaderClasses.Items.Add("Druid");
            comboBoxHeaderClasses.Items.Add("Monk");
            comboBoxHeaderClasses.Items.Add("Paladin");
            comboBoxHeaderClasses.Items.Add("Ranger");
            comboBoxHeaderClasses.Items.Add("Rogue");
            comboBoxHeaderClasses.Items.Add("Sorcerer");
            comboBoxHeaderClasses.Items.Add("Warrior");
            comboBoxHeaderClasses.Items.Add("Wizard");

            _canFireClassChangeEvent = false;
            comboBoxHeaderClasses.SelectedIndex = 0;
            _canFireClassChangeEvent = true;
        }

        private void InitializeLevels()
        {
            for (int i = 1; i <= 20; i++)
            {
                comboBoxHeaderLevel.Items.Add(i.ToString());
            }

            _canFireLevelChangeEvent = false;
            comboBoxHeaderLevel.SelectedIndex = 0;
            _canFireLevelChangeEvent = true;
        }

        public void SetLabels(string attributeScore)
        {
            if (string.Equals(attributeScore, "HIDE"))
            {
                labelHeaderAttributeScore.Visible = false;
                textBoxHeaderAttributeScore.Visible = false;
            }
            else
            {
                labelHeaderAttributeScore.Text = attributeScore;
            }
        }

        private void comboBoxHeaderClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_canFireClassChangeEvent)
            {
                ClassChangeEvent?.Invoke(null, null);
            }
        }

        private void comboBoxHeaderLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_canFireLevelChangeEvent)
            {
                LevelChangeEvent?.Invoke(null, null);
            }
        }

        private void textBoxHeaderAttributeScore_TextChanged(object sender, EventArgs e)
        {
            AttributeScoreEvent?.Invoke(null, null);
        }

        private void textBoxHeaderAttributeScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
