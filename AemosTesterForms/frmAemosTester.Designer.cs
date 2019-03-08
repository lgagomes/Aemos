namespace AemosTesterForms
{
    partial class frmAemosTester
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
            this.btnTestSpellsPerDayDatabase = new System.Windows.Forms.Button();
            this.btnTestCastSpellV2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTestSpellsPerDayDatabase
            // 
            this.btnTestSpellsPerDayDatabase.Location = new System.Drawing.Point(12, 12);
            this.btnTestSpellsPerDayDatabase.Name = "btnTestSpellsPerDayDatabase";
            this.btnTestSpellsPerDayDatabase.Size = new System.Drawing.Size(122, 59);
            this.btnTestSpellsPerDayDatabase.TabIndex = 0;
            this.btnTestSpellsPerDayDatabase.Text = "Test Spells per \r\nDay via Database";
            this.btnTestSpellsPerDayDatabase.UseVisualStyleBackColor = true;
            this.btnTestSpellsPerDayDatabase.Click += new System.EventHandler(this.btnTestSpellsPerDayDatabase_Click);
            // 
            // btnTestCastSpellV2
            // 
            this.btnTestCastSpellV2.Location = new System.Drawing.Point(160, 12);
            this.btnTestCastSpellV2.Name = "btnTestCastSpellV2";
            this.btnTestCastSpellV2.Size = new System.Drawing.Size(122, 59);
            this.btnTestCastSpellV2.TabIndex = 1;
            this.btnTestCastSpellV2.Text = "Test Cast Spell V2";
            this.btnTestCastSpellV2.UseVisualStyleBackColor = true;
            this.btnTestCastSpellV2.Click += new System.EventHandler(this.btnTestCastSpellV2_Click);
            // 
            // frmAemosTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 89);
            this.Controls.Add(this.btnTestCastSpellV2);
            this.Controls.Add(this.btnTestSpellsPerDayDatabase);
            this.Name = "frmAemosTester";
            this.Text = "AemosTesterForms";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTestSpellsPerDayDatabase;
        private System.Windows.Forms.Button btnTestCastSpellV2;
    }
}

