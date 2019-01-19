namespace Aemos.Forms
{
    partial class frmSkillPoints
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
            this.ctrlSkillPoints1 = new Aemos.UserControls.ctrlSkillPoints();
            this.SuspendLayout();
            // 
            // ctrlCharInputHeader1
            // 
            this.ctrlCharInputHeader1.Location = new System.Drawing.Point(26, 12);
            this.ctrlCharInputHeader1.Name = "ctrlCharInputHeader1";
            this.ctrlCharInputHeader1.Size = new System.Drawing.Size(508, 95);
            this.ctrlCharInputHeader1.TabIndex = 1;
            // 
            // ctrlSkillPoints1
            // 
            this.ctrlSkillPoints1.Location = new System.Drawing.Point(12, 113);
            this.ctrlSkillPoints1.Name = "ctrlSkillPoints1";
            this.ctrlSkillPoints1.Size = new System.Drawing.Size(543, 224);
            this.ctrlSkillPoints1.TabIndex = 0;
            // 
            // frmSkillPoints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 338);
            this.Controls.Add(this.ctrlCharInputHeader1);
            this.Controls.Add(this.ctrlSkillPoints1);
            this.Name = "frmSkillPoints";
            this.Text = "Skill Points";
            this.Load += new System.EventHandler(this.frmSkillPoints_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ctrlSkillPoints ctrlSkillPoints1;
        private UserControls.ctrlCharInputHeader ctrlCharInputHeader1;
    }
}