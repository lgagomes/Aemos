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
            frmSpellcasting frmSpellcasting = new frmSpellcasting();
            frmSpellcasting.ShowDialog();
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
    }
}
