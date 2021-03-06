﻿namespace ProjetoBoletimAlunos.UI.TelasAdministrador.Gerenciar_Aluno
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
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.Btn_Voltar = new System.Windows.Forms.Button();
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
            this.btn_AlterarExcluirAluno.Click += new System.EventHandler(this.btn_AlterarExcluirAluno_Click_1);
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
            // Btn_Sair
            // 
            this.Btn_Sair.BackColor = System.Drawing.Color.OrangeRed;
            this.Btn_Sair.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Btn_Sair.Location = new System.Drawing.Point(381, 283);
            this.Btn_Sair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.Size = new System.Drawing.Size(241, 38);
            this.Btn_Sair.TabIndex = 17;
            this.Btn_Sair.Text = "Sair do Sistema";
            this.Btn_Sair.UseVisualStyleBackColor = false;
            this.Btn_Sair.Click += new System.EventHandler(this.Btn_Sair_Click);
            // 
            // Btn_Voltar
            // 
            this.Btn_Voltar.BackColor = System.Drawing.Color.LightCoral;
            this.Btn_Voltar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Btn_Voltar.Location = new System.Drawing.Point(55, 283);
            this.Btn_Voltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Voltar.Name = "Btn_Voltar";
            this.Btn_Voltar.Size = new System.Drawing.Size(241, 38);
            this.Btn_Voltar.TabIndex = 16;
            this.Btn_Voltar.Text = "Voltar";
            this.Btn_Voltar.UseVisualStyleBackColor = false;
            this.Btn_Voltar.Click += new System.EventHandler(this.Btn_Voltar_Click);
            // 
            // Form_MenuGerenciarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(716, 341);
            this.Controls.Add(this.Btn_Sair);
            this.Controls.Add(this.Btn_Voltar);
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
        private System.Windows.Forms.Button Btn_Sair;
        private System.Windows.Forms.Button Btn_Voltar;
    }
}