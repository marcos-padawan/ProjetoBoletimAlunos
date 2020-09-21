using System;
using System.Windows.Forms;

namespace ProjetoBoletimAlunos.UI.TelasAdministrador.Gerenciar_Aluno
{
    public partial class Form_MenuGerenciarAluno : Form
    {
        public Form_MenuGerenciarAluno()
        {
            InitializeComponent();
        }
        private void btn_AddAluno_Click(object sender, EventArgs e)
        {
            var addAluno = new Form_AdicionarAluno();
            this.Hide();
            addAluno.ShowDialog();
            this.Show();
        }

        private void btn_AlterarExcluirAluno_Click(object sender, EventArgs e)
        {
            var alterarExcluirAluno = new Form_AlterarOuExcluirAluno();
            this.Hide();
            alterarExcluirAluno.ShowDialog();
            this.Show();
        }
    }
}
