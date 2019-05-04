using Aemos.Helpers;
using Aemos.Repository;
using System;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;
using Aemos.Forms;

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
            comboBoxClassToSearch.Items.Add("Bard");
            comboBoxClassToSearch.Items.Add("Cleric");
            comboBoxClassToSearch.Items.Add("Druid");
            comboBoxClassToSearch.Items.Add("Paladin");
            comboBoxClassToSearch.Items.Add("Ranger");
            comboBoxClassToSearch.Items.Add("Sorcerer");
            comboBoxClassToSearch.Items.Add("Wizard");

            comboBoxClassToSearch.SelectedIndex = 0;
        }

        private void InitializeLevels()
        {
            for (int i = 1; i <= 9; i++)
            {
                comboBoxLevelToSearch.Items.Add(i.ToString());
            }
        }

        private void InitializeSpellsSchools()
        {
            List<string> schools = new List<string>
            {
                "Select a School", "Abjuration", "Conjuration",
                "Divination", "Enchantment", "Evocation",
                "Illusion", "Necromancy", "Transmutation", "Universal"
            };

            foreach (string school in schools)
            {
                comboBoxSpellSchool.Items.Add(school);
            }

            comboBoxSpellSchool.SelectedIndex = 0;
        }

        private void btnSearchSpell_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                SpellFIlter spellFilter = new SpellFIlter();
                PrepareFilter(spellFilter);
                List<SpellDTO> spellsDetailed = SpellsRepository.GetSpellsDetailed(spellFilter);

                dataGridViewSpellsDetailed.DataSource = spellsDetailed;
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
                spellFIlter.SpellSchool = comboBoxSpellSchool.Text;
            }

            if (!string.IsNullOrWhiteSpace(comboBoxLevelToSearch.Text))
            {
                spellFIlter.ClassLevel = Convert.ToInt32(comboBoxLevelToSearch.Text).ToString();
            }

            if (!string.Equals(comboBoxClassToSearch.Text, "Choose a Class"))
            {
                spellFIlter.ClassName = comboBoxClassToSearch.Text;
            }
        }

        private bool ValidateFields()
        {
            StringBuilder errors = new StringBuilder();
            string spellName = textBoxSpellName.Text;
            string className = comboBoxClassToSearch.Text;
            string classLevel = comboBoxLevelToSearch.Text;
            string spellSchool = comboBoxClassToSearch.Text;
            int.TryParse(comboBoxLevelToSearch.Text, out int level);

            if (string.IsNullOrWhiteSpace(spellName) && string.Equals(className, "Choose a Class") && string.Equals(spellSchool, "Select a School"))
            {
                errors.AppendLine("Please inform at least a spell name, a class or a spell school");
            }

            if (!string.IsNullOrWhiteSpace(classLevel) && string.Equals(className, "Choose a Class"))
            {
                errors.AppendLine("Need to inform the class as well if you inform the level");
            }

            if(string.Equals(className,"Bard") && level > 6)
            {
                errors.AppendLine("A Bard doesn't have spell cycles above 6. Please select another value");
            }
            
            if((string.Equals(className, "Paladin") || string.Equals(className, "Ranger")) && level > 4)
            {
                errors.AppendLine($"A {className} doesn't have spell cycles above 4. Please select another value");
            }

            return CheckErrors(errors);
        }

        private bool CheckErrors(StringBuilder errors)
        {
            if (string.IsNullOrWhiteSpace(errors.ToString()))
            {
                return true;
            }
            else
            {
                WarningMessage.ShowWarningMessage(errors.ToString());
                return false;
            }
        }

        private void btnClearSpellsGrid_Click(object sender, EventArgs e)
        {
            dataGridViewSpellsDetailed.DataSource = null;
            dataGridViewSpellsDetailed.Refresh();
        }

        private void dataGridViewSpellsDetailed_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SpellDTO spellDTO = (SpellDTO)dataGridViewSpellsDetailed.CurrentRow.DataBoundItem;

            using (var formSpellDetail = new frmSpellDetailed(spellDTO))
            {
                formSpellDetail.ShowDialog();
            }
        }
    }
}
