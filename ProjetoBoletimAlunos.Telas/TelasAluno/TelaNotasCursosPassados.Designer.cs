namespace ProjetoBoletimAlunos.Telas.TelasAluno
{
    partial class form_TelaNotasCursosPassados
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
            this.btn_VoltaMenuAluno = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ListaMateriasCursoAnterior = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ListaNotasCursoAnterior = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_CursosAnteriores = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_MostraErroNaoTemCursoAnterior = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_VoltaMenuAluno
            // 
            this.btn_VoltaMenuAluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_VoltaMenuAluno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_VoltaMenuAluno.Location = new System.Drawing.Point(184, 496);
            this.btn_VoltaMenuAluno.Name = "btn_VoltaMenuAluno";
            this.btn_VoltaMenuAluno.Size = new System.Drawing.Size(288, 63);
            this.btn_VoltaMenuAluno.TabIndex = 0;
            this.btn_VoltaMenuAluno.Text = "Voltar ao Menu de Aluno";
            this.btn_VoltaMenuAluno.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(59, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(526, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "{nomeDoAluno} escolha o nome do curso anterior:";
            // 
            // txt_ListaMateriasCursoAnterior
            // 
            this.txt_ListaMateriasCursoAnterior.Location = new System.Drawing.Point(25, 184);
            this.txt_ListaMateriasCursoAnterior.Multiline = true;
            this.txt_ListaMateriasCursoAnterior.Name = "txt_ListaMateriasCursoAnterior";
            this.txt_ListaMateriasCursoAnterior.Size = new System.Drawing.Size(258, 283);
            this.txt_ListaMateriasCursoAnterior.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(107, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Matérias";
            // 
            // txt_ListaNotasCursoAnterior
            // 
            this.txt_ListaNotasCursoAnterior.Location = new System.Drawing.Point(380, 184);
            this.txt_ListaNotasCursoAnterior.Multiline = true;
            this.txt_ListaNotasCursoAnterior.Name = "txt_ListaNotasCursoAnterior";
            this.txt_ListaNotasCursoAnterior.Size = new System.Drawing.Size(258, 283);
            this.txt_ListaNotasCursoAnterior.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(474, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "Notas";
            // 
            // cmb_CursosAnteriores
            // 
            this.cmb_CursosAnteriores.FormattingEnabled = true;
            this.cmb_CursosAnteriores.Location = new System.Drawing.Point(38, 110);
            this.cmb_CursosAnteriores.Name = "cmb_CursosAnteriores";
            this.cmb_CursosAnteriores.Size = new System.Drawing.Size(245, 28);
            this.cmb_CursosAnteriores.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(38, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 31);
            this.label4.TabIndex = 1;
            this.label4.Text = "Curso";
            // 
            // lbl_MostraErroNaoTemCursoAnterior
            // 
            this.lbl_MostraErroNaoTemCursoAnterior.AutoSize = true;
            this.lbl_MostraErroNaoTemCursoAnterior.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_MostraErroNaoTemCursoAnterior.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_MostraErroNaoTemCursoAnterior.ForeColor = System.Drawing.Color.Red;
            this.lbl_MostraErroNaoTemCursoAnterior.Location = new System.Drawing.Point(342, 83);
            this.lbl_MostraErroNaoTemCursoAnterior.Name = "lbl_MostraErroNaoTemCursoAnterior";
            this.lbl_MostraErroNaoTemCursoAnterior.Size = new System.Drawing.Size(0, 31);
            this.lbl_MostraErroNaoTemCursoAnterior.TabIndex = 1;
            // 
            // form_TelaNotasCursosPassados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(670, 577);
            this.Controls.Add(this.lbl_MostraErroNaoTemCursoAnterior);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_CursosAnteriores);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ListaNotasCursoAnterior);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ListaMateriasCursoAnterior);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_VoltaMenuAluno);
            this.Name = "form_TelaNotasCursosPassados";
            this.Text = "TelaNotasCursosPassados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_VoltaMenuAluno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ListaMateriasCursoAnterior;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ListaNotasCursoAnterior;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_CursosAnteriores;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_MostraErroNaoTemCursoAnterior;
    }
}