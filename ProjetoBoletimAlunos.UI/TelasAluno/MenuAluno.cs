using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBoletimAlunos.UI.TelasAluno
{
    public partial class Form_MenuAluno : Form
    {
        public Form_MenuAluno()
        {
            InitializeComponent();
        }
        private void btn_Notas1Materia_Click(object sender, EventArgs e)
        {
            var nota1Materia = new Form_NotaUmaMateria();
            this.Hide();
            nota1Materia.ShowDialog();
            this.Show();
        }

        private void btn_NotasTodasMaterias_Click(object sender, EventArgs e)
        {
            var notaTodasMaterias = new Form_NotasTodasMaterias();
            this.Hide();
            notaTodasMaterias.ShowDialog();
            this.Show();
        }

        private void btn_NotasCursosAnteriores_Click(object sender, EventArgs e)
        {
            var notasCursosAnteriores = new Form_NotasCursosPassados();
            this.Hide();
            notasCursosAnteriores.ShowDialog();
            this.Show();
        }
    }
}
