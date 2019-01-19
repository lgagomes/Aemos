namespace Aemos.Forms
{
    partial class frmXpProgression
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
            this.ctrlXpProgression1 = new Aemos.UserControls.ctrlXpProgression();
            this.SuspendLayout();
            // 
            // ctrlXpProgression1
            // 
            this.ctrlXpProgression1.Location = new System.Drawing.Point(12, 12);
            this.ctrlXpProgression1.Name = "ctrlXpProgression1";
            this.ctrlXpProgression1.Size = new System.Drawing.Size(466, 481);
            this.ctrlXpProgression1.TabIndex = 0;
            // 
            // frmXpProgression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 492);
            this.Controls.Add(this.ctrlXpProgression1);
            this.Name = "frmXpProgression";
            this.Text = "Xp Progression";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ctrlXpProgression ctrlXpProgression1;
    }
}