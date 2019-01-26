namespace Aemos.Forms
{
    partial class frmBaseAttackBonus
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
            this.ctrlCharInputHeader1 = new Aemos.UserControls.ctrlCharInputHeader();
            this.ctrlBaseAttackBonus1 = new Aemos.UserControls.ctrlBaseAttackBonus();
            this.SuspendLayout();
            // 
            // ctrlCharInputHeader1
            // 
            this.ctrlCharInputHeader1.Location = new System.Drawing.Point(22, 12);
            this.ctrlCharInputHeader1.Name = "ctrlCharInputHeader1";
            this.ctrlCharInputHeader1.Size = new System.Drawing.Size(508, 95);
            this.ctrlCharInputHeader1.TabIndex = 0;
            // 
            // ctrlBaseAttackBonus1
            // 
            this.ctrlBaseAttackBonus1.Location = new System.Drawing.Point(12, 113);
            this.ctrlBaseAttackBonus1.Name = "ctrlBaseAttackBonus1";
            this.ctrlBaseAttackBonus1.Size = new System.Drawing.Size(550, 110);
            this.ctrlBaseAttackBonus1.TabIndex = 1;
            // 
            // frmBaseAttackBonus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 227);
            this.Controls.Add(this.ctrlBaseAttackBonus1);
            this.Controls.Add(this.ctrlCharInputHeader1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmBaseAttackBonus";
            this.Text = "Base Attack Bonus";
            this.Load += new System.EventHandler(this.frmBaseAttackBonus_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ctrlCharInputHeader ctrlCharInputHeader1;
        private UserControls.ctrlBaseAttackBonus ctrlBaseAttackBonus1;
    }
}