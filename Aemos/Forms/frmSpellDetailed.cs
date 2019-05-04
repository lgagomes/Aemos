using Aemos.Helpers;
using System;
using System.Text;
using System.Windows.Forms;

namespace Aemos.Forms
{
    public partial class frmSpellDetailed : Form
    {
        public frmSpellDetailed(SpellDTO spellDTO)
        {
            InitializeComponent();
            CenterToParent();
            FormatLabels(spellDTO);
        }

        private void FormatLabels(SpellDTO spell)
        {
            StringBuilder name = new StringBuilder();

            name.Append($"{spell.Name.ToUpper()}{Environment.NewLine}{spell.School}")
                .Append(!string.IsNullOrWhiteSpace(spell.SubSchool) ? $" ({spell.SubSchool})" : string.Empty)
                .Append(!string.IsNullOrWhiteSpace(spell.Descriptor) ? $" [{spell.Descriptor}]" : string.Empty);          

            labelSpellFullName.Text = name.ToString();
            labelSpellLevel.Text = spell.Level;
            labelSpellComponents.Text = spell.Components;
            labelCastingTime.Text = spell.CastingTime;
        }
    }
}
