namespace ProjetoBoletimAlunos.UI.TelasAluno
{
    partial class Form_NotasCursosPassados
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
            this.txt_ListaMateriasCursoAnterior = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ListaNotasCursoAnterior = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_CursosAnteriores = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_MostraErroNaoTemCursoAnterior = new System.Windows.Forms.Label();
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(32, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escolha o nome do curso anterior:";
            // 
            // txt_ListaMateriasCursoAnterior
            // 
            this.txt_ListaMateriasCursoAnterior.Location = new System.Drawing.Point(25, 157);
            this.txt_ListaMateriasCursoAnterior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ListaMateriasCursoAnterior.Multiline = true;
            this.txt_ListaMateriasCursoAnterior.Name = "txt_ListaMateriasCursoAnterior";
            this.txt_ListaMateriasCursoAnterior.Size = new System.Drawing.Size(258, 227);
            this.txt_ListaMateriasCursoAnterior.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(107, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Matérias";
            // 
            // txt_ListaNotasCursoAnterior
            // 
            this.txt_ListaNotasCursoAnterior.Location = new System.Drawing.Point(380, 157);
            this.txt_ListaNotasCursoAnterior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ListaNotasCursoAnterior.Multiline = true;
            this.txt_ListaNotasCursoAnterior.Name = "txt_ListaNotasCursoAnterior";
            this.txt_ListaNotasCursoAnterior.Size = new System.Drawing.Size(258, 227);
            this.txt_ListaNotasCursoAnterior.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(474, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Notas";
            // 
            // cmb_CursosAnteriores
            // 
            this.cmb_CursosAnteriores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_CursosAnteriores.FormattingEnabled = true;
            this.cmb_CursosAnteriores.Location = new System.Drawing.Point(38, 81);
            this.cmb_CursosAnteriores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_CursosAnteriores.Name = "cmb_CursosAnteriores";
            this.cmb_CursosAnteriores.Size = new System.Drawing.Size(245, 33);
            this.cmb_CursosAnteriores.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(32, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Curso";
            // 
            // lbl_MostraErroNaoTemCursoAnterior
            // 
            this.lbl_MostraErroNaoTemCursoAnterior.AutoSize = true;
            this.lbl_MostraErroNaoTemCursoAnterior.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_MostraErroNaoTemCursoAnterior.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.lbl_MostraErroNaoTemCursoAnterior.ForeColor = System.Drawing.Color.Red;
            this.lbl_MostraErroNaoTemCursoAnterior.Location = new System.Drawing.Point(342, 66);
            this.lbl_MostraErroNaoTemCursoAnterior.Name = "lbl_MostraErroNaoTemCursoAnterior";
            this.lbl_MostraErroNaoTemCursoAnterior.Size = new System.Drawing.Size(0, 32);
            this.lbl_MostraErroNaoTemCursoAnterior.TabIndex = 1;
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.BackColor = System.Drawing.Color.OrangeRed;
            this.Btn_Sair.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Btn_Sair.Location = new System.Drawing.Point(380, 413);
            this.Btn_Sair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.Size = new System.Drawing.Size(241, 38);
            this.Btn_Sair.TabIndex = 15;
            this.Btn_Sair.Text = "Sair do Sistema";
            this.Btn_Sair.UseVisualStyleBackColor = false;
            this.Btn_Sair.Click += new System.EventHandler(this.Btn_Sair_Click);
            // 
            // Btn_Voltar
            // 
            this.Btn_Voltar.BackColor = System.Drawing.Color.LightCoral;
            this.Btn_Voltar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Btn_Voltar.Location = new System.Drawing.Point(44, 413);
            this.Btn_Voltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Voltar.Name = "Btn_Voltar";
            this.Btn_Voltar.Size = new System.Drawing.Size(241, 38);
            this.Btn_Voltar.TabIndex = 14;
            this.Btn_Voltar.Text = "Voltar";
            this.Btn_Voltar.UseVisualStyleBackColor = false;
            this.Btn_Voltar.Click += new System.EventHandler(this.Btn_Voltar_Click);
            // 
            // Form_NotasCursosPassados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(670, 492);
            this.Controls.Add(this.Btn_Sair);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.lbl_MostraErroNaoTemCursoAnterior);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_CursosAnteriores);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ListaNotasCursoAnterior);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ListaMateriasCursoAnterior);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_NotasCursosPassados";
            this.Text = "Tela Notas Cursos Passados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ListaMateriasCursoAnterior;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ListaNotasCursoAnterior;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_CursosAnteriores;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_MostraErroNaoTemCursoAnterior;
        private System.Windows.Forms.Button Btn_Sair;
        private System.Windows.Forms.Button Btn_Voltar;
    }
}