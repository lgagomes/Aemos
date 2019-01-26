namespace Aemos.Forms
{
    partial class frmDiceRoller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrlDiceRoller1 = new Aemos.UserControls.ctrlDiceRoller();
            this.SuspendLayout();
            // 
            // ctrlDiceRoller1
            // 
            this.ctrlDiceRoller1.Location = new System.Drawing.Point(10, 12);
            this.ctrlDiceRoller1.Name = "ctrlDiceRoller1";
            this.ctrlDiceRoller1.Size = new System.Drawing.Size(1104, 358);
            this.ctrlDiceRoller1.TabIndex = 0;
            // 
            // frmDiceRoller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 375);
            this.Controls.Add(this.ctrlDiceRoller1);
            this.Name = "frmDiceRoller";
            this.Text = "Dice Roller";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ctrlDiceRoller ctrlDiceRoller1;
    }
}