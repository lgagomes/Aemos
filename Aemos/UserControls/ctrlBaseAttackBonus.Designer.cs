namespace Aemos.UserControls
{
    partial class ctrlBaseAttackBonus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlBaseAttackBonus));
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label47 = new System.Windows.Forms.Label();
            this.textBoxMonkFoB = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.textBoxBAB = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.groupBox11.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.label47);
            this.groupBox11.Controls.Add(this.textBoxMonkFoB);
            this.groupBox11.Controls.Add(this.label46);
            this.groupBox11.Controls.Add(this.textBoxBAB);
            this.groupBox11.Controls.Add(this.label45);
            this.groupBox11.Location = new System.Drawing.Point(3, 3);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(529, 98);
            this.groupBox11.TabIndex = 1;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Base Attack Bonus";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(328, 16);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(201, 78);
            this.label47.TabIndex = 16;
            this.label47.Text = resources.GetString("label47.Text");
            // 
            // textBoxMonkFoB
            // 
            this.textBoxMonkFoB.Location = new System.Drawing.Point(156, 55);
            this.textBoxMonkFoB.Name = "textBoxMonkFoB";
            this.textBoxMonkFoB.ReadOnly = true;
            this.textBoxMonkFoB.Size = new System.Drawing.Size(153, 20);
            this.textBoxMonkFoB.TabIndex = 15;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(6, 58);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(144, 13);
            this.label46.TabIndex = 14;
            this.label46.Text = "Monk\'s Fury of Blows Bonus*";
            // 
            // textBoxBAB
            // 
            this.textBoxBAB.Location = new System.Drawing.Point(156, 28);
            this.textBoxBAB.Name = "textBoxBAB";
            this.textBoxBAB.ReadOnly = true;
            this.textBoxBAB.Size = new System.Drawing.Size(153, 20);
            this.textBoxBAB.TabIndex = 13;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(5, 31);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(98, 13);
            this.label45.TabIndex = 12;
            this.label45.Text = "Base Attack Bonus";
            // 
            // ctrlBaseAttackBonus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox11);
            this.Name = "ctrlBaseAttackBonus";
            this.Size = new System.Drawing.Size(550, 110);
            this.Load += new System.EventHandler(this.ctrlBaseAttackBonus_Load);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.TextBox textBoxMonkFoB;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TextBox textBoxBAB;
        private System.Windows.Forms.Label label45;
    }
}
