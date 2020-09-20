namespace ProjetoBoletimAlunos.Forms.TelasProfessor
{
    partial class form_AdicionarNotas
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
            this.btn_AdicionarNota.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AdicionarNota.Location = new System.Drawing.Point(159, 340);
            this.btn_AdicionarNota.Name = "btn_AdicionarNota";
            this.btn_AdicionarNota.Size = new System.Drawing.Size(405, 42);
            this.btn_AdicionarNota.TabIndex = 0;
            this.btn_AdicionarNota.Text = "Adicionar Nota";
            this.btn_AdicionarNota.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(56, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(656, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Insira as Informaçãoes de TODOS os campos abaixo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(22, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(715, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Depois pressione o botão Adicionar Nota para confirmar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(99, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome do Aluno:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_NomeAluno
            // 
            this.txt_NomeAluno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_NomeAluno.Location = new System.Drawing.Point(99, 125);
            this.txt_NomeAluno.Name = "txt_NomeAluno";
            this.txt_NomeAluno.Size = new System.Drawing.Size(189, 34);
            this.txt_NomeAluno.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(444, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Matéria:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_MateriaAluno
            // 
            this.txt_MateriaAluno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_MateriaAluno.Location = new System.Drawing.Point(444, 125);
            this.txt_MateriaAluno.Name = "txt_MateriaAluno";
            this.txt_MateriaAluno.Size = new System.Drawing.Size(189, 34);
            this.txt_MateriaAluno.TabIndex = 3;
            this.txt_MateriaAluno.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_NotaAluno
            // 
            this.txt_NotaAluno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_NotaAluno.Location = new System.Drawing.Point(444, 219);
            this.txt_NotaAluno.Name = "txt_NotaAluno";
            this.txt_NotaAluno.Size = new System.Drawing.Size(189, 34);
            this.txt_NotaAluno.TabIndex = 3;
            this.txt_NotaAluno.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(444, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 28);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nota:";
            this.label5.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_SobrenomeAluno
            // 
            this.txt_SobrenomeAluno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_SobrenomeAluno.Location = new System.Drawing.Point(99, 219);
            this.txt_SobrenomeAluno.Name = "txt_SobrenomeAluno";
            this.txt_SobrenomeAluno.Size = new System.Drawing.Size(189, 34);
            this.txt_SobrenomeAluno.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(99, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 28);
            this.label6.TabIndex = 2;
            this.label6.Text = "Sobrenome do Aluno:";
            this.label6.Click += new System.EventHandler(this.label3_Click);
            // 
            // form_AdicionarNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(739, 402);
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
            this.Name = "form_AdicionarNotas";
            this.Text = "Adicionar Notas";
            this.Load += new System.EventHandler(this.form_AdicionarNotas_Load);
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