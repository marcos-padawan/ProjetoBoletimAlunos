﻿namespace ProjetoBoletimAlunos.UI.TelasAdministrador.Gerenciar_Curso
{
    partial class Form_MenuGerenciarCurso
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_AddCurso = new System.Windows.Forms.Button();
            this.btn_AlterarExcluirCurso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(93, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Qual operação você deseja realizar?";
            // 
            // btn_AddCurso
            // 
            this.btn_AddCurso.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_AddCurso.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.btn_AddCurso.Location = new System.Drawing.Point(110, 87);
            this.btn_AddCurso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddCurso.Name = "btn_AddCurso";
            this.btn_AddCurso.Size = new System.Drawing.Size(442, 60);
            this.btn_AddCurso.TabIndex = 1;
            this.btn_AddCurso.Text = "Adicionar Novo Curso";
            this.btn_AddCurso.UseVisualStyleBackColor = false;
            this.btn_AddCurso.Click += new System.EventHandler(this.btn_AddCurso_Click);
            // 
            // btn_AlterarExcluirCurso
            // 
            this.btn_AlterarExcluirCurso.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_AlterarExcluirCurso.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.btn_AlterarExcluirCurso.Location = new System.Drawing.Point(110, 187);
            this.btn_AlterarExcluirCurso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AlterarExcluirCurso.Name = "btn_AlterarExcluirCurso";
            this.btn_AlterarExcluirCurso.Size = new System.Drawing.Size(442, 60);
            this.btn_AlterarExcluirCurso.TabIndex = 1;
            this.btn_AlterarExcluirCurso.Text = "Alterar ou Excluir Curso Existente";
            this.btn_AlterarExcluirCurso.UseVisualStyleBackColor = false;
            this.btn_AlterarExcluirCurso.Click += new System.EventHandler(this.btn_AlterarExcluirCurso_Click);
            // 
            // Form_MenuGerenciarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(691, 284);
            this.Controls.Add(this.btn_AlterarExcluirCurso);
            this.Controls.Add(this.btn_AddCurso);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_MenuGerenciarCurso";
            this.Text = "Gerenciar Curso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_AddCurso;
        private System.Windows.Forms.Button btn_AlterarExcluirCurso;
    }
}