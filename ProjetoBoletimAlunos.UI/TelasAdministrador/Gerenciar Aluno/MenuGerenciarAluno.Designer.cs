namespace ProjetoBoletimAlunos.UI.TelasAdministrador.Gerenciar_Aluno
{
    partial class Form_MenuGerenciarAluno
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
            this.btn_AlterarExcluirAluno = new System.Windows.Forms.Button();
            this.btn_AddAluno = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_AlterarExcluirAluno
            // 
            this.btn_AlterarExcluirAluno.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_AlterarExcluirAluno.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.btn_AlterarExcluirAluno.Location = new System.Drawing.Point(117, 196);
            this.btn_AlterarExcluirAluno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AlterarExcluirAluno.Name = "btn_AlterarExcluirAluno";
            this.btn_AlterarExcluirAluno.Size = new System.Drawing.Size(442, 60);
            this.btn_AlterarExcluirAluno.TabIndex = 1;
            this.btn_AlterarExcluirAluno.Text = "Alterar ou Excluir Aluno Existente";
            this.btn_AlterarExcluirAluno.UseVisualStyleBackColor = false;
            // 
            // btn_AddAluno
            // 
            this.btn_AddAluno.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_AddAluno.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.btn_AddAluno.Location = new System.Drawing.Point(117, 96);
            this.btn_AddAluno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddAluno.Name = "btn_AddAluno";
            this.btn_AddAluno.Size = new System.Drawing.Size(442, 60);
            this.btn_AddAluno.TabIndex = 1;
            this.btn_AddAluno.Text = "Adicionar Novo Aluno";
            this.btn_AddAluno.UseVisualStyleBackColor = false;
            this.btn_AddAluno.Click += new System.EventHandler(this.btn_AddAluno_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(100, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Qual operação você deseja realizar?";
            // 
            // Form_MenuGerenciarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(716, 285);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_AddAluno);
            this.Controls.Add(this.btn_AlterarExcluirAluno);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_MenuGerenciarAluno";
            this.Text = "Gerenciar Aluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_AlterarExcluirAluno;
        private System.Windows.Forms.Button btn_AddAluno;
        private System.Windows.Forms.Label label1;
    }
}