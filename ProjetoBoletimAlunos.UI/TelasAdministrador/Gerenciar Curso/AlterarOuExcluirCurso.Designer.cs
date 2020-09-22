namespace ProjetoBoletimAlunos.UI.TelasAdministrador.Gerenciar_Curso
{
    partial class Form_AlterarOuExcluirCurso
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
            this.txt_NomeCursoBusca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_SituacaoCursoBusca = new System.Windows.Forms.TextBox();
            this.txt_MateriaCursoBusca = new System.Windows.Forms.TextBox();
            this.btn_AlterarCurso = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_BuscarCurso = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_ExcluirCurso = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(31, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Curso:";
            // 
            // txt_NomeCursoBusca
            // 
            this.txt_NomeCursoBusca.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_NomeCursoBusca.Location = new System.Drawing.Point(31, 86);
            this.txt_NomeCursoBusca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_NomeCursoBusca.Name = "txt_NomeCursoBusca";
            this.txt_NomeCursoBusca.Size = new System.Drawing.Size(327, 34);
            this.txt_NomeCursoBusca.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(31, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Situação (Ativo ou Inativo):";
            // 
            // txt_SituacaoCursoBusca
            // 
            this.txt_SituacaoCursoBusca.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_SituacaoCursoBusca.Location = new System.Drawing.Point(31, 399);
            this.txt_SituacaoCursoBusca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SituacaoCursoBusca.Name = "txt_SituacaoCursoBusca";
            this.txt_SituacaoCursoBusca.Size = new System.Drawing.Size(327, 34);
            this.txt_SituacaoCursoBusca.TabIndex = 1;
            // 
            // txt_MateriaCursoBusca
            // 
            this.txt_MateriaCursoBusca.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_MateriaCursoBusca.Location = new System.Drawing.Point(31, 327);
            this.txt_MateriaCursoBusca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MateriaCursoBusca.Name = "txt_MateriaCursoBusca";
            this.txt_MateriaCursoBusca.Size = new System.Drawing.Size(327, 34);
            this.txt_MateriaCursoBusca.TabIndex = 1;
            // 
            // btn_AlterarCurso
            // 
            this.btn_AlterarCurso.BackColor = System.Drawing.Color.Gold;
            this.btn_AlterarCurso.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_AlterarCurso.Location = new System.Drawing.Point(465, 396);
            this.btn_AlterarCurso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AlterarCurso.Name = "btn_AlterarCurso";
            this.btn_AlterarCurso.Size = new System.Drawing.Size(327, 34);
            this.btn_AlterarCurso.TabIndex = 3;
            this.btn_AlterarCurso.Text = "Alterar Registro";
            this.btn_AlterarCurso.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(31, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Matéria:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(31, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(674, 38);
            this.label4.TabIndex = 0;
            this.label4.Text = "Insira o nome do Curso e pressione o botão BUSCAR:";
            // 
            // btn_BuscarCurso
            // 
            this.btn_BuscarCurso.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_BuscarCurso.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_BuscarCurso.Location = new System.Drawing.Point(465, 84);
            this.btn_BuscarCurso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_BuscarCurso.Name = "btn_BuscarCurso";
            this.btn_BuscarCurso.Size = new System.Drawing.Size(327, 34);
            this.btn_BuscarCurso.TabIndex = 3;
            this.btn_BuscarCurso.Text = "BUSCAR";
            this.btn_BuscarCurso.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(31, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(789, 38);
            this.label5.TabIndex = 0;
            this.label5.Text = "Os dados do Curso pesquisado aparecerão abaixo, para excluir";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(31, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(652, 38);
            this.label6.TabIndex = 0;
            this.label6.Text = "esse registro, pressione o botão de Excluir Registro.";
            // 
            // btn_ExcluirCurso
            // 
            this.btn_ExcluirCurso.BackColor = System.Drawing.Color.Tomato;
            this.btn_ExcluirCurso.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_ExcluirCurso.Location = new System.Drawing.Point(465, 324);
            this.btn_ExcluirCurso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ExcluirCurso.Name = "btn_ExcluirCurso";
            this.btn_ExcluirCurso.Size = new System.Drawing.Size(327, 34);
            this.btn_ExcluirCurso.TabIndex = 3;
            this.btn_ExcluirCurso.Text = "Excluir Registro";
            this.btn_ExcluirCurso.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(31, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(822, 38);
            this.label7.TabIndex = 0;
            this.label7.Text = "Caso deseje alterar as informações do Curso, altere qualquer um ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.label8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(31, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(806, 38);
            this.label8.TabIndex = 0;
            this.label8.Text = "dos três campos e depois pressione o botão de Alterar Registro.";
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.BackColor = System.Drawing.Color.OrangeRed;
            this.Btn_Sair.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Btn_Sair.Location = new System.Drawing.Point(517, 472);
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
            this.Btn_Voltar.Location = new System.Drawing.Point(75, 472);
            this.Btn_Voltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Voltar.Name = "Btn_Voltar";
            this.Btn_Voltar.Size = new System.Drawing.Size(241, 38);
            this.Btn_Voltar.TabIndex = 20;
            this.Btn_Voltar.Text = "Voltar";
            this.Btn_Voltar.UseVisualStyleBackColor = false;
            this.Btn_Voltar.Click += new System.EventHandler(this.Btn_Voltar_Click);
            // 
            // Form_AlterarOuExcluirCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(853, 521);
            this.Controls.Add(this.Btn_Sair);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_ExcluirCurso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_BuscarCurso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_AlterarCurso);
            this.Controls.Add(this.txt_MateriaCursoBusca);
            this.Controls.Add(this.txt_SituacaoCursoBusca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_NomeCursoBusca);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_AlterarOuExcluirCurso";
            this.Text = "Alterar ou Excluir Curso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_NomeCursoBusca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_SituacaoCursoBusca;
        private System.Windows.Forms.TextBox txt_MateriaCursoBusca;
        private System.Windows.Forms.Button btn_AlterarCurso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_BuscarCurso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_ExcluirCurso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Btn_Sair;
        private System.Windows.Forms.Button Btn_Voltar;
    }
}