using Aemos.CharacterClasses;
using Aemos.DomainClasses;
using Aemos.DomainClasses.DTOs;
using Aemos.Forms;
using Aemos.Helpers;
using Aemos.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Aemos.UserControls
{
    public partial class ctrlSpellCompendium : UserControl
    {
        private SpellsRepository _spellsRepository;

        public ctrlSpellCompendium()
        {
            InitializeComponent();

            _spellsRepository = new SpellsRepository();
        }

        private void ctrlSpellCompendium_Load(object sender, EventArgs e)
        {
            InitializeLevels();
            GetSpellcasters();
            GetSchools();
            GetDomains();
        }

        private void GetDomains()
        {
            var domains = new List<SpellDomain>() { new SpellDomain { IdDomain = 0, DomainName = "Choose a Domain" } };
            domains.AddRange(_spellsRepository.GetSpellDomains());

            comboBoxDomain.DataSource = domains;
        }

        private void GetSpellcasters()
        {
            var spellcasters = new List<BaseClass>() { new BaseClass { Id = 0, ClassName = "Choose a Class" } };
            spellcasters.AddRange(_spellsRepository.GetSpellcastingClasses());

            comboBoxClasses.DataSource = spellcasters;
        }

        private void GetSchools()
        {
            var schools = new List<SpellSchool>() { new SpellSchool { Id = 0, SchoolName = "Choose a School" } };
            schools.AddRange(_spellsRepository.GetSpellSchools());

            comboBoxSchools.DataSource = schools;
        }
       
        private void InitializeLevels()
        {
            for (int i = 1; i <= 9; i++)
            {
                comboBoxSpellLevel.Items.Add(i.ToString());
            }
        }     

        private void btnSearchSpell_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                dataGridViewSpellsDetailed.DataSource = _spellsRepository.GetSpells(PrepareFilter());
            }
        }

        private SpellFIlter PrepareFilter()
        {
            return new SpellFIlter
            {
                IdClass = ((BaseClass)comboBoxClasses.SelectedItem)?.Id ?? 0,
                IdSchool = ((SpellSchool)comboBoxSchools.SelectedItem)?.Id ?? 0,
                SpellName = textBoxSpellName.Text,
                SpellLevel = !string.IsNullOrWhiteSpace(comboBoxSpellLevel.Text) ? Convert.ToInt32(comboBoxSpellLevel.Text) : 0,
                IdDomain = ((SpellDomain)comboBoxDomain.SelectedItem)?.IdDomain ?? 0
            };
        }

        private bool ValidateFields()
        {
            StringBuilder errors = new StringBuilder();
            string spellName = textBoxSpellName.Text;
            string classLevel = comboBoxSpellLevel.Text;
            int.TryParse(comboBoxSpellLevel.Text, out int level);
            var selectedClass = ((BaseClass)comboBoxClasses.SelectedItem);
            var idSelectedSchool = ((SpellSchool)comboBoxSchools.SelectedItem)?.Id ?? 0;


            if (string.IsNullOrWhiteSpace(spellName) && selectedClass?.Id == 0 && idSelectedSchool == 0)
            {
                errors.AppendLine("Please inform at least a spell name, a class or a spell school");
            }

            if (!string.IsNullOrWhiteSpace(classLevel) && selectedClass?.Id == 0)
            {
                errors.AppendLine("Need to inform the class as well if you inform the level");
            }

            if (string.Equals(selectedClass?.ClassName, "Bard") && level > 6)
            {
                errors.AppendLine("A Bard doesn't have spell cycles above 6. Please select another value");
            }

            if ((string.Equals(selectedClass?.ClassName, "Paladin") || string.Equals(selectedClass?.ClassName, "Ranger")) && level > 4)
            {
                errors.AppendLine($"A {selectedClass.ClassName} doesn't have spell cycles above 4. Please select another value");
            }

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
