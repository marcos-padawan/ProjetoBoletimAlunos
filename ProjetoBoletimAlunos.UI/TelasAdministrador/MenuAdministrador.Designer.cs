namespace ProjetoBoletimAlunos.UI.TelasAdministrador
{
    partial class Form_MenuAdministrador
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
            this.btn_GerenciarAlunos = new System.Windows.Forms.Button();
            this.btn_GerenciarMaterias = new System.Windows.Forms.Button();
            this.btn_GerenciarCursos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_GerenciarAlunos
            // 
            this.btn_GerenciarAlunos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_GerenciarAlunos.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_GerenciarAlunos.Location = new System.Drawing.Point(186, 103);
            this.btn_GerenciarAlunos.Name = "btn_GerenciarAlunos";
            this.btn_GerenciarAlunos.Size = new System.Drawing.Size(364, 48);
            this.btn_GerenciarAlunos.TabIndex = 0;
            this.btn_GerenciarAlunos.Text = "Gerenciar Alunos";
            this.btn_GerenciarAlunos.UseVisualStyleBackColor = false;
            this.btn_GerenciarAlunos.Click += new System.EventHandler(this.btn_GerenciarAlunos_Click);
            // 
            // btn_GerenciarMaterias
            // 
            this.btn_GerenciarMaterias.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_GerenciarMaterias.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_GerenciarMaterias.Location = new System.Drawing.Point(186, 189);
            this.btn_GerenciarMaterias.Name = "btn_GerenciarMaterias";
            this.btn_GerenciarMaterias.Size = new System.Drawing.Size(364, 48);
            this.btn_GerenciarMaterias.TabIndex = 0;
            this.btn_GerenciarMaterias.Text = "Gerenciar Matérias";
            this.btn_GerenciarMaterias.UseVisualStyleBackColor = false;
            this.btn_GerenciarMaterias.Click += new System.EventHandler(this.btn_GerenciarMaterias_Click);
            // 
            // btn_GerenciarCursos
            // 
            this.btn_GerenciarCursos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_GerenciarCursos.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_GerenciarCursos.Location = new System.Drawing.Point(186, 275);
            this.btn_GerenciarCursos.Name = "btn_GerenciarCursos";
            this.btn_GerenciarCursos.Size = new System.Drawing.Size(364, 48);
            this.btn_GerenciarCursos.TabIndex = 0;
            this.btn_GerenciarCursos.Text = "Gerenciar Cursos";
            this.btn_GerenciarCursos.UseVisualStyleBackColor = false;
            this.btn_GerenciarCursos.Click += new System.EventHandler(this.btn_GerenciarCursos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(30, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(687, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Olá Administrador, escolha uma das opções de gerenciamento:";
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.BackColor = System.Drawing.Color.OrangeRed;
            this.Btn_Sair.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Btn_Sair.Location = new System.Drawing.Point(405, 367);
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
            this.Btn_Voltar.Location = new System.Drawing.Point(79, 367);
            this.Btn_Voltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Voltar.Name = "Btn_Voltar";
            this.Btn_Voltar.Size = new System.Drawing.Size(241, 38);
            this.Btn_Voltar.TabIndex = 14;
            this.Btn_Voltar.Text = "Voltar";
            this.Btn_Voltar.UseVisualStyleBackColor = false;
            this.Btn_Voltar.Click += new System.EventHandler(this.Btn_Voltar_Click);
            // 
            // Form_MenuAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(746, 438);
            this.Controls.Add(this.Btn_Sair);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_GerenciarCursos);
            this.Controls.Add(this.btn_GerenciarMaterias);
            this.Controls.Add(this.btn_GerenciarAlunos);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "Form_MenuAdministrador";
            this.Text = "Menu Administrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_GerenciarAlunos;
        private System.Windows.Forms.Button btn_GerenciarMaterias;
        private System.Windows.Forms.Button btn_GerenciarCursos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Sair;
        private System.Windows.Forms.Button Btn_Voltar;
    }
}