namespace ProjetoBoletimAlunos.UI.TelasProfessor
{
    partial class Form_AdicionarNotas
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
            this.btn_AdicionarNota = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_NomeAluno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_MateriaAluno = new System.Windows.Forms.TextBox();
            this.txt_NotaAluno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_SobrenomeAluno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_AdicionarNota
            // 
            this.btn_AdicionarNota.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_AdicionarNota.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_AdicionarNota.Location = new System.Drawing.Point(159, 272);
            this.btn_AdicionarNota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AdicionarNota.Name = "btn_AdicionarNota";
            this.btn_AdicionarNota.Size = new System.Drawing.Size(405, 34);
            this.btn_AdicionarNota.TabIndex = 0;
            this.btn_AdicionarNota.Text = "Adicionar Nota";
            this.btn_AdicionarNota.UseVisualStyleBackColor = false;
            this.btn_AdicionarNota.Click += new System.EventHandler(this.btn_AdicionarNota_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(56, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(656, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Insira as Informaçãoes de TODOS os campos abaixo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(22, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(715, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Depois pressione o botão Adicionar Nota para confirmar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(99, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome do Aluno:";
            // 
            // txt_NomeAluno
            // 
            this.txt_NomeAluno.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_NomeAluno.Location = new System.Drawing.Point(99, 100);
            this.txt_NomeAluno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_NomeAluno.Name = "txt_NomeAluno";
            this.txt_NomeAluno.Size = new System.Drawing.Size(189, 34);
            this.txt_NomeAluno.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(444, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Matéria:";
            // 
            // txt_MateriaAluno
            // 
            this.txt_MateriaAluno.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_MateriaAluno.Location = new System.Drawing.Point(444, 100);
            this.txt_MateriaAluno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MateriaAluno.Name = "txt_MateriaAluno";
            this.txt_MateriaAluno.Size = new System.Drawing.Size(189, 34);
            this.txt_MateriaAluno.TabIndex = 3;
            // 
            // txt_NotaAluno
            // 
            this.txt_NotaAluno.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_NotaAluno.Location = new System.Drawing.Point(444, 175);
            this.txt_NotaAluno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_NotaAluno.Name = "txt_NotaAluno";
            this.txt_NotaAluno.Size = new System.Drawing.Size(189, 34);
            this.txt_NotaAluno.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(444, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 28);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nota:";
            // 
            // txt_SobrenomeAluno
            // 
            this.txt_SobrenomeAluno.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_SobrenomeAluno.Location = new System.Drawing.Point(99, 175);
            this.txt_SobrenomeAluno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SobrenomeAluno.Name = "txt_SobrenomeAluno";
            this.txt_SobrenomeAluno.Size = new System.Drawing.Size(189, 34);
            this.txt_SobrenomeAluno.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(99, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 28);
            this.label6.TabIndex = 2;
            this.label6.Text = "Sobrenome do Aluno:";
            // 
            // Form_AdicionarNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(739, 322);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_SobrenomeAluno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_NotaAluno);
            this.Controls.Add(this.txt_MateriaAluno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_NomeAluno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_AdicionarNota);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_AdicionarNotas";
            this.Text = "Adicionar Notas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AdicionarNota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_NomeAluno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_MateriaAluno;
        private System.Windows.Forms.TextBox txt_NotaAluno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_SobrenomeAluno;
        private System.Windows.Forms.Label label6;
    }
}