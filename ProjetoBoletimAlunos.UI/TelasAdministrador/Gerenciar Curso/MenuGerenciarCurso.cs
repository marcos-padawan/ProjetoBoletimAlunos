using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
