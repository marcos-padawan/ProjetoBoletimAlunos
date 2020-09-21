namespace ProjetoBoletimAlunos.UI.TelasAdministrador.Gerenciar_Materia
{
    partial class Form_AdicionarMateria
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
            this.txt_NomeMateria = new System.Windows.Forms.TextBox();
            this.txt_SituacaoMateria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_SalvarNovaMateria = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_DataCadastroMateria = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(37, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome da Matéria:";
            // 
            // txt_NomeMateria
            // 
            this.txt_NomeMateria.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_NomeMateria.Location = new System.Drawing.Point(37, 50);
            this.txt_NomeMateria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_NomeMateria.Name = "txt_NomeMateria";
            this.txt_NomeMateria.Size = new System.Drawing.Size(327, 34);
            this.txt_NomeMateria.TabIndex = 1;
            // 
            // txt_SituacaoMateria
            // 
            this.txt_SituacaoMateria.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_SituacaoMateria.Location = new System.Drawing.Point(38, 122);
            this.txt_SituacaoMateria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SituacaoMateria.Name = "txt_SituacaoMateria";
            this.txt_SituacaoMateria.Size = new System.Drawing.Size(327, 34);
            this.txt_SituacaoMateria.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(38, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Situação (Ativo ou Inativo):";
            // 
            // btn_SalvarNovaMateria
            // 
            this.btn_SalvarNovaMateria.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_SalvarNovaMateria.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_SalvarNovaMateria.Location = new System.Drawing.Point(37, 206);
            this.btn_SalvarNovaMateria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_SalvarNovaMateria.Name = "btn_SalvarNovaMateria";
            this.btn_SalvarNovaMateria.Size = new System.Drawing.Size(328, 34);
            this.btn_SalvarNovaMateria.TabIndex = 3;
            this.btn_SalvarNovaMateria.Text = "Salvar Novo Registro";
            this.btn_SalvarNovaMateria.UseVisualStyleBackColor = false;
            this.btn_SalvarNovaMateria.Click += new System.EventHandler(this.btn_SalvarNovaMateria_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(484, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Data de Cadastro:";
            // 
            // txt_DataCadastroMateria
            // 
            this.txt_DataCadastroMateria.Location = new System.Drawing.Point(484, 50);
            this.txt_DataCadastroMateria.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txt_DataCadastroMateria.Name = "txt_DataCadastroMateria";
            this.txt_DataCadastroMateria.TabIndex = 2;
            // 
            // Form_AdicionarMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(835, 267);
            this.Controls.Add(this.txt_DataCadastroMateria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_SalvarNovaMateria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_SituacaoMateria);
            this.Controls.Add(this.txt_NomeMateria);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_AdicionarMateria";
            this.Text = "Adicionar Matéria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_NomeMateria;
        private System.Windows.Forms.TextBox txt_SituacaoMateria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_SalvarNovaMateria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar txt_DataCadastroMateria;
    }
}