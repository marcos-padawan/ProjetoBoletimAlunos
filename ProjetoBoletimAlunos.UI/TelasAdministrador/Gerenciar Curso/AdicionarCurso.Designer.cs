namespace ProjetoBoletimAlunos.UI.TelasAdministrador.Gerenciar_Curso
{
    partial class Form_AdicionarCurso
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
            this.btn_SalvarRegistroCurso = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MateriaCurso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_NomeCurso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Cmb_SituacaoCurso = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_SalvarRegistroCurso
            // 
            this.btn_SalvarRegistroCurso.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_SalvarRegistroCurso.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_SalvarRegistroCurso.Location = new System.Drawing.Point(37, 243);
            this.btn_SalvarRegistroCurso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_SalvarRegistroCurso.Name = "btn_SalvarRegistroCurso";
            this.btn_SalvarRegistroCurso.Size = new System.Drawing.Size(327, 34);
            this.btn_SalvarRegistroCurso.TabIndex = 3;
            this.btn_SalvarRegistroCurso.Text = "Salvar Novo Registro";
            this.btn_SalvarRegistroCurso.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(37, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matéria:";
            // 
            // txt_MateriaCurso
            // 
            this.txt_MateriaCurso.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_MateriaCurso.Location = new System.Drawing.Point(37, 118);
            this.txt_MateriaCurso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MateriaCurso.Name = "txt_MateriaCurso";
            this.txt_MateriaCurso.Size = new System.Drawing.Size(327, 34);
            this.txt_MateriaCurso.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(37, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Situação (Ativo ou Inativo):";
            // 
            // txt_NomeCurso
            // 
            this.txt_NomeCurso.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_NomeCurso.Location = new System.Drawing.Point(37, 52);
            this.txt_NomeCurso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_NomeCurso.Name = "txt_NomeCurso";
            this.txt_NomeCurso.Size = new System.Drawing.Size(327, 34);
            this.txt_NomeCurso.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(37, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nome do Curso:";
            // 
            // Cmb_SituacaoCurso
            // 
            this.Cmb_SituacaoCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_SituacaoCurso.FormattingEnabled = true;
            this.Cmb_SituacaoCurso.Location = new System.Drawing.Point(37, 195);
            this.Cmb_SituacaoCurso.Name = "Cmb_SituacaoCurso";
            this.Cmb_SituacaoCurso.Size = new System.Drawing.Size(327, 33);
            this.Cmb_SituacaoCurso.TabIndex = 4;
            // 
            // Form_AdicionarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(406, 298);
            this.Controls.Add(this.Cmb_SituacaoCurso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_NomeCurso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_MateriaCurso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_SalvarRegistroCurso);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_AdicionarCurso";
            this.Text = "Adicionar Curso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_SalvarRegistroCurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MateriaCurso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_NomeCurso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Cmb_SituacaoCurso;
    }
}