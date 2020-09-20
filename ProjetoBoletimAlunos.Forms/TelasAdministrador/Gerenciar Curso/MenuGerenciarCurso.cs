using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProjetoBoletimAlunos.Forms.TelasAdministrador.Gerenciar_Curso;

namespace ProjetoBoletimAlunos.Forms.TelasAdministrador
{
    public partial class form_MenuGerenciarCurso : Form
    {
        public form_MenuGerenciarCurso()
        {
            InitializeComponent();
        }

        private void btn_AddCurso_Click(object sender, EventArgs e)
        {
            var addCurso = new form_AdicionarCurso();
            this.Hide();
            addCurso.ShowDialog();
            this.Show();
        }

        private void btn_AlterarExcluirCurso_Click(object sender, EventArgs e)
        {
            var alterarExcluirCurso = new form_AlterarOuExcluirCurso();
            this.Hide();
            alterarExcluirCurso.ShowDialog();
            this.Show();
        }
    }
}
