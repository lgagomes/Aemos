namespace Aemos.UserControls
{
    partial class ctrlXpProgression
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxXpRequired = new System.Windows.Forms.TextBox();
            this.textBoxCharLevel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.dataGridViewXpProgression = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXpProgression)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "XP Required";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Character Level";
            // 
            // textBoxXpRequired
            // 
            this.textBoxXpRequired.Location = new System.Drawing.Point(361, 182);
            this.textBoxXpRequired.Name = "textBoxXpRequired";
            this.textBoxXpRequired.ReadOnly = true;
            this.textBoxXpRequired.Size = new System.Drawing.Size(83, 20);
            this.textBoxXpRequired.TabIndex = 11;
            // 
            // textBoxCharLevel
            // 
            this.textBoxCharLevel.Location = new System.Drawing.Point(361, 143);
            this.textBoxCharLevel.Name = "textBoxCharLevel";
            this.textBoxCharLevel.Size = new System.Drawing.Size(81, 20);
            this.textBoxCharLevel.TabIndex = 10;
            this.textBoxCharLevel.Text = "0";
            this.textBoxCharLevel.TextChanged += new System.EventHandler(this.textBoxCharLevel_TextChanged);
            this.textBoxCharLevel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCharLevel_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 112);
            this.label1.TabIndex = 9;
            this.label1.Text = "Here is presented the level\r\nprogression for levels 1 to 20 \r\nonly (just like in " +
    "the Player\'s \r\nHandbook). If you wish to \r\nknow the XP required for\r\nlevels abov" +
    "e 20, inform the\r\ndesired level below.";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(300, 226);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 8;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // dataGridViewXpProgression
            // 
            this.dataGridViewXpProgression.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewXpProgression.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewXpProgression.Location = new System.Drawing.Point(12, 6);
            this.dataGridViewXpProgression.Name = "dataGridViewXpProgression";
            this.dataGridViewXpProgression.ReadOnly = true;
            this.dataGridViewXpProgression.RowHeadersWidth = 5;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewXpProgression.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewXpProgression.Size = new System.Drawing.Size(208, 465);
            this.dataGridViewXpProgression.TabIndex = 7;
            // 
            // ctrlXpProgression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxXpRequired);
            this.Controls.Add(this.textBoxCharLevel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.dataGridViewXpProgression);
            this.Name = "ctrlXpProgression";
            this.Size = new System.Drawing.Size(466, 481);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXpProgression)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxXpRequired;
        private System.Windows.Forms.TextBox textBoxCharLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.DataGridView dataGridViewXpProgression;
    }
}
