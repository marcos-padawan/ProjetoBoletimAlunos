using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoBoletimAlunos.Telas.TelasAdministrador;
using ProjetoBoletimAlunos.Telas.TelasAluno;
using ProjetoBoletimAlunos.Telas.TelasProfessor;

namespace ProjetoBoletimAlunos.Telas
{
    public partial class form_MenuPrincipal : Form
    {
        public form_MenuPrincipal()
        {
            InitializeComponent();
        }
        private void btn_AcessoAluno_Click(object sender, EventArgs e)
        {
            var menuAluno = new form_MenuAluno();
            this.Hide();
            menuAluno.ShowDialog();
            this.Show();
        }
        private void btn_AcessoProfessor_Click(object sender, EventArgs e)
        {
            var menuProfessor = new form_GerenciarNotas();
            this.Hide();
            menuProfessor.ShowDialog();
            this.Show();
        }
        private void btn_AcessoAdministrador_Click(object sender, EventArgs e)
        {
            var menuAdministrador = new form_MenuAdministrador();
            this.Hide();
            menuAdministrador.ShowDialog();
            this.Show();
        }
        
    }
}
