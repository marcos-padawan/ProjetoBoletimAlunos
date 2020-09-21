using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoBoletimAlunos.UI.TelasAdministrador.Gerenciar_Aluno;
using ProjetoBoletimAlunos.UI.TelasAdministrador.Gerenciar_Materia;
using ProjetoBoletimAlunos.UI.TelasAdministrador.Gerenciar_Curso;

namespace ProjetoBoletimAlunos.UI.TelasAdministrador
{
    public partial class Form_MenuAdministrador : Form
    {
        public Form_MenuAdministrador()
        {
            InitializeComponent();
        }
        private void btn_GerenciarAlunos_Click(object sender, EventArgs e)
        {
            var menuGerencAluno = new Form_MenuGerenciarAluno();
            this.Hide();
            menuGerencAluno.ShowDialog();
            this.Show();
        }

        private void btn_GerenciarMaterias_Click(object sender, EventArgs e)
        {
            var menuGerencMateria = new Form_MenuGerenciarMateria();
            this.Hide();
            menuGerencMateria.ShowDialog();
            this.Show();
        }

        private void btn_GerenciarCursos_Click(object sender, EventArgs e)
        {
            var menuGerencCurso = new Form_MenuGerenciarCurso();
            this.Hide();
            menuGerencCurso.ShowDialog();
            this.Show();
        }
    }
}
