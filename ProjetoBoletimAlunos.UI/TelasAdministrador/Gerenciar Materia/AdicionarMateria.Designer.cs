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
            this.label3 = new System.Windows.Forms.Label();
            this.btn_SalvarNovaMateria = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_DataCadastroMateria = new System.Windows.Forms.MonthCalendar();
            this.Cmb_SituacaoMateria = new System.Windows.Forms.ComboBox();
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.Btn_Voltar = new System.Windows.Forms.Button();
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(38, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Situação:";
            // 
            // btn_SalvarNovaMateria
            // 
            this.btn_SalvarNovaMateria.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_SalvarNovaMateria.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_SalvarNovaMateria.Location = new System.Drawing.Point(37, 196);
            this.btn_SalvarNovaMateria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_SalvarNovaMateria.Name = "btn_SalvarNovaMateria";
            this.btn_SalvarNovaMateria.Size = new System.Drawing.Size(328, 44);
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
            this.txt_DataCadastroMateria.MaxDate = new System.DateTime(2020, 11, 29, 0, 0, 0, 0);
            this.txt_DataCadastroMateria.MaxSelectionCount = 1;
            this.txt_DataCadastroMateria.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.txt_DataCadastroMateria.Name = "txt_DataCadastroMateria";
            this.txt_DataCadastroMateria.TabIndex = 2;
            // 
            // Cmb_SituacaoMateria
            // 
            this.Cmb_SituacaoMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_SituacaoMateria.FormattingEnabled = true;
            this.Cmb_SituacaoMateria.Location = new System.Drawing.Point(37, 131);
            this.Cmb_SituacaoMateria.Name = "Cmb_SituacaoMateria";
            this.Cmb_SituacaoMateria.Size = new System.Drawing.Size(327, 33);
            this.Cmb_SituacaoMateria.TabIndex = 4;
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.BackColor = System.Drawing.Color.OrangeRed;
            this.Btn_Sair.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Btn_Sair.Location = new System.Drawing.Point(500, 285);
            this.Btn_Sair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.Size = new System.Drawing.Size(241, 38);
            this.Btn_Sair.TabIndex = 19;
            this.Btn_Sair.Text = "Sair do Sistema";
            this.Btn_Sair.UseVisualStyleBackColor = false;
            this.Btn_Sair.Click += new System.EventHandler(this.Btn_Sair_Click);
            // 
            // Btn_Voltar
            // 
            this.Btn_Voltar.BackColor = System.Drawing.Color.LightCoral;
            this.Btn_Voltar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Btn_Voltar.Location = new System.Drawing.Point(81, 285);
            this.Btn_Voltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Voltar.Name = "Btn_Voltar";
            this.Btn_Voltar.Size = new System.Drawing.Size(241, 38);
            this.Btn_Voltar.TabIndex = 18;
            this.Btn_Voltar.Text = "Voltar";
            this.Btn_Voltar.UseVisualStyleBackColor = false;
            this.Btn_Voltar.Click += new System.EventHandler(this.Btn_Voltar_Click);
            // 
            // Form_AdicionarMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(950, 421);
            this.Controls.Add(this.Btn_Sair);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.Cmb_SituacaoMateria);
            this.Controls.Add(this.txt_DataCadastroMateria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_SalvarNovaMateria);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_SalvarNovaMateria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar txt_DataCadastroMateria;
        private System.Windows.Forms.ComboBox Cmb_SituacaoMateria;
        private System.Windows.Forms.Button Btn_Sair;
        private System.Windows.Forms.Button Btn_Voltar;
    }
}