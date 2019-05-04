using System;
using System.Windows.Forms;

namespace Aemos.Forms
{
    public partial class frmSpellcastingSubMenu : Form
    {
        public frmSpellcastingSubMenu()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void btnSpellcastingClasses_Click(object sender, EventArgs e)
        {
            frmSpellcasting frmSpellcasting = new frmSpellcasting();
            frmSpellcasting.ShowDialog();
        }

        private void btnSpellCompendium_Click(object sender, EventArgs e)
        {
            frmSpellCompendium frmSpellCompendium = new frmSpellCompendium();
            frmSpellCompendium.ShowDialog();
        }
    }
}
