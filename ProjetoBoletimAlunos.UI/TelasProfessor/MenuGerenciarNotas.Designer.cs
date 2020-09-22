namespace ProjetoBoletimAlunos.UI.TelasProfessor
{
    partial class Form_MenuGerenciarNotas
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
            this.btn_AddNota = new System.Windows.Forms.Button();
            this.btn_AlterarOuExcluirNota = new System.Windows.Forms.Button();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(694, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Olá Professor, Escolha uma opção de gerenciamento de Notas:";
            // 
            // btn_AddNota
            // 
            this.btn_AddNota.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_AddNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddNota.Location = new System.Drawing.Point(83, 122);
            this.btn_AddNota.Name = "btn_AddNota";
            this.btn_AddNota.Size = new System.Drawing.Size(570, 61);
            this.btn_AddNota.TabIndex = 1;
            this.btn_AddNota.Text = "Adicionar Registro de Nota";
            this.btn_AddNota.UseVisualStyleBackColor = false;
            this.btn_AddNota.Click += new System.EventHandler(this.btn_AddNota_Click);
            // 
            // btn_AlterarOuExcluirNota
            // 
            this.btn_AlterarOuExcluirNota.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_AlterarOuExcluirNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AlterarOuExcluirNota.Location = new System.Drawing.Point(83, 225);
            this.btn_AlterarOuExcluirNota.Name = "btn_AlterarOuExcluirNota";
            this.btn_AlterarOuExcluirNota.Size = new System.Drawing.Size(570, 61);
            this.btn_AlterarOuExcluirNota.TabIndex = 2;
            this.btn_AlterarOuExcluirNota.Text = "Alterar ou Excluir Registro de Nota";
            this.btn_AlterarOuExcluirNota.UseVisualStyleBackColor = false;
            this.btn_AlterarOuExcluirNota.Click += new System.EventHandler(this.btn_AlterarOuExcluirNota_Click);
            // 
            // Btn_Voltar
            // 
            this.Btn_Voltar.BackColor = System.Drawing.Color.LightCoral;
            this.Btn_Voltar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Btn_Voltar.Location = new System.Drawing.Point(83, 353);
            this.Btn_Voltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Voltar.Name = "Btn_Voltar";
            this.Btn_Voltar.Size = new System.Drawing.Size(241, 38);
            this.Btn_Voltar.TabIndex = 6;
            this.Btn_Voltar.Text = "Voltar";
            this.Btn_Voltar.UseVisualStyleBackColor = false;
            this.Btn_Voltar.Click += new System.EventHandler(this.Btn_Voltar_Click);
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.BackColor = System.Drawing.Color.OrangeRed;
            this.Btn_Sair.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Btn_Sair.Location = new System.Drawing.Point(412, 353);
            this.Btn_Sair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.Size = new System.Drawing.Size(241, 38);
            this.Btn_Sair.TabIndex = 7;
            this.Btn_Sair.Text = "Sair do Sistema";
            this.Btn_Sair.UseVisualStyleBackColor = false;
            this.Btn_Sair.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_MenuGerenciarNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(728, 425);
            this.Controls.Add(this.Btn_Sair);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.btn_AlterarOuExcluirNota);
            this.Controls.Add(this.btn_AddNota);
            this.Controls.Add(this.label1);
            this.Name = "Form_MenuGerenciarNotas";
            this.Text = "Menu Gerenciar Notas - Professor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_AddNota;
        private System.Windows.Forms.Button btn_AlterarOuExcluirNota;
        private System.Windows.Forms.Button Btn_Voltar;
        private System.Windows.Forms.Button Btn_Sair;
    }
}