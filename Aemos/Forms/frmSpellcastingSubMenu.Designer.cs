namespace Aemos.Forms
{
    partial class frmSpellcastingSubMenu
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
            this.btnSpellcastingClasses = new System.Windows.Forms.Button();
            this.btnSpellCompendium = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSpellcastingClasses
            // 
            this.btnSpellcastingClasses.Location = new System.Drawing.Point(12, 12);
            this.btnSpellcastingClasses.Name = "btnSpellcastingClasses";
            this.btnSpellcastingClasses.Size = new System.Drawing.Size(149, 41);
            this.btnSpellcastingClasses.TabIndex = 1;
            this.btnSpellcastingClasses.Text = "Classes Spellcasting";
            this.btnSpellcastingClasses.UseVisualStyleBackColor = true;
            this.btnSpellcastingClasses.Click += new System.EventHandler(this.btnSpellcastingClasses_Click);
            // 
            // btnSpellCompendium
            // 
            this.btnSpellCompendium.Location = new System.Drawing.Point(167, 12);
            this.btnSpellCompendium.Name = "btnSpellCompendium";
            this.btnSpellCompendium.Size = new System.Drawing.Size(149, 41);
            this.btnSpellCompendium.TabIndex = 2;
            this.btnSpellCompendium.Text = "Spell Compendium";
            this.btnSpellCompendium.UseVisualStyleBackColor = true;
            this.btnSpellCompendium.Click += new System.EventHandler(this.btnSpellCompendium_Click);
            // 
            // frmSpellcastingSubMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 66);
            this.Controls.Add(this.btnSpellCompendium);
            this.Controls.Add(this.btnSpellcastingClasses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSpellcastingSubMenu";
            this.Text = "Spellcasting Categories";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSpellcastingClasses;
        private System.Windows.Forms.Button btnSpellCompendium;
    }
}