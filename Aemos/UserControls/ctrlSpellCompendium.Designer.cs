namespace Aemos.UserControls
{
    partial class ctrlSpellCompendium
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSpellName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSpellSchool = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxClassToSearch = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxLevelToSearch = new System.Windows.Forms.ComboBox();
            this.btnSearchSpell = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClearSpellsGrid = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Spell Name";
            // 
            // textBoxSpellName
            // 
            this.textBoxSpellName.Location = new System.Drawing.Point(94, 21);
            this.textBoxSpellName.Name = "textBoxSpellName";
            this.textBoxSpellName.Size = new System.Drawing.Size(114, 20);
            this.textBoxSpellName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Spell School";
            // 
            // comboBoxSpellSchool
            // 
            this.comboBoxSpellSchool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSpellSchool.FormattingEnabled = true;
            this.comboBoxSpellSchool.Location = new System.Drawing.Point(315, 21);
            this.comboBoxSpellSchool.Name = "comboBoxSpellSchool";
            this.comboBoxSpellSchool.Size = new System.Drawing.Size(114, 21);
            this.comboBoxSpellSchool.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Class";
            // 
            // comboBoxClassToSearch
            // 
            this.comboBoxClassToSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClassToSearch.FormattingEnabled = true;
            this.comboBoxClassToSearch.Location = new System.Drawing.Point(94, 60);
            this.comboBoxClassToSearch.Name = "comboBoxClassToSearch";
            this.comboBoxClassToSearch.Size = new System.Drawing.Size(94, 21);
            this.comboBoxClassToSearch.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Level";
            // 
            // comboBoxLevelToSearch
            // 
            this.comboBoxLevelToSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLevelToSearch.FormattingEnabled = true;
            this.comboBoxLevelToSearch.Location = new System.Drawing.Point(315, 60);
            this.comboBoxLevelToSearch.Name = "comboBoxLevelToSearch";
            this.comboBoxLevelToSearch.Size = new System.Drawing.Size(74, 21);
            this.comboBoxLevelToSearch.TabIndex = 7;
            // 
            // btnSearchSpell
            // 
            this.btnSearchSpell.Location = new System.Drawing.Point(183, 107);
            this.btnSearchSpell.Name = "btnSearchSpell";
            this.btnSearchSpell.Size = new System.Drawing.Size(75, 23);
            this.btnSearchSpell.TabIndex = 8;
            this.btnSearchSpell.Text = "Search";
            this.btnSearchSpell.UseVisualStyleBackColor = true;
            this.btnSearchSpell.Click += new System.EventHandler(this.btnSearchSpell_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearchSpell);
            this.groupBox1.Controls.Add(this.comboBoxLevelToSearch);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBoxClassToSearch);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxSpellSchool);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxSpellName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 151);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Spell\'s Info";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClearSpellsGrid);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(15, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(452, 249);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Spells Found";
            // 
            // btnClearSpellsGrid
            // 
            this.btnClearSpellsGrid.Location = new System.Drawing.Point(180, 220);
            this.btnClearSpellsGrid.Name = "btnClearSpellsGrid";
            this.btnClearSpellsGrid.Size = new System.Drawing.Size(96, 23);
            this.btnClearSpellsGrid.TabIndex = 1;
            this.btnClearSpellsGrid.Text = "Clear Results";
            this.btnClearSpellsGrid.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(437, 183);
            this.dataGridView1.TabIndex = 0;
            // 
            // ctrlSpellCompendium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ctrlSpellCompendium";
            this.Size = new System.Drawing.Size(483, 444);
            this.Load += new System.EventHandler(this.ctrlSpellCompendium_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSpellName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSpellSchool;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxClassToSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxLevelToSearch;
        private System.Windows.Forms.Button btnSearchSpell;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnClearSpellsGrid;
    }
}
