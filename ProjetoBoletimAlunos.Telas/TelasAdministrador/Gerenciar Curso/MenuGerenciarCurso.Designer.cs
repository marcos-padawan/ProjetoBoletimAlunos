namespace ProjetoBoletimAlunos.Telas.TelasAdministrador
{
    partial class form_MenuGerenciarCurso
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
            this.btn_VoltarMenuAdm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(93, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Qual operação você deseja realizar?";
            // 
            // btn_AddCurso
            // 
            this.btn_AddCurso.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_AddCurso.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AddCurso.Location = new System.Drawing.Point(110, 109);
            this.btn_AddCurso.Name = "btn_AddCurso";
            this.btn_AddCurso.Size = new System.Drawing.Size(442, 75);
            this.btn_AddCurso.TabIndex = 1;
            this.btn_AddCurso.Text = "Adicionar Novo Curso";
            this.btn_AddCurso.UseVisualStyleBackColor = false;
            // 
            // btn_AlterarExcluirCurso
            // 
            this.btn_AlterarExcluirCurso.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_AlterarExcluirCurso.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AlterarExcluirCurso.Location = new System.Drawing.Point(110, 234);
            this.btn_AlterarExcluirCurso.Name = "btn_AlterarExcluirCurso";
            this.btn_AlterarExcluirCurso.Size = new System.Drawing.Size(442, 75);
            this.btn_AlterarExcluirCurso.TabIndex = 1;
            this.btn_AlterarExcluirCurso.Text = "Alterar ou Excluir Curso Existente";
            this.btn_AlterarExcluirCurso.UseVisualStyleBackColor = false;
            // 
            // btn_VoltarMenuAdm
            // 
            this.btn_VoltarMenuAdm.BackColor = System.Drawing.Color.LightCoral;
            this.btn_VoltarMenuAdm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_VoltarMenuAdm.Location = new System.Drawing.Point(526, 363);
            this.btn_VoltarMenuAdm.Name = "btn_VoltarMenuAdm";
            this.btn_VoltarMenuAdm.Size = new System.Drawing.Size(167, 39);
            this.btn_VoltarMenuAdm.TabIndex = 2;
            this.btn_VoltarMenuAdm.Text = "Voltar";
            this.btn_VoltarMenuAdm.UseVisualStyleBackColor = false;
            // 
            // form_MenuGerenciarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(717, 425);
            this.Controls.Add(this.btn_VoltarMenuAdm);
            this.Controls.Add(this.btn_AlterarExcluirCurso);
            this.Controls.Add(this.btn_AddCurso);
            this.Controls.Add(this.label1);
            this.Name = "form_MenuGerenciarCurso";
            this.Text = "Gerenciar Curso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_AddCurso;
        private System.Windows.Forms.Button btn_AlterarExcluirCurso;
        private System.Windows.Forms.Button btn_VoltarMenuAdm;
    }
}