using Aemos.CharacterClasses;
using Aemos.Helpers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Aemos.UserControls
{
    public partial class ctrlSkillPoints : UserControl
    {
        private List<BaseClass> _classes;
        private BaseClass _actualClass;
        private CheckBox[] _levelBonusPoints;
        private string _actualClassName;
        private int _actualLevel;
        private int _actualIntScore;

        public ctrlSkillPoints()
        {
            InitializeComponent();
        }

        public void ActualClassNameChanged(string className)
        {
            _actualClassName = className;

            if (string.Equals(_actualClassName, "Choose a Class"))
            {
                return;
            }
            else
            {
                _actualClass = _classes.Find(x => x.ClassName == className);
                _actualClass.SkillPointsCalculator = new SkillPointsCalculator();

                UpdateLevelBonusPointsCheckboxes();
                UpdateIntelligenceBonuses();
                UpdateSkillPoints();
            }
        }

        public void ActualLevelChanged(string level)
        {
            _actualLevel = Convert.ToInt32(level);
            UpdateLevelBonusPointsCheckboxes();
            UpdateIntelligenceBonuses();
            UpdateSkillPoints();
            UpdateSkillRanks();
        }

        public void ActualIntScoreChanged(string intScore)
        {
            if (string.IsNullOrEmpty(intScore) || string.IsNullOrWhiteSpace(intScore) || !CheckValidClass())
            {
                return;
            }
            else
            {
                _actualIntScore = Convert.ToInt32(intScore);
                UpdateSkillPoints();
                UpdateSkillRanks();
            }
        }

        private void ctrlSkillPoints_Load(object sender, EventArgs e)
        {
            InstantiateClasses();
            InitializeLevelBonusPoints();
        }

        private void InitializeLevelBonusPoints()
        {
            _levelBonusPoints = new CheckBox[5];

            _levelBonusPoints[0] = checkBoxInt4thLevel;
            _levelBonusPoints[1] = checkBoxInt8thLevel;
            _levelBonusPoints[2] = checkBoxInt12thLevel;
            _levelBonusPoints[3] = checkBoxInt16thLevel;
            _levelBonusPoints[4] = checkBoxInt20thLevel;
        }

        private void InstantiateClasses()
        {
            _classes = new List<BaseClass>();
            _actualClass = new BaseClass();

            Barbarian barbarian = new Barbarian("barbarian");
            Bard bard = new Bard("bard");
            Cleric cleric = new Cleric("cleric");
            Druid druid = new Druid("druid");
            Monk monk = new Monk("monk");
            Paladin paladin = new Paladin("paladin");
            Ranger ranger = new Ranger("ranger");
            Rogue rogue = new Rogue("rogue");
            Sorcerer sorcerer = new Sorcerer("sorcerer");
            Warrior warrior = new Warrior("warrior");
            Wizard wizard = new Wizard("wizard");

            AddClass(barbarian);
            AddClass(bard);
            AddClass(cleric);
            AddClass(druid);
            AddClass(monk);
            AddClass(paladin);
            AddClass(ranger);
            AddClass(rogue);
            AddClass(sorcerer);
            AddClass(warrior);
            AddClass(wizard);
        }

        private void AddClass(BaseClass character)
        {
            _classes.Add(character);
        }        

        private void UpdateLevelBonusPointsCheckboxes()
        {
            int unlockIndex = _actualLevel / 4;

            // enable checkboxes in case of increase the level
            for (int i = 0; i < unlockIndex; i++)
            {
                _levelBonusPoints[i].Enabled = true;
            }

            // in case of decrease the level, disable any ckeckboxes already enabled
            for (int j = unlockIndex; j < _levelBonusPoints.Length; j++)
            {
                _levelBonusPoints[j].Enabled = false;
                _levelBonusPoints[j].Checked = false;
            }
        }

        private void UpdateIntelligenceBonuses()
        {
            if (!CheckValidClass())
            {
                return;
            }
            else
            {
                _actualClass.SkillPointsCalculator.IntelligenceBonuses.IntBonus4thLevel = checkBoxInt4thLevel.Checked;
                _actualClass.SkillPointsCalculator.IntelligenceBonuses.IntBonus8thLevel = checkBoxInt8thLevel.Checked;
                _actualClass.SkillPointsCalculator.IntelligenceBonuses.IntBonus12thLevel = checkBoxInt12thLevel.Checked;
                _actualClass.SkillPointsCalculator.IntelligenceBonuses.IntBonus16thLevel = checkBoxInt16thLevel.Checked;
                _actualClass.SkillPointsCalculator.IntelligenceBonuses.IntBonus20thLevel = checkBoxInt20thLevel.Checked;
            }
        }

        private void UpdateSkillPoints()
        {
            if (!CheckValidClass())
            {
                return;
            }
            else
            {
                _actualClass.CharacterLevel = _actualLevel;
                _actualClass.Intelligence = _actualIntScore;

                _actualClass.SkillPointsCalculator.ResetSkillPoints();
                _actualClass.UpdateSkillPointsModifiers();

                _actualClass.SkillPointsCalculator.CalculateSkillPoints(_actualClass.CharacterLevel,
                        _actualClass.GetModifier(_actualClass.Intelligence),
                        _actualClass.SkillClassModifier,
                        checkBoxIsHuman.Checked);

                textBoxSkillPoints.Text = _actualClass.SkillPointsCalculator.SkillPoints.ToString();
            }
        }

        private void UpdateSkillRanks()
        {
            if (!CheckValidClass())
            {
                return;
            }
            else
            {
                _actualClass.SkillPointsCalculator.CalculateSkillRanks(_actualClass.CharacterLevel);
                textBoxClassSkillMaxRanks.Text = _actualClass.SkillPointsCalculator.ClassSkillMaxRanks.ToString();
                textBoxNonClassSkillMaxRanks.Text = _actualClass.SkillPointsCalculator.NonClassSkillMaxRanks.ToString();
            }
        }

        private void UpdateIntBonusAndSkillPoints(object sender, EventArgs e)
        {
            UpdateIntelligenceBonuses();
            UpdateSkillPoints();
        }

        private bool CheckValidClass()
        {
            return string.Equals(_actualClassName, "Choose a Class") ? false : true;
        }

        private void checkBoxIsHuman_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSkillPoints();
        }
    }
}
