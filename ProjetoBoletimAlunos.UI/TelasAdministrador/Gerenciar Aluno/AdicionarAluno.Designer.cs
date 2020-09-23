namespace ProjetoBoletimAlunos.UI.TelasAdministrador.Gerenciar_Aluno
{
    partial class Form_AdicionarAluno
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
            this.txt_NomeAluno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_SobrenomeAluno = new System.Windows.Forms.TextBox();
            this.txt_CpfAluno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_NascimentoAluno = new System.Windows.Forms.MonthCalendar();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_SalvarRegistroAluno = new System.Windows.Forms.Button();
            this.Cmb_Cursos = new System.Windows.Forms.ComboBox();
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(58, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txt_NomeAluno
            // 
            this.txt_NomeAluno.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_NomeAluno.Location = new System.Drawing.Point(58, 62);
            this.txt_NomeAluno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_NomeAluno.Name = "txt_NomeAluno";
            this.txt_NomeAluno.Size = new System.Drawing.Size(221, 34);
            this.txt_NomeAluno.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(350, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sobrenome:";
            // 
            // txt_SobrenomeAluno
            // 
            this.txt_SobrenomeAluno.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_SobrenomeAluno.Location = new System.Drawing.Point(350, 62);
            this.txt_SobrenomeAluno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SobrenomeAluno.Name = "txt_SobrenomeAluno";
            this.txt_SobrenomeAluno.Size = new System.Drawing.Size(222, 34);
            this.txt_SobrenomeAluno.TabIndex = 1;
            // 
            // txt_CpfAluno
            // 
            this.txt_CpfAluno.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_CpfAluno.Location = new System.Drawing.Point(350, 151);
            this.txt_CpfAluno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_CpfAluno.Name = "txt_CpfAluno";
            this.txt_CpfAluno.Size = new System.Drawing.Size(222, 34);
            this.txt_CpfAluno.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(350, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "CPF (somente números):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(58, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Curso:";
            // 
            // txt_NascimentoAluno
            // 
            this.txt_NascimentoAluno.Location = new System.Drawing.Point(680, 74);
            this.txt_NascimentoAluno.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txt_NascimentoAluno.MaxDate = new System.DateTime(2001, 12, 31, 0, 0, 0, 0);
            this.txt_NascimentoAluno.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.txt_NascimentoAluno.Name = "txt_NascimentoAluno";
            this.txt_NascimentoAluno.ShowToday = false;
            this.txt_NascimentoAluno.ShowTodayCircle = false;
            this.txt_NascimentoAluno.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(715, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Data de Nascimento:";
            // 
            // btn_SalvarRegistroAluno
            // 
            this.btn_SalvarRegistroAluno.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_SalvarRegistroAluno.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_SalvarRegistroAluno.Location = new System.Drawing.Point(58, 213);
            this.btn_SalvarRegistroAluno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_SalvarRegistroAluno.Name = "btn_SalvarRegistroAluno";
            this.btn_SalvarRegistroAluno.Size = new System.Drawing.Size(514, 34);
            this.btn_SalvarRegistroAluno.TabIndex = 3;
            this.btn_SalvarRegistroAluno.Text = "Salvar Novo Registro";
            this.btn_SalvarRegistroAluno.UseVisualStyleBackColor = false;
            this.btn_SalvarRegistroAluno.Click += new System.EventHandler(this.btn_SalvarRegistroAluno_Click);
            // 
            // Cmb_Cursos
            // 
            this.Cmb_Cursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Cursos.FormattingEnabled = true;
            this.Cmb_Cursos.Location = new System.Drawing.Point(58, 154);
            this.Cmb_Cursos.Name = "Cmb_Cursos";
            this.Cmb_Cursos.Size = new System.Drawing.Size(221, 33);
            this.Cmb_Cursos.TabIndex = 4;
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.BackColor = System.Drawing.Color.OrangeRed;
            this.Btn_Sair.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Btn_Sair.Location = new System.Drawing.Point(331, 266);
            this.Btn_Sair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.Size = new System.Drawing.Size(241, 38);
            this.Btn_Sair.TabIndex = 21;
            this.Btn_Sair.Text = "Sair do Sistema";
            this.Btn_Sair.UseVisualStyleBackColor = false;
            this.Btn_Sair.Click += new System.EventHandler(this.Btn_Sair_Click);
            // 
            // Btn_Voltar
            // 
            this.Btn_Voltar.BackColor = System.Drawing.Color.LightCoral;
            this.Btn_Voltar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Btn_Voltar.Location = new System.Drawing.Point(58, 266);
            this.Btn_Voltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Voltar.Name = "Btn_Voltar";
            this.Btn_Voltar.Size = new System.Drawing.Size(241, 38);
            this.Btn_Voltar.TabIndex = 20;
            this.Btn_Voltar.Text = "Voltar";
            this.Btn_Voltar.UseVisualStyleBackColor = false;
            this.Btn_Voltar.Click += new System.EventHandler(this.Btn_Voltar_Click);
            // 
            // Form_AdicionarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1053, 371);
            this.Controls.Add(this.Btn_Sair);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.Cmb_Cursos);
            this.Controls.Add(this.btn_SalvarRegistroAluno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_NascimentoAluno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_CpfAluno);
            this.Controls.Add(this.txt_SobrenomeAluno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_NomeAluno);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_AdicionarAluno";
            this.Text = "Adicionar Aluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_NomeAluno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_SobrenomeAluno;
        private System.Windows.Forms.TextBox txt_CpfAluno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar txt_NascimentoAluno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_SalvarRegistroAluno;
        private System.Windows.Forms.ComboBox Cmb_Cursos;
        private System.Windows.Forms.Button Btn_Sair;
        private System.Windows.Forms.Button Btn_Voltar;
    }
}