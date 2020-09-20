using System;
using System.Windows.Forms;

namespace ProjetoBoletimAlunos.Telas.TelasProfessor
{
    public partial class form_GerenciarNotas : Form
    {
        public form_GerenciarNotas()
        {
            InitializeComponent();
        }
        private void btn_AddNotas_Click(object sender, EventArgs e)
        {
            var adicionarNotas = new form_AdicionarNotas();
            this.Hide();
            adicionarNotas.ShowDialog();
            this.Show();
        }

        private void btn_VoltarMenuPrincipal_Click(object sender, EventArgs e)
        {
            var menuPrincipal = new form_MenuPrincipal();
            this.Hide();
            menuPrincipal.ShowDialog();
            this.Show();
        }

    }
}
