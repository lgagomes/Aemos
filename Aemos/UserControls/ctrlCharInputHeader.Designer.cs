namespace Aemos.UserControls
{
    partial class ctrlCharInputHeader
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboHeaderBoxClasses = new System.Windows.Forms.ComboBox();
            this.comboHeaderBoxLevel = new System.Windows.Forms.ComboBox();
            this.labelHeaderAttibuteBonus = new System.Windows.Forms.Label();
            this.textBoxHeaderKeyAttribute = new System.Windows.Forms.TextBox();
            this.labelHeaderAttributeScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelHeaderCharacterClass = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboHeaderBoxClasses);
            this.groupBox1.Controls.Add(this.comboHeaderBoxLevel);
            this.groupBox1.Controls.Add(this.labelHeaderAttibuteBonus);
            this.groupBox1.Controls.Add(this.textBoxHeaderKeyAttribute);
            this.groupBox1.Controls.Add(this.labelHeaderAttributeScore);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelHeaderCharacterClass);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 85);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Character Info";
            // 
            // comboHeaderBoxClasses
            // 
            this.comboHeaderBoxClasses.FormattingEnabled = true;
            this.comboHeaderBoxClasses.Items.AddRange(new object[] {
            "cleric",
            "bard",
            "wizard"});
            this.comboHeaderBoxClasses.Location = new System.Drawing.Point(25, 46);
            this.comboHeaderBoxClasses.Name = "comboHeaderBoxClasses";
            this.comboHeaderBoxClasses.Size = new System.Drawing.Size(121, 24);
            this.comboHeaderBoxClasses.TabIndex = 15;
            this.comboHeaderBoxClasses.Text = "Choose a Class";
            this.comboHeaderBoxClasses.SelectedIndexChanged += new System.EventHandler(this.comboHeaderBoxClasses_SelectedIndexChanged);
            // 
            // comboHeaderBoxLevel
            // 
            this.comboHeaderBoxLevel.FormattingEnabled = true;
            this.comboHeaderBoxLevel.Location = new System.Drawing.Point(203, 47);
            this.comboHeaderBoxLevel.Name = "comboHeaderBoxLevel";
            this.comboHeaderBoxLevel.Size = new System.Drawing.Size(96, 24);
            this.comboHeaderBoxLevel.TabIndex = 14;
            this.comboHeaderBoxLevel.Text = "1";
            // 
            // labelHeaderAttibuteBonus
            // 
            this.labelHeaderAttibuteBonus.AutoSize = true;
            this.labelHeaderAttibuteBonus.Location = new System.Drawing.Point(418, 50);
            this.labelHeaderAttibuteBonus.Name = "labelHeaderAttibuteBonus";
            this.labelHeaderAttibuteBonus.Size = new System.Drawing.Size(22, 16);
            this.labelHeaderAttibuteBonus.TabIndex = 13;
            this.labelHeaderAttibuteBonus.Text = "__";
            // 
            // textBoxHeaderKeyAttribute
            // 
            this.textBoxHeaderKeyAttribute.Location = new System.Drawing.Point(380, 47);
            this.textBoxHeaderKeyAttribute.Name = "textBoxHeaderKeyAttribute";
            this.textBoxHeaderKeyAttribute.Size = new System.Drawing.Size(32, 22);
            this.textBoxHeaderKeyAttribute.TabIndex = 12;
            this.textBoxHeaderKeyAttribute.Text = "10";
            // 
            // labelHeaderAttributeScore
            // 
            this.labelHeaderAttributeScore.AutoSize = true;
            this.labelHeaderAttributeScore.Location = new System.Drawing.Point(360, 24);
            this.labelHeaderAttributeScore.Name = "labelHeaderAttributeScore";
            this.labelHeaderAttributeScore.Size = new System.Drawing.Size(118, 16);
            this.labelHeaderAttributeScore.TabIndex = 11;
            this.labelHeaderAttributeScore.Text = "labelAttributeScore";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Character Level";
            // 
            // labelHeaderCharacterClass
            // 
            this.labelHeaderCharacterClass.AutoSize = true;
            this.labelHeaderCharacterClass.Location = new System.Drawing.Point(22, 24);
            this.labelHeaderCharacterClass.Name = "labelHeaderCharacterClass";
            this.labelHeaderCharacterClass.Size = new System.Drawing.Size(101, 16);
            this.labelHeaderCharacterClass.TabIndex = 9;
            this.labelHeaderCharacterClass.Text = "Character Class";
            // 
            // ctrlCharInputHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "ctrlCharInputHeader";
            this.Size = new System.Drawing.Size(508, 95);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboHeaderBoxClasses;
        private System.Windows.Forms.ComboBox comboHeaderBoxLevel;
        private System.Windows.Forms.Label labelHeaderAttibuteBonus;
        private System.Windows.Forms.TextBox textBoxHeaderKeyAttribute;
        private System.Windows.Forms.Label labelHeaderAttributeScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelHeaderCharacterClass;
    }
}
