using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoBoletimAlunos.UI.TelasAdministrador;
using ProjetoBoletimAlunos.UI.TelasAluno;
using ProjetoBoletimAlunos.UI.TelasProfessor;

namespace ProjetoBoletimAlunos.UI
{
    public partial class Form_MenuPrincipal : Form
    {
        public Form_MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btn_AcessoAdministrador_Click(object sender, EventArgs e)
        {
            var menuAdministrador = new Form_MenuAdministrador();
            this.Hide();
            menuAdministrador.ShowDialog();
            this.Show();
        }
        private void btn_AcessoProfessor_Click(object sender, EventArgs e)
        {
            var menuProfessor = new Form_MenuGerenciarNotas();
            this.Hide();
            menuProfessor.ShowDialog();
            this.Show();
        }
        private void btn_AcessoAluno_Click(object sender, EventArgs e)
        {
            var menuAluno = new Form_MenuAluno();
            this.Hide();
            menuAluno.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var funcionalidades = new Form_PROFESSORES_VEJAM_ISSO();
            this.Hide();
            funcionalidades.ShowDialog();
            this.Show();
        }
    }
}
