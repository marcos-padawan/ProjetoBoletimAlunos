using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoBoletimAlunos.Forms.TelasProfessor
{
    public partial class form_GerenciarNotas : Form
    {
        public form_GerenciarNotas()
        {
            InitializeComponent();
        }

        private void btn_AddNotas_Click(object sender, EventArgs e)
        {
            var addNotas = new form_AdicionarNotas();
            this.Hide();
            addNotas.ShowDialog();
            this.Show();
        }
    }
}
