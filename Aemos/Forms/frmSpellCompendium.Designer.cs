namespace Aemos.Forms
{
    partial class frmSpellCompendium
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
            this.ctrlSpellCompendium1 = new Aemos.UserControls.ctrlSpellCompendium();
            this.SuspendLayout();
            // 
            // ctrlSpellCompendium1
            // 
            this.ctrlSpellCompendium1.Location = new System.Drawing.Point(0, -4);
            this.ctrlSpellCompendium1.Name = "ctrlSpellCompendium1";
            this.ctrlSpellCompendium1.Size = new System.Drawing.Size(792, 444);
            this.ctrlSpellCompendium1.TabIndex = 0;
            // 
            // frmSpellCompendium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 452);
            this.Controls.Add(this.ctrlSpellCompendium1);
            this.MaximizeBox = false;
            this.Name = "frmSpellCompendium";
            this.Text = "Spells Compendium";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ctrlSpellCompendium ctrlSpellCompendium1;
    }
}