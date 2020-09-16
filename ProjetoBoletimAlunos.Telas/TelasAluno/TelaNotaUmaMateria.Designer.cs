namespace ProjetoBoletimAlunos.Telas.TelasAluno
{
    partial class form_MenuNotaUmaMateria
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
            this.cmb_EscolheMateriaAtiva = new System.Windows.Forms.ComboBox();
            this.btn_VoltaMenuAluno = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_NotaMateriaAtivaEscolhida = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(589, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "{nomeDoAluno} escolha a matéria que deseja ver a nota:";
            // 
            // cmb_EscolheMateriaAtiva
            // 
            this.cmb_EscolheMateriaAtiva.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_EscolheMateriaAtiva.FormattingEnabled = true;
            this.cmb_EscolheMateriaAtiva.Location = new System.Drawing.Point(23, 119);
            this.cmb_EscolheMateriaAtiva.Name = "cmb_EscolheMateriaAtiva";
            this.cmb_EscolheMateriaAtiva.Size = new System.Drawing.Size(194, 39);
            this.cmb_EscolheMateriaAtiva.TabIndex = 4;
            // 
            // btn_VoltaMenuAluno
            // 
            this.btn_VoltaMenuAluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_VoltaMenuAluno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_VoltaMenuAluno.Location = new System.Drawing.Point(170, 193);
            this.btn_VoltaMenuAluno.Name = "btn_VoltaMenuAluno";
            this.btn_VoltaMenuAluno.Size = new System.Drawing.Size(288, 63);
            this.btn_VoltaMenuAluno.TabIndex = 0;
            this.btn_VoltaMenuAluno.Text = "Voltar ao Menu de Aluno";
            this.btn_VoltaMenuAluno.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(23, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Matéria";
            // 
            // btn_NotaMateriaAtivaEscolhida
            // 
            this.btn_NotaMateriaAtivaEscolhida.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_NotaMateriaAtivaEscolhida.Location = new System.Drawing.Point(366, 119);
            this.btn_NotaMateriaAtivaEscolhida.Name = "btn_NotaMateriaAtivaEscolhida";
            this.btn_NotaMateriaAtivaEscolhida.Size = new System.Drawing.Size(224, 38);
            this.btn_NotaMateriaAtivaEscolhida.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(366, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nota";
            // 
            // form_MenuNotaUmaMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(630, 268);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_NotaMateriaAtivaEscolhida);
            this.Controls.Add(this.btn_VoltaMenuAluno);
            this.Controls.Add(this.cmb_EscolheMateriaAtiva);
            this.Controls.Add(this.label1);
            this.Name = "form_MenuNotaUmaMateria";
            this.Text = "Nota de uma matéria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_EscolheMateriaAtiva;
        private System.Windows.Forms.Button btn_VoltaMenuAluno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox btn_NotaMateriaAtivaEscolhida;
        private System.Windows.Forms.Label label3;
    }
}