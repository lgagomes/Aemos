namespace Aemos.UserControls
{
    partial class ctrlSkillPoints
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
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.checkBoxIsHuman = new System.Windows.Forms.CheckBox();
            this.textBoxNonClassSkillMaxRanks = new System.Windows.Forms.TextBox();
            this.textBoxClassSkillMaxRanks = new System.Windows.Forms.TextBox();
            this.checkBoxInt20thLevel = new System.Windows.Forms.CheckBox();
            this.label52 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.checkBoxInt16thLevel = new System.Windows.Forms.CheckBox();
            this.label50 = new System.Windows.Forms.Label();
            this.checkBoxInt12thLevel = new System.Windows.Forms.CheckBox();
            this.checkBoxInt8thLevel = new System.Windows.Forms.CheckBox();
            this.checkBoxInt4thLevel = new System.Windows.Forms.CheckBox();
            this.label49 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.textBoxSkillPoints = new System.Windows.Forms.TextBox();
            this.groupBox13.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.checkBoxIsHuman);
            this.groupBox13.Controls.Add(this.textBoxNonClassSkillMaxRanks);
            this.groupBox13.Controls.Add(this.textBoxClassSkillMaxRanks);
            this.groupBox13.Controls.Add(this.checkBoxInt20thLevel);
            this.groupBox13.Controls.Add(this.label52);
            this.groupBox13.Controls.Add(this.label51);
            this.groupBox13.Controls.Add(this.checkBoxInt16thLevel);
            this.groupBox13.Controls.Add(this.label50);
            this.groupBox13.Controls.Add(this.checkBoxInt12thLevel);
            this.groupBox13.Controls.Add(this.checkBoxInt8thLevel);
            this.groupBox13.Controls.Add(this.checkBoxInt4thLevel);
            this.groupBox13.Controls.Add(this.label49);
            this.groupBox13.Controls.Add(this.label48);
            this.groupBox13.Controls.Add(this.textBoxSkillPoints);
            this.groupBox13.Location = new System.Drawing.Point(3, 3);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(528, 212);
            this.groupBox13.TabIndex = 14;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Skill Points";
            // 
            // checkBoxIsHuman
            // 
            this.checkBoxIsHuman.AutoSize = true;
            this.checkBoxIsHuman.Location = new System.Drawing.Point(6, 46);
            this.checkBoxIsHuman.Name = "checkBoxIsHuman";
            this.checkBoxIsHuman.Size = new System.Drawing.Size(202, 17);
            this.checkBoxIsHuman.TabIndex = 14;
            this.checkBoxIsHuman.Text = "Check this if your character is Human";
            this.checkBoxIsHuman.UseVisualStyleBackColor = true;
            this.checkBoxIsHuman.CheckedChanged += new System.EventHandler(this.checkBoxIsHuman_CheckedChanged);
            // 
            // textBoxNonClassSkillMaxRanks
            // 
            this.textBoxNonClassSkillMaxRanks.Location = new System.Drawing.Point(442, 43);
            this.textBoxNonClassSkillMaxRanks.Name = "textBoxNonClassSkillMaxRanks";
            this.textBoxNonClassSkillMaxRanks.ReadOnly = true;
            this.textBoxNonClassSkillMaxRanks.Size = new System.Drawing.Size(71, 20);
            this.textBoxNonClassSkillMaxRanks.TabIndex = 12;
            // 
            // textBoxClassSkillMaxRanks
            // 
            this.textBoxClassSkillMaxRanks.Location = new System.Drawing.Point(442, 13);
            this.textBoxClassSkillMaxRanks.Name = "textBoxClassSkillMaxRanks";
            this.textBoxClassSkillMaxRanks.ReadOnly = true;
            this.textBoxClassSkillMaxRanks.Size = new System.Drawing.Size(71, 20);
            this.textBoxClassSkillMaxRanks.TabIndex = 11;
            // 
            // checkBoxInt20thLevel
            // 
            this.checkBoxInt20thLevel.AutoSize = true;
            this.checkBoxInt20thLevel.Enabled = false;
            this.checkBoxInt20thLevel.Location = new System.Drawing.Point(157, 186);
            this.checkBoxInt20thLevel.Name = "checkBoxInt20thLevel";
            this.checkBoxInt20thLevel.Size = new System.Drawing.Size(235, 17);
            this.checkBoxInt20thLevel.TabIndex = 6;
            this.checkBoxInt20thLevel.Text = "Put 20th level Ability Score into Intelligence?";
            this.checkBoxInt20thLevel.UseVisualStyleBackColor = true;
            this.checkBoxInt20thLevel.CheckedChanged += new System.EventHandler(this.UpdateIntBonusAndSkillPoints);
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(298, 47);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(134, 13);
            this.label52.TabIndex = 10;
            this.label52.Text = "Non-Class Skill Max Ranks";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(298, 16);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(111, 13);
            this.label51.TabIndex = 9;
            this.label51.Text = "Class Skill Max Ranks";
            // 
            // checkBoxInt16thLevel
            // 
            this.checkBoxInt16thLevel.AutoSize = true;
            this.checkBoxInt16thLevel.Enabled = false;
            this.checkBoxInt16thLevel.Location = new System.Drawing.Point(275, 160);
            this.checkBoxInt16thLevel.Name = "checkBoxInt16thLevel";
            this.checkBoxInt16thLevel.Size = new System.Drawing.Size(235, 17);
            this.checkBoxInt16thLevel.TabIndex = 5;
            this.checkBoxInt16thLevel.Text = "Put 16th level Ability Score into Intelligence?";
            this.checkBoxInt16thLevel.UseVisualStyleBackColor = true;
            this.checkBoxInt16thLevel.CheckedChanged += new System.EventHandler(this.UpdateIntBonusAndSkillPoints);
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.Location = new System.Drawing.Point(6, 75);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(120, 13);
            this.label50.TabIndex = 8;
            this.label50.Text = "Level Bonus Points:";
            // 
            // checkBoxInt12thLevel
            // 
            this.checkBoxInt12thLevel.AutoSize = true;
            this.checkBoxInt12thLevel.Enabled = false;
            this.checkBoxInt12thLevel.Location = new System.Drawing.Point(24, 160);
            this.checkBoxInt12thLevel.Name = "checkBoxInt12thLevel";
            this.checkBoxInt12thLevel.Size = new System.Drawing.Size(235, 17);
            this.checkBoxInt12thLevel.TabIndex = 4;
            this.checkBoxInt12thLevel.Text = "Put 12th level Ability Score into Intelligence?";
            this.checkBoxInt12thLevel.UseVisualStyleBackColor = true;
            this.checkBoxInt12thLevel.CheckedChanged += new System.EventHandler(this.UpdateIntBonusAndSkillPoints);
            // 
            // checkBoxInt8thLevel
            // 
            this.checkBoxInt8thLevel.AutoSize = true;
            this.checkBoxInt8thLevel.Enabled = false;
            this.checkBoxInt8thLevel.Location = new System.Drawing.Point(275, 137);
            this.checkBoxInt8thLevel.Name = "checkBoxInt8thLevel";
            this.checkBoxInt8thLevel.Size = new System.Drawing.Size(229, 17);
            this.checkBoxInt8thLevel.TabIndex = 3;
            this.checkBoxInt8thLevel.Text = "Put 8th level Ability Score into Intelligence?";
            this.checkBoxInt8thLevel.UseVisualStyleBackColor = true;
            this.checkBoxInt8thLevel.CheckedChanged += new System.EventHandler(this.UpdateIntBonusAndSkillPoints);
            // 
            // checkBoxInt4thLevel
            // 
            this.checkBoxInt4thLevel.AutoSize = true;
            this.checkBoxInt4thLevel.Enabled = false;
            this.checkBoxInt4thLevel.Location = new System.Drawing.Point(24, 137);
            this.checkBoxInt4thLevel.Name = "checkBoxInt4thLevel";
            this.checkBoxInt4thLevel.Size = new System.Drawing.Size(229, 17);
            this.checkBoxInt4thLevel.TabIndex = 2;
            this.checkBoxInt4thLevel.Text = "Put 4th level Ability Score into Intelligence?";
            this.checkBoxInt4thLevel.UseVisualStyleBackColor = true;
            this.checkBoxInt4thLevel.CheckedChanged += new System.EventHandler(this.UpdateIntBonusAndSkillPoints);
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(6, 94);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(519, 26);
            this.label49.TabIndex = 7;
            this.label49.Text = "Every 4 levels you gain an Ability Score point to assign to any attribute. If you" +
    " choose to put those points into \r\nIntelligence, the calculation of Skill Points" +
    " will take this into account";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(6, 22);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(133, 13);
            this.label48.TabIndex = 1;
            this.label48.Text = "Total Skill Points Availlable";
            // 
            // textBoxSkillPoints
            // 
            this.textBoxSkillPoints.Location = new System.Drawing.Point(156, 18);
            this.textBoxSkillPoints.Name = "textBoxSkillPoints";
            this.textBoxSkillPoints.ReadOnly = true;
            this.textBoxSkillPoints.Size = new System.Drawing.Size(100, 20);
            this.textBoxSkillPoints.TabIndex = 0;
            // 
            // ctrlSkillPoints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox13);
            this.Name = "ctrlSkillPoints";
            this.Size = new System.Drawing.Size(543, 224);
            this.Load += new System.EventHandler(this.ctrlSkillPoints_Load);
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.CheckBox checkBoxIsHuman;
        private System.Windows.Forms.TextBox textBoxNonClassSkillMaxRanks;
        private System.Windows.Forms.TextBox textBoxClassSkillMaxRanks;
        private System.Windows.Forms.CheckBox checkBoxInt20thLevel;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.CheckBox checkBoxInt16thLevel;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.CheckBox checkBoxInt12thLevel;
        private System.Windows.Forms.CheckBox checkBoxInt8thLevel;
        private System.Windows.Forms.CheckBox checkBoxInt4thLevel;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.TextBox textBoxSkillPoints;
    }
}
