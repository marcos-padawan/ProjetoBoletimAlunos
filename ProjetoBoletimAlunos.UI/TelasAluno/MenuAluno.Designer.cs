﻿namespace ProjetoBoletimAlunos.UI.TelasAluno
{
    partial class Form_MenuAluno
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
            this.btn_Notas1Materia = new System.Windows.Forms.Button();
            this.btn_NotasTodasMaterias = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_NomeAluno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_NotasCursosAnteriores = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_SobrenomeAluno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_MostraErroAlunoNaoEncontrado = new System.Windows.Forms.Label();
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Notas1Materia
            // 
            this.btn_Notas1Materia.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_Notas1Materia.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_Notas1Materia.Location = new System.Drawing.Point(46, 189);
            this.btn_Notas1Materia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Notas1Materia.Name = "btn_Notas1Materia";
            this.btn_Notas1Materia.Size = new System.Drawing.Size(548, 38);
            this.btn_Notas1Materia.TabIndex = 0;
            this.btn_Notas1Materia.Text = "Consultar notas de UMA matéria";
            this.btn_Notas1Materia.UseVisualStyleBackColor = false;
            this.btn_Notas1Materia.Click += new System.EventHandler(this.btn_Notas1Materia_Click);
            // 
            // btn_NotasTodasMaterias
            // 
            this.btn_NotasTodasMaterias.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_NotasTodasMaterias.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_NotasTodasMaterias.Location = new System.Drawing.Point(46, 252);
            this.btn_NotasTodasMaterias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_NotasTodasMaterias.Name = "btn_NotasTodasMaterias";
            this.btn_NotasTodasMaterias.Size = new System.Drawing.Size(548, 38);
            this.btn_NotasTodasMaterias.TabIndex = 0;
            this.btn_NotasTodasMaterias.Text = "Consultar notas de TODAS as matérias";
            this.btn_NotasTodasMaterias.UseVisualStyleBackColor = false;
            this.btn_NotasTodasMaterias.Click += new System.EventHandler(this.btn_NotasTodasMaterias_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(32, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Insira seu nome e sobrenome nos campos abaixo:";
            // 
            // txt_NomeAluno
            // 
            this.txt_NomeAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NomeAluno.Location = new System.Drawing.Point(32, 89);
            this.txt_NomeAluno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_NomeAluno.Name = "txt_NomeAluno";
            this.txt_NomeAluno.Size = new System.Drawing.Size(265, 30);
            this.txt_NomeAluno.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(32, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(508, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Escolha uma das opções de consulta de notas:";
            // 
            // btn_NotasCursosAnteriores
            // 
            this.btn_NotasCursosAnteriores.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_NotasCursosAnteriores.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_NotasCursosAnteriores.Location = new System.Drawing.Point(46, 314);
            this.btn_NotasCursosAnteriores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_NotasCursosAnteriores.Name = "btn_NotasCursosAnteriores";
            this.btn_NotasCursosAnteriores.Size = new System.Drawing.Size(548, 38);
            this.btn_NotasCursosAnteriores.TabIndex = 0;
            this.btn_NotasCursosAnteriores.Text = "Consultar notas de CURSOS ANTERIORES";
            this.btn_NotasCursosAnteriores.UseVisualStyleBackColor = false;
            this.btn_NotasCursosAnteriores.Click += new System.EventHandler(this.btn_NotasCursosAnteriores_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(32, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nome:";
            // 
            // txt_SobrenomeAluno
            // 
            this.txt_SobrenomeAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SobrenomeAluno.Location = new System.Drawing.Point(329, 89);
            this.txt_SobrenomeAluno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SobrenomeAluno.Name = "txt_SobrenomeAluno";
            this.txt_SobrenomeAluno.Size = new System.Drawing.Size(265, 30);
            this.txt_SobrenomeAluno.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(326, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sobrenome:";
            // 
            // lbl_MostraErroAlunoNaoEncontrado
            // 
            this.lbl_MostraErroAlunoNaoEncontrado.AutoSize = true;
            this.lbl_MostraErroAlunoNaoEncontrado.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_MostraErroAlunoNaoEncontrado.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.lbl_MostraErroAlunoNaoEncontrado.ForeColor = System.Drawing.Color.Red;
            this.lbl_MostraErroAlunoNaoEncontrado.Location = new System.Drawing.Point(179, 122);
            this.lbl_MostraErroAlunoNaoEncontrado.Name = "lbl_MostraErroAlunoNaoEncontrado";
            this.lbl_MostraErroAlunoNaoEncontrado.Size = new System.Drawing.Size(0, 32);
            this.lbl_MostraErroAlunoNaoEncontrado.TabIndex = 3;
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.BackColor = System.Drawing.Color.OrangeRed;
            this.Btn_Sair.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Btn_Sair.Location = new System.Drawing.Point(353, 392);
            this.Btn_Sair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.Size = new System.Drawing.Size(241, 38);
            this.Btn_Sair.TabIndex = 15;
            this.Btn_Sair.Text = "Sair do Sistema";
            this.Btn_Sair.UseVisualStyleBackColor = false;
            this.Btn_Sair.Click += new System.EventHandler(this.Btn_Sair_Click);
            // 
            // Btn_Voltar
            // 
            this.Btn_Voltar.BackColor = System.Drawing.Color.LightCoral;
            this.Btn_Voltar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Btn_Voltar.Location = new System.Drawing.Point(46, 392);
            this.Btn_Voltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Voltar.Name = "Btn_Voltar";
            this.Btn_Voltar.Size = new System.Drawing.Size(241, 38);
            this.Btn_Voltar.TabIndex = 14;
            this.Btn_Voltar.Text = "Voltar";
            this.Btn_Voltar.UseVisualStyleBackColor = false;
            this.Btn_Voltar.Click += new System.EventHandler(this.Btn_Voltar_Click);
            // 
            // Form_MenuAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(622, 457);
            this.Controls.Add(this.Btn_Sair);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.lbl_MostraErroAlunoNaoEncontrado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_SobrenomeAluno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_NotasCursosAnteriores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_NomeAluno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_NotasTodasMaterias);
            this.Controls.Add(this.btn_Notas1Materia);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_MenuAluno";
            this.Text = "Menu aluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Notas1Materia;
        private System.Windows.Forms.Button btn_NotasTodasMaterias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_NomeAluno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_NotasCursosAnteriores;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_SobrenomeAluno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_MostraErroAlunoNaoEncontrado;
        private System.Windows.Forms.Button Btn_Sair;
        private System.Windows.Forms.Button Btn_Voltar;
    }
}