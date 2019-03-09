using Aemos.CharacterClasses;
using Aemos.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Aemos.UserControls
{
    public partial class ctrlSpellcasting : UserControl
    {
        private List<Spellcaster> _spellcastersList;
        private List<KnowlerOfSpells> _knowlers;
        private List<Label> _spellDCs;
        private List<Label> _extraSpells;
        private List<Button> _castButtons;
        private List<TextBox> _knownSpells;
        private TextBox[] _spellsPerDay;
        private Spellcaster _currentSpellcaster;
        private CasterSelector _selector;
        private const int TEN = 10;
        private const int TWENTY = 20;

        public ctrlSpellcasting()
        {
            InitializeComponent();
        }

        #region Initializations
        private void ctrlSpellcasting_Load(object sender, EventArgs e)
        {
            InitializeListsAndArrays();
            InitializeLevels();            
            InitializeDCs();            
            InitializeExtraSpells();
            InitializeSpellsPerDay();
            InitializeKnownSpells();
            InitializeClasses();            
            InitializeCastButtons(); 
        }
        
        private void InitializeListsAndArrays()
        {
            _spellcastersList = new List<Spellcaster>();
            _knowlers = new List<KnowlerOfSpells>();
            _castButtons = new List<Button>();
            _spellDCs = new List<Label>();
            _extraSpells = new List<Label>();
            _spellsPerDay = new TextBox[TEN];
            _knownSpells = new List<TextBox>();
        }

        private void InitializeLevels()
        {
            for (int i = 1; i <= TWENTY; i++)
                comboBoxLevel.Items.Add(i.ToString());
            comboBoxLevel.SelectedIndex = 0;
        }

        private void InitializeDCs()
        {
            string labelDC;
            for (int i = 0; i < TEN; i++)
            {
                labelDC = "LabelDC" + i;
                Label label = Controls.Find(labelDC, true).FirstOrDefault() as Label;
                _spellDCs.Add(label);
            }            
        }

        private void InitializeExtraSpells()
        {
            string labelExtraSpells;
            for (int i = 0; i < TEN; i++)
            {
                labelExtraSpells = "labelExtraSpells" + i;
                Label label = Controls.Find(labelExtraSpells, true).FirstOrDefault() as Label;
                _extraSpells.Add(label);
            }           
        }

        private void InitializeSpellsPerDay()
        {
            string textBoxSpells;
            for (int i = 0; i < TEN; i++)
            {
                textBoxSpells = "textBoxSpellsLvL" + i;
                TextBox txtBox = Controls.Find(textBoxSpells, true).FirstOrDefault() as TextBox;
                _spellsPerDay[i] = txtBox;
            }
        }

        private void InitializeKnownSpells()
        {
            string textBoxName;
            for (int i = 0; i < TEN; i++)
            {
                textBoxName = "textBoxKnownSpells" + i;
                TextBox txtBox = Controls.Find(textBoxName, true).FirstOrDefault() as TextBox;
                _knownSpells.Add(txtBox);                
            }
        }

        private void InitializeClasses()
        {
            _currentSpellcaster = new Spellcaster();
            _selector = new CasterSelector();
            comboBoxClasses.Items.Add("Choose a Class");

            Bard bard = new Bard("Bard")
            {
                CharacterLevel = Convert.ToInt32(comboBoxLevel.Text),
                Charisma = Convert.ToInt32(textBoxKeyAttribute.Text)
            };
            AddSpellcasterClass(bard);
            AddKnowlerOfSpellsClass(bard);

            Cleric cleric = new Cleric("Cleric")
            {
                CharacterLevel = Convert.ToInt32(comboBoxLevel.Text),
                Wisdom = Convert.ToInt32(textBoxKeyAttribute.Text)
            };
            AddSpellcasterClass(cleric);

            Druid druid = new Druid("Druid")
            {
                CharacterLevel = Convert.ToInt32(comboBoxLevel.Text),
                Wisdom = Convert.ToInt32(textBoxKeyAttribute.Text)
            };
            AddSpellcasterClass(druid);

            Paladin paladin = new Paladin("Paladin")
            {
                CharacterLevel = Convert.ToInt32(comboBoxLevel.Text),
                Charisma = Convert.ToInt32(textBoxKeyAttribute.Text)
            };
            AddSpellcasterClass(paladin);

            Ranger ranger = new Ranger("Ranger")
            {
                CharacterLevel = Convert.ToInt32(comboBoxLevel.Text),
                Wisdom = Convert.ToInt32(textBoxKeyAttribute.Text)
            };
            AddSpellcasterClass(ranger);

            Sorcerer sorcerer = new Sorcerer("Sorcerer")
            {
                CharacterLevel = Convert.ToInt32(comboBoxLevel.Text),
                Charisma = Convert.ToInt32(textBoxKeyAttribute.Text)
            };
            AddSpellcasterClass(sorcerer);
            AddKnowlerOfSpellsClass(sorcerer);

            Wizard wizard = new Wizard("Wizard")
            {
                CharacterLevel = Convert.ToInt32(comboBoxLevel.Text),
                Intelligence = Convert.ToInt32(textBoxKeyAttribute.Text)
            };
            AddSpellcasterClass(wizard);

            comboBoxClasses.SelectedIndex = 0;
        }

        private void InitializeCastButtons()
        {
            string btnName;
            for (int i = 0; i < TEN; i++)
            {
                btnName = "buttonCastLevel" + i;
                Button btn = Controls.Find(btnName, true).FirstOrDefault() as Button;
                _castButtons.Add(btn);
                btn.Enabled = false;
            }           
            buttonRegainSpells.Enabled = false;
        }
        #endregion

        #region Methods
        private void AddSpellcasterClass(Spellcaster spellcasterCharacter)
        {
            _spellcastersList.Add(spellcasterCharacter);
            comboBoxClasses.Items.Add(spellcasterCharacter.ClassName.ToString());
        }

        private void AddKnowlerOfSpellsClass(KnowlerOfSpells knowlerOfSpells)
        {
            _knowlers.Add(knowlerOfSpells);
        }

        private void ShowSpellsDC()
        {
            if (string.Equals(comboBoxClasses.Text, "Choose a Class"))
            {
                WarningMessage.ShowWarningMessage("Please select a valid class");
            }
            else
            {
                _selector.Select(_currentSpellcaster, labelBaseScore.Text, Convert.ToInt32(textBoxKeyAttribute.Text));
                _currentSpellcaster.GetSpellsDC();

                int i = 0;
                foreach (var item in _spellDCs)
                {
                    item.Text = (_currentSpellcaster.SpellsDC[i] > -1)
                        ? _currentSpellcaster.SpellsDC[i].ToString()
                        : "-";
                    i++;
                }
            }
        }

        private void ShowExtraSpells()
        {
            _selector.Select(_currentSpellcaster, labelBaseScore.Text, Convert.ToInt32(textBoxKeyAttribute.Text));
            _currentSpellcaster.GetExtraSpells();

            int i = 0;
            foreach (var item in _extraSpells)
            {
                item.Text = (_currentSpellcaster.ExtraSpells[i] >= 0)
                    ? _currentSpellcaster.ExtraSpells[i].ToString()
                    : "-";               
                i++;
            }
        }

        private void ShowSpellsPerDay()
        {
            LoadSpells();
            FillSpellcyclesTextBox();            
        }

        private void LoadSpells()
        {
            _currentSpellcaster.CharacterLevel = Convert.ToInt32(comboBoxLevel.Text);
            _currentSpellcaster.GetDailySpells();
        }

        private void FillSpellcyclesTextBox()
        {
            for (int i = 0; i < _spellsPerDay.Length; i++)
            {
                _spellsPerDay[i].Text = (_currentSpellcaster.CurrentDailySpells[i] > 0)
                    ? _currentSpellcaster.CurrentDailySpells[i].ToString()
                    : "-";
            }
        }

        private void ShowKnownSpells(bool signal)
        {
            if (signal)
            {
                KnowlerOfSpells character = _knowlers.Find(x => x.ClassName == comboBoxClasses.Text.ToString());
                character.CharacterLevel = Convert.ToInt32(comboBoxLevel.Text);
                character.GetKnownSpells();

                int i = 0;
                foreach (var item in _knownSpells)
                {
                    item.Text = (character.CurrentKnownSpells[i] > 0)
                        ? character.CurrentKnownSpells[i].ToString()
                        : "-";
                    i++;
                }
            }
        }

        private void ResetKnownSpells(bool signal)
        {
            if (!signal)
            {
                foreach (var item in _knownSpells)
                    item.Text = "-";
            }
        }

        private void EnableOnlyNnecessaryButtons()
        {
            string btnName;
            Button btn;

            for (int i = 0; i < _spellsPerDay.Length; i++)
            {
                btnName = "buttonCastLevel" + i;
                btn = Controls.Find(btnName, true).FirstOrDefault() as Button;
                btn.Enabled = (!string.Equals(_spellsPerDay[i].Text, "-")) ? true : false;
            }
        }
        #endregion

        #region Events
        private void Cast(object sender, EventArgs e)
        {
            Button buttonSender = sender as Button;
            int spellCycle = GetSpellCycleFromButton(buttonSender.Name);
            bool castStatus = _currentSpellcaster.CastSpell(spellCycle);

            if (castStatus)
            {
                _spellsPerDay[spellCycle].Text = _currentSpellcaster.CurrentDailySpells[spellCycle].ToString();
            }
            else
            {
                WarningMessage.ShowWarningMessage("You don't have enough spells slots or " +
                    "don't have access to this spell cycle yet");

                _spellsPerDay[spellCycle].Text = "-";
                buttonSender.Enabled = false;
            }
        }

        private int GetSpellCycleFromButton(string buttonName)
        {
            return (int)char.GetNumericValue(buttonName[buttonName.Length - 1]);
        }

        private void comboBoxClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.Equals(comboBoxClasses.Text, "Choose a Class"))
            {
                _currentSpellcaster = _spellcastersList.Find(x => x.ClassName == comboBoxClasses.Text.ToString());

                labelBaseScore.Text = _currentSpellcaster.KeyAttribute;
                ShowSpellsDC();
                ShowExtraSpells();
                ShowSpellsPerDay();

                bool signal = _selector.IsKnownlerOfSpells(_currentSpellcaster);
                ShowKnownSpells(signal);
                ResetKnownSpells(signal);

                buttonRegainSpells.Enabled = true;
                EnableOnlyNnecessaryButtons();
            }
        }

        private void textBoxKeyAttribute_TextChanged(object sender, EventArgs e)
        {
            if (string.Equals(comboBoxClasses.Text, "Choose a Class"))
            {
                WarningMessage.ShowWarningMessage("Please select a valid class");
            }
            else if (!string.IsNullOrEmpty(textBoxKeyAttribute.Text))
            {
                _selector.Select(_currentSpellcaster, labelBaseScore.Text, Convert.ToInt32(textBoxKeyAttribute.Text));

                labelAttibuteBonus.Text = (_currentSpellcaster.KeyAttributeModifier < 0)
                    ? _currentSpellcaster.KeyAttributeModifier.ToString()
                    : "+" + _currentSpellcaster.KeyAttributeModifier.ToString();

                ShowSpellsDC();
                ShowExtraSpells();
            }
        }

        private void comboBoxLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.Equals(comboBoxClasses.Text, "Choose a Class"))
            {
                WarningMessage.ShowWarningMessage("Please select a valid class");
            }
            else if(!string.IsNullOrEmpty(comboBoxClasses.Text))
            {
                ShowSpellsPerDay();

                bool signal = _selector.IsKnownlerOfSpells(_currentSpellcaster);
                ShowKnownSpells(signal);
                ResetKnownSpells(signal);
                EnableOnlyNnecessaryButtons();
            }
        }

        private void textBoxKeyAttribute_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void buttonRegainSpells_Click(object sender, EventArgs e)
        {
            ShowSpellsPerDay();
            EnableOnlyNnecessaryButtons();
        }
        #endregion
    }
}
