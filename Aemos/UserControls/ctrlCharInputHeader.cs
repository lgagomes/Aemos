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
            _canFireClassChangeEvent = false;
            comboBoxHeaderClasses.SelectedIndex = 0;
            _canFireClassChangeEvent = true;

            InitializeLevels();
            _canFireLevelChangeEvent = false;
            comboBoxHeaderLevel.SelectedIndex = 0;
            _canFireLevelChangeEvent = true;
        }

        private void InitializeClasses()
        {
            comboBoxHeaderClasses.Items.Add("Choose a Class");
            comboBoxHeaderClasses.Items.Add("barbarian");
            comboBoxHeaderClasses.Items.Add("bard");
            comboBoxHeaderClasses.Items.Add("cleric");
            comboBoxHeaderClasses.Items.Add("druid");
            comboBoxHeaderClasses.Items.Add("monk");
            comboBoxHeaderClasses.Items.Add("paladin");
            comboBoxHeaderClasses.Items.Add("ranger");
            comboBoxHeaderClasses.Items.Add("rogue");
            comboBoxHeaderClasses.Items.Add("sorcerer");
            comboBoxHeaderClasses.Items.Add("warrior");
            comboBoxHeaderClasses.Items.Add("wizard");
        }

        private void InitializeLevels()
        {
            for (int i = 1; i <= 20; i++)
                comboBoxHeaderLevel.Items.Add(i.ToString());
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
            if(_canFireClassChangeEvent)
                ClassChangeEvent?.Invoke(null, null);
        }

        private void comboBoxHeaderLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(_canFireLevelChangeEvent)
                LevelChangeEvent?.Invoke(null, null);
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
