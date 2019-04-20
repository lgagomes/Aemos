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
        }

        private void btnSpellcasting_Click(object sender, EventArgs e)
        {
            frmSpellcastingSubMenu frmSpellcastingSubMenu = new frmSpellcastingSubMenu();
            frmSpellcastingSubMenu.ShowDialog();
        }

        private void btnCarrying_Click(object sender, EventArgs e)
        {
            frmCarryingCapacity frmCarryingCapacity = new frmCarryingCapacity();
            frmCarryingCapacity.ShowDialog();
        }

        private void btnBaseAttack_Click(object sender, EventArgs e)
        {
            frmBaseAttackBonus frmBaseAttackBonus = new frmBaseAttackBonus();
            frmBaseAttackBonus.ShowDialog();
        }

        private void btnSkillPoints_Click(object sender, EventArgs e)
        {
            frmSkillPoints frmSkillPoints = new frmSkillPoints();
            frmSkillPoints.ShowDialog();
        }

        private void btnXpCalculator_Click(object sender, EventArgs e)
        {
            frmXpCalculator frmXpCalculator = new frmXpCalculator();
            frmXpCalculator.ShowDialog();
        }

        private void btnDiceRoller_Click(object sender, EventArgs e)
        {
            frmDiceRoller frmDiceRoller = new frmDiceRoller();
            frmDiceRoller.ShowDialog();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copyright© 2018 - 2019 Luiz Gustavo A. Gomes\n\n" +
               "If you have any questions just contact me at\n" +
               "\tlgustavogom@gmail.com\n\n" +
               "This program uses content from the d20 System, with no intention to " +
               "replace the books for full descriptions, " +
               "but rather to be a tool to ease the character creation.",
               "About", MessageBoxButtons.OK);
        }
    }
}
