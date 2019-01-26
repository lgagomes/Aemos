namespace Aemos.UserControls
{
    partial class ctrlDiceRoller
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
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.textBoxCustomDice = new System.Windows.Forms.TextBox();
            this.labelCustomDice = new System.Windows.Forms.Label();
            this.textBoxNumberOfDices = new System.Windows.Forms.TextBox();
            this.comboBoxModifierSignal = new System.Windows.Forms.ComboBox();
            this.buttonRoll = new System.Windows.Forms.Button();
            this.radioButtonAfterRolls = new System.Windows.Forms.RadioButton();
            this.radioButtonEachRoll = new System.Windows.Forms.RadioButton();
            this.textBoxDiceRollModifier = new System.Windows.Forms.TextBox();
            this.label64 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.labelDiceType = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.buttonCustomDice = new System.Windows.Forms.Button();
            this.buttonD100 = new System.Windows.Forms.Button();
            this.buttonD20 = new System.Windows.Forms.Button();
            this.buttonD12 = new System.Windows.Forms.Button();
            this.buttonD10 = new System.Windows.Forms.Button();
            this.buttonD8 = new System.Windows.Forms.Button();
            this.buttonD6 = new System.Windows.Forms.Button();
            this.buttonD4 = new System.Windows.Forms.Button();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.buttonClearRollResults = new System.Windows.Forms.Button();
            this.textBoxRollResults = new System.Windows.Forms.TextBox();
            this.groupBox15.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.textBoxCustomDice);
            this.groupBox15.Controls.Add(this.labelCustomDice);
            this.groupBox15.Controls.Add(this.textBoxNumberOfDices);
            this.groupBox15.Controls.Add(this.comboBoxModifierSignal);
            this.groupBox15.Controls.Add(this.buttonRoll);
            this.groupBox15.Controls.Add(this.radioButtonAfterRolls);
            this.groupBox15.Controls.Add(this.radioButtonEachRoll);
            this.groupBox15.Controls.Add(this.textBoxDiceRollModifier);
            this.groupBox15.Controls.Add(this.label64);
            this.groupBox15.Controls.Add(this.label63);
            this.groupBox15.Controls.Add(this.labelDiceType);
            this.groupBox15.Controls.Add(this.label62);
            this.groupBox15.Controls.Add(this.label61);
            this.groupBox15.Controls.Add(this.buttonCustomDice);
            this.groupBox15.Controls.Add(this.buttonD100);
            this.groupBox15.Controls.Add(this.buttonD20);
            this.groupBox15.Controls.Add(this.buttonD12);
            this.groupBox15.Controls.Add(this.buttonD10);
            this.groupBox15.Controls.Add(this.buttonD8);
            this.groupBox15.Controls.Add(this.buttonD6);
            this.groupBox15.Controls.Add(this.buttonD4);
            this.groupBox15.Location = new System.Drawing.Point(18, 10);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(526, 327);
            this.groupBox15.TabIndex = 1;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Roll setup";
            // 
            // textBoxCustomDice
            // 
            this.textBoxCustomDice.Location = new System.Drawing.Point(310, 222);
            this.textBoxCustomDice.Name = "textBoxCustomDice";
            this.textBoxCustomDice.Size = new System.Drawing.Size(59, 20);
            this.textBoxCustomDice.TabIndex = 38;
            this.textBoxCustomDice.Visible = false;
            this.textBoxCustomDice.TextChanged += new System.EventHandler(this.textBoxCustomDice_TextChanged);
            this.textBoxCustomDice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPressCommon);
            // 
            // labelCustomDice
            // 
            this.labelCustomDice.AutoSize = true;
            this.labelCustomDice.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelCustomDice.Location = new System.Drawing.Point(140, 223);
            this.labelCustomDice.Name = "labelCustomDice";
            this.labelCustomDice.Size = new System.Drawing.Size(166, 16);
            this.labelCustomDice.TabIndex = 37;
            this.labelCustomDice.Text = "Insert a custom dice type";
            this.labelCustomDice.Visible = false;
            // 
            // textBoxNumberOfDices
            // 
            this.textBoxNumberOfDices.Location = new System.Drawing.Point(177, 185);
            this.textBoxNumberOfDices.Name = "textBoxNumberOfDices";
            this.textBoxNumberOfDices.Size = new System.Drawing.Size(59, 20);
            this.textBoxNumberOfDices.TabIndex = 36;
            this.textBoxNumberOfDices.TextChanged += new System.EventHandler(this.textBoxNumberOfDices_TextChanged);
            this.textBoxNumberOfDices.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPressCommon);
            // 
            // comboBoxModifierSignal
            // 
            this.comboBoxModifierSignal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModifierSignal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxModifierSignal.FormattingEnabled = true;
            this.comboBoxModifierSignal.Items.AddRange(new object[] {
            "+",
            "-"});
            this.comboBoxModifierSignal.Location = new System.Drawing.Point(315, 181);
            this.comboBoxModifierSignal.Name = "comboBoxModifierSignal";
            this.comboBoxModifierSignal.Size = new System.Drawing.Size(44, 24);
            this.comboBoxModifierSignal.TabIndex = 10;
            // 
            // buttonRoll
            // 
            this.buttonRoll.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRoll.Location = new System.Drawing.Point(214, 295);
            this.buttonRoll.Name = "buttonRoll";
            this.buttonRoll.Size = new System.Drawing.Size(75, 23);
            this.buttonRoll.TabIndex = 35;
            this.buttonRoll.Text = "Roll";
            this.buttonRoll.UseVisualStyleBackColor = true;
            this.buttonRoll.Click += new System.EventHandler(this.buttonRoll_Click);
            // 
            // radioButtonAfterRolls
            // 
            this.radioButtonAfterRolls.AutoSize = true;
            this.radioButtonAfterRolls.Checked = true;
            this.radioButtonAfterRolls.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAfterRolls.Location = new System.Drawing.Point(91, 259);
            this.radioButtonAfterRolls.Name = "radioButtonAfterRolls";
            this.radioButtonAfterRolls.Size = new System.Drawing.Size(172, 20);
            this.radioButtonAfterRolls.TabIndex = 34;
            this.radioButtonAfterRolls.TabStop = true;
            this.radioButtonAfterRolls.Text = "Add modifier after all rolls";
            this.radioButtonAfterRolls.UseVisualStyleBackColor = true;
            this.radioButtonAfterRolls.CheckedChanged += new System.EventHandler(this.radioButtonAfterRolls_CheckedChanged);
            // 
            // radioButtonEachRoll
            // 
            this.radioButtonEachRoll.AutoSize = true;
            this.radioButtonEachRoll.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonEachRoll.Location = new System.Drawing.Point(298, 259);
            this.radioButtonEachRoll.Name = "radioButtonEachRoll";
            this.radioButtonEachRoll.Size = new System.Drawing.Size(169, 20);
            this.radioButtonEachRoll.TabIndex = 33;
            this.radioButtonEachRoll.Text = "Add modifier on each roll";
            this.radioButtonEachRoll.UseVisualStyleBackColor = true;
            this.radioButtonEachRoll.CheckedChanged += new System.EventHandler(this.radioButtonEachRoll_CheckedChanged);
            // 
            // textBoxDiceRollModifier
            // 
            this.textBoxDiceRollModifier.Location = new System.Drawing.Point(441, 185);
            this.textBoxDiceRollModifier.Name = "textBoxDiceRollModifier";
            this.textBoxDiceRollModifier.Size = new System.Drawing.Size(59, 20);
            this.textBoxDiceRollModifier.TabIndex = 32;
            this.textBoxDiceRollModifier.Text = "0";
            this.textBoxDiceRollModifier.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPressCommon);
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label64.Location = new System.Drawing.Point(319, 159);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(36, 16);
            this.label64.TabIndex = 28;
            this.label64.Text = "+  / -";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.Location = new System.Drawing.Point(440, 159);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(60, 16);
            this.label63.TabIndex = 27;
            this.label63.Text = "Modifier";
            // 
            // labelDiceType
            // 
            this.labelDiceType.AutoSize = true;
            this.labelDiceType.Location = new System.Drawing.Point(24, 188);
            this.labelDiceType.Name = "labelDiceType";
            this.labelDiceType.Size = new System.Drawing.Size(19, 13);
            this.labelDiceType.TabIndex = 26;
            this.labelDiceType.Text = "__";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label62.Location = new System.Drawing.Point(24, 158);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(70, 16);
            this.label62.TabIndex = 25;
            this.label62.Text = "Dice Type";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label61.Location = new System.Drawing.Point(156, 158);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(112, 16);
            this.label61.TabIndex = 24;
            this.label61.Text = "Number of Dices";
            // 
            // buttonCustomDice
            // 
            this.buttonCustomDice.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCustomDice.Location = new System.Drawing.Point(437, 88);
            this.buttonCustomDice.Name = "buttonCustomDice";
            this.buttonCustomDice.Size = new System.Drawing.Size(75, 23);
            this.buttonCustomDice.TabIndex = 23;
            this.buttonCustomDice.Text = "Custom";
            this.buttonCustomDice.UseVisualStyleBackColor = true;
            this.buttonCustomDice.Click += new System.EventHandler(this.buttonCustomDice_Click);
            // 
            // buttonD100
            // 
            this.buttonD100.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonD100.Location = new System.Drawing.Point(298, 88);
            this.buttonD100.Name = "buttonD100";
            this.buttonD100.Size = new System.Drawing.Size(75, 23);
            this.buttonD100.TabIndex = 22;
            this.buttonD100.Text = "d100";
            this.buttonD100.UseVisualStyleBackColor = true;
            this.buttonD100.Click += new System.EventHandler(this.UpdateDiceType);
            // 
            // buttonD20
            // 
            this.buttonD20.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonD20.Location = new System.Drawing.Point(156, 88);
            this.buttonD20.Name = "buttonD20";
            this.buttonD20.Size = new System.Drawing.Size(75, 23);
            this.buttonD20.TabIndex = 21;
            this.buttonD20.Text = "d20";
            this.buttonD20.UseVisualStyleBackColor = true;
            this.buttonD20.Click += new System.EventHandler(this.UpdateDiceType);
            // 
            // buttonD12
            // 
            this.buttonD12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonD12.Location = new System.Drawing.Point(14, 88);
            this.buttonD12.Name = "buttonD12";
            this.buttonD12.Size = new System.Drawing.Size(75, 23);
            this.buttonD12.TabIndex = 20;
            this.buttonD12.Text = "d12";
            this.buttonD12.UseVisualStyleBackColor = true;
            this.buttonD12.Click += new System.EventHandler(this.UpdateDiceType);
            // 
            // buttonD10
            // 
            this.buttonD10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonD10.Location = new System.Drawing.Point(437, 40);
            this.buttonD10.Name = "buttonD10";
            this.buttonD10.Size = new System.Drawing.Size(75, 23);
            this.buttonD10.TabIndex = 19;
            this.buttonD10.Text = "d10";
            this.buttonD10.UseVisualStyleBackColor = true;
            this.buttonD10.Click += new System.EventHandler(this.UpdateDiceType);
            // 
            // buttonD8
            // 
            this.buttonD8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonD8.Location = new System.Drawing.Point(298, 40);
            this.buttonD8.Name = "buttonD8";
            this.buttonD8.Size = new System.Drawing.Size(75, 23);
            this.buttonD8.TabIndex = 18;
            this.buttonD8.Text = "d8";
            this.buttonD8.UseVisualStyleBackColor = true;
            this.buttonD8.Click += new System.EventHandler(this.UpdateDiceType);
            // 
            // buttonD6
            // 
            this.buttonD6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonD6.Location = new System.Drawing.Point(156, 40);
            this.buttonD6.Name = "buttonD6";
            this.buttonD6.Size = new System.Drawing.Size(75, 23);
            this.buttonD6.TabIndex = 17;
            this.buttonD6.Text = "d6";
            this.buttonD6.UseVisualStyleBackColor = true;
            this.buttonD6.Click += new System.EventHandler(this.UpdateDiceType);
            // 
            // buttonD4
            // 
            this.buttonD4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonD4.Location = new System.Drawing.Point(14, 40);
            this.buttonD4.Name = "buttonD4";
            this.buttonD4.Size = new System.Drawing.Size(75, 23);
            this.buttonD4.TabIndex = 16;
            this.buttonD4.Text = "d4";
            this.buttonD4.UseVisualStyleBackColor = true;
            this.buttonD4.Click += new System.EventHandler(this.UpdateDiceType);
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.buttonClearRollResults);
            this.groupBox16.Controls.Add(this.textBoxRollResults);
            this.groupBox16.Location = new System.Drawing.Point(564, 10);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(526, 327);
            this.groupBox16.TabIndex = 2;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Roll Results";
            // 
            // buttonClearRollResults
            // 
            this.buttonClearRollResults.Location = new System.Drawing.Point(208, 295);
            this.buttonClearRollResults.Name = "buttonClearRollResults";
            this.buttonClearRollResults.Size = new System.Drawing.Size(130, 23);
            this.buttonClearRollResults.TabIndex = 1;
            this.buttonClearRollResults.Text = "Clear Results";
            this.buttonClearRollResults.UseVisualStyleBackColor = true;
            this.buttonClearRollResults.Click += new System.EventHandler(this.buttonClearRollResults_Click);
            // 
            // textBoxRollResults
            // 
            this.textBoxRollResults.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.textBoxRollResults.Location = new System.Drawing.Point(15, 19);
            this.textBoxRollResults.Multiline = true;
            this.textBoxRollResults.Name = "textBoxRollResults";
            this.textBoxRollResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxRollResults.Size = new System.Drawing.Size(496, 260);
            this.textBoxRollResults.TabIndex = 0;
            this.textBoxRollResults.WordWrap = false;
            this.textBoxRollResults.TextChanged += new System.EventHandler(this.textBoxRollResults_TextChanged);
            // 
            // ctrlDiceRoller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox16);
            this.Controls.Add(this.groupBox15);
            this.Name = "ctrlDiceRoller";
            this.Size = new System.Drawing.Size(1104, 358);
            this.Load += new System.EventHandler(this.ctrlDiceRoller_Load);
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.TextBox textBoxCustomDice;
        private System.Windows.Forms.Label labelCustomDice;
        private System.Windows.Forms.TextBox textBoxNumberOfDices;
        private System.Windows.Forms.ComboBox comboBoxModifierSignal;
        private System.Windows.Forms.Button buttonRoll;
        private System.Windows.Forms.RadioButton radioButtonAfterRolls;
        private System.Windows.Forms.RadioButton radioButtonEachRoll;
        private System.Windows.Forms.TextBox textBoxDiceRollModifier;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label labelDiceType;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Button buttonCustomDice;
        private System.Windows.Forms.Button buttonD100;
        private System.Windows.Forms.Button buttonD20;
        private System.Windows.Forms.Button buttonD12;
        private System.Windows.Forms.Button buttonD10;
        private System.Windows.Forms.Button buttonD8;
        private System.Windows.Forms.Button buttonD6;
        private System.Windows.Forms.Button buttonD4;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.Button buttonClearRollResults;
        private System.Windows.Forms.TextBox textBoxRollResults;
    }
}
