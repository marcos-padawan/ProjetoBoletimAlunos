using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProjetoBoletimAlunos.Forms.TelasAdministrador.Gerenciar_Matéria;

namespace ProjetoBoletimAlunos.Forms.TelasAdministrador
{
    public partial class form_MenuGerenciarMateria : Form
    {
        public form_MenuGerenciarMateria()
        {
            InitializeComponent();
        }

        private void btn_AddMateria_Click(object sender, EventArgs e)
        {
            var addMateria = new form_AdicionarMateria();
            this.Hide();
            addMateria.ShowDialog();
            this.Show();
        }

        private void btn_AlterarExcluirMateria_Click(object sender, EventArgs e)
        {
            var alterarExcluirMateria = new form_AlterarOuExcluirMateria();
            this.Hide();
            alterarExcluirMateria.ShowDialog();
            this.Show();
        }
    }
}
