namespace ProjetoBoletimAlunos.UI.TelasAdministrador.Gerenciar_Aluno
{
    partial class Form_AlterarOuExcluirAluno
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
            this.txt_NomeAlunoBuscar = new System.Windows.Forms.TextBox();
            this.btn_BuscarAluno = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_SobrenomeAlunoBuscar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_CpfAlunoBuscar = new System.Windows.Forms.TextBox();
            this.btn_ExcluirAluno = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_NascimentoAlunoBuscar = new System.Windows.Forms.TextBox();
            this.btn_AlterarAluno = new System.Windows.Forms.Button();
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.txt_NovoNome = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_NovoSobrenome = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(855, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insira o Nome e Sobrenome do Aluno e pressione o botão BUSCAR:";
            // 
            // txt_NomeAlunoBuscar
            // 
            this.txt_NomeAlunoBuscar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_NomeAlunoBuscar.Location = new System.Drawing.Point(20, 88);
            this.txt_NomeAlunoBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_NomeAlunoBuscar.Name = "txt_NomeAlunoBuscar";
            this.txt_NomeAlunoBuscar.Size = new System.Drawing.Size(197, 34);
            this.txt_NomeAlunoBuscar.TabIndex = 1;
            // 
            // btn_BuscarAluno
            // 
            this.btn_BuscarAluno.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_BuscarAluno.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.btn_BuscarAluno.Location = new System.Drawing.Point(577, 71);
            this.btn_BuscarAluno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_BuscarAluno.Name = "btn_BuscarAluno";
            this.btn_BuscarAluno.Size = new System.Drawing.Size(262, 52);
            this.btn_BuscarAluno.TabIndex = 2;
            this.btn_BuscarAluno.Text = "BUSCAR";
            this.btn_BuscarAluno.UseVisualStyleBackColor = false;
            this.btn_BuscarAluno.Click += new System.EventHandler(this.btn_BuscarAluno_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(20, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome do Aluno:";
            // 
            // txt_SobrenomeAlunoBuscar
            // 
            this.txt_SobrenomeAlunoBuscar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_SobrenomeAlunoBuscar.Location = new System.Drawing.Point(297, 88);
            this.txt_SobrenomeAlunoBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SobrenomeAlunoBuscar.Name = "txt_SobrenomeAlunoBuscar";
            this.txt_SobrenomeAlunoBuscar.Size = new System.Drawing.Size(197, 34);
            this.txt_SobrenomeAlunoBuscar.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(297, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sobrenome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(20, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(791, 38);
            this.label4.TabIndex = 0;
            this.label4.Text = "Os dados do Aluno pesquisado aparecerão abaixo, para excluir";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(20, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(652, 38);
            this.label6.TabIndex = 4;
            this.label6.Text = "esse registro, pressione o botão de Excluir Registro.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(20, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(860, 38);
            this.label5.TabIndex = 0;
            this.label5.Text = "Caso deseje alterar as informações do Aluno, altere quantos campos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(20, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(810, 38);
            this.label7.TabIndex = 4;
            this.label7.Text = "achar necessário e depois pressione o botão de Alterar Registro.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(20, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(222, 28);
            this.label8.TabIndex = 0;
            this.label8.Text = "CPF (somente números):";
            // 
            // txt_CpfAlunoBuscar
            // 
            this.txt_CpfAlunoBuscar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_CpfAlunoBuscar.Location = new System.Drawing.Point(20, 344);
            this.txt_CpfAlunoBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_CpfAlunoBuscar.Name = "txt_CpfAlunoBuscar";
            this.txt_CpfAlunoBuscar.Size = new System.Drawing.Size(304, 34);
            this.txt_CpfAlunoBuscar.TabIndex = 1;
            // 
            // btn_ExcluirAluno
            // 
            this.btn_ExcluirAluno.BackColor = System.Drawing.Color.Tomato;
            this.btn_ExcluirAluno.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.btn_ExcluirAluno.Location = new System.Drawing.Point(465, 353);
            this.btn_ExcluirAluno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ExcluirAluno.Name = "btn_ExcluirAluno";
            this.btn_ExcluirAluno.Size = new System.Drawing.Size(365, 63);
            this.btn_ExcluirAluno.TabIndex = 2;
            this.btn_ExcluirAluno.Text = "Excluir Registro";
            this.btn_ExcluirAluno.UseVisualStyleBackColor = false;
            this.btn_ExcluirAluno.Click += new System.EventHandler(this.btn_ExcluirAluno_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label11.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label11.Location = new System.Drawing.Point(20, 391);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(193, 28);
            this.label11.TabIndex = 0;
            this.label11.Text = "Data de Nascimento:";
            // 
            // txt_NascimentoAlunoBuscar
            // 
            this.txt_NascimentoAlunoBuscar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_NascimentoAlunoBuscar.Location = new System.Drawing.Point(20, 421);
            this.txt_NascimentoAlunoBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_NascimentoAlunoBuscar.Name = "txt_NascimentoAlunoBuscar";
            this.txt_NascimentoAlunoBuscar.Size = new System.Drawing.Size(304, 34);
            this.txt_NascimentoAlunoBuscar.TabIndex = 1;
            // 
            // btn_AlterarAluno
            // 
            this.btn_AlterarAluno.BackColor = System.Drawing.Color.Gold;
            this.btn_AlterarAluno.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.btn_AlterarAluno.Location = new System.Drawing.Point(465, 452);
            this.btn_AlterarAluno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AlterarAluno.Name = "btn_AlterarAluno";
            this.btn_AlterarAluno.Size = new System.Drawing.Size(365, 61);
            this.btn_AlterarAluno.TabIndex = 2;
            this.btn_AlterarAluno.Text = "Alterar Registro";
            this.btn_AlterarAluno.UseVisualStyleBackColor = false;
            this.btn_AlterarAluno.Click += new System.EventHandler(this.btn_AlterarAluno_Click);
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.BackColor = System.Drawing.Color.OrangeRed;
            this.Btn_Sair.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Btn_Sair.Location = new System.Drawing.Point(386, 580);
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
            this.Btn_Voltar.Location = new System.Drawing.Point(656, 580);
            this.Btn_Voltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Voltar.Name = "Btn_Voltar";
            this.Btn_Voltar.Size = new System.Drawing.Size(241, 38);
            this.Btn_Voltar.TabIndex = 18;
            this.Btn_Voltar.Text = "Voltar";
            this.Btn_Voltar.UseVisualStyleBackColor = false;
            this.Btn_Voltar.Click += new System.EventHandler(this.Btn_Voltar_Click);
            // 
            // txt_NovoNome
            // 
            this.txt_NovoNome.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_NovoNome.Location = new System.Drawing.Point(20, 501);
            this.txt_NovoNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_NovoNome.Name = "txt_NovoNome";
            this.txt_NovoNome.Size = new System.Drawing.Size(304, 34);
            this.txt_NovoNome.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label10.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label10.Location = new System.Drawing.Point(20, 471);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 28);
            this.label10.TabIndex = 20;
            this.label10.Text = "Novo Nome:";
            // 
            // txt_NovoSobrenome
            // 
            this.txt_NovoSobrenome.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_NovoSobrenome.Location = new System.Drawing.Point(20, 574);
            this.txt_NovoSobrenome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_NovoSobrenome.Name = "txt_NovoSobrenome";
            this.txt_NovoSobrenome.Size = new System.Drawing.Size(304, 34);
            this.txt_NovoSobrenome.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label12.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label12.Location = new System.Drawing.Point(20, 544);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(172, 28);
            this.label12.TabIndex = 22;
            this.label12.Text = "Novo Sobrenome:";
            // 
            // Form_AlterarOuExcluirAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(957, 645);
            this.Controls.Add(this.txt_NovoSobrenome);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_NovoNome);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Btn_Sair);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.btn_AlterarAluno);
            this.Controls.Add(this.txt_NascimentoAlunoBuscar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_ExcluirAluno);
            this.Controls.Add(this.txt_CpfAlunoBuscar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_SobrenomeAlunoBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_BuscarAluno);
            this.Controls.Add(this.txt_NomeAlunoBuscar);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_AlterarOuExcluirAluno";
            this.Text = "Alterar ou Excluir Aluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_NomeAlunoBuscar;
        private System.Windows.Forms.Button btn_BuscarAluno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_SobrenomeAlunoBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_CpfAlunoBuscar;
        private System.Windows.Forms.Button btn_ExcluirAluno;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_NascimentoAlunoBuscar;
        private System.Windows.Forms.Button btn_AlterarAluno;
        private System.Windows.Forms.Button Btn_Sair;
        private System.Windows.Forms.Button Btn_Voltar;
        private System.Windows.Forms.TextBox txt_NovoNome;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_NovoSobrenome;
        private System.Windows.Forms.Label label12;
    }
}