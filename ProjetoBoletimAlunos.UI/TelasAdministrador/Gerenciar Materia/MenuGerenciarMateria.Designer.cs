namespace ProjetoBoletimAlunos.UI.TelasAdministrador.Gerenciar_Materia
{
    partial class Form_MenuGerenciarMateria
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
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_AlterarExcluirMateria
            // 
            this.btn_AlterarExcluirMateria.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_AlterarExcluirMateria.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.btn_AlterarExcluirMateria.Location = new System.Drawing.Point(117, 196);
            this.btn_AlterarExcluirMateria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AlterarExcluirMateria.Name = "btn_AlterarExcluirMateria";
            this.btn_AlterarExcluirMateria.Size = new System.Drawing.Size(473, 60);
            this.btn_AlterarExcluirMateria.TabIndex = 1;
            this.btn_AlterarExcluirMateria.Text = "Alterar ou Excluir Matéria Existente";
            this.btn_AlterarExcluirMateria.UseVisualStyleBackColor = false;
            this.btn_AlterarExcluirMateria.Click += new System.EventHandler(this.btn_AlterarExcluirMateria_Click);
            // 
            // btn_AddMateria
            // 
            this.btn_AddMateria.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_AddMateria.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.btn_AddMateria.Location = new System.Drawing.Point(117, 96);
            this.btn_AddMateria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddMateria.Name = "btn_AddMateria";
            this.btn_AddMateria.Size = new System.Drawing.Size(473, 60);
            this.btn_AddMateria.TabIndex = 1;
            this.btn_AddMateria.Text = "Adicionar Nova Matéria";
            this.btn_AddMateria.UseVisualStyleBackColor = false;
            this.btn_AddMateria.Click += new System.EventHandler(this.btn_AddMateria_Click);
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
            this.Btn_Sair.Location = new System.Drawing.Point(393, 295);
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
            this.Btn_Voltar.Location = new System.Drawing.Point(67, 295);
            this.Btn_Voltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Voltar.Name = "Btn_Voltar";
            this.Btn_Voltar.Size = new System.Drawing.Size(241, 38);
            this.Btn_Voltar.TabIndex = 14;
            this.Btn_Voltar.Text = "Voltar";
            this.Btn_Voltar.UseVisualStyleBackColor = false;
            this.Btn_Voltar.Click += new System.EventHandler(this.Btn_Voltar_Click);
            // 
            // Form_MenuGerenciarMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(722, 353);
            this.Controls.Add(this.Btn_Sair);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_AddMateria);
            this.Controls.Add(this.btn_AlterarExcluirMateria);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_MenuGerenciarMateria";
            this.Text = "Gerenciar Matéria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_AlterarExcluirMateria;
        private System.Windows.Forms.Button btn_AddMateria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Sair;
        private System.Windows.Forms.Button Btn_Voltar;
    }
}