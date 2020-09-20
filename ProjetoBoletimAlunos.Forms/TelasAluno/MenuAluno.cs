using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoBoletimAlunos.Forms.TelasAluno
{
    public partial class form_MenuAluno : Form
    {
        public form_MenuAluno()
        {
            InitializeComponent();
        }

        private void form_MenuAluno_Load(object sender, EventArgs e)
        {

        }

        private void btn_Notas1Materia_Click(object sender, EventArgs e)
        {
            var nota1Materia = new form_MenuNotaUmaMateria();
            this.Hide();
            nota1Materia.ShowDialog();
            this.Show();
        }

        private void btn_NotasTodasMaterias_Click(object sender, EventArgs e)
        {
            var notaTodasMaterias = new form_TelaNotasTodasMaterias();
            this.Hide();
            notaTodasMaterias.ShowDialog();
            this.Show();
        }

        private void btn_NotasCursosAnteriores_Click(object sender, EventArgs e)
        {
            var notasCursosAnteriores = new form_TelaNotasCursosPassados();
            this.Hide();
            notasCursosAnteriores.ShowDialog();
            this.Show();
        }
    }
}
