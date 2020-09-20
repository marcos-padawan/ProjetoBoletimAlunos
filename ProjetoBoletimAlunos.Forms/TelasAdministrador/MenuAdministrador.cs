using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoBoletimAlunos.Forms.TelasAdministrador
{
    public partial class form_MenuAdministrador : Form
    {
        public form_MenuAdministrador()
        {
            InitializeComponent();
        }

        private void btn_GerenciarAlunos_Click(object sender, EventArgs e)
        {
            var menuGerencAluno = new form_MenuGerenciarAluno();
            this.Hide();
            menuGerencAluno.ShowDialog();
            this.Show();
        }

        private void btn_GerenciarMaterias_Click(object sender, EventArgs e)
        {
            var menuGerencMateria = new form_MenuGerenciarMateria();
            this.Hide();
            menuGerencMateria.ShowDialog();
            this.Show();
        }

        private void btn_GerenciarCursos_Click(object sender, EventArgs e)
        {
            var menuGerencCurso = new form_MenuGerenciarCurso();
            this.Hide();
            menuGerencCurso.ShowDialog();
            this.Show();
        }
    }
}
