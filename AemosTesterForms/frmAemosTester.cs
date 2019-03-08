using Aemos.CharacterClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AemosTesterForms
{
    public partial class frmAemosTester : Form
    {
        public frmAemosTester()
        {
            InitializeComponent();
        }

        private void btnTestSpellsPerDayDatabase_Click(object sender, EventArgs e)
        {
            Cleric character = new Cleric("Cleric");
            character.CharacterLevel = 20;
            character.GetSpellsPerDayDB();

            PrintSpells(character.CurrentDailySpells);
        }

        private void btnTestCastSpellV2_Click(object sender, EventArgs e)
        {
            Cleric character = new Cleric("Cleric");
            character.CharacterLevel = 20;
            character.GetSpellsPerDayDB();

            PrintSpells(character.CurrentDailySpells);

            character.CastSpell(0);

            PrintSpells(character.CurrentDailySpells);
        }

        private void PrintSpells(int[] spellsArray)
        {
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < spellsArray.Length; i++)
            {
                str.Append(spellsArray[i].ToString()).Append(" ");
            }
            MessageBox.Show(str.ToString());
        }
    }
}
