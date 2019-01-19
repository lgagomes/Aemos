using Aemos.Helpers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Aemos.UserControls
{
    public partial class ctrlCarryingCapacity : UserControl
    {
        private LoadCalculator loadCalculator;
        private int sizeModifiersCode = 4;
        private TextBox[] carryCapacities;
        private List<Label> unityLabels;

        public ctrlCarryingCapacity()
        {
            InitializeComponent();            
        }

        private void ctrlCarryingCapacity_Load(object sender, EventArgs e)
        {
            InitializeListsAndArrays();
            InitializeCarryCapacities();
            InitializeUnityLabels();
            CalculateCarryCapacity();
        }

        #region Initializations
        private void InitializeListsAndArrays()
        {
            loadCalculator = new LoadCalculator();
            carryCapacities = new TextBox[8];
            unityLabels = new List<Label>();
        }

        private void InitializeCarryCapacities()
        {
            carryCapacities[0] = textBoxLightLoad;
            carryCapacities[1] = textBoxMediumLoadMin;
            carryCapacities[2] = textBoxMediumLoadMax;
            carryCapacities[3] = textBoxHeavyLoadMin;
            carryCapacities[4] = textBoxHeavyLoadMax;
            carryCapacities[5] = textBoxLiftHead;
            carryCapacities[6] = textBoxLiftGround;
            carryCapacities[7] = textBoxPushGround;
        }

        private void InitializeUnityLabels()
        {
            unityLabels.Add(labelLightLoad);
            unityLabels.Add(labelMediumLoadMin);
            unityLabels.Add(labelMediumLoadMax);
            unityLabels.Add(labelHeavyLoadMin);
            unityLabels.Add(labelHeavyLoadMax);
            unityLabels.Add(labelLiftHead);
            unityLabels.Add(labelLiftGround);
            unityLabels.Add(labelPushDrag);
        }
        #endregion

        #region Methods
        private void UpdateCarryCapacities()
        {
            if (radioButtonKgs.Checked)
                for (int i = 0; i < carryCapacities.Length; i++)
                    carryCapacities[i].Text = loadCalculator.LoadsKgs[i].ToString("#,0.00");

            else if (radioButtonLbs.Checked)
                for (int i = 0; i < carryCapacities.Length; i++)
                    carryCapacities[i].Text = loadCalculator.LoadsLbs[i].ToString("#,0.00");
        }

        private void CalculateCarryCapacity()
        {
            loadCalculator.CalculateLoad(Convert.ToInt32(textBoxStrenghtScore.Text),
                                        sizeModifiersCode,
                                        checkBoxFourLegs.Checked);
            UpdateCarryCapacities();
        }
        #endregion

        #region Events
        private void textBoxStrenghtScore_TextChanged(object sender, EventArgs e)
        {
            if (textBoxStrenghtScore != null)
                CalculateCarryCapacity();
        }

        private void radioButtonSizeFine_CheckedChanged(object sender, EventArgs e)
        {
            sizeModifiersCode = 0;
            CalculateCarryCapacity();
        }

        private void radioButtonSizeDiminutive_CheckedChanged(object sender, EventArgs e)
        {
            sizeModifiersCode = 1;
            CalculateCarryCapacity();
        }

        private void radioButtonSizeTiny_CheckedChanged(object sender, EventArgs e)
        {
            sizeModifiersCode = 2;
            CalculateCarryCapacity();
        }

        private void radioButtonSizeSmall_CheckedChanged(object sender, EventArgs e)
        {
            sizeModifiersCode = 3;
            CalculateCarryCapacity();
        }

        private void radioButtonSizeMedium_CheckedChanged(object sender, EventArgs e)
        {
            sizeModifiersCode = 4;
            CalculateCarryCapacity();
        }

        private void radioButtonSizeLarge_CheckedChanged(object sender, EventArgs e)
        {
            sizeModifiersCode = 5;
            CalculateCarryCapacity();
        }

        private void radioButtonSizeHuge_CheckedChanged(object sender, EventArgs e)
        {
            sizeModifiersCode = 6;
            CalculateCarryCapacity();
        }

        private void radioButtonSizeGargantuan_CheckedChanged(object sender, EventArgs e)
        {
            sizeModifiersCode = 7;
            CalculateCarryCapacity();
        }

        private void radioButtonSizeColossal_CheckedChanged(object sender, EventArgs e)
        {
            sizeModifiersCode = 8;
            CalculateCarryCapacity();
        }

        private void checkBoxFourLegs_CheckedChanged(object sender, EventArgs e)
        {
            CalculateCarryCapacity();
        }

        private void radioButtonKgs_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var item in unityLabels)
            {
                item.Text = "Kgs";
                UpdateCarryCapacities();
            }
        }

        private void radioButtonLbs_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var item in unityLabels)
            {
                item.Text = "Lbs";

            }
            UpdateCarryCapacities();
        }
        #endregion
    }
}
