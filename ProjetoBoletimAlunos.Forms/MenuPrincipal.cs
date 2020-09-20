using ProjetoBoletimAlunos.Forms.TelasAdministrador;
using ProjetoBoletimAlunos.Forms.TelasAluno;
using ProjetoBoletimAlunos.Forms.TelasProfessor;
using System;
using System.Windows.Forms;

namespace ProjetoBoletimAlunos.Forms
{
    public partial class form_MenuPrincipal : Form
    {
        public form_MenuPrincipal()
        {
            InitializeComponent();
        }
        private void btn_AcessoAdministrador_Click(object sender, EventArgs e)
        {
            var menuAdministrador = new form_MenuAdministrador();
            this.Hide();
            menuAdministrador.ShowDialog();
            this.Show();
        }
        private void btn_AcessoProfessor_Click(object sender, EventArgs e)
        {
            var menuProfessor = new form_GerenciarNotas();
            this.Hide();
            menuProfessor.ShowDialog();
            this.Show();
        }
        private void btn_AcessoAluno_Click(object sender, EventArgs e)
        {
            var menuAluno = new form_MenuAluno();
            this.Hide();
            menuAluno.ShowDialog();
            this.Show();
        }
    }
}
