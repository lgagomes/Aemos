namespace Aemos.Forms
{
    partial class frmSpellcasting
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
            this.ctrlSpellcasting1 = new Aemos.UserControls.ctrlSpellcasting();
            this.SuspendLayout();
            // 
            // ctrlSpellcasting1
            // 
            this.ctrlSpellcasting1.Location = new System.Drawing.Point(12, 7);
            this.ctrlSpellcasting1.Name = "ctrlSpellcasting1";
            this.ctrlSpellcasting1.Size = new System.Drawing.Size(558, 629);
            this.ctrlSpellcasting1.TabIndex = 0;
            // 
            // frmSpellcasting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 632);
            this.Controls.Add(this.ctrlSpellcasting1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSpellcasting";
            this.Text = "Spellcasting";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ctrlSpellcasting ctrlSpellcasting1;
    }
}