using ProjetoBoletimAlunos.Forms.TelasAdministrador.Gerenciar_Aluno;
using System;
using System.Windows.Forms;

namespace ProjetoBoletimAlunos.Forms.TelasAdministrador
{
    public partial class form_MenuGerenciarAluno : Form
    {
        public form_MenuGerenciarAluno()
        {
            InitializeComponent();
        }

        private void btn_AddAluno_Click(object sender, EventArgs e)
        {
            var addAluno = new form_AdicionarAluno();
            this.Hide();
            addAluno.ShowDialog();
            this.Show();
        }

        private void btn_AlterarExcluirAluno_Click(object sender, EventArgs e)
        {
            var alterarExcluirAluno = new form_AlterarOuExcluirAluno();
            this.Hide();
            alterarExcluirAluno.ShowDialog();
            this.Show();
        }
    }
}
