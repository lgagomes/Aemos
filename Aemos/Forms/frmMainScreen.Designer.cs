namespace Aemos
{
    partial class frmMainScreen
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSpellcasting = new System.Windows.Forms.Button();
            this.btnCarrying = new System.Windows.Forms.Button();
            this.btnBaseAttack = new System.Windows.Forms.Button();
            this.btnSkillPoints = new System.Windows.Forms.Button();
            this.btnXpCalculator = new System.Windows.Forms.Button();
            this.btnDiceRoller = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSpellcasting
            // 
            this.btnSpellcasting.Location = new System.Drawing.Point(17, 19);
            this.btnSpellcasting.Name = "btnSpellcasting";
            this.btnSpellcasting.Size = new System.Drawing.Size(149, 41);
            this.btnSpellcasting.TabIndex = 0;
            this.btnSpellcasting.Text = "Spellcasting";
            this.btnSpellcasting.UseVisualStyleBackColor = true;
            this.btnSpellcasting.Click += new System.EventHandler(this.btnSpellcasting_Click);
            // 
            // btnCarrying
            // 
            this.btnCarrying.Location = new System.Drawing.Point(241, 19);
            this.btnCarrying.Name = "btnCarrying";
            this.btnCarrying.Size = new System.Drawing.Size(149, 41);
            this.btnCarrying.TabIndex = 1;
            this.btnCarrying.Text = "Carrying Capacity\r\nCalculation";
            this.btnCarrying.UseVisualStyleBackColor = true;
            this.btnCarrying.Click += new System.EventHandler(this.btnCarrying_Click);
            // 
            // btnBaseAttack
            // 
            this.btnBaseAttack.Location = new System.Drawing.Point(17, 102);
            this.btnBaseAttack.Name = "btnBaseAttack";
            this.btnBaseAttack.Size = new System.Drawing.Size(149, 41);
            this.btnBaseAttack.TabIndex = 2;
            this.btnBaseAttack.Text = "Base Attack Bonus\r\nCalculation";
            this.btnBaseAttack.UseVisualStyleBackColor = true;
            this.btnBaseAttack.Click += new System.EventHandler(this.btnBaseAttack_Click);
            // 
            // btnSkillPoints
            // 
            this.btnSkillPoints.Location = new System.Drawing.Point(241, 102);
            this.btnSkillPoints.Name = "btnSkillPoints";
            this.btnSkillPoints.Size = new System.Drawing.Size(149, 41);
            this.btnSkillPoints.TabIndex = 3;
            this.btnSkillPoints.Text = "Skill Points\r\nCalculation";
            this.btnSkillPoints.UseVisualStyleBackColor = true;
            this.btnSkillPoints.Click += new System.EventHandler(this.btnSkillPoints_Click);
            // 
            // btnXpCalculator
            // 
            this.btnXpCalculator.Location = new System.Drawing.Point(17, 184);
            this.btnXpCalculator.Name = "btnXpCalculator";
            this.btnXpCalculator.Size = new System.Drawing.Size(149, 41);
            this.btnXpCalculator.TabIndex = 4;
            this.btnXpCalculator.Text = "XP Calculator";
            this.btnXpCalculator.UseVisualStyleBackColor = true;
            this.btnXpCalculator.Click += new System.EventHandler(this.btnXpCalculator_Click);
            // 
            // btnDiceRoller
            // 
            this.btnDiceRoller.Location = new System.Drawing.Point(241, 184);
            this.btnDiceRoller.Name = "btnDiceRoller";
            this.btnDiceRoller.Size = new System.Drawing.Size(149, 41);
            this.btnDiceRoller.TabIndex = 5;
            this.btnDiceRoller.Text = "Dice Roller";
            this.btnDiceRoller.UseVisualStyleBackColor = true;
            this.btnDiceRoller.Click += new System.EventHandler(this.btnDiceRoller_Click);
            // 
            // frmMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 249);
            this.Controls.Add(this.btnDiceRoller);
            this.Controls.Add(this.btnXpCalculator);
            this.Controls.Add(this.btnSkillPoints);
            this.Controls.Add(this.btnBaseAttack);
            this.Controls.Add(this.btnCarrying);
            this.Controls.Add(this.btnSpellcasting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMainScreen";
            this.Text = "Aemos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSpellcasting;
        private System.Windows.Forms.Button btnCarrying;
        private System.Windows.Forms.Button btnBaseAttack;
        private System.Windows.Forms.Button btnSkillPoints;
        private System.Windows.Forms.Button btnXpCalculator;
        private System.Windows.Forms.Button btnDiceRoller;
    }
}

