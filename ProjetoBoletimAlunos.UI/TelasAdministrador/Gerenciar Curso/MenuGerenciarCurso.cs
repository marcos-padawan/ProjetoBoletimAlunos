using System;
using System.Windows.Forms;

namespace ProjetoBoletimAlunos.UI.TelasAdministrador.Gerenciar_Curso
{
    public partial class Form_MenuGerenciarCurso : Form
    {
        public Form_MenuGerenciarCurso()
        {
            InitializeComponent();
        }
        private void btn_AddCurso_Click(object sender, EventArgs e)
        {
            var addCurso = new Form_AdicionarCurso();
            this.Hide();
            addCurso.ShowDialog();
            this.Show();
        }

        private void btn_AlterarExcluirCurso_Click(object sender, EventArgs e)
        {
            var alterarExcluirCurso = new Form_AlterarOuExcluirCurso();
            this.Hide();
            alterarExcluirCurso.ShowDialog();
            this.Show();
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
