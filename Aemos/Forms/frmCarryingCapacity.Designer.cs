namespace Aemos.Forms
{
    partial class frmCarryingCapacity
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
            this.ctrlCarryingCapacity1 = new Aemos.UserControls.ctrlCarryingCapacity();
            this.SuspendLayout();
            // 
            // ctrlCarryingCapacity1
            // 
            this.ctrlCarryingCapacity1.Location = new System.Drawing.Point(12, 12);
            this.ctrlCarryingCapacity1.Name = "ctrlCarryingCapacity1";
            this.ctrlCarryingCapacity1.Size = new System.Drawing.Size(535, 366);
            this.ctrlCarryingCapacity1.TabIndex = 0;
            // 
            // frmCarryingCapacity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 371);
            this.Controls.Add(this.ctrlCarryingCapacity1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCarryingCapacity";
            this.Text = "Carrying Capacity";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ctrlCarryingCapacity ctrlCarryingCapacity1;
    }
}