using System;
using System.Windows.Forms;


namespace ProjetoBoletimAlunos.Telas.TelasAluno
{
    public partial class form_MenuAluno : Form
    {
        public form_MenuAluno()
        {
            InitializeComponent();
        }
        private void btn_Notas1Materia(object sender, EventArgs e)
        {
            var telaNotas1Materia = new form_MenuNotaUmaMateria();
            this.Hide();
            telaNotas1Materia.ShowDialog();
            this.Show();
        }
        private void btn_NotasTodasMaterias(object sender, EventArgs e)
        {
            var telaNotasTodasMaterias = new form_TelaNotasTodasMaterias();
            this.Hide();
            telaNotasTodasMaterias.ShowDialog();
            this.Show();
        }
        private void btn_NotasCursosAnteriores(object sender, EventArgs e)
        {
            var telaNotasCursosPassados = new form_TelaNotasCursosPassados();
            this.Hide();
            telaNotasCursosPassados.ShowDialog();
            this.Show();
        }
        private void btn_VoltaMenuPrincipal(object sender, EventArgs e)
        {
            var menuPrincipal = new form_MenuPrincipal();
            this.Hide();
            menuPrincipal.ShowDialog();
            this.Show();
        }
    }
}
