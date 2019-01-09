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
       
        public ctrlCharInputHeader()
        {
            InitializeComponent();
        }

        public void SetLabels(string attributeScore, string attributeBonus)
        {
            labelHeaderAttributeScore.Text = attributeScore;
            labelHeaderAttibuteBonus.Text = attributeBonus;
        }

        public string ClassName
        {
            get { return comboHeaderBoxClasses.Text; }
        }

        private void comboHeaderBoxClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassChangeEvent?.Invoke(null, null);
        }
    }
}
