namespace ProjetoBoletimAlunos.UI.TelasAdministrador.Gerenciar_Materia
{
    partial class Form_AlterarOuExcluirMateria
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txt_DescricaoMateriaBuscar = new System.Windows.Forms.TextBox();
            this.btn_BuscarMateria = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_SituacaoMateriaBuscar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_DataCadastroMateriaBuscar = new System.Windows.Forms.TextBox();
            this.btn_ExcluirMateria = new System.Windows.Forms.Button();
            this.btn_AlterarMateria = new System.Windows.Forms.Button();
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(32, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(695, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insira o nome da Matéria e pressione o botão BUSCAR:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(32, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txt_DescricaoMateriaBuscar
            // 
            this.txt_DescricaoMateriaBuscar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_DescricaoMateriaBuscar.Location = new System.Drawing.Point(32, 74);
            this.txt_DescricaoMateriaBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DescricaoMateriaBuscar.Name = "txt_DescricaoMateriaBuscar";
            this.txt_DescricaoMateriaBuscar.Size = new System.Drawing.Size(253, 34);
            this.txt_DescricaoMateriaBuscar.TabIndex = 3;
            // 
            // btn_BuscarMateria
            // 
            this.btn_BuscarMateria.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_BuscarMateria.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_BuscarMateria.Location = new System.Drawing.Point(456, 66);
            this.btn_BuscarMateria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_BuscarMateria.Name = "btn_BuscarMateria";
            this.btn_BuscarMateria.Size = new System.Drawing.Size(303, 43);
            this.btn_BuscarMateria.TabIndex = 4;
            this.btn_BuscarMateria.Text = "BUSCAR";
            this.btn_BuscarMateria.UseVisualStyleBackColor = false;
            this.btn_BuscarMateria.Click += new System.EventHandler(this.btn_BuscarMateria_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(32, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(808, 38);
            this.label3.TabIndex = 0;
            this.label3.Text = "Os dados da Matéria pesquisada aparecerão abaixo, para excluir";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(32, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(646, 38);
            this.label4.TabIndex = 0;
            this.label4.Text = "esse registro pressione o botão de Excluir Registro.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(32, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(879, 38);
            this.label5.TabIndex = 0;
            this.label5.Text = "Caso deseje alterar as informações da Matéria, altere quantos campos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(32, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(810, 38);
            this.label6.TabIndex = 0;
            this.label6.Text = "achar necessário e depois pressione o botão de Alterar Registro.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(32, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(244, 28);
            this.label7.TabIndex = 1;
            this.label7.Text = "Situação (Ativa ou Inativa):";
            // 
            // txt_SituacaoMateriaBuscar
            // 
            this.txt_SituacaoMateriaBuscar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_SituacaoMateriaBuscar.Location = new System.Drawing.Point(32, 324);
            this.txt_SituacaoMateriaBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SituacaoMateriaBuscar.Name = "txt_SituacaoMateriaBuscar";
            this.txt_SituacaoMateriaBuscar.Size = new System.Drawing.Size(253, 34);
            this.txt_SituacaoMateriaBuscar.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(32, 367);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 28);
            this.label8.TabIndex = 1;
            this.label8.Text = "Data de Cadastro:";
            // 
            // txt_DataCadastroMateriaBuscar
            // 
            this.txt_DataCadastroMateriaBuscar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_DataCadastroMateriaBuscar.Location = new System.Drawing.Point(32, 396);
            this.txt_DataCadastroMateriaBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DataCadastroMateriaBuscar.Name = "txt_DataCadastroMateriaBuscar";
            this.txt_DataCadastroMateriaBuscar.Size = new System.Drawing.Size(253, 34);
            this.txt_DataCadastroMateriaBuscar.TabIndex = 3;
            // 
            // btn_ExcluirMateria
            // 
            this.btn_ExcluirMateria.BackColor = System.Drawing.Color.Tomato;
            this.btn_ExcluirMateria.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_ExcluirMateria.Location = new System.Drawing.Point(456, 316);
            this.btn_ExcluirMateria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ExcluirMateria.Name = "btn_ExcluirMateria";
            this.btn_ExcluirMateria.Size = new System.Drawing.Size(303, 43);
            this.btn_ExcluirMateria.TabIndex = 4;
            this.btn_ExcluirMateria.Text = "Excluir Registro";
            this.btn_ExcluirMateria.UseVisualStyleBackColor = false;
            this.btn_ExcluirMateria.Click += new System.EventHandler(this.btn_ExcluirMateria_Click);
            // 
            // btn_AlterarMateria
            // 
            this.btn_AlterarMateria.BackColor = System.Drawing.Color.Gold;
            this.btn_AlterarMateria.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_AlterarMateria.Location = new System.Drawing.Point(456, 380);
            this.btn_AlterarMateria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AlterarMateria.Name = "btn_AlterarMateria";
            this.btn_AlterarMateria.Size = new System.Drawing.Size(303, 43);
            this.btn_AlterarMateria.TabIndex = 4;
            this.btn_AlterarMateria.Text = "Alterar Registro";
            this.btn_AlterarMateria.UseVisualStyleBackColor = false;
            this.btn_AlterarMateria.Click += new System.EventHandler(this.btn_AlterarMateria_Click);
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.BackColor = System.Drawing.Color.OrangeRed;
            this.Btn_Sair.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Btn_Sair.Location = new System.Drawing.Point(424, 470);
            this.Btn_Sair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.Size = new System.Drawing.Size(241, 38);
            this.Btn_Sair.TabIndex = 17;
            this.Btn_Sair.Text = "Sair do Sistema";
            this.Btn_Sair.UseVisualStyleBackColor = false;
            this.Btn_Sair.Click += new System.EventHandler(this.Btn_Sair_Click);
            // 
            // Btn_Voltar
            // 
            this.Btn_Voltar.BackColor = System.Drawing.Color.LightCoral;
            this.Btn_Voltar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Btn_Voltar.Location = new System.Drawing.Point(98, 470);
            this.Btn_Voltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Voltar.Name = "Btn_Voltar";
            this.Btn_Voltar.Size = new System.Drawing.Size(241, 38);
            this.Btn_Voltar.TabIndex = 16;
            this.Btn_Voltar.Text = "Voltar";
            this.Btn_Voltar.UseVisualStyleBackColor = false;
            this.Btn_Voltar.Click += new System.EventHandler(this.Btn_Voltar_Click);
            // 
            // Form_AlterarOuExcluirMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(916, 540);
            this.Controls.Add(this.Btn_Sair);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.btn_AlterarMateria);
            this.Controls.Add(this.btn_ExcluirMateria);
            this.Controls.Add(this.txt_DataCadastroMateriaBuscar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_SituacaoMateriaBuscar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_BuscarMateria);
            this.Controls.Add(this.txt_DescricaoMateriaBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_AlterarOuExcluirMateria";
            this.Text = "Alterar ou Excluir Matéria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txt_DescricaoMateriaBuscar;
        private System.Windows.Forms.Button btn_BuscarMateria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_SituacaoMateriaBuscar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_DataCadastroMateriaBuscar;
        private System.Windows.Forms.Button btn_ExcluirMateria;
        private System.Windows.Forms.Button btn_AlterarMateria;
        private System.Windows.Forms.Button Btn_Sair;
        private System.Windows.Forms.Button Btn_Voltar;
    }
}