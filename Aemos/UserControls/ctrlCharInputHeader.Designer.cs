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
            this.comboBoxHeaderClasses = new System.Windows.Forms.ComboBox();
            this.comboBoxHeaderLevel = new System.Windows.Forms.ComboBox();
            this.textBoxHeaderAttributeScore = new System.Windows.Forms.TextBox();
            this.labelHeaderAttributeScore = new System.Windows.Forms.Label();
            this.labelHeaderCharacterLevel = new System.Windows.Forms.Label();
            this.labelHeaderCharacterClass = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxHeaderClasses);
            this.groupBox1.Controls.Add(this.comboBoxHeaderLevel);
            this.groupBox1.Controls.Add(this.textBoxHeaderAttributeScore);
            this.groupBox1.Controls.Add(this.labelHeaderAttributeScore);
            this.groupBox1.Controls.Add(this.labelHeaderCharacterLevel);
            this.groupBox1.Controls.Add(this.labelHeaderCharacterClass);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 85);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Character Info";
            // 
            // comboBoxHeaderClasses
            // 
            this.comboBoxHeaderClasses.FormattingEnabled = true;
            this.comboBoxHeaderClasses.Location = new System.Drawing.Point(25, 46);
            this.comboBoxHeaderClasses.Name = "comboBoxHeaderClasses";
            this.comboBoxHeaderClasses.Size = new System.Drawing.Size(121, 24);
            this.comboBoxHeaderClasses.TabIndex = 15;
            this.comboBoxHeaderClasses.Text = "Choose a Class";
            this.comboBoxHeaderClasses.SelectedIndexChanged += new System.EventHandler(this.comboBoxHeaderClasses_SelectedIndexChanged);
            // 
            // comboBoxHeaderLevel
            // 
            this.comboBoxHeaderLevel.FormattingEnabled = true;
            this.comboBoxHeaderLevel.Location = new System.Drawing.Point(203, 47);
            this.comboBoxHeaderLevel.Name = "comboBoxHeaderLevel";
            this.comboBoxHeaderLevel.Size = new System.Drawing.Size(96, 24);
            this.comboBoxHeaderLevel.TabIndex = 14;
            this.comboBoxHeaderLevel.Text = "1";
            this.comboBoxHeaderLevel.SelectedIndexChanged += new System.EventHandler(this.comboBoxHeaderLevel_SelectedIndexChanged);
            // 
            // textBoxHeaderAttributeScore
            // 
            this.textBoxHeaderAttributeScore.Location = new System.Drawing.Point(380, 47);
            this.textBoxHeaderAttributeScore.Name = "textBoxHeaderAttributeScore";
            this.textBoxHeaderAttributeScore.Size = new System.Drawing.Size(32, 22);
            this.textBoxHeaderAttributeScore.TabIndex = 12;
            this.textBoxHeaderAttributeScore.Text = "10";
            this.textBoxHeaderAttributeScore.TextChanged += new System.EventHandler(this.textBoxHeaderAttributeScore_TextChanged);
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
            // labelHeaderCharacterLevel
            // 
            this.labelHeaderCharacterLevel.AutoSize = true;
            this.labelHeaderCharacterLevel.Location = new System.Drawing.Point(200, 24);
            this.labelHeaderCharacterLevel.Name = "labelHeaderCharacterLevel";
            this.labelHeaderCharacterLevel.Size = new System.Drawing.Size(97, 16);
            this.labelHeaderCharacterLevel.TabIndex = 10;
            this.labelHeaderCharacterLevel.Text = "Character Level";
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
            this.Load += new System.EventHandler(this.ctrlCharInputHeader_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxHeaderClasses;
        private System.Windows.Forms.ComboBox comboBoxHeaderLevel;
        private System.Windows.Forms.TextBox textBoxHeaderAttributeScore;
        private System.Windows.Forms.Label labelHeaderAttributeScore;
        private System.Windows.Forms.Label labelHeaderCharacterLevel;
        private System.Windows.Forms.Label labelHeaderCharacterClass;
    }
}
