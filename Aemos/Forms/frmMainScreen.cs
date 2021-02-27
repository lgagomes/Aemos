using Aemos.Forms;
using System;
using System.Windows.Forms;

namespace Aemos
{
    public partial class frmMainScreen : Form
    {
        public frmMainScreen()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnSpellcasting_Click(object sender, EventArgs e)
        {
            using (var frmSpellcastingSubMenu = new frmSpellcastingSubMenu())
            {
                frmSpellcastingSubMenu.ShowDialog();
            }
        }

        private void btnCarrying_Click(object sender, EventArgs e)
        {
            using (var frmCarryingCapacity = new frmCarryingCapacity())
            {
                frmCarryingCapacity.ShowDialog();
            }
        }

        private void btnBaseAttack_Click(object sender, EventArgs e)
        {
            using (var frmBaseAttackBonus = new frmBaseAttackBonus())
            {
                frmBaseAttackBonus.ShowDialog();
            }
        }

        private void btnSkillPoints_Click(object sender, EventArgs e)
        {
            using (var frmSkillPoints = new frmSkillPoints())
            {
                frmSkillPoints.ShowDialog();
            }
        }

        private void btnXpCalculator_Click(object sender, EventArgs e)
        {
            using (var frmXpCalculator = new frmXpCalculator())
            {
                frmXpCalculator.ShowDialog();
            }
        }

        private void btnDiceRoller_Click(object sender, EventArgs e)
        {
            using (var frmDiceRoller = new frmDiceRoller())
            {
                frmDiceRoller.ShowDialog();
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copyright© 2018 Luiz Gustavo A. Gomes\n\n" +
               "If you have any questions just contact me at\n" +
               "\tlgustavogom@gmail.com\n\n" +
               "This program uses content from the d20 System, with no intention to " +
               "replace the books for full descriptions, " +
               "but rather to be a tool to ease the character creation.\n\n" +
               "Thanks to:\n" +
               "Melissa Avery-Weir's d20 3.5 SRD Spell Lists (http://thecharonsheet.com/d20-spell-lists/) for inspiration;\n\n" +
               "Andargor's SQL script with SRD spells (http://www.andargor.com)",
               "About", MessageBoxButtons.OK);
        }
    }
}
