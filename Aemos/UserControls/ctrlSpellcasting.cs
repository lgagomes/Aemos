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
        private List<Spellcaster> spellcastersList;
        private List<KnowlerOfSpells> knowlers;
        private List<Label> spellDCs;
        private List<Label> extraSpells;
        private List<Button> castButtons;
        private List<TextBox> knownSpells;
        private TextBox[] spellsPerDay;
        private Spellcaster spellcaster;
        private CasterSelector selector;

        public ctrlSpellcasting()
        {
            InitializeComponent();
        }

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

        #region Initializations
        private void InitializeListsAndArrays()
        {
            spellcastersList = new List<Spellcaster>();
            knowlers = new List<KnowlerOfSpells>();
            castButtons = new List<Button>();
            spellDCs = new List<Label>();
            extraSpells = new List<Label>();
            spellsPerDay = new TextBox[10];
            knownSpells = new List<TextBox>();
        }

        private void InitializeLevels()
        {
            for (int i = 1; i <= 20; i++)
                comboBoxLevel.Items.Add(i.ToString());
        }

        private void InitializeDCs()
        {
            string labelDC;
            for (int i = 0; i < 10; i++)
            {
                labelDC = "LabelDC" + i;
                Label label = Controls.Find(labelDC, true).FirstOrDefault() as Label;
                spellDCs.Add(label);
            }            
        }

        private void InitializeExtraSpells()
        {
            string labelExtraSpells;
            for (int i = 0; i < 10; i++)
            {
                labelExtraSpells = "labelExtraSpells" + i;
                Label label = Controls.Find(labelExtraSpells, true).FirstOrDefault() as Label;
                extraSpells.Add(label);
            }           
        }

        private void InitializeSpellsPerDay()
        {
            string textBoxSpells;
            for (int i = 0; i < 10; i++)
            {
                textBoxSpells = "textBoxSpellsLvL" + i;
                TextBox txtBox = Controls.Find(textBoxSpells, true).FirstOrDefault() as TextBox;
                spellsPerDay[i] = txtBox;
            }
        }

        private void InitializeKnownSpells()
        {
            string textBoxName;
            for (int i = 0; i < 10; i++)
            {
                textBoxName = "textBoxKnownSpells" + i;
                TextBox txtBox = Controls.Find(textBoxName, true).FirstOrDefault() as TextBox;
                knownSpells.Add(txtBox);
            }
        }

        private void InitializeClasses()
        {
            spellcaster = new Spellcaster();
            selector = new CasterSelector();

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
        }

        private void InitializeCastButtons()
        {
            string btnName;
            for (int i = 0; i < 10; i++)
            {
                btnName = "buttonCastLevel" + i;
                Button btn = Controls.Find(btnName, true).FirstOrDefault() as Button;
                castButtons.Add(btn);
                btn.Enabled = false;
            }           
            buttonRegainSpells.Enabled = false;
        }
        #endregion

        #region Methods
        private void AddSpellcasterClass(Spellcaster spellcasterCharacter)
        {
            spellcastersList.Add(spellcasterCharacter);
            comboBoxClasses.Items.Add(spellcasterCharacter.ClassName.ToString());
        }

        private void AddKnowlerOfSpellsClass(KnowlerOfSpells knowlerOfSpells)
        {
            knowlers.Add(knowlerOfSpells);
        }

        private void ShowSpellsDC()
        {
            if (string.Equals(comboBoxClasses.Text, "Choose a Class"))
            {
                WarningMessage.ShowWarningMessage("Please select a valid class");
            }
            else
            {
                selector.Select(spellcaster, labelBaseScore.Text, Convert.ToInt32(textBoxKeyAttribute.Text));
                spellcaster.UpdateSpellsDC();

                int i = 0;
                foreach (var item in spellDCs)
                {
                    item.Text = (spellcaster.SpellsDC[i] > -1)
                        ? spellcaster.SpellsDC[i].ToString()
                        : "-";
                    i++;
                }
            }
        }

        private void ShowExtraSpells()
        {
            selector.Select(spellcaster, labelBaseScore.Text, Convert.ToInt32(textBoxKeyAttribute.Text));
            spellcaster.UpdateExtraSpells();

            int i = 0;
            foreach (var item in extraSpells)
            {
                item.Text = (spellcaster.ExtraSpells[i] >= 0)
                    ? spellcaster.ExtraSpells[i].ToString()
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
            spellcaster.UpdateSpellsPerDay();
        }

        private void FillSpellcyclesTextBox()
        {
            int level = Convert.ToInt32(comboBoxLevel.Text);

            for (int i = 0; i < spellsPerDay.Length; i++)
            {
                spellsPerDay[i].Text = (spellcaster.DailySpells[level - 1, i] > 0)
                    ? spellcaster.DailySpells[level - 1, i].ToString()
                    : "-";
            }
        }

        private void ShowKnownSpells(bool signal)
        {
            if (signal)
            {
                KnowlerOfSpells character = knowlers.Find(x => x.ClassName == comboBoxClasses.Text.ToString());
                int level = Convert.ToInt32(comboBoxLevel.Text);

                character.UpdateKnownSpells();

                int i = 0;
                foreach (var item in knownSpells)
                {
                    item.Text = (character.KnownSpells[level - 1, i] > 0)
                        ? character.KnownSpells[level - 1, i].ToString()
                        : "-";
                }
            }
        }

        private void ResetKnownSpells(bool signal)
        {
            if (!signal)
            {
                foreach (var item in knownSpells)
                    item.Text = "-";
            }
        }

        private void Cast(object sender, EventArgs e)
        {
            Button buttonSender = sender as Button;
            string buttonName = buttonSender.Name;
            int spellCycle = (int)char.GetNumericValue(buttonName[buttonName.Length - 1]);
            int level = Convert.ToInt32(comboBoxLevel.Text);

            bool castStatus = spellcaster.CastSpell(level, spellCycle);

            if(castStatus)
                spellsPerDay[spellCycle].Text = spellcaster.DailySpells[level - 1, spellCycle].ToString();
            else
            {
                WarningMessage.ShowWarningMessage("You don't have enough spells slots or " +
                    "don't have access to this spell cycle yet");

                spellsPerDay[spellCycle].Text = "-";
                buttonSender.Enabled = false;
            }
        }
        #endregion

        #region Events
        private void comboBoxClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            spellcaster = spellcastersList.Find(x => x.ClassName == comboBoxClasses.Text.ToString());

            labelBaseScore.Text = spellcaster.KeyAttribute;
            ShowSpellsDC();
            ShowExtraSpells();
            ShowSpellsPerDay();

            bool signal = selector.IsKnownlerOfSpells(spellcaster);
            ShowKnownSpells(signal);
            ResetKnownSpells(signal);

            foreach (var item in castButtons)
                item.Enabled = true;

            buttonRegainSpells.Enabled = true;
        }

        private void textBoxKeyAttribute_TextChanged(object sender, EventArgs e)
        {
            if (string.Equals(comboBoxClasses.Text, "Choose a Class"))
            {
                WarningMessage.ShowWarningMessage("Please select a valid class");
            }
            else if (!string.IsNullOrEmpty(textBoxKeyAttribute.Text))
            {
                selector.Select(spellcaster, labelBaseScore.Text, Convert.ToInt32(textBoxKeyAttribute.Text));

                labelAttibuteBonus.Text = (spellcaster.KeyAttributeModifier < 0)
                    ? spellcaster.KeyAttributeModifier.ToString()
                    : "+" + spellcaster.KeyAttributeModifier.ToString();

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
            else
            {
                ShowSpellsPerDay();

                bool signal = selector.IsKnownlerOfSpells(spellcaster);
                ShowKnownSpells(signal);
                ResetKnownSpells(signal);
            }
        }

        private void textBoxKeyAttribute_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void buttonRegainSpells_Click(object sender, EventArgs e)
        {
            ShowSpellsPerDay();

            foreach (var item in castButtons)
                item.Enabled = true;
        }
        #endregion
    }
}
