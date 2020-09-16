namespace ProjetoBoletimAlunos.Telas.TelasAluno
{
    partial class TelaNotasTodasMaterias
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
            this.txt_ListaNotasAtivas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ListaMateriasAtivas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_VoltaMenuAluno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(473, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Notas";
            // 
            // txt_ListaNotasAtivas
            // 
            this.txt_ListaNotasAtivas.Location = new System.Drawing.Point(379, 107);
            this.txt_ListaNotasAtivas.Multiline = true;
            this.txt_ListaNotasAtivas.Name = "txt_ListaNotasAtivas";
            this.txt_ListaNotasAtivas.Size = new System.Drawing.Size(258, 344);
            this.txt_ListaNotasAtivas.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(106, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Matérias";
            // 
            // txt_ListaMateriasAtivas
            // 
            this.txt_ListaMateriasAtivas.Location = new System.Drawing.Point(24, 107);
            this.txt_ListaMateriasAtivas.Multiline = true;
            this.txt_ListaMateriasAtivas.Name = "txt_ListaMateriasAtivas";
            this.txt_ListaMateriasAtivas.Size = new System.Drawing.Size(258, 344);
            this.txt_ListaMateriasAtivas.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(12, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(639, 31);
            this.label4.TabIndex = 1;
            this.label4.Text = "{nomeDoAluno} suas notas no curso {nomeDoCursoAtivo}são:";
            // 
            // btn_VoltaMenuAluno
            // 
            this.btn_VoltaMenuAluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_VoltaMenuAluno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_VoltaMenuAluno.Location = new System.Drawing.Point(185, 502);
            this.btn_VoltaMenuAluno.Name = "btn_VoltaMenuAluno";
            this.btn_VoltaMenuAluno.Size = new System.Drawing.Size(288, 63);
            this.btn_VoltaMenuAluno.TabIndex = 0;
            this.btn_VoltaMenuAluno.Text = "Voltar ao Menu de Aluno";
            this.btn_VoltaMenuAluno.UseVisualStyleBackColor = false;
            // 
            // MenuNotasTodasMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(663, 577);
            this.Controls.Add(this.btn_VoltaMenuAluno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_ListaMateriasAtivas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ListaNotasAtivas);
            this.Controls.Add(this.label1);
            this.Name = "MenuNotasTodasMaterias";
            this.Text = "Boletim Curso Ativo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ListaNotasAtivas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ListaMateriasAtivas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_VoltaMenuAluno;
    }
}