using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoBoletimAlunos.Telas.TelasProfessor
{
    public partial class form_AdicionarNotas : Form
    {
        public form_AdicionarNotas()
        {
            InitializeComponent();
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            var voltaGerenciarNotas = new form_GerenciarNotas();
            this.Hide();
            voltaGerenciarNotas.ShowDialog();
            this.Show();
        }



    }
}
