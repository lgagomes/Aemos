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
            labelRange.Text = (string.IsNullOrWhiteSpace(spell.Range)) ? "-" : spell.Range;
            labelArea.Text = (string.IsNullOrWhiteSpace(spell.Area)) ? "-" : spell.Area;
            labelEffect.Text = (string.IsNullOrWhiteSpace(spell.Effect)) ? "-" : spell.Effect;
            labelTarget.Text = (string.IsNullOrWhiteSpace(spell.Target)) ? "-" : spell.Target;
            labelDuration.Text = spell.Duration;
            labelSavingThrow.Text = (string.IsNullOrWhiteSpace(spell.SavingThrow)) ? "-" : spell.SavingThrow;
            labelSpellResistance.Text = (string.IsNullOrWhiteSpace(spell.SpellResistance)) ? "-" : spell.SpellResistance;

            StringBuilder descriptiveText = new StringBuilder();
            descriptiveText.Append($"{spell.BriefDescription}{Environment.NewLine}{Environment.NewLine}");

            if (!string.IsNullOrWhiteSpace(spell.ArcaneFocus))
            {
                descriptiveText
                    .Append($"Arcane Focus:{Environment.NewLine}")
                    .Append($"{spell.ArcaneFocus}{Environment.NewLine}{Environment.NewLine}");
            }

            if (!string.IsNullOrWhiteSpace(spell.BardFocus))
            {
                descriptiveText
                    .Append($"Bard Focus:{Environment.NewLine}")
                    .Append($"{spell.BardFocus}{Environment.NewLine}{Environment.NewLine}");
            }

            if (!string.IsNullOrWhiteSpace(spell.ClericFocus))
            {
                descriptiveText
                    .Append($"Cleric Focus:{Environment.NewLine}")
                    .Append($"{spell.ClericFocus}{Environment.NewLine}{Environment.NewLine}");
            }

            if (!string.IsNullOrWhiteSpace(spell.DruidFocus))
            {
                descriptiveText
                    .Append($"Druid Focus:{Environment.NewLine}")
                    .Append($"{spell.DruidFocus}{Environment.NewLine}{Environment.NewLine}");
            }

            if (!string.IsNullOrWhiteSpace(spell.SorcererFocus))
            {
                descriptiveText
                    .Append($"Sorcerer Focus:{Environment.NewLine}")
                    .Append($"{spell.SorcererFocus}{Environment.NewLine}{Environment.NewLine}");
            }

            if (!string.IsNullOrWhiteSpace(spell.WizardFocus))
            {
                descriptiveText
                    .Append($"Wizard Focus:{Environment.NewLine}")
                    .Append($"{spell.WizardFocus}{Environment.NewLine}{Environment.NewLine}");
            }

            if (!string.IsNullOrWhiteSpace(spell.Focus))
            {
                descriptiveText
                    .Append($"Focus:{Environment.NewLine}")
                    .Append($"{spell.Focus}{Environment.NewLine}{Environment.NewLine}");
            }

            if (!string.IsNullOrWhiteSpace(spell.MaterialComponents))
            {
                descriptiveText
                    .Append($"Material Components:{Environment.NewLine}")
                    .Append($"{spell.MaterialComponents}{Environment.NewLine}{Environment.NewLine}");
            }

            if (!string.IsNullOrWhiteSpace(spell.XpCost))
            {
                descriptiveText.Append($"XP Cost:{Environment.NewLine}").Append(spell.XpCost);
            }

            textBoxDescriptiveText.Text = descriptiveText.ToString();
        }
    }
}
