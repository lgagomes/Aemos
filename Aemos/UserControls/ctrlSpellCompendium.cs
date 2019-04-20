using Aemos.Helpers;
using System;
using System.Windows.Forms;

namespace Aemos.UserControls
{
    public partial class ctrlSpellCompendium : UserControl
    {
        public ctrlSpellCompendium()
        {
            InitializeComponent();
            
        }

        private void ctrlSpellCompendium_Load(object sender, EventArgs e)
        {
            InitializeClasses();
            InitializeLevels();
            InitializeSpellsSchools();
        }       

        private void InitializeClasses()
        {
            comboBoxClassToSearch.Items.Add("Choose a Class");
            comboBoxClassToSearch.Items.Add("Barbarian");
            comboBoxClassToSearch.Items.Add("Bard");
            comboBoxClassToSearch.Items.Add("Cleric");
            comboBoxClassToSearch.Items.Add("Druid");
            comboBoxClassToSearch.Items.Add("Monk");
            comboBoxClassToSearch.Items.Add("Paladin");
            comboBoxClassToSearch.Items.Add("Ranger");
            comboBoxClassToSearch.Items.Add("Rogue");
            comboBoxClassToSearch.Items.Add("Sorcerer");
            comboBoxClassToSearch.Items.Add("Warrior");
            comboBoxClassToSearch.Items.Add("Wizard");

            comboBoxClassToSearch.SelectedIndex = 0;
        }

        private void InitializeLevels()
        {
            for (int i = 1; i <= 20; i++)
            {
                comboBoxLevelToSearch.Items.Add(i.ToString());
            }
        }

        private void InitializeSpellsSchools()
        {
            comboBoxSpellSchool.Items.Add("Select a School");
            comboBoxSpellSchool.Items.Add("Abjuration");
            comboBoxSpellSchool.Items.Add("Conjuration");
            comboBoxSpellSchool.Items.Add("Divination");
            comboBoxSpellSchool.Items.Add("Enchantment");
            comboBoxSpellSchool.Items.Add("Evocation");
            comboBoxSpellSchool.Items.Add("Illusion");
            comboBoxSpellSchool.Items.Add("Necromancy");
            comboBoxSpellSchool.Items.Add("Transmutation");
            comboBoxSpellSchool.Items.Add("Universal");

            comboBoxSpellSchool.SelectedIndex = 0;
        }

        private void btnSearchSpell_Click(object sender, EventArgs e)
        {
            if(ValidateFields())
            {
                SpellFIlter spellFIlter = new SpellFIlter();
                PrepareFilter(spellFIlter);
            }
        }

        private void PrepareFilter(SpellFIlter spellFIlter)
        {
            if (!string.IsNullOrWhiteSpace(textBoxSpellName.Text))
            {
                spellFIlter.SpellName = textBoxSpellName.Text;
            }

            if (!string.Equals(comboBoxSpellSchool.Text, "Select a School"))
            {
                spellFIlter.SpellName = comboBoxSpellSchool.Text;
            }                       

            if (!string.IsNullOrWhiteSpace(comboBoxLevelToSearch.Text))
            {
                spellFIlter.ClassLevel = Convert.ToInt32(comboBoxLevelToSearch.Text).ToString();
            }

            if(!string.Equals(comboBoxClassToSearch.Text, "Choose a Class"))
            {
                spellFIlter.ClassName = comboBoxClassToSearch.Text;
            }
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(textBoxSpellName.Text.ToString()) && 
                string.Equals(comboBoxClassToSearch.Text.ToString(), "Choose a Class"))
            {
                WarningMessage.ShowWarningMessage("Please inform at least a spell name or a spell class");
                return false;
            }

            if(!string.IsNullOrWhiteSpace(comboBoxLevelToSearch.Text) && 
                string.Equals(comboBoxClassToSearch.Text, "Choose a Class"))
            {
                WarningMessage.ShowWarningMessage("Need to inform the class as well if you inform the level");
                return false;
            }            

            return true;
        }
    }
}
