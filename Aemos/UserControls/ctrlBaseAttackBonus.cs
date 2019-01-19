using Aemos.CharacterClasses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Aemos.UserControls
{
    public partial class ctrlBaseAttackBonus : UserControl
    {
        private string _actualClassNameValue;
        private int _actualLevelValue;
        private List<BaseClass> _classesList;
        private BaseClass _actualClass;

        public ctrlBaseAttackBonus()
        {
            InitializeComponent();
        }

        public void Initializations()
        {
            _classesList = new List<BaseClass>();
            _actualClass = new BaseClass();
        }

        public void ActualClassNameChanged(string className)
        {
            _actualClassNameValue = className;
            UpdateBaseAttackBonus();
        }

        public void ActualLevelChanged(string level)
        {
            _actualLevelValue = Convert.ToInt32(level);
            UpdateBaseAttackBonus();
        }

        private void ctrlBaseAttackBonus_Load(object sender, EventArgs e)
        {
            Initializations();
            InstantiateClasses();
        }        

        private void InstantiateClasses()
        {
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
            _classesList.Add(character);
        }

        private void UpdateBaseAttackBonus()
        {
            if (string.Equals(_actualClassNameValue, "Choose a Class"))
                return;

            _actualClass = _classesList.Find(x => x.ClassName == _actualClassNameValue);
            _actualClass.CharacterLevel = _actualLevelValue;

            BaseAttackBonusCalc(_actualClass);

            if (_actualClass is Monk)
                FuryOfBlowsCalc(_actualClass);
        }

        private void BaseAttackBonusCalc(BaseClass baseClass)
        {
            textBoxMonkFoB.Text = "";
            baseClass.CalculateBaseAttackBonus();

            StringBuilder textBAB = new StringBuilder();

            for (int i = 0; i < baseClass.BaseAttackBonus.Length; i++)
            {
                if (baseClass.BaseAttackBonus[i] > 0)
                {
                    if ((i < 3) && (baseClass.BaseAttackBonus[i + 1] > 0))
                    {
                        textBAB.Append("+");
                        textBAB.Append(baseClass.BaseAttackBonus[i]);
                        textBAB.Append(" / ");
                    }
                    else
                    {
                        textBAB.Append("+");
                        textBAB.Append(baseClass.BaseAttackBonus[i]);
                    }
                }
            }
            textBoxBAB.Text = textBAB.ToString();
        }

        private void FuryOfBlowsCalc(BaseClass baseClass)
        {
            StringBuilder textFoB = new StringBuilder();
            Monk monk = (Monk)baseClass;
            monk.CalculateFuryOfBlowsBonus();

            textFoB.Append(monk.FuryOfBlowsBonus[0].ToString("+0;-#"));
            textFoB.Append(" / ");
            textFoB.Append(monk.FuryOfBlowsBonus[1].ToString("+0;-#"));

            if (monk.CharacterLevel > 9)
            {
                textFoB.Append(" / ");
            }

            for (int i = 2; i < monk.FuryOfBlowsBonus.Length; i++)
            {
                if (monk.FuryOfBlowsBonus[i] > 0)
                {
                    if ((i < 4) && (monk.FuryOfBlowsBonus[i + 1] > 0))
                    {
                        textFoB.Append(monk.FuryOfBlowsBonus[i].ToString("+#;-#;0"));
                        textFoB.Append(" / ");
                    }
                    else
                    {
                        textFoB.Append(monk.FuryOfBlowsBonus[i].ToString("+#;-#;0"));
                    }
                }
            }
            textBoxMonkFoB.Text = textFoB.ToString();
        }           
    }
}
 