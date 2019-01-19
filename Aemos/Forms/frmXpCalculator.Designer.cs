namespace Aemos.Forms
{
    partial class frmXpCalculator
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
            this.ctrlXpCalculator1 = new Aemos.UserControls.ctrlXpCalculator();
            this.SuspendLayout();
            // 
            // ctrlXpCalculator1
            // 
            this.ctrlXpCalculator1.Location = new System.Drawing.Point(12, 12);
            this.ctrlXpCalculator1.Name = "ctrlXpCalculator1";
            this.ctrlXpCalculator1.Size = new System.Drawing.Size(536, 210);
            this.ctrlXpCalculator1.TabIndex = 0;
            // 
            // frmXpCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 234);
            this.Controls.Add(this.ctrlXpCalculator1);
            this.Name = "frmXpCalculator";
            this.Text = "Xp Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ctrlXpCalculator ctrlXpCalculator1;
    }
}