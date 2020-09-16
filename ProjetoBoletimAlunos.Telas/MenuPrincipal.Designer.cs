namespace ProjetoBoletimAlunos.Telas
{
    partial class form_MenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.btn_AcessoAluno = new System.Windows.Forms.Button();
            this.btn_AcessoProfessor = new System.Windows.Forms.Button();
            this.btn_AcessoAdministrador = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(826, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Olá, Bem-Vindo ao sistema de boletins da Universidade Padawan!";
            // 
            // btn_AcessoAluno
            // 
            this.btn_AcessoAluno.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_AcessoAluno.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AcessoAluno.Location = new System.Drawing.Point(206, 106);
            this.btn_AcessoAluno.Name = "btn_AcessoAluno";
            this.btn_AcessoAluno.Size = new System.Drawing.Size(379, 61);
            this.btn_AcessoAluno.TabIndex = 3;
            this.btn_AcessoAluno.Text = "Aluno";
            this.btn_AcessoAluno.UseVisualStyleBackColor = false;
            // 
            // btn_AcessoProfessor
            // 
            this.btn_AcessoProfessor.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_AcessoProfessor.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AcessoProfessor.Location = new System.Drawing.Point(206, 219);
            this.btn_AcessoProfessor.Name = "btn_AcessoProfessor";
            this.btn_AcessoProfessor.Size = new System.Drawing.Size(379, 61);
            this.btn_AcessoProfessor.TabIndex = 3;
            this.btn_AcessoProfessor.Text = "Professor";
            this.btn_AcessoProfessor.UseVisualStyleBackColor = false;
            // 
            // btn_AcessoAdministrador
            // 
            this.btn_AcessoAdministrador.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_AcessoAdministrador.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AcessoAdministrador.Location = new System.Drawing.Point(206, 333);
            this.btn_AcessoAdministrador.Name = "btn_AcessoAdministrador";
            this.btn_AcessoAdministrador.Size = new System.Drawing.Size(379, 61);
            this.btn_AcessoAdministrador.TabIndex = 3;
            this.btn_AcessoAdministrador.Text = "Administrador";
            this.btn_AcessoAdministrador.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Escolha uma das opções abaixo:";
            // 
            // form_MenuPrincipal
            // 
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(834, 439);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_AcessoAdministrador);
            this.Controls.Add(this.btn_AcessoProfessor);
            this.Controls.Add(this.btn_AcessoAluno);
            this.Controls.Add(this.label2);
            this.Name = "form_MenuPrincipal";
            this.Text = "Sistema de Boletins Universidade Padawan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_AcessoAluno;
        private System.Windows.Forms.Button btn_AcessoProfessor;
        private System.Windows.Forms.Button btn_AcessoAdministrador;
        private System.Windows.Forms.Label label1;
    }
}

