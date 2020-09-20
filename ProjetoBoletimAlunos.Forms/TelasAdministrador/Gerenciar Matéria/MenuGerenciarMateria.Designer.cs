namespace ProjetoBoletimAlunos.Forms.TelasAdministrador
{
    partial class form_MenuGerenciarMateria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_AlterarExcluirMateria = new System.Windows.Forms.Button();
            this.btn_AddMateria = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_AlterarExcluirMateria
            // 
            this.btn_AlterarExcluirMateria.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_AlterarExcluirMateria.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AlterarExcluirMateria.Location = new System.Drawing.Point(117, 245);
            this.btn_AlterarExcluirMateria.Name = "btn_AlterarExcluirMateria";
            this.btn_AlterarExcluirMateria.Size = new System.Drawing.Size(473, 75);
            this.btn_AlterarExcluirMateria.TabIndex = 1;
            this.btn_AlterarExcluirMateria.Text = "Alterar ou Excluir Matéria Existente";
            this.btn_AlterarExcluirMateria.UseVisualStyleBackColor = false;
            this.btn_AlterarExcluirMateria.Click += new System.EventHandler(this.btn_AlterarExcluirMateria_Click);
            // 
            // btn_AddMateria
            // 
            this.btn_AddMateria.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_AddMateria.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AddMateria.Location = new System.Drawing.Point(117, 120);
            this.btn_AddMateria.Name = "btn_AddMateria";
            this.btn_AddMateria.Size = new System.Drawing.Size(473, 75);
            this.btn_AddMateria.TabIndex = 1;
            this.btn_AddMateria.Text = "Adicionar Nova Matéria";
            this.btn_AddMateria.UseVisualStyleBackColor = false;
            this.btn_AddMateria.Click += new System.EventHandler(this.btn_AddMateria_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(100, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Qual operação você deseja realizar?";
            // 
            // form_MenuGerenciarMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(722, 359);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_AddMateria);
            this.Controls.Add(this.btn_AlterarExcluirMateria);
            this.Name = "form_MenuGerenciarMateria";
            this.Text = "Gerenciar Matéria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_AlterarExcluirMateria;
        private System.Windows.Forms.Button btn_AddMateria;
        private System.Windows.Forms.Label label1;
    }
}