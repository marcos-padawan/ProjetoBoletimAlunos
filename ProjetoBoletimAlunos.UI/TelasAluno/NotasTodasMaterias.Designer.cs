namespace ProjetoBoletimAlunos.UI.TelasAluno
{
    partial class Form_NotasTodasMaterias
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(473, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Notas";
            // 
            // txt_ListaNotasAtivas
            // 
            this.txt_ListaNotasAtivas.Location = new System.Drawing.Point(379, 86);
            this.txt_ListaNotasAtivas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ListaNotasAtivas.Multiline = true;
            this.txt_ListaNotasAtivas.Name = "txt_ListaNotasAtivas";
            this.txt_ListaNotasAtivas.Size = new System.Drawing.Size(258, 276);
            this.txt_ListaNotasAtivas.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(106, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Matérias";
            // 
            // txt_ListaMateriasAtivas
            // 
            this.txt_ListaMateriasAtivas.Location = new System.Drawing.Point(24, 86);
            this.txt_ListaMateriasAtivas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ListaMateriasAtivas.Multiline = true;
            this.txt_ListaMateriasAtivas.Name = "txt_ListaMateriasAtivas";
            this.txt_ListaMateriasAtivas.Size = new System.Drawing.Size(258, 276);
            this.txt_ListaMateriasAtivas.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(12, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(673, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "{nomeDoAluno} suas notas no curso {nomeDoCursoAtivo}são:";
            // 
            // Form_NotasTodasMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(705, 387);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_ListaMateriasAtivas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ListaNotasAtivas);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_NotasTodasMaterias";
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
    }
}