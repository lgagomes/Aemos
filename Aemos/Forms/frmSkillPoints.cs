using System;
using System.Windows.Forms;

namespace Aemos.Forms
{
    public partial class frmSkillPoints : Form
    {
        public frmSkillPoints()
        {
            InitializeComponent();
            ctrlCharInputHeader1.ClassChangeEvent += OnClassChangeEvent;
            ctrlCharInputHeader1.LevelChangeEvent += OnLevelChangeEvent;
            ctrlCharInputHeader1.AttributeScoreEvent += OnIntScoreChangeEvent;
        }

        private void frmSkillPoints_Load(object sender, EventArgs e)
        {
            ctrlCharInputHeader1.SetLabels("Intelligence Score");
            OnClassChangeEvent(null, null);
            OnLevelChangeEvent(null, null);
            OnIntScoreChangeEvent(null, null);
        }

        void OnClassChangeEvent(object sender, EventArgs e)
        {
            ctrlSkillPoints1.ActualClassNameChanged(ctrlCharInputHeader1.ClassName);
        }

        void OnLevelChangeEvent(object sender, EventArgs e)
        {
            ctrlSkillPoints1.ActualLevelChanged(ctrlCharInputHeader1.Level);
        }

        void OnIntScoreChangeEvent(object sender, EventArgs e)
        {
            ctrlSkillPoints1.ActualIntScoreChanged(ctrlCharInputHeader1.AttributeScore);
        }
    }
}
