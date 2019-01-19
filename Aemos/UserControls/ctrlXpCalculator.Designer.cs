namespace Aemos.UserControls
{
    partial class ctrlXpCalculator
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.buttonXPProgression = new System.Windows.Forms.Button();
            this.label60 = new System.Windows.Forms.Label();
            this.textBoxLevelAfterXP = new System.Windows.Forms.TextBox();
            this.textBoxTotalXP = new System.Windows.Forms.TextBox();
            this.textBoxReceivedXP = new System.Windows.Forms.TextBox();
            this.textBoxActualXP = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.groupBox14.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.buttonXPProgression);
            this.groupBox14.Controls.Add(this.label60);
            this.groupBox14.Controls.Add(this.textBoxLevelAfterXP);
            this.groupBox14.Controls.Add(this.textBoxTotalXP);
            this.groupBox14.Controls.Add(this.textBoxReceivedXP);
            this.groupBox14.Controls.Add(this.textBoxActualXP);
            this.groupBox14.Controls.Add(this.label59);
            this.groupBox14.Controls.Add(this.label58);
            this.groupBox14.Controls.Add(this.label57);
            this.groupBox14.Controls.Add(this.label56);
            this.groupBox14.Controls.Add(this.label55);
            this.groupBox14.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox14.Location = new System.Drawing.Point(3, 3);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(525, 204);
            this.groupBox14.TabIndex = 15;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "XP Calculator";
            // 
            // buttonXPProgression
            // 
            this.buttonXPProgression.Location = new System.Drawing.Point(341, 153);
            this.buttonXPProgression.Name = "buttonXPProgression";
            this.buttonXPProgression.Size = new System.Drawing.Size(153, 23);
            this.buttonXPProgression.TabIndex = 10;
            this.buttonXPProgression.Text = "Show XP progression table";
            this.buttonXPProgression.UseVisualStyleBackColor = true;
            this.buttonXPProgression.Click += new System.EventHandler(this.buttonXPProgression_Click);
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(40, 153);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(293, 28);
            this.label60.TabIndex = 9;
            this.label60.Text = "Or click on the \"Show XP progression table\" button \r\nto show the complete XP prog" +
    "ression table";
            // 
            // textBoxLevelAfterXP
            // 
            this.textBoxLevelAfterXP.Location = new System.Drawing.Point(413, 107);
            this.textBoxLevelAfterXP.Name = "textBoxLevelAfterXP";
            this.textBoxLevelAfterXP.ReadOnly = true;
            this.textBoxLevelAfterXP.Size = new System.Drawing.Size(59, 22);
            this.textBoxLevelAfterXP.TabIndex = 8;
            // 
            // textBoxTotalXP
            // 
            this.textBoxTotalXP.Location = new System.Drawing.Point(396, 72);
            this.textBoxTotalXP.Name = "textBoxTotalXP";
            this.textBoxTotalXP.ReadOnly = true;
            this.textBoxTotalXP.Size = new System.Drawing.Size(76, 22);
            this.textBoxTotalXP.TabIndex = 7;
            // 
            // textBoxReceivedXP
            // 
            this.textBoxReceivedXP.Location = new System.Drawing.Point(160, 107);
            this.textBoxReceivedXP.Name = "textBoxReceivedXP";
            this.textBoxReceivedXP.Size = new System.Drawing.Size(76, 22);
            this.textBoxReceivedXP.TabIndex = 6;
            this.textBoxReceivedXP.Text = "0";
            this.textBoxReceivedXP.TextChanged += new System.EventHandler(this.UpdateXpTextBoxes);
            this.textBoxReceivedXP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressValidation);
            // 
            // textBoxActualXP
            // 
            this.textBoxActualXP.Location = new System.Drawing.Point(160, 72);
            this.textBoxActualXP.Name = "textBoxActualXP";
            this.textBoxActualXP.Size = new System.Drawing.Size(76, 22);
            this.textBoxActualXP.TabIndex = 5;
            this.textBoxActualXP.Text = "0";
            this.textBoxActualXP.TextChanged += new System.EventHandler(this.UpdateXpTextBoxes);
            this.textBoxActualXP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressValidation);
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(257, 110);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(150, 14);
            this.label59.TabIndex = 4;
            this.label59.Text = "Current level after XP gain";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(257, 77);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(53, 14);
            this.label58.TabIndex = 3;
            this.label58.Text = "Total XP";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(82, 110);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(74, 14);
            this.label57.TabIndex = 2;
            this.label57.Text = "Received XP";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(82, 75);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(59, 14);
            this.label56.TabIndex = 1;
            this.label56.Text = "Actual XP";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.Location = new System.Drawing.Point(109, 18);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(332, 28);
            this.label55.TabIndex = 0;
            this.label55.Text = "Inform how much XP do you have and the ammount\r\n of XP gained to find out what yo" +
    "ur current level is";
            // 
            // ctrlXpCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox14);
            this.Name = "ctrlXpCalculator";
            this.Size = new System.Drawing.Size(536, 210);
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.Button buttonXPProgression;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.TextBox textBoxLevelAfterXP;
        private System.Windows.Forms.TextBox textBoxTotalXP;
        private System.Windows.Forms.TextBox textBoxReceivedXP;
        private System.Windows.Forms.TextBox textBoxActualXP;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label55;
    }
}
