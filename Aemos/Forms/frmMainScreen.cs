using Aemos.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
