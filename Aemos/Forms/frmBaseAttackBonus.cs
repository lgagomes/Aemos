using System;
using System.Windows.Forms;

namespace Aemos.Forms
{
    public partial class frmBaseAttackBonus : Form
    {
        public frmBaseAttackBonus()
        {
            InitializeComponent();
            CenterToParent();
            ctrlCharInputHeader1.ClassChangeEvent += OnClassChangeEvent;
            ctrlCharInputHeader1.LevelChangeEvent += OnLevelChangeEvent;
        }

        private void frmBaseAttackBonus_Load(object sender, EventArgs e)
        {
            ctrlCharInputHeader1.SetLabels("HIDE");
            OnClassChangeEvent(null,null);
            OnLevelChangeEvent(null, null);
        }

        void OnClassChangeEvent(object sender, EventArgs e)
        {
            ctrlBaseAttackBonus1.ActualClassNameChanged(ctrlCharInputHeader1.ClassName);
        }

        void OnLevelChangeEvent(object sender, EventArgs e)
        {
            ctrlBaseAttackBonus1.ActualLevelChanged(ctrlCharInputHeader1.Level);
        }
    }
}
