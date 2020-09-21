using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBoletimAlunos.UI.TelasAdministrador.Gerenciar_Materia
{
    public partial class Form_MenuGerenciarMateria : Form
    {
        public Form_MenuGerenciarMateria()
        {
            InitializeComponent();
        }
        private void btn_AddMateria_Click(object sender, EventArgs e)
        {
            var addMateria = new Form_AdicionarMateria();
            this.Hide();
            addMateria.ShowDialog();
            this.Show();
        }

        private void btn_AlterarExcluirMateria_Click(object sender, EventArgs e)
        {
            var alterarExcluirMateria = new Form_AlterarOuExcluirMateria();
            this.Hide();
            alterarExcluirMateria.ShowDialog();
            this.Show();
        }
    }
}
