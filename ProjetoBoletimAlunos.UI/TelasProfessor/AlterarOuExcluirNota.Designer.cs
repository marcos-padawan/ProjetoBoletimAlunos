namespace ProjetoBoletimAlunos.UI.TelasProfessor
{
    partial class Form_AlterarOuExcluirNota
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
            this.cmb_MateriaAlunoBuscar = new System.Windows.Forms.ComboBox();
            this.btn_BuscarNotas = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NotaAlunoBuscar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_EscluirNotas = new System.Windows.Forms.Button();
            this.btn_AlterarNotas = new System.Windows.Forms.Button();
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.Cmb_TodosAlunos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(935, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insira o Nome completo do Aluno, a Matéria e pressione o botão BUSCAR:";
            // 
            // cmb_MateriaAlunoBuscar
            // 
            this.cmb_MateriaAlunoBuscar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmb_MateriaAlunoBuscar.FormattingEnabled = true;
            this.cmb_MateriaAlunoBuscar.Location = new System.Drawing.Point(525, 100);
            this.cmb_MateriaAlunoBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_MateriaAlunoBuscar.Name = "cmb_MateriaAlunoBuscar";
            this.cmb_MateriaAlunoBuscar.Size = new System.Drawing.Size(424, 36);
            this.cmb_MateriaAlunoBuscar.TabIndex = 2;
            // 
            // btn_BuscarNotas
            // 
            this.btn_BuscarNotas.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_BuscarNotas.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_BuscarNotas.Location = new System.Drawing.Point(183, 168);
            this.btn_BuscarNotas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_BuscarNotas.Name = "btn_BuscarNotas";
            this.btn_BuscarNotas.Size = new System.Drawing.Size(613, 43);
            this.btn_BuscarNotas.TabIndex = 3;
            this.btn_BuscarNotas.Text = "BUSCAR";
            this.btn_BuscarNotas.UseVisualStyleBackColor = false;
            this.btn_BuscarNotas.Click += new System.EventHandler(this.btn_BuscarNotas_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(22, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome completo do Aluno:";
            // 
            // txt_NotaAlunoBuscar
            // 
            this.txt_NotaAlunoBuscar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_NotaAlunoBuscar.Location = new System.Drawing.Point(29, 373);
            this.txt_NotaAlunoBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_NotaAlunoBuscar.Name = "txt_NotaAlunoBuscar";
            this.txt_NotaAlunoBuscar.Size = new System.Drawing.Size(282, 34);
            this.txt_NotaAlunoBuscar.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(29, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nota:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(526, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Matéria:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(21, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(925, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "A nota registrada aparecerá no campo abaixo. Para remover esse registro, pression" +
    "e o";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(21, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1163, 40);
            this.label7.TabIndex = 0;
            this.label7.Text = "botão de Excluir Nota. Caso deseje alterar a nota, insira o novo valor no campo n" +
    "ota e";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.label8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(21, 306);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(513, 32);
            this.label8.TabIndex = 0;
            this.label8.Text = "em seguida pressione o botão de Alterar Nota.";
            // 
            // btn_EscluirNotas
            // 
            this.btn_EscluirNotas.BackColor = System.Drawing.Color.Tomato;
            this.btn_EscluirNotas.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_EscluirNotas.Location = new System.Drawing.Point(675, 367);
            this.btn_EscluirNotas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_EscluirNotas.Name = "btn_EscluirNotas";
            this.btn_EscluirNotas.Size = new System.Drawing.Size(281, 45);
            this.btn_EscluirNotas.TabIndex = 3;
            this.btn_EscluirNotas.Text = "Excluir Nota";
            this.btn_EscluirNotas.UseVisualStyleBackColor = false;
            this.btn_EscluirNotas.Click += new System.EventHandler(this.btn_EscluirNotas_Click);
            // 
            // btn_AlterarNotas
            // 
            this.btn_AlterarNotas.BackColor = System.Drawing.Color.Gold;
            this.btn_AlterarNotas.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_AlterarNotas.Location = new System.Drawing.Point(362, 367);
            this.btn_AlterarNotas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AlterarNotas.Name = "btn_AlterarNotas";
            this.btn_AlterarNotas.Size = new System.Drawing.Size(281, 47);
            this.btn_AlterarNotas.TabIndex = 3;
            this.btn_AlterarNotas.Text = "Alterar Nota";
            this.btn_AlterarNotas.UseVisualStyleBackColor = false;
            this.btn_AlterarNotas.Click += new System.EventHandler(this.btn_AlterarNotas_Click);
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.BackColor = System.Drawing.Color.OrangeRed;
            this.Btn_Sair.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Btn_Sair.Location = new System.Drawing.Point(531, 454);
            this.Btn_Sair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.Size = new System.Drawing.Size(241, 38);
            this.Btn_Sair.TabIndex = 9;
            this.Btn_Sair.Text = "Sair do Sistema";
            this.Btn_Sair.UseVisualStyleBackColor = false;
            this.Btn_Sair.Click += new System.EventHandler(this.Btn_Sair_Click);
            // 
            // Btn_Voltar
            // 
            this.Btn_Voltar.BackColor = System.Drawing.Color.LightCoral;
            this.Btn_Voltar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Btn_Voltar.Location = new System.Drawing.Point(204, 454);
            this.Btn_Voltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Voltar.Name = "Btn_Voltar";
            this.Btn_Voltar.Size = new System.Drawing.Size(241, 38);
            this.Btn_Voltar.TabIndex = 8;
            this.Btn_Voltar.Text = "Voltar";
            this.Btn_Voltar.UseVisualStyleBackColor = false;
            this.Btn_Voltar.Click += new System.EventHandler(this.Btn_Voltar_Click);
            // 
            // Cmb_TodosAlunos
            // 
            this.Cmb_TodosAlunos.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Cmb_TodosAlunos.FormattingEnabled = true;
            this.Cmb_TodosAlunos.Location = new System.Drawing.Point(29, 100);
            this.Cmb_TodosAlunos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cmb_TodosAlunos.Name = "Cmb_TodosAlunos";
            this.Cmb_TodosAlunos.Size = new System.Drawing.Size(341, 36);
            this.Cmb_TodosAlunos.TabIndex = 10;
            // 
            // Form_AlterarOuExcluirNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(974, 517);
            this.Controls.Add(this.Cmb_TodosAlunos);
            this.Controls.Add(this.Btn_Sair);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.btn_AlterarNotas);
            this.Controls.Add(this.btn_EscluirNotas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_NotaAlunoBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_BuscarNotas);
            this.Controls.Add(this.cmb_MateriaAlunoBuscar);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_AlterarOuExcluirNota";
            this.Text = "AdicionarNotas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_MateriaAlunoBuscar;
        private System.Windows.Forms.Button btn_BuscarNotas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NotaAlunoBuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_EscluirNotas;
        private System.Windows.Forms.Button btn_AlterarNotas;
        private System.Windows.Forms.Button Btn_Sair;
        private System.Windows.Forms.Button Btn_Voltar;
        private System.Windows.Forms.ComboBox Cmb_TodosAlunos;
    }
}