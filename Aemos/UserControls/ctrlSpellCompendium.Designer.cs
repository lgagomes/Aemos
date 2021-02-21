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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSpellName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxSpellLevel = new System.Windows.Forms.ComboBox();
            this.btnSearchSpell = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxSchools = new System.Windows.Forms.ComboBox();
            this.comboBoxClasses = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClearSpellsGrid = new System.Windows.Forms.Button();
            this.dataGridViewSpellsDetailed = new System.Windows.Forms.DataGridView();
            this.comboBoxDomain = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subSchoolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.componentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.castingTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.effectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.savingThrowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spellResistanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.briefDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialComponentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arcaneMaterialComponentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xpCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.focusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arcaneFocusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bardFocusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clericFocusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.druidFocusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sorcererFocusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wizardFocusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spellDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpellsDetailed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spellDTOBindingSource)).BeginInit();
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
            this.label2.Location = new System.Drawing.Point(7, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Spell School";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Class";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Spell Cycle";
            // 
            // comboBoxSpellLevel
            // 
            this.comboBoxSpellLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSpellLevel.FormattingEnabled = true;
            this.comboBoxSpellLevel.Location = new System.Drawing.Point(501, 41);
            this.comboBoxSpellLevel.Name = "comboBoxSpellLevel";
            this.comboBoxSpellLevel.Size = new System.Drawing.Size(74, 21);
            this.comboBoxSpellLevel.TabIndex = 7;
            // 
            // btnSearchSpell
            // 
            this.btnSearchSpell.Location = new System.Drawing.Point(615, 39);
            this.btnSearchSpell.Name = "btnSearchSpell";
            this.btnSearchSpell.Size = new System.Drawing.Size(100, 23);
            this.btnSearchSpell.TabIndex = 8;
            this.btnSearchSpell.Text = "Search";
            this.btnSearchSpell.UseVisualStyleBackColor = true;
            this.btnSearchSpell.Click += new System.EventHandler(this.btnSearchSpell_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxDomain);
            this.groupBox1.Controls.Add(this.comboBoxSchools);
            this.groupBox1.Controls.Add(this.comboBoxClasses);
            this.groupBox1.Controls.Add(this.btnSearchSpell);
            this.groupBox1.Controls.Add(this.comboBoxSpellLevel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxSpellName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(767, 97);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Spell\'s Filter";
            // 
            // comboBoxSchools
            // 
            this.comboBoxSchools.DisplayMember = "SchoolName";
            this.comboBoxSchools.FormattingEnabled = true;
            this.comboBoxSchools.Location = new System.Drawing.Point(94, 60);
            this.comboBoxSchools.Name = "comboBoxSchools";
            this.comboBoxSchools.Size = new System.Drawing.Size(114, 21);
            this.comboBoxSchools.TabIndex = 10;
            this.comboBoxSchools.ValueMember = "Id";
            // 
            // comboBoxClasses
            // 
            this.comboBoxClasses.DisplayMember = "ClassName";
            this.comboBoxClasses.FormattingEnabled = true;
            this.comboBoxClasses.Location = new System.Drawing.Point(286, 22);
            this.comboBoxClasses.Name = "comboBoxClasses";
            this.comboBoxClasses.Size = new System.Drawing.Size(121, 21);
            this.comboBoxClasses.TabIndex = 9;
            this.comboBoxClasses.ValueMember = "Id";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClearSpellsGrid);
            this.groupBox2.Controls.Add(this.dataGridViewSpellsDetailed);
            this.groupBox2.Location = new System.Drawing.Point(15, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(767, 310);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Spells Found";
            // 
            // btnClearSpellsGrid
            // 
            this.btnClearSpellsGrid.Location = new System.Drawing.Point(339, 281);
            this.btnClearSpellsGrid.Name = "btnClearSpellsGrid";
            this.btnClearSpellsGrid.Size = new System.Drawing.Size(96, 23);
            this.btnClearSpellsGrid.TabIndex = 1;
            this.btnClearSpellsGrid.Text = "Clear Results";
            this.btnClearSpellsGrid.UseVisualStyleBackColor = true;
            this.btnClearSpellsGrid.Click += new System.EventHandler(this.btnClearSpellsGrid_Click);
            // 
            // dataGridViewSpellsDetailed
            // 
            this.dataGridViewSpellsDetailed.AutoGenerateColumns = false;
            this.dataGridViewSpellsDetailed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSpellsDetailed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.schoolDataGridViewTextBoxColumn,
            this.subSchoolDataGridViewTextBoxColumn,
            this.descriptorDataGridViewTextBoxColumn,
            this.levelDataGridViewTextBoxColumn,
            this.componentsDataGridViewTextBoxColumn,
            this.castingTimeDataGridViewTextBoxColumn,
            this.rangeDataGridViewTextBoxColumn,
            this.targetDataGridViewTextBoxColumn,
            this.effectDataGridViewTextBoxColumn,
            this.areaDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.savingThrowDataGridViewTextBoxColumn,
            this.spellResistanceDataGridViewTextBoxColumn,
            this.briefDescriptionDataGridViewTextBoxColumn,
            this.materialComponentsDataGridViewTextBoxColumn,
            this.arcaneMaterialComponentsDataGridViewTextBoxColumn,
            this.xpCostDataGridViewTextBoxColumn,
            this.focusDataGridViewTextBoxColumn,
            this.arcaneFocusDataGridViewTextBoxColumn,
            this.bardFocusDataGridViewTextBoxColumn,
            this.clericFocusDataGridViewTextBoxColumn,
            this.druidFocusDataGridViewTextBoxColumn,
            this.sorcererFocusDataGridViewTextBoxColumn,
            this.wizardFocusDataGridViewTextBoxColumn});
            this.dataGridViewSpellsDetailed.DataSource = this.spellDTOBindingSource;
            this.dataGridViewSpellsDetailed.Location = new System.Drawing.Point(9, 23);
            this.dataGridViewSpellsDetailed.Name = "dataGridViewSpellsDetailed";
            this.dataGridViewSpellsDetailed.Size = new System.Drawing.Size(749, 252);
            this.dataGridViewSpellsDetailed.TabIndex = 0;
            this.dataGridViewSpellsDetailed.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSpellsDetailed_CellContentDoubleClick);
            // 
            // comboBoxDomain
            // 
            this.comboBoxDomain.DisplayMember = "DomainName";
            this.comboBoxDomain.FormattingEnabled = true;
            this.comboBoxDomain.Location = new System.Drawing.Point(286, 61);
            this.comboBoxDomain.Name = "comboBoxDomain";
            this.comboBoxDomain.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDomain.TabIndex = 11;
            this.comboBoxDomain.ValueMember = "IdDomain";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Class";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Domain";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Spell Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // schoolDataGridViewTextBoxColumn
            // 
            this.schoolDataGridViewTextBoxColumn.DataPropertyName = "School";
            this.schoolDataGridViewTextBoxColumn.HeaderText = "School";
            this.schoolDataGridViewTextBoxColumn.Name = "schoolDataGridViewTextBoxColumn";
            this.schoolDataGridViewTextBoxColumn.Visible = false;
            // 
            // subSchoolDataGridViewTextBoxColumn
            // 
            this.subSchoolDataGridViewTextBoxColumn.DataPropertyName = "SubSchool";
            this.subSchoolDataGridViewTextBoxColumn.HeaderText = "SubSchool";
            this.subSchoolDataGridViewTextBoxColumn.Name = "subSchoolDataGridViewTextBoxColumn";
            this.subSchoolDataGridViewTextBoxColumn.Visible = false;
            // 
            // descriptorDataGridViewTextBoxColumn
            // 
            this.descriptorDataGridViewTextBoxColumn.DataPropertyName = "Descriptor";
            this.descriptorDataGridViewTextBoxColumn.HeaderText = "Descriptor";
            this.descriptorDataGridViewTextBoxColumn.Name = "descriptorDataGridViewTextBoxColumn";
            this.descriptorDataGridViewTextBoxColumn.Visible = false;
            this.descriptorDataGridViewTextBoxColumn.Width = 200;
            // 
            // levelDataGridViewTextBoxColumn
            // 
            this.levelDataGridViewTextBoxColumn.DataPropertyName = "Level";
            this.levelDataGridViewTextBoxColumn.HeaderText = "Classes and Level";
            this.levelDataGridViewTextBoxColumn.Name = "levelDataGridViewTextBoxColumn";
            this.levelDataGridViewTextBoxColumn.Width = 235;
            // 
            // componentsDataGridViewTextBoxColumn
            // 
            this.componentsDataGridViewTextBoxColumn.DataPropertyName = "Components";
            this.componentsDataGridViewTextBoxColumn.HeaderText = "Components";
            this.componentsDataGridViewTextBoxColumn.Name = "componentsDataGridViewTextBoxColumn";
            this.componentsDataGridViewTextBoxColumn.Visible = false;
            // 
            // castingTimeDataGridViewTextBoxColumn
            // 
            this.castingTimeDataGridViewTextBoxColumn.DataPropertyName = "CastingTime";
            this.castingTimeDataGridViewTextBoxColumn.HeaderText = "CastingTime";
            this.castingTimeDataGridViewTextBoxColumn.Name = "castingTimeDataGridViewTextBoxColumn";
            this.castingTimeDataGridViewTextBoxColumn.Visible = false;
            // 
            // rangeDataGridViewTextBoxColumn
            // 
            this.rangeDataGridViewTextBoxColumn.DataPropertyName = "Range";
            this.rangeDataGridViewTextBoxColumn.HeaderText = "Range";
            this.rangeDataGridViewTextBoxColumn.Name = "rangeDataGridViewTextBoxColumn";
            this.rangeDataGridViewTextBoxColumn.Visible = false;
            // 
            // targetDataGridViewTextBoxColumn
            // 
            this.targetDataGridViewTextBoxColumn.DataPropertyName = "Target";
            this.targetDataGridViewTextBoxColumn.HeaderText = "Target";
            this.targetDataGridViewTextBoxColumn.Name = "targetDataGridViewTextBoxColumn";
            this.targetDataGridViewTextBoxColumn.Visible = false;
            // 
            // effectDataGridViewTextBoxColumn
            // 
            this.effectDataGridViewTextBoxColumn.DataPropertyName = "Effect";
            this.effectDataGridViewTextBoxColumn.HeaderText = "Effect";
            this.effectDataGridViewTextBoxColumn.Name = "effectDataGridViewTextBoxColumn";
            this.effectDataGridViewTextBoxColumn.Visible = false;
            // 
            // areaDataGridViewTextBoxColumn
            // 
            this.areaDataGridViewTextBoxColumn.DataPropertyName = "Area";
            this.areaDataGridViewTextBoxColumn.HeaderText = "Area";
            this.areaDataGridViewTextBoxColumn.Name = "areaDataGridViewTextBoxColumn";
            this.areaDataGridViewTextBoxColumn.Visible = false;
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "Duration";
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            this.durationDataGridViewTextBoxColumn.Visible = false;
            // 
            // savingThrowDataGridViewTextBoxColumn
            // 
            this.savingThrowDataGridViewTextBoxColumn.DataPropertyName = "SavingThrow";
            this.savingThrowDataGridViewTextBoxColumn.HeaderText = "SavingThrow";
            this.savingThrowDataGridViewTextBoxColumn.Name = "savingThrowDataGridViewTextBoxColumn";
            this.savingThrowDataGridViewTextBoxColumn.Visible = false;
            // 
            // spellResistanceDataGridViewTextBoxColumn
            // 
            this.spellResistanceDataGridViewTextBoxColumn.DataPropertyName = "SpellResistance";
            this.spellResistanceDataGridViewTextBoxColumn.HeaderText = "SpellResistance";
            this.spellResistanceDataGridViewTextBoxColumn.Name = "spellResistanceDataGridViewTextBoxColumn";
            this.spellResistanceDataGridViewTextBoxColumn.Visible = false;
            // 
            // briefDescriptionDataGridViewTextBoxColumn
            // 
            this.briefDescriptionDataGridViewTextBoxColumn.DataPropertyName = "BriefDescription";
            this.briefDescriptionDataGridViewTextBoxColumn.HeaderText = "Brief Description";
            this.briefDescriptionDataGridViewTextBoxColumn.Name = "briefDescriptionDataGridViewTextBoxColumn";
            this.briefDescriptionDataGridViewTextBoxColumn.Width = 350;
            // 
            // materialComponentsDataGridViewTextBoxColumn
            // 
            this.materialComponentsDataGridViewTextBoxColumn.DataPropertyName = "MaterialComponents";
            this.materialComponentsDataGridViewTextBoxColumn.HeaderText = "MaterialComponents";
            this.materialComponentsDataGridViewTextBoxColumn.Name = "materialComponentsDataGridViewTextBoxColumn";
            this.materialComponentsDataGridViewTextBoxColumn.Visible = false;
            // 
            // arcaneMaterialComponentsDataGridViewTextBoxColumn
            // 
            this.arcaneMaterialComponentsDataGridViewTextBoxColumn.DataPropertyName = "ArcaneMaterialComponents";
            this.arcaneMaterialComponentsDataGridViewTextBoxColumn.HeaderText = "ArcaneMaterialComponents";
            this.arcaneMaterialComponentsDataGridViewTextBoxColumn.Name = "arcaneMaterialComponentsDataGridViewTextBoxColumn";
            this.arcaneMaterialComponentsDataGridViewTextBoxColumn.Visible = false;
            // 
            // xpCostDataGridViewTextBoxColumn
            // 
            this.xpCostDataGridViewTextBoxColumn.DataPropertyName = "XpCost";
            this.xpCostDataGridViewTextBoxColumn.HeaderText = "XpCost";
            this.xpCostDataGridViewTextBoxColumn.Name = "xpCostDataGridViewTextBoxColumn";
            this.xpCostDataGridViewTextBoxColumn.Visible = false;
            // 
            // focusDataGridViewTextBoxColumn
            // 
            this.focusDataGridViewTextBoxColumn.DataPropertyName = "Focus";
            this.focusDataGridViewTextBoxColumn.HeaderText = "Focus";
            this.focusDataGridViewTextBoxColumn.Name = "focusDataGridViewTextBoxColumn";
            this.focusDataGridViewTextBoxColumn.Visible = false;
            // 
            // arcaneFocusDataGridViewTextBoxColumn
            // 
            this.arcaneFocusDataGridViewTextBoxColumn.DataPropertyName = "ArcaneFocus";
            this.arcaneFocusDataGridViewTextBoxColumn.HeaderText = "ArcaneFocus";
            this.arcaneFocusDataGridViewTextBoxColumn.Name = "arcaneFocusDataGridViewTextBoxColumn";
            this.arcaneFocusDataGridViewTextBoxColumn.Visible = false;
            // 
            // bardFocusDataGridViewTextBoxColumn
            // 
            this.bardFocusDataGridViewTextBoxColumn.DataPropertyName = "BardFocus";
            this.bardFocusDataGridViewTextBoxColumn.HeaderText = "BardFocus";
            this.bardFocusDataGridViewTextBoxColumn.Name = "bardFocusDataGridViewTextBoxColumn";
            this.bardFocusDataGridViewTextBoxColumn.Visible = false;
            // 
            // clericFocusDataGridViewTextBoxColumn
            // 
            this.clericFocusDataGridViewTextBoxColumn.DataPropertyName = "ClericFocus";
            this.clericFocusDataGridViewTextBoxColumn.HeaderText = "ClericFocus";
            this.clericFocusDataGridViewTextBoxColumn.Name = "clericFocusDataGridViewTextBoxColumn";
            this.clericFocusDataGridViewTextBoxColumn.Visible = false;
            // 
            // druidFocusDataGridViewTextBoxColumn
            // 
            this.druidFocusDataGridViewTextBoxColumn.DataPropertyName = "DruidFocus";
            this.druidFocusDataGridViewTextBoxColumn.HeaderText = "DruidFocus";
            this.druidFocusDataGridViewTextBoxColumn.Name = "druidFocusDataGridViewTextBoxColumn";
            this.druidFocusDataGridViewTextBoxColumn.Visible = false;
            // 
            // sorcererFocusDataGridViewTextBoxColumn
            // 
            this.sorcererFocusDataGridViewTextBoxColumn.DataPropertyName = "SorcererFocus";
            this.sorcererFocusDataGridViewTextBoxColumn.HeaderText = "SorcererFocus";
            this.sorcererFocusDataGridViewTextBoxColumn.Name = "sorcererFocusDataGridViewTextBoxColumn";
            this.sorcererFocusDataGridViewTextBoxColumn.Visible = false;
            // 
            // wizardFocusDataGridViewTextBoxColumn
            // 
            this.wizardFocusDataGridViewTextBoxColumn.DataPropertyName = "WizardFocus";
            this.wizardFocusDataGridViewTextBoxColumn.HeaderText = "WizardFocus";
            this.wizardFocusDataGridViewTextBoxColumn.Name = "wizardFocusDataGridViewTextBoxColumn";
            this.wizardFocusDataGridViewTextBoxColumn.Visible = false;
            // 
            // spellDTOBindingSource
            // 
            this.spellDTOBindingSource.DataSource = typeof(Aemos.Helpers.SpellDTO);
            // 
            // ctrlSpellCompendium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ctrlSpellCompendium";
            this.Size = new System.Drawing.Size(794, 444);
            this.Load += new System.EventHandler(this.ctrlSpellCompendium_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpellsDetailed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spellDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSpellName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxSpellLevel;
        private System.Windows.Forms.Button btnSearchSpell;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewSpellsDetailed;
        private System.Windows.Forms.Button btnClearSpellsGrid;
        private System.Windows.Forms.BindingSource spellDTOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subSchoolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn componentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn castingTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn effectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn savingThrowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spellResistanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn briefDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialComponentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arcaneMaterialComponentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xpCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn focusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arcaneFocusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bardFocusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clericFocusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn druidFocusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sorcererFocusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wizardFocusDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBoxClasses;
        private System.Windows.Forms.ComboBox comboBoxSchools;
        private System.Windows.Forms.ComboBox comboBoxDomain;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}
