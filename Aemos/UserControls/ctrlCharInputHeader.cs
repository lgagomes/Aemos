using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aemos.CharacterClasses;
using Aemos.Helpers;

namespace Aemos.UserControls
{
    public partial class ctrlCharInputHeader : UserControl
    {
        public event EventHandler ClassChangeEvent;
        public event EventHandler LevelChangeEvent;
        public event EventHandler AttributeScoreEvent;

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
            ClassChangeEvent?.Invoke(null, null);
        }

        private void comboBoxHeaderLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            LevelChangeEvent?.Invoke(null, null);
        }

        private void textBoxHeaderAttributeScore_TextChanged(object sender, EventArgs e)
        {
            AttributeScoreEvent?.Invoke(null, null);
        }        
    }
}
